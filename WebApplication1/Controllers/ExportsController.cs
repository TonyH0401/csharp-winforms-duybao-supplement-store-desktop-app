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
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class ExportsController : Controller
    {
        private DevConn db = new DevConn();

        // GET: Exports
        public ActionResult Index()
        {
            var exports = db.Exports.Include(e => e.Account).Include(e => e.PaymentMethod).Include(e => e.Store);
            return View(exports.ToList());
        }

        // GET: Exports/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Export export = db.Exports.Find(id);
            //List<ExportDetail> detail = db.ExportDetails.Where(a => a.exportID == id).ToList();
            if (export == null)
            {
                return HttpNotFound();
            }
            //return View(export);
            return RedirectToAction("Index", "ExportDetails", new {id = id});
        }

        // GET: Exports/Create
        public ActionResult Create()
        {
            ViewBag.accountID = new SelectList(db.Accounts, "accountID", "accountID");
            ViewBag.paymentID = new SelectList(db.PaymentMethods, "paymentID", "paymentName");
            ViewBag.storeID = new SelectList(db.Stores, "storeID", "storeName");
            ViewBag.productID = new SelectList(db.Products, "productID", "productName");

            Export _export = new Export();
            String date = DateTime.Now.ToString("yyyy:MM:dd").Replace(":", "").Trim();
            int counter = db.Exports.Count() + 1;
            String exportID = "EXPRT" + date + counter.ToString().Trim();
            _export.exportID = exportID;

            return View(_export);
        }

        // POST: Exports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "exportID,exportTotalProduct,exportTotalPrice,exportCreated,exportStatus,accountID,paymentID,storeID,productID,productQuantity")] Export export)
        {
            String date = DateTime.Now.ToString("yyyy:MM:dd").Replace(":", "").Trim();
            int counter = db.Exports.Count() + 1;
            String exportID = "EXPRT" + date + counter.ToString().Trim();
            export.exportID = exportID;
            export.exportStatus = 0;
            export.exportCreated = DateTime.Now;
            export.exportTotalProduct = 1;

            ExportDetail exportDetail = new ExportDetail();
            exportDetail.exportID = exportID;
            exportDetail.productID = export.productID;
            exportDetail.productName = db.Products.Find(export.productID).productName;
            exportDetail.productPrice = db.Products.Find(export.productID).productPrice;
            exportDetail.productQuantity = Int32.Parse(export.productQuantity);
            exportDetail.productOrigin = db.Products.Find(export.productID).productOrigin;

            int storeTax = (int)db.Stores.Find(export.storeID).taxValue;
            export.exportTotalPrice = ((exportDetail.productQuantity * exportDetail.productPrice) - ((exportDetail.productQuantity * exportDetail.productPrice) * storeTax / 100)).ToString().Trim();

            if (ModelState.IsValid)
            {
                db.Exports.Add(export);
                db.SaveChanges();
                db.ExportDetails.Add(exportDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.accountID = new SelectList(db.Accounts, "accountID", "accountPassword", export.accountID);
            ViewBag.paymentID = new SelectList(db.PaymentMethods, "paymentID", "paymentName", export.paymentID);
            ViewBag.storeID = new SelectList(db.Stores, "storeID", "storeName", export.storeID);
            return View(export);
        }

        // GET: Exports/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Export export = db.Exports.Find(id);
            if (export == null)
            {
                return HttpNotFound();
            }
            ViewBag.accountID = new SelectList(db.Accounts, "accountID", "accountPassword", export.accountID);
            ViewBag.paymentID = new SelectList(db.PaymentMethods, "paymentID", "paymentName", export.paymentID);
            ViewBag.storeID = new SelectList(db.Stores, "storeID", "storeName", export.storeID);
            return View(export);
        }

        // POST: Exports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "exportID,exportTotalProduct,exportTotalPrice,exportCreated,exportStatus,accountID,paymentID,storeID")] Export export)
        {
            if (ModelState.IsValid)
            {
                db.Entry(export).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.accountID = new SelectList(db.Accounts, "accountID", "accountPassword", export.accountID);
            ViewBag.paymentID = new SelectList(db.PaymentMethods, "paymentID", "paymentName", export.paymentID);
            ViewBag.storeID = new SelectList(db.Stores, "storeID", "storeName", export.storeID);
            return View(export);
        }

        // GET: Exports/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Export export = db.Exports.Find(id);
            if (export == null)
            {
                return HttpNotFound();
            }
            return View(export);
        }

        // POST: Exports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Export export = db.Exports.Find(id);
            db.Exports.Remove(export);
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
