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
    public partial class frmExport : Form
    {
        private String sessionAccount = "";
        private String sessAccountPhone = "";
        private DataTable dtProduct = new DataTable();
        private String dtProductTotal = "";
        public frmExport()
        {
            InitializeComponent();
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            initiateComponents();
            getSessionUserData();
            getExportIDList();

            //add a visible button for employee but not for acct
            if(viewProductAuthentication() == false)
            {
                btnConfirm.Visible = false;
            }
        }
        public bool viewProductAuthentication()
        {
            String temp = sessionAccount;
            if (temp.Equals("admin") == true || temp.Contains("ACCT") == true)
            {
                return true;
            }
            return false;
        }
        public void initiateComponents()
        {
            txtAccount.ReadOnly = true;
            txtExportID.ReadOnly = true;
            txtbxStoreID.ReadOnly = true;
            txtbxExportStatus.ReadOnly = true;
            dateTimePickerExportCreated.Enabled = false;
            txtbxPaymentMethod.ReadOnly = true;
            txtTotal.ReadOnly = true;
        }
        //done
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
        //done
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
        //done
        public void getExportIDList()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "select exportID from Export";
                SqlCommand cmd = new SqlCommand(sSQL, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                List<String> exportIDList = new List<String>();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        String temp = dt.Rows[i][0].ToString().Trim();
                        exportIDList.Add(temp);
                    }
                    listBoxExportID.DataSource = exportIDList;
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
        //done
        public void getDataFromExportID()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "select exportID, exportTotalPrice, exportCreated, exportStatus, accountID, paymentID, storeID from Export where exportID = @exportID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@exportID", listBoxExportID.SelectedValue.ToString().Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtExportID.Text = dt.Rows[0][0].ToString().Trim();
                    txtTotal.Text = dt.Rows[0][1].ToString().Trim();
                    dateTimePickerExportCreated.Text = dt.Rows[0][2].ToString().Trim();
                    getExportStatus(dt.Rows[0][3].ToString().Trim());
                    txtAccount.Text = dt.Rows[0][4].ToString().Trim();
                    getExportPaymentMethodName(dt.Rows[0][5].ToString().Trim());
                    txtbxStoreID.Text = dt.Rows[0][6].ToString().Trim();
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
        //done
        public void getExportStatus(String exportStatusValue)
        {
            if (exportStatusValue.Equals("0") == true)
            {
                txtbxExportStatus.Text = "Delivering";
                txtbxExportStatus.ForeColor = Color.White;
                txtbxExportStatus.BackColor = Color.Red;
                btnConfirm.Enabled = true;
                btnConfirm.ForeColor = Color.White;
            }
            else if (exportStatusValue.Equals("1") == true)
            {
                txtbxExportStatus.Text = "Received";
                txtbxExportStatus.ForeColor = Color.White;
                txtbxExportStatus.BackColor = Color.Green;
                btnConfirm.Enabled = false;
            } 
            else
            {
                MessageBox.Show("Invalid Export Status Code", "Warning");
            }
            //remember to update database if anything
        }
        //done
        public void getExportPaymentMethodName(String exportPaymentID)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "select paymentName from PaymentMethod where paymentID = @paymentID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@paymentID", exportPaymentID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtbxPaymentMethod.Text = dt.Rows[0][0].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("No data in Payment Method", "Warning");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //done
        public void getDetailDataFromExportID()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "select productID, productName, productPrice, productQuantity, productOrigin from ExportDetail where exportID = @exportID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@exportID", listBoxExportID.SelectedValue.ToString().Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewExportDetail.DataSource = dt;
                    //be used in ReportViewer
                    dtProduct = dt;
                    dtProductTotal = dt.Rows.Count.ToString().Trim();
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
        //done
        private void listBoxExportID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataFromExportID();
            getDetailDataFromExportID();
        }
        //done
        private void btnNewExport_Click(object sender, EventArgs e)
        {
            frmAddProductExport frmAddProductExport = new frmAddProductExport();
            frmAddProductExport.ShowDialog();
        }
        //done
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.frmExport_Load(null, EventArgs.Empty);
        }
        //done
        public void updateExportStatusDatabase(String exportID, int exportStatus)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "update Export set exportStatus = @exportStatus where exportID = @exportID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@exportID", exportID);
            cmd.Parameters.AddWithValue("@exportStatus", exportStatus);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                //MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
            conn.Close();
        }
        //done
        public Dictionary<String, int> getProductIDFromExportDetail(String exportID)
        {
            Dictionary<String, int> result = new Dictionary<String, int>();

            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select productID, productQuantity from ExportDetail where exportID = @exportID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@exportID", exportID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    result.Add(dr[0].ToString().Trim(), Int32.Parse(dr[1].ToString().Trim()));
                }
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check Username or Password!", "Warning");
            }
            return result;
        }
        public void updateProductQuantityExportDatabase(String exportID)
        {
            Dictionary<String, int> productList = getProductIDFromExportDetail(exportID);
            foreach (KeyValuePair<String, int> entry in productList)
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "update Product set productQuantity = productQuantity - @productQuantity where productID = @productID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@productID", entry.Key);
                cmd.Parameters.AddWithValue("@productQuantity", entry.Value);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    //MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                conn.Close();
            }
        }
        //done
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do you want to Confirm Delivery", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                //1.change the status display
                if (txtbxExportStatus.Text.Equals("Delivering") == true)
                {
                    txtbxExportStatus.Text = "Received";
                    txtbxExportStatus.ForeColor = Color.White;
                    txtbxExportStatus.BackColor = Color.Green;
                    btnConfirm.Enabled = false;
                }
                //2.change export status in db
                updateExportStatusDatabase(listBoxExportID.SelectedValue.ToString().Trim(), 1);
                //2.update quantity in db
                updateProductQuantityExportDatabase(listBoxExportID.SelectedValue.ToString().Trim());
                //3.disable the button forever, this should also be done for loading and index change
            }
        }
        //done
        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Product> dataSourceProduct = convertDataTableToListProduct(dtProduct);
            String exportID = listBoxExportID.SelectedValue.ToString().Trim();
            String storeID = txtbxStoreID.Text.ToString().Trim();
            String accountID = txtAccount.Text.ToString().Trim();
            String paymentMethod = txtbxPaymentMethod.Text.ToString().Trim();
            String exportStatus = txtbxExportStatus.Text.ToString().Trim();
            String date = dateTimePickerExportCreated.Text.ToString().Trim();
            String totalPrice = txtTotal.Text.ToString().Trim();
            String totalQuantity = dtProductTotal.ToString().Trim();

            frmPrintExport f = new frmPrintExport(dataSourceProduct,exportID,storeID,accountID,paymentMethod,exportStatus,date,totalPrice,totalQuantity);
            f.ShowDialog();
        }
        //done
        public List<Product> convertDataTableToListProduct(DataTable inputDataTable)
        {
            List<Product> res = new List<Product>();
            foreach (DataRow row in inputDataTable.Rows)
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
