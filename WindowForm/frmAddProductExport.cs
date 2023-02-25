using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Finals_Project
{
    public partial class frmAddProductExport : Form
    {
        //the quantity after this will be saved into the database
        Dictionary<string, int> initialProductQuantity = new Dictionary<string, int>();
        private String sessionAccountID = "";
        public frmAddProductExport()
        {
            InitializeComponent();
        }

        private void frmAddProductImport_Load(object sender, EventArgs e)
        {
            //initiate components (disable txtbx and cbbx), pre-load datagridview with header
            initiateComponents();
            initiateDataGridView();
            //load cbbxStoreName, getInitialProductQuantity
            initiateComboBoxStoreName();
            getProductInitialQuantity(); //need this first to load the product initial quantity
            initiateComboBoxProduct();

            initiateComboBoxPaymentMethod();
        }
        //done
        public void initiateComponents()
        {
            //product display panel
            txtbxProductID.ReadOnly = true;
            txtbxProductPrice.ReadOnly = true;
            txtbxProductQuantity.ReadOnly = true;
            txtbxOrigin.ReadOnly = true;
            txtbxProductID.BackColor = Color.White;
            txtbxProductPrice.BackColor = Color.White;
            txtbxProductQuantity.BackColor = Color.White;
            txtbxOrigin.BackColor = Color.White;
            cbbxProductID.Enabled = false;
            //store display panel
            txtbxStoreID.ReadOnly = true;
            txtbxStoreLocation.ReadOnly = true;
            txtbxSessionUser.ReadOnly = true;
            txtbxStoreID.BackColor = Color.White;
            txtbxStoreLocation.BackColor = Color.White;
            txtbxSessionUser.BackColor = Color.White;
            getSessionAccountData();
            txtbxSessionUser.Text = sessionAccountID;
            //disable button
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            //
            txtbxQuantityToImport.Enabled = false;
            //total cost
            txtbxTotalCost.ReadOnly = true;
            //cbbx paymentmethod
            cbbxPaymentMethod.Enabled = false;
            //button create export
            btnCreateExport.Enabled = false;
        }
        public void initiateComboBoxPaymentMethod()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select * from PaymentMethod";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cbbxPaymentMethod.DataSource = dt;
                cbbxPaymentMethod.DisplayMember = "paymentName";
                cbbxPaymentMethod.ValueMember = "paymentID";
            }
            else
            {
                MessageBox.Show("No data", "Warning");
            }
        }
        //done
        public String getSesstionAccountFromProgram()
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
        public void getSessionAccountData()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select accountID from Account where accountID=@accountID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@accountID", getSesstionAccountFromProgram().Trim());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                String sessionID = (String)dt.Rows[0][0];
                sessionAccountID = sessionID;
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check Username or Password!", "Warning");
            }
        }
        //done
        public double getStoreTax(String storeID)
        {
            double result = -1;
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select taxValue from Store where storeID=@storeID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@storeID", storeID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                String temp = dt.Rows[0][0].ToString();
                result = double.Parse(temp, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("No store", "Warning");
            }
            return result;
        }
        //done
        public double calculateTotalCost(String storeID)
        {
            double storeTax = getStoreTax(storeID);
            double sum = 0;
            foreach(DataGridViewRow row in dataGridViewAddedProduct.Rows)
            {
                sum = sum + Int32.Parse(row.Cells[4].Value.ToString().Trim());
            }
            return sum - (sum * storeTax / 100);
        }
        //done
        private void initiateDataGridView()
        {
            dataGridViewAddedProduct.ColumnCount = 6;
            dataGridViewAddedProduct.Columns[0].Name = "ProductID";
            dataGridViewAddedProduct.Columns[1].Name = "Product Name";
            dataGridViewAddedProduct.Columns[2].Name = "Price";
            dataGridViewAddedProduct.Columns[3].Name = "Quantity";
            dataGridViewAddedProduct.Columns[5].Name = "Origin";
            dataGridViewAddedProduct.Columns[4].Name = "Total Price";
        }
        //done
        private void initiateComboBoxProduct()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select * from Product";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cbbxProductID.DataSource = dt;
                cbbxProductID.DisplayMember = "productName";
                cbbxProductID.ValueMember = "productID";
            }
            else
            {
                MessageBox.Show("No data", "Warning");
            }
        }
        //done
        private void initiaProductInformation()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select * from Product where productID=@productID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@productID", cbbxProductID.SelectedValue.ToString().Trim());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtbxProductID.Text = (String)dt.Rows[0][0];
                txtbxProductPrice.Text = ((int)dt.Rows[0][2]).ToString().Trim();
                //txtbxProductQuantity.Text = ((int)dt.Rows[0][3]).ToString().Trim();
                txtbxProductQuantity.Text = initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()].ToString();
                txtbxOrigin.Text = (String)dt.Rows[0][4];
                btnAdd.Enabled = (txtbxProductID.Text.Equals("") == true) ? false : true;
            }
            else
            {
                //MessageBox.Show("No data", "Warning");
            }
        }
        //done
        private void cbbxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            initiaProductInformation();
            //enalbe Quantity to Import
            txtbxQuantityToImport.Enabled = true;
            this.ActiveControl = txtbxQuantityToImport;
        }
        //done
        private void initiateComboBoxStoreName()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select * from Store";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cbbxStoreName.DataSource = dt;
                cbbxStoreName.DisplayMember = "storeName";
                cbbxStoreName.ValueMember = "storeID";
            }
            else
            {
                MessageBox.Show("No data", "Warning");
            }
        }
        //done
        private void initiaStoreInformation()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select * from Store where storeID=@storeID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@storeID", cbbxStoreName.SelectedValue.ToString().Trim());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtbxStoreID.Text = (String)dt.Rows[0][0];
                txtbxStoreLocation.Text = (String) dt.Rows[0][2].ToString().Trim();
                txtbxPercentDis.Text = (String) dt.Rows[0][3].ToString().Trim();
                //enable add button
                btnAdd.Enabled = (txtbxStoreID.Text.Equals("") == true) ? false : true;
                //enable cbbxProduct
                cbbxProductID.Enabled = true;
            }
            else
            {
                //MessageBox.Show("No data", "Warning");
            }
        }
        //done
        private void cbbxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            initiaStoreInformation();
        }
        //done
        private void getProductInitialQuantity()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select productID, productQuantity from Product";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    initialProductQuantity.Add((String)dr[0], (int)dr[1]);
                }
            }
            else
            {
                //MessageBox.Show("No data", "Warning");
            }
        }
        //done
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(((int) txtbxStoreID.Text.Length * (int) txtbxStoreID.Text.Length) == 0)
            {
                MessageBox.Show("Incomplete Product or Location selection. Please complete!", "Warning Incompletion");
            }
            else
            {
                if (txtbxQuantityToImport.Text.Length == 0)
                {
                    MessageBox.Show("Incomplete Quantity", "Warning Incompletion");
                }
                else
                {
                    int n;
                    bool isNumeric = int.TryParse(txtbxQuantityToImport.Text.ToString().Trim(), out n);
                    if(isNumeric == false)
                    {
                        MessageBox.Show("Please enter a number", "Warning input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbxQuantityToImport.Clear();
                    }
                    else if(txtbxProductID.Text.Equals("") == true)
                    {
                        MessageBox.Show("Please select a product", "Warning input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbxQuantityToImport.Clear();
                    }
                    else
                    {
                        if((n <= 0) || n >= ((int)initialProductQuantity[txtbxProductID.Text]))
                        {
                            MessageBox.Show("Exceed the limit product", "Warning Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtbxQuantityToImport.Clear();
                        }
                        else
                        {
                            //remember to add a loop to iterate through
                            int rowIndex = -1;
                            String searchValuePROD = cbbxProductID.SelectedValue.ToString().Trim();
                            //String searchValueSTORE = cbbxStoreName.SelectedValue.ToString().Trim();
                            bool foundProduct = false;
                            foreach (DataGridViewRow cRow in dataGridViewAddedProduct.Rows)
                            {
                                if (cRow.Cells[0].Value.ToString().Equals(searchValuePROD))
                                {
                                    cRow.Cells[3].Value = Int32.Parse(cRow.Cells[3].Value.ToString().Trim()) + Int32.Parse(txtbxQuantityToImport.Text.ToString().Trim());
                                    cRow.Cells[4].Value = Int32.Parse(cRow.Cells[2].Value.ToString().Trim()) * Int32.Parse(cRow.Cells[3].Value.ToString().Trim());
                                    //update initial product quantity, this will be uploaded to SERVER
                                    int temp_value = initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()] - Int32.Parse(txtbxQuantityToImport.Text);
                                    initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()] = temp_value;
                                    //update initial product quantity on DISPLAY
                                    txtbxProductQuantity.Text = initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()].ToString();
                                    rowIndex = cRow.Index;
                                    foundProduct = true;
                                    break;
                                }
                            }
                            if(foundProduct == false)
                            {
                                //string[] row = new string[] { txtbxProductID.Text, cbbxProductID.Text.ToString(), txtbxProductPrice.Text, txtbxQuantityToImport.Text, (Int32.Parse(txtbxProductPrice.Text.ToString().Trim()) * Int32.Parse(txtbxQuantityToImport.Text.ToString().Trim())).ToString().Trim(), cbbxStoreName.SelectedValue.ToString().Trim(), cbbxStoreName.Text.ToString().Trim(), txtbxStoreLocation.Text.ToString().Trim()};
                                string[] row = new string[] { txtbxProductID.Text, cbbxProductID.Text.ToString(), txtbxProductPrice.Text, txtbxQuantityToImport.Text, (Int32.Parse(txtbxProductPrice.Text.ToString().Trim()) * Int32.Parse(txtbxQuantityToImport.Text.ToString().Trim())).ToString().Trim(), txtbxOrigin.Text.ToString().Trim()};
                                //update initial product quantity, this will be uploaded to SERVER
                                int temp_value = initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()] - Int32.Parse(txtbxQuantityToImport.Text);
                                initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()] = temp_value;
                                //update initial product quantity on DISPLAY
                                txtbxProductQuantity.Text = initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()].ToString();
                                dataGridViewAddedProduct.Rows.Add(row);
                                //MessageBox.Show(initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()].ToString() + "; " + cbbxProductID.SelectedValue.ToString().Trim());
                            }
                            //
                            txtbxTotalCost.Text = calculateTotalCost(txtbxStoreID.Text.ToString().Trim()).ToString().Trim();
                            MessageBox.Show("Successfully Added", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtbxQuantityToImport.Clear();
                            cbbxPaymentMethod.Enabled = true;
                            btnCreateExport.Enabled = true;
                        }
                    }                   
                }
                //create new import code
                //save current account,, storeID, productID, productQuantity, totalprice, created time, total price bill
                
                //also save current product quantity after. when delete remember to refill product quantity
            }
        }
        //done
        private void dataGridViewAddedProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //enable delete button
            btnDelete.Enabled = true;
            //load product information from datagridview to product display panel
            foreach (DataGridViewRow row in dataGridViewAddedProduct.SelectedRows)
            {
                cbbxProductID.Text = row.Cells[1].Value.ToString();
                txtbxProductID.Text = row.Cells[0].Value.ToString();
                txtbxProductPrice.Text = row.Cells[2].Value.ToString();
                txtbxProductQuantity.Text = initialProductQuantity[txtbxProductID.Text.ToString().Trim()].ToString().Trim();
                //load quantity need import from datagridview to txbx
                txtbxQuantityToImport.Text = row.Cells[3].Value.ToString();
            }
        }
        //done
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewAddedProduct.Rows.Count == 0)
            {
                MessageBox.Show("There are no products to delete", "Warning");
            }
            else
            {
                //there are a little bug is that if you continue to delete without select there will be error
                //update product quantity SERVER
                foreach (DataGridViewRow cRow2 in dataGridViewAddedProduct.SelectedRows)
                {
                    initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()] = initialProductQuantity[txtbxProductID.Text.ToString().Trim()] + Int32.Parse(txtbxQuantityToImport.Text.ToString().Trim());
                    txtbxProductQuantity.Text = initialProductQuantity[cbbxProductID.SelectedValue.ToString().Trim()].ToString().Trim();
                }
                //delete product from datagridview
                foreach (DataGridViewRow cRow in dataGridViewAddedProduct.SelectedRows)
                {
                    dataGridViewAddedProduct.Rows.RemoveAt(cRow.Index);
                }
                MessageBox.Show("Deleted Product", "Warning");
                txtbxQuantityToImport.Clear();
                //re-calculate after deletion
                txtbxTotalCost.Text = calculateTotalCost(txtbxStoreID.Text.ToString().Trim()).ToString().Trim();
            }
            if (dataGridViewAddedProduct.Rows.Count == 0)
            {
                txtbxTotalCost.Clear();
            }
        }
        //done
        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear all data
            initialProductQuantity.Clear();
            txtbxStoreID.Clear();
            txtbxStoreLocation.Clear();
            txtbxProductID.Clear();
            txtbxProductPrice.Clear();
            txtbxProductQuantity.Clear();
            txtbxOrigin.Clear();
            txtbxQuantityToImport.Clear();
            txtbxTotalCost.Clear();
            this.dataGridViewAddedProduct.DataSource = null;
            this.dataGridViewAddedProduct.Rows.Clear();
            //re-load
            this.frmAddProductImport_Load(sender, e);
        }
        //done
        public int getExportBillCounter()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select exportID from Export";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return Int32.Parse(dt.Rows.Count.ToString().Trim());
            }
            else
            {
                return Int32.Parse(dt.Rows.Count.ToString().Trim());
            }
        }
        //done
        public String getExportBillID()
        {
            string exportBillCounter = (getExportBillCounter() + 1).ToString().Trim();
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd").Replace("-", "");
            return "EXPRT"+ dateTime + exportBillCounter;
        }
        //done
        public void insertExportBill(String exportBillID, String paymentMethodID)
        {
            String exportID = exportBillID;
            String exportTotalProduct = dataGridViewAddedProduct.Rows.Count.ToString().Trim();
            String exportTotalPrice = txtbxTotalCost.Text.ToString().Trim();
            String exportCreated = DateTime.Now.ToString("yyyy-MM-dd").Trim();
            String accountID = sessionAccountID;
            int exportStatus = 0; //when create it is always 0, it is set as 1 by the accountant
            String paymentID = paymentMethodID;
            String storeID = txtbxStoreID.Text.ToString().Trim();

            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "insert into Export values (@exportID, @exportTotalProduct, @exportTotalPrice, @exportCreated, @exportStatus, @accountID, @paymentID, @storeID)";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@exportID", exportID);
                cmd.Parameters.AddWithValue("@exportTotalProduct", exportTotalProduct);
                cmd.Parameters.AddWithValue("@exportTotalPrice", exportTotalPrice);
                cmd.Parameters.AddWithValue("@exportCreated", exportCreated);
                cmd.Parameters.AddWithValue("@exportStatus", exportStatus);
                cmd.Parameters.AddWithValue("@accountID", accountID);
                cmd.Parameters.AddWithValue("@paymentID", paymentID);
                cmd.Parameters.AddWithValue("@storeID", storeID);

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
            catch (Exception ex)
            {
                MessageBox.Show("Some error occur: " + ex.Message + " - " + ex.Source);
            }
        }
        //done
        public void insertExportBillDetail(String exportBillID)
        {
            foreach (DataGridViewRow row in dataGridViewAddedProduct.Rows)
            {
                String productID = row.Cells[0].Value.ToString().Trim();
                String productName = row.Cells[1].Value.ToString().Trim();
                String productPrice = row.Cells[2].Value.ToString().Trim();
                String productQuantity = row.Cells[3].Value.ToString().Trim();
                String productOrigin = row.Cells[5].Value.ToString().Trim();
                try
                {
                    SqlConnection conn = new SqlConnection(Program.strConn);
                    conn.Open();

                    String sSQL = "insert into ExportDetail values (@importID, @productID, @productName, @productPrice, @productQuantity, @productOrigin)";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.Parameters.AddWithValue("@importID", exportBillID);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@productPrice", productPrice);
                    cmd.Parameters.AddWithValue("@productQuantity", productQuantity);
                    cmd.Parameters.AddWithValue("@productOrigin", productOrigin);

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
                catch (Exception ex)
                {
                    MessageBox.Show("Some error occur: " + ex.Message + " - " + ex.Source);
                }
            }
        }
        private void btnCreateExport_Click(object sender, EventArgs e)
        {
            if(dataGridViewAddedProduct.Rows.Count == 0)
            {
                MessageBox.Show("Can not Export Bill because there are no product", "Warning");
                btnCreateExport.Enabled = false;
                txtbxTotalCost.Clear();
            }
            else
            {
                //String temp = "ID: " + getExportBillID() + ", Total Cost: " + txtbxTotalCost.Text.ToString().Trim() +", Method: " +paymentMethod;
                //MessageBox.Show(temp);
                String exportBillID = getExportBillID();
                String paymentMethodID = cbbxPaymentMethod.SelectedValue.ToString();
                DialogResult dt = MessageBox.Show("Do you want to Create Export Bill", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dt == DialogResult.Yes)
                {
                    insertExportBill(exportBillID, paymentMethodID);
                    insertExportBillDetail(exportBillID);

                    MessageBox.Show("Created Export Bill: " + exportBillID + "", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear data not reload
                    this.dataGridViewAddedProduct.DataSource = null;
                    this.dataGridViewAddedProduct.Rows.Clear();
                    txtbxTotalCost.Clear();
                    txtbxQuantityToImport.Clear();
                    cbbxPaymentMethod.SelectedIndex = 0;
                }
            }
        }
        //TESTING AREA FUNCTIONS
        public String getStoreTaxMethod(String storeID, String strConn) 
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select taxValue from Store where storeID = @storeID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@storeID", storeID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString().Trim();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public double calculateTotalCostMethod(double sum, String storeID, String strConn)
        {
            double storeTax;
            String temp = getStoreTaxMethod(storeID, strConn);
            if(temp.Equals("") == true)
            {
                return -1;
            }
            else
            {
                storeTax = double.Parse(temp);
            }
            return sum - (sum * storeTax / 100);
        }
        public int getExportBillCounterMethod(String strConn)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                String sSQL = "select exportID from Export";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return Int32.Parse(dt.Rows.Count.ToString().Trim());
                }
                else
                {
                    return Int32.Parse(dt.Rows.Count.ToString().Trim());
                }
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public List<Product> convertDataGridToListProduct(DataGridView inputData)
        {
            List<Product> result = new List<Product>();
            foreach (DataGridViewRow row in inputData.Rows)
            {
                Product product = new Product();
                product.id = row.Cells[0].Value.ToString();
                product.name = row.Cells[1].Value.ToString();
                product.price = row.Cells[2].Value.ToString();
                product.quantity = row.Cells[3].Value.ToString();
                product.origin = row.Cells[4].Value.ToString();
                result.Add(product);
            }
            return result;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(dataGridViewAddedProduct.Rows.Count == 0)
            {
                MessageBox.Show("No preview available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Product> dataSourceProduct = convertDataGridToListProduct(dataGridViewAddedProduct);
            String exportID = getExportBillID();
            String storeID = txtbxStoreID.Text.ToString().Trim();
            String accountID = txtbxSessionUser.Text.ToString().Trim();
            String paymentMethod = cbbxPaymentMethod.SelectedValue.ToString();
            String exportStatus = "(preview)";
            String date = DateTime.Now.ToString().Trim();
            String totalPrice = txtbxTotalCost.Text.ToString().Trim();
            String totalQuantity = dataGridViewAddedProduct.Rows.Count.ToString().Trim();

            frmPrintExport f = new frmPrintExport(dataSourceProduct, exportID, storeID, accountID, paymentMethod, exportStatus, date, totalPrice, totalQuantity);
            f.ShowDialog();
        }
    }
}
