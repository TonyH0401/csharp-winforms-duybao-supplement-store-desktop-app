using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Finals_Project
{
    public partial class frmPrintExport : Form
    {
        private List<Product> _products = new List<Product>();
        private String _exportID, _storeID, _accountID, _paymentMethod, _exportStatus, _date, _totalPrice, _totalQuantity;
        public frmPrintExport(List<Product> dataSource, string exportID, string storeID, string accountID, string paymentMethod, string exportStatus, string date, string totalPrice, string totalQuantity)
        {
            InitializeComponent();
            _products = dataSource;
            _exportID =  exportID;
            _storeID = storeID;
            _accountID = accountID;
            _paymentMethod = paymentMethod;
            _exportStatus = exportStatus;
            _date = date;
            _totalQuantity = totalQuantity;
            _totalPrice = totalPrice;
        }

        private void frmPrintExport_Load(object sender, EventArgs e)
        {
            //remember to name the dataset the same as the dataset model, and the rds should have the same string name
            //table
            ReportDataSource rds = new ReportDataSource("Product", _products);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Finals_Project.ReportExport.rdlc";
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            reportViewer1.RefreshReport();
            //@p parameters
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pExportID", _exportID),
                new Microsoft.Reporting.WinForms.ReportParameter("pStoreID", _storeID),
                new Microsoft.Reporting.WinForms.ReportParameter("pAccountID", _accountID),
                new Microsoft.Reporting.WinForms.ReportParameter("pPaymentMethod", _paymentMethod),
                new Microsoft.Reporting.WinForms.ReportParameter("pExportStatus", _exportStatus),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalProduct", _totalQuantity),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPrice", _totalPrice)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
