using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            this.Text = "Homepage - " + getSessionAccountIDFromProgram();
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
            fCreateExport.Show();
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

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMProduct f = new frmMProduct();
            f.Show();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(viewProductAuthentication() == true)
            {
                frmMStore f = new frmMStore();
                f.Show();
            }
            else
            {
                MessageBox.Show("You do not have this level clearance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable getDataTable(String sqlcmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = sqlcmd;
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    MessageBox.Show("No data to return!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataTable();
        }

        public List<Store> convertDataTableToListStore(DataTable datatable)
        {
            List<Store> result = new List<Store>();
            foreach (DataRow row in datatable.Rows)
            {
                String id = row[0].ToString();
                String name = row[1].ToString();
                String location = row[2].ToString();
                String tax = row[3].ToString();
                result.Add(new Store(id, name, location, tax));
            }
            return result;
        }

        private void storeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String str = "select * from Store";
            var records = convertDataTableToListStore(getDataTable(str));
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
            })
            {
                sfd.FileName = "Store List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                        {
                            csv.WriteRecords(records);
                        }
                    }
                    MessageBox.Show("Store list was Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public List<Product> convertDataTableToListProduct(DataTable datatable)
        {
            List<Product> result = new List<Product>();
            foreach (DataRow row in datatable.Rows)
            {
                Product product = new Product();
                product.id = row[0].ToString();
                product.name = row[1].ToString();
                product.price = row[2].ToString();
                product.quantity = row[3].ToString();
                product.origin = row[4].ToString();
                result.Add(product);
            }
            return result;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String str = "select * from Product";
            var records = convertDataTableToListProduct(getDataTable(str));
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
            })
            {
                sfd.FileName = "Product List";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                        {
                            csv.WriteRecords(records);
                        }
                    }
                    MessageBox.Show("Product List was Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public List<Account> convertDataTableToListAccount(DataTable datatable)
        {
            List<Account> result = new List<Account>();
            foreach (DataRow row in datatable.Rows)
            {
                String id = row[0].ToString();
                String fname = row[2].ToString();
                String lname = row[3].ToString();
                String email = row[4].ToString();
                String phone = row[5].ToString();
                String address = row[6].ToString();
                result.Add(new Account(id, fname, lname, email, phone, address));
            }
            return result;
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sessionID = Program.sessionAccount;
            if(sessionID == null)
            {
                MessageBox.Show("Error! Please reload!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(sessionID.Equals("admin") == true || sessionID.Contains("ACCT") == true || sessionID.Contains("STRMNGR") == true) 
            {
                String str = "select * from Account";
                var records = convertDataTableToListAccount(getDataTable(str));
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "CSV|*.csv",
                    ValidateNames = true,
                })
                {
                    sfd.FileName = "Account List";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var sw = new StreamWriter(sfd.FileName))
                        {
                            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                            {
                                csv.WriteRecords(records);
                            }
                        }
                        MessageBox.Show("Account List was Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("You are not allowed to do that!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }
    }
}
