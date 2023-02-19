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
    public class frmProductTests
    {
        private String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        [TestMethod()]
        public void setProductListDataGridViewMethodTest()
        {
            frmProduct test = new frmProduct();
            bool expected = true;
            bool act = test.setProductListDataGridViewMethod(strConn);
            Assert.AreEqual(expected, act);
        }
    }
}