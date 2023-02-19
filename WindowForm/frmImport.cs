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
    public partial class frmImport : Form
    {
        public String sessionAccount = "";
        public String sessAccountPhone = "";
        DataTable dtProduct = new DataTable();
        String dtProductTotal = "";
        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        { 
            initiateComponents();
            getSessionUserData();
            getImportID();
        }
        public void initiateComponents()
        {
            txtAccount.Enabled = false;
            txtImportID.Enabled = false;
            txtTotal.Enabled = false;
            dateTimePickerImportCreated.Enabled = false;
        }
        public String getSessionUserDataFromProgram()
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
        public void getSessionUserData()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select accountID, accountPhone from Account where accountID=@accountID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@accountID", getSessionUserDataFromProgram().Trim());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                String sessionID = (String)dt.Rows[0][0];
                String sessionPhone = (String)dt.Rows[0][1];
                sessionAccount = sessionID;
                sessAccountPhone = sessionPhone;
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check Username or Password!", "Warning");
            }
        }
        public void getImportID()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "select importID from Import";
                SqlCommand cmd = new SqlCommand(sSQL, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                List<String> importIDList = new List<String>();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        String temp = dt.Rows[i][0].ToString().Trim();
                        importIDList.Add(temp);
                    }
                    listBoxImportID.DataSource = importIDList;
                }
                else
                {
                    MessageBox.Show("No Data", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getDataFromImportID()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "select importID, importTotalPrice, importCreated, accountID from Import where importID = @importID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@importID", listBoxImportID.SelectedValue.ToString().Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtImportID.Text = dt.Rows[0][0].ToString().Trim();
                    txtTotal.Text = dt.Rows[0][1].ToString().Trim();
                    dateTimePickerImportCreated.Text = dt.Rows[0][2].ToString().Trim();
                    txtAccount.Text = dt.Rows[0][3].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("No Data", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getDetailDataFromImportID() 
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "select productID, productName, productPrice, productQuantity, productOrigin from ImportDetail where importID = @importID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@importID", listBoxImportID.SelectedValue.ToString().Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewImportDetail.DataSource = dt;
                    //dtProduct will be used in Report Viewer RDLC
                    dtProduct = dt;
                    dtProductTotal = dt.Rows.Count.ToString().Trim();
                }
                else
                {
                    MessageBox.Show("No Data", "Warning");
                }
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listBoxImportID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataFromImportID();
            getDetailDataFromImportID();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int itemCounter = listBoxImportID.Items.Count;
            if(itemCounter == 0)
            {
                MessageBox.Show("There are no Import Bills to DELETE", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String temp = listBoxImportID.Items[listBoxImportID.SelectedIndex].ToString();
                //TO DO delete
                //try
                //{
                //    SqlConnection conn = new SqlConnection(Program.strConn);
                //    conn.Open();

                //    String sSQL = "delete from ";
                //    SqlCommand cmd = new SqlCommand(sSQL, conn);
                //    cmd.Parameters.AddWithValue("")

                //    int i = cmd.ExecuteNonQuery();
                //    if (i != 0)
                //    {
                //        //MessageBox.Show("Saved");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Error");
                //    }
                //    conn.Close();
                //}
                //catch (Exception ex)
                //{

                //}
                MessageBox.Show(temp);
            }
        }
        private void btnNewImport_Click(object sender, EventArgs e)
        {
            frmCreateImport f = new frmCreateImport();
            f.ShowDialog();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.frmImport_Load(null, EventArgs.Empty);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Product> dataSourceProduct = convertDataTableToListProduct(dtProduct);
            frmPrint f = new frmPrint(dataSourceProduct, txtTotal.Text.ToString().Trim(), dtProductTotal, txtImportID.Text, dateTimePickerImportCreated.Text, txtAccount.Text);
            f.ShowDialog();
        }
        public List<Product> convertDataTableToListProduct(DataTable inputDataTable)
        {
            List<Product> res = new List<Product>();
            foreach(DataRow row in inputDataTable.Rows)
            {
                Product product = new Product();
                product.id = row[0].ToString();
                product.name = row[1].ToString();
                product.price = row[2].ToString();
                product.quantity = row[3].ToString();
                product.origin = row[4].ToString();
                res.Add(product);
            }
            return res;
        }
    }
}
