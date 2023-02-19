using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadLoginFRM();
            initiateComponents();
            getDataFromSessionAccountID();
            //Update the UserAccount handle on the menustrip with AccountID, THIS IS IN THE TIMER FUNCTION
            //because there will be error if we load it here, when on exist from Login
            this.Text = "Homepage of " + getSessionAccountIDFromProgram();
        }
        public void initiateComponents()
        {
            txtbxAccountID.ReadOnly = true;
            txtbxAccountName.ReadOnly = true;
            txtbxAccountPhone.ReadOnly = true;
            txtbxAccountEmail.ReadOnly = true;

            dateTimePickerCurrentTime.Enabled = false;
        }
        //done
        public String getSessionAccountIDFromProgram()
        {
            String value0 = Program.sessionAccount;
            if (value0.Length == 0)
            {
                return "admin";
            }
            else
            {
                return value0;
            }
        }
        //done
        public void getDataFromSessionAccountID()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select accountID, accountFirstName, accountLastName, accountEmail, accountPhone from Account where accountID = @accountID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@accountID", getSessionAccountIDFromProgram());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtbxAccountID.Text = dt.Rows[0][0].ToString().Trim();
                String temp = dt.Rows[0][1].ToString().Trim() + " " + dt.Rows[0][2].ToString().Trim();
                txtbxAccountName.Text = temp;
                txtbxAccountEmail.Text = dt.Rows[0][3].ToString().Trim();
                txtbxAccountPhone.Text = dt.Rows[0][4].ToString().Trim();
            }
            else
            {
                MessageBox.Show("No User in Account", "Warning");
            }
        }
        //done
        public void loadLoginFRM()
        {
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();
        }

        private void viewExportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExport fExport = new frmExport();
            fExport.ShowDialog();
        }

        private void createExportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProductExport fCreateExport = new frmAddProductExport();
            fCreateExport.ShowDialog();
        }

        private void viewImportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImport fImport = new frmImport();
            fImport.Show();
        }

        private void createImportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateImport fCreateImport = new frmCreateImport();
            fCreateImport.ShowDialog();
        }

        private void viewStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistic fStatistic = new frmStatistic();
            fStatistic.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do you want to Exit!?", "Exit System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //Update the UserAccount handle on the menustrip with AccountID, THIS IS IN THE TIMER FUNCTION
            //because there will be error if we load it in frmMain_Load, when on exist from Login
            menuStrip1.Items[0].Text = getSessionAccountIDFromProgram();
        }
        public bool viewProductAuthentication()
        {
            String temp = getSessionAccountIDFromProgram();
            if (temp.Equals("admin") == true || temp.Contains("ACCT") == true)
            {
                return true;
            }
            return false;
        }
        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool authentication = viewProductAuthentication();
            if(authentication == true)
            {
                frmProduct fProduct = new frmProduct();
                fProduct.Show();
            }
            else
            {
                MessageBox.Show("You are not allowed!", "WARNING OFF LIMITS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dt = MessageBox.Show("Do you want to Logout!?", "Exit System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dt == DialogResult.Yes)
                {
                    this.Hide();
                    this.frmMain_Load(null, EventArgs.Empty);
                    this.Show();
                }
            }
            catch (ObjectDisposedException ex)
            {
                Application.Exit();
            }
        }
        //TEST AREA FUNCTION
        public bool viewProductAuthenticationMethod(String temp)
        {
            if (temp.Equals("admin") == true || temp.Contains("ACCT") == true)
            {
                return true;
            }
            return false;
        }
    }
}
