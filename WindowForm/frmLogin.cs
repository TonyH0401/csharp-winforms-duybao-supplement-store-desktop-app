using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Project
{
    public partial class frmLogin : Form
    {
        private int wrongInputTries = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do you want to Exit!?", "Exit System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxUsername;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "select accountID, accountPassword from Account where accountID=@accountID and accountPassword=@accountPassword";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@accountID", txtbxUsername.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@accountPassword", txtbxPassword.Text.ToString().Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    String sessionACCT = (String)dt.Rows[0][0];
                    Program.sessionAccount = sessionACCT;
                    MessageBox.Show("Login Successful! Welcome", "SUCCESSFUL LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    wrongInputTries++;
                    MessageBox.Show("Invalid Login. Please check Username or Password!\nYou have: " +(5-wrongInputTries).ToString().Trim() +" tries left", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if(wrongInputTries == 5)
                    {
                        Application.Exit();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! Please reload the Application", "ERROR");
            }
        }

        private void chkbxDisplayPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxDisplayPassword.Checked == true)
            {
                txtbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxPassword.UseSystemPasswordChar = true;
            }
        }

        public bool loadLogin(String accountID, String accountPassword, String strConn)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select accountID, accountPassword from Account where accountID=@accountID and accountPassword=@accountPassword";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@accountPassword", accountPassword);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
