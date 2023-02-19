using Microsoft.VisualStudio.TestTools.UnitTesting;
using Finals_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Configuration;

namespace Finals_Project.Tests
{
    [TestClass()]
    public class frmAddProductExportTests
    {
        private String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        [DataTestMethod]
        [DataRow("10", "ST1")]
        [DataRow("15", "ST2")]
        [DataRow("5", "ST3")]
        [DataRow("11", "ST4")]
        [DataRow("", "randomStoreName")]
        public void getStoreTaxMethodTest_MV(String expected, String storeID)
        {
            frmAddProductExport test = new frmAddProductExport();
            String act = test.getStoreTaxMethod(storeID, strConn);
            Assert.AreEqual(expected, act);
        }

        [DataTestMethod]
        [DataRow(90, 100, "ST1")]
        [DataRow(85, 100, "ST2")]
        [DataRow(95, 100, "ST3")]
        [DataRow(89, 100, "ST4")]
        [DataRow(-1, 100, "")]
        public void calculateTotalCostMethodTest_MV(double expected, double sum, String storeID)
        {
            frmAddProductExport test = new frmAddProductExport();
            double act = test.calculateTotalCostMethod(sum, storeID, strConn);
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void getExportBillCounterMethodTest()
        {
            frmAddProductExport test = new frmAddProductExport();
            bool expected = true;
            bool act = false;
            if(test.getExportBillCounterMethod(strConn) >= 0)
            {
                act = true;
            }
            Assert.AreEqual(expected, act);
        }
    }
}