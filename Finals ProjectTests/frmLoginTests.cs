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
    public class frmLoginTests
    {
        //[TestMethod()]
        //public void loadLoginTest()
        //{
        //    String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        //    frmLogin fLogin = new frmLogin();
        //    bool expected = true;
        //    bool act = fLogin.loadLogin("ACCT1", "123", strConn);
        //    Assert.AreEqual(expected, act);
        //}
        [DataTestMethod]
        [DataRow(true, "ACCT1","123")]
        [DataRow(true, "ACCT2","123")]
        [DataRow(true, "STRMNGR1","123")]
        [DataRow(true, "STRMNGR2","123")]
        [DataRow(true, "admin","admin")]
        [DataRow(false, "random","123")]
        public void loadLoginTest_MV(bool expected, String accountID, String accountPassword)
        {
            String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            frmLogin fLogin = new frmLogin();
            bool act = fLogin.loadLogin(accountID, accountPassword, strConn);
            Assert.AreEqual(expected, act);
        }
    }
}