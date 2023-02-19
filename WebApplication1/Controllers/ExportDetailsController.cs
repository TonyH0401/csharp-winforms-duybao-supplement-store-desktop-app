using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ExportDetailsController : Controller
    {
        private DevConn db = new DevConn();

        // GET: ExportDetails
        public ActionResult Index1()
        {
            var exportDetails = db.ExportDetails.Include(e => e.Export).Include(e => e.Product);
            return View(exportDetails.ToList());
        }
        public ActionResult Index(String id)
        {
            List<ExportDetail> detail = db.ExportDetails.Where(a => a.exportID == id).ToList();
            return View(detail);
        }

        // GET: ExportDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExportDetail exportDetail = db.ExportDetails.Find(id);
            if (exportDetail == null)
            {
                return HttpNotFound();
            }
            return View(exportDetail);
        }

        // GET: ExportDetails/Create
        public ActionResult Create()
        {
            ViewBag.exportID = new SelectList(db.Exports, "exportID", "exportID");
            ViewBag.productID = new SelectList(db.Products, "productID", "productName");
            return View();
        }

        // POST: ExportDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "exportID,productID,productName,productPrice,productQuantity,productOrigin")] ExportDetail exportDetail)
        {
            //var dateTime = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.ExportDetails.Add(exportDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.exportID = new SelectList(db.Exports, "exportID", "exportTotalPrice", exportDetail.exportID);
            ViewBag.productID = new SelectList(db.Products, "productID", "productName", exportDetail.productID);
            return View(exportDetail);
        }

        // GET: ExportDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExportDetail exportDetail = db.ExportDetails.Find(id);
            if (exportDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.exportID = new SelectList(db.Exports, "exportID", "exportTotalPrice", exportDetail.exportID);
            ViewBag.productID = new SelectList(db.Products, "productID", "productName", exportDetail.productID);
            return View(exportDetail);
        }

        // POST: ExportDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "exportID,productID,productName,productPrice,productQuantity,productOrigin")] ExportDetail exportDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exportDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.exportID = new SelectList(db.Exports, "exportID", "exportTotalPrice", exportDetail.exportID);
            ViewBag.productID = new SelectList(db.Products, "productID", "productName", exportDetail.productID);
            return View(exportDetail);
        }

        // GET: ExportDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExportDetail exportDetail = db.ExportDetails.Find(id);
            if (exportDetail == null)
            {
                return HttpNotFound();
            }
            return View(exportDetail);
        }

        // POST: ExportDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ExportDetail exportDetail = db.ExportDetails.Find(id);
            db.ExportDetails.Remove(exportDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
