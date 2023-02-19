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
    public class frmMainTests
    {
        [DataTestMethod]
        [DataRow(true, "ACCT1")]
        [DataRow(true, "ACCT2")]
        [DataRow(false, "STRMNGR1")]
        [DataRow(false, "STRMNGR2")]
        [DataRow(true, "admin")]
        public void viewProductAuthenticationMethodTest(bool expected, String accountID)
        {
            frmMain test = new frmMain();
            bool act = test.viewProductAuthenticationMethod(accountID);
            Assert.AreEqual(expected, act);
        }
    }
}