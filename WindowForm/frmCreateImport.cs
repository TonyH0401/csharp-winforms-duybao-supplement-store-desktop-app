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
    public partial class frmCreateImport : Form
    {
        //Dictionary<string, int> initialProductQuantity = new Dictionary<string, int>();
        public String sessionAccount = "";
        public String sessAccountPhone = "";
        public frmCreateImport()
        {
            InitializeComponent();
        }

        private void frmCreateImport_Load(object sender, EventArgs e)
        {
            initiateComponentsOnLoad(); 
            initiateDataGridView();
            onFormLoadAccountSessionData();
        }

        private void initiateComponentsOnLoad()
        {
            //pre-exist products
            cbbxProductName.Enabled = false;
            txtbxProductIDOld.Enabled = false;
            txtbxProductIDOld.ReadOnly = true;
            txtbxProductOriginOld.Enabled = false;
            txtbxProductOriginOld.ReadOnly = true;
            txtbxProductPriceOld.Enabled = false;
            txtbxProductPriceOld.ReadOnly = true;
            txtbxProductQuantityOld.Enabled = false;

            //new products
            txtbxProductID.Enabled = false;
            txtbxProductName.Enabled = false;
            txtbxProductQuantityNew.Enabled = false;
            txtbxProductPrice.Enabled = false;
            txtbxProductOrigin.Enabled = false;

            //account info
            txtsessionAccount.Enabled = false;
            txtsessionAccountPhone.Enabled = false;

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void initiateDataGridView()
        {
            dataGridViewImportProduct.ColumnCount = 6;
            dataGridViewImportProduct.Columns[0].Name = "ProductID";
            dataGridViewImportProduct.Columns[1].Name = "Product Name";
            dataGridViewImportProduct.Columns[2].Name = "Product Price";
            dataGridViewImportProduct.Columns[3].Name = "Quantity";
            dataGridViewImportProduct.Columns[4].Name = "Origin";
            dataGridViewImportProduct.Columns[5].Name = "Total Price";
        }
        private void btnChooseImportType_Click(object sender, EventArgs e)
        {
            if(rdbtnImportNewProduct.Checked == false && rdbtnImportOldProduct.Checked == false)
            {
                MessageBox.Show("Please choose type of Import", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            if(rdbtnImportNewProduct.Checked == true)
            {
                this.ActiveControl = txtbxProductName;

                txtbxProductID.Enabled = true;
                txtbxProductName.Enabled = true;
                txtbxProductOrigin.Enabled = true;
                txtbxProductPrice.Enabled = true;
                txtbxProductQuantityNew.Enabled = true;

                cbbxProductName.Enabled = false; ;
                txtbxProductPriceOld.Enabled = false;
                txtbxProductQuantityOld.Enabled = false;

                btnAdd.Enabled = true;
            }
            if(rdbtnImportOldProduct.Checked == true)
            {
                this.ActiveControl = txtbxProductQuantityOld;

                cbbxProductName.Enabled = true;

                txtbxProductID.Enabled = false;
                txtbxProductName.Enabled = false;
                txtbxProductOrigin.Enabled = false;
                txtbxProductPrice.Enabled = false;
                txtbxProductQuantityNew.Enabled = false;

                btnAdd.Enabled = true;

                loadComboBoxOldProduct();
            }
        }
        private void loadComboBoxOldProduct()
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
                cbbxProductName.DataSource = dt;
                cbbxProductName.DisplayMember = "productName";
                cbbxProductName.ValueMember = "productID";
            }
            else
            {
                MessageBox.Show("No data", "Warning");
            }
        }
        private void loadOtherDataFromComboBoxOldProduct()
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select * from Product where productID = @productID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@productID", cbbxProductName.SelectedValue.ToString().Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtbxProductIDOld.Text = (String)dt.Rows[0][0];
                txtbxProductPriceOld.Text = ((int)dt.Rows[0][2]).ToString().Trim();
                txtbxProductOriginOld.Text = (String)dt.Rows[0][4];
            }
            else
            {
                //MessageBox.Show("No data", "Warning");
            }
        }
        private void cbbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxProductQuantityOld;
            txtbxProductQuantityOld.Enabled = true;

            loadOtherDataFromComboBoxOldProduct();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;

            String productID = "";
            String productName = "";
            String productPrice = "";
            String productOrigin = "";
            String productQuantity = "";
            if (rdbtnImportOldProduct.Checked == true)
            {
                if (txtbxProductQuantityOld.Text.ToString().Trim().Equals("") == true)
                {
                    MessageBox.Show("Please fill in the quantity!", "Warning Box");
                }
                else if(txtbxProductOriginOld.Text.ToString().Trim().Equals("") == true)
                {
                    MessageBox.Show("Please choose the product first!", "Warning Box");
                }
                else
                {
                    int n;
                    bool isNumeric = int.TryParse(txtbxProductQuantityOld.Text.ToString().Trim(), out n);
                    if (isNumeric == false)
                    {
                        MessageBox.Show("Please enter a number", "Warning input type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbxProductQuantityOld.Clear();
                    }
                    else
                    {
                        //get data from text box
                        productID = txtbxProductIDOld.Text.ToString().Trim();
                        productName = cbbxProductName.Text.ToString().Trim();
                        productPrice = txtbxProductPriceOld.Text.ToString().Trim();
                        productOrigin = txtbxProductOriginOld.Text.ToString().Trim();
                        productQuantity = txtbxProductQuantityOld.Text.ToString().Trim();

                        int rowIndex = -1;
                        String searchValuePROD = cbbxProductName.SelectedValue.ToString().Trim();
                        bool foundProduct = false;
                        //add to an existing product in the datagrid
                        foreach (DataGridViewRow row in dataGridViewImportProduct.Rows)
                        {
                            if (row.Cells[0].Value.ToString().Equals(searchValuePROD) == true)
                            {
                                row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString().Trim()) + Int32.Parse(txtbxProductQuantityOld.Text.ToString().Trim());
                                row.Cells[5].Value = Int32.Parse(row.Cells[2].Value.ToString().Trim()) * Int32.Parse(row.Cells[3].Value.ToString().Trim());
                                rowIndex = row.Index;
                                foundProduct = true;
                                break;
                            }
                        }
                        //add new data to datagrid
                        if (foundProduct == false)
                        {
                            String totalPrice = (Int32.Parse(productPrice) * Int32.Parse(productQuantity)).ToString().Trim();
                            string[] row = new string[] { productID, productName, productPrice, productQuantity, productOrigin, totalPrice };
                            dataGridViewImportProduct.Rows.Add(row);
                        }
                        MessageBox.Show("Successfully Added", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearDataFromInsert();
                    }
                }
            }
            if(rdbtnImportNewProduct.Checked == true)
            {
                int pNameNew = txtbxProductName.Text.ToString().Trim().Length;
                int pIDNew = txtbxProductID.Text.ToString().Trim().Length;
                int pQuantityNew = txtbxProductQuantityNew.Text.ToString().Trim().Length;
                int pPriceNew = txtbxProductPrice.Text.ToString().Trim().Length;
                int pOriginNew = txtbxProductOrigin.Text.ToString().Trim().Length;

                if((pNameNew * pIDNew * pQuantityNew * pPriceNew * pOriginNew) == 0)
                {
                    MessageBox.Show("Please fill in all the correct information", "Warning");
                }
                else
                {
                    int n, m;
                    bool isNumericQuantity = int.TryParse(txtbxProductQuantityNew.Text.ToString().Trim(), out n);
                    bool isNumberPrice = int.TryParse(txtbxProductPrice.Text.ToString().Trim(), out m);
                    if((isNumericQuantity && isNumberPrice) == false)
                    {
                        MessageBox.Show("Wrong data input type", "Warning");
                    }
                    else
                    {
                        productID = txtbxProductID.Text.ToString().ToUpper().Trim();
                        productName = txtbxProductName.Text.ToString().Trim();
                        productPrice = txtbxProductPrice.Text.ToString().Trim();
                        productOrigin = txtbxProductOrigin.Text.ToString().Trim();
                        productQuantity = txtbxProductQuantityNew.Text.ToString().Trim();

                        int rowIndex = -1;
                        String searchValuePROD = productID;
                        bool foundProduct = false;
                        //add to an existing product in the datagrid
                        foreach (DataGridViewRow row in dataGridViewImportProduct.Rows)
                        {
                            if (row.Cells[0].Value.ToString().Equals(searchValuePROD) == true)
                            {
                                row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString().Trim()) + Int32.Parse(txtbxProductQuantityOld.Text.ToString().Trim());
                                row.Cells[5].Value = Int32.Parse(row.Cells[2].Value.ToString().Trim()) * Int32.Parse(row.Cells[3].Value.ToString().Trim());
                                rowIndex = row.Index;
                                foundProduct = true;
                                break;
                            }
                        }
                        //add new data to datagrid
                        if (foundProduct == false)
                        {
                            String totalPrice = (Int32.Parse(productPrice) * Int32.Parse(productQuantity)).ToString().Trim();
                            string[] row = new string[] { productID, productName, productPrice, productQuantity, productOrigin, totalPrice };
                            dataGridViewImportProduct.Rows.Add(row);
                        }
                        MessageBox.Show("Successfully Added", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearDataFromInsert();
                    }
                }
            }
        }
        public void clearDataFromInsert()
        {
            //old products sections
            //cbbxProductName.SelectedIndex = -1;
            txtbxProductIDOld.Clear();
            txtbxProductPriceOld.Clear();
            txtbxProductOriginOld.Clear();
            txtbxProductQuantityOld.Clear();
            //new products section
            txtbxProductID.Clear();
            txtbxProductName.Clear();
            txtbxProductPrice.Clear();
            txtbxProductOrigin.Clear();
            txtbxProductQuantityNew.Clear();
        }
        public void clearDataGridView()
        {
            dataGridViewImportProduct.Rows.Clear();
            dataGridViewImportProduct.Refresh();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDataFromInsert();
            clearDataGridView();
        }
        public String getSessionUserDataFromProgram()
        {
            String value0 = Program.sessionAccount;
            if(value0.Length == 0)
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
        public void onFormLoadAccountSessionData()
        {
            getSessionUserData();
            txtsessionAccount.Text = sessionAccount;
            txtsessionAccountPhone.Text = sessAccountPhone;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewImportProduct.Rows.Count == 0)
            {
                MessageBox.Show("There are no products to Import", "Warning box");
                btnDelete.Enabled = false;
            }
            else
            {
                foreach (DataGridViewRow item in this.dataGridViewImportProduct.SelectedRows)
                {
                    dataGridViewImportProduct.Rows.RemoveAt(item.Index);
                }
            }   
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do you want to Exit!?", "Exit System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public int countImportBill()
        {
            int importBillCounter = 0;

            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select importID from Import where importCreated = @importCreated";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@importCreated", DateTime.Now.ToString("yyyy:MM:dd").Replace(":", "-").Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                importBillCounter = dt.Rows.Count;
            }
            else
            {
                importBillCounter = 0;
            }
            return importBillCounter;
        }
        public String createImportBillID()
        {
            String billNumber = (countImportBill() + 1).ToString().Trim();
            String dateTime = DateTime.Now.ToString("yyyy-MM-dd").Replace("-", "");
            String billID = "IMPRT" + dateTime + billNumber;
            return billID;
        }
        public String getImportBillTotalPrice()
        {
            int totalPrice = 0;
            foreach(DataGridViewRow row in dataGridViewImportProduct.Rows)
            {
                String temp = row.Cells[5].Value.ToString().Trim();
                totalPrice = totalPrice + Int32.Parse(temp);
            }
            return totalPrice.ToString().Trim();
        }
        public void insertImportBill(String importBillID)
        {
            String importID = importBillID;
            String importTotalProduct = dataGridViewImportProduct.Rows.Count.ToString().Trim();
            String importTotalPrice = getImportBillTotalPrice();
            String importCreated = DateTime.Now.ToString("yyyy-MM-dd").Trim();
            String accountID = sessionAccount;

            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();

                String sSQL = "insert into Import values (@importID, @importTotalProduct, @importTotalPrice, @importCreated, @accountID)";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@importID", importID);
                cmd.Parameters.AddWithValue("@importTotalProduct", importTotalProduct);
                cmd.Parameters.AddWithValue("@importTotalPrice", importTotalPrice);
                cmd.Parameters.AddWithValue("@importCreated", importCreated);
                cmd.Parameters.AddWithValue("@accountID", accountID);

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
        public void insertImportBillDetail(String importBillID)
        {
            foreach(DataGridViewRow row in dataGridViewImportProduct.Rows)
            {
                String productID = row.Cells[0].Value.ToString().Trim();
                String productName = row.Cells[1].Value.ToString().Trim();
                String productPrice = row.Cells[2].Value.ToString().Trim();
                String productQuantity = row.Cells[3].Value.ToString().Trim();
                String productOrigin = row.Cells[4].Value.ToString().Trim();

                try
                {
                    SqlConnection conn = new SqlConnection(Program.strConn);
                    conn.Open();

                    String sSQL = "insert into ImportDetail values (@importID, @productID, @productName, @productPrice, @productQuantity, @productOrigin)";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.Parameters.AddWithValue("@importID", importBillID);
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
        public bool checkProductExist(String productID)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            String sSQL = "select * from Product where productID = @productID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@productID", productID);
                
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
        public void insertProduct()
        {
            foreach (DataGridViewRow row in dataGridViewImportProduct.Rows)
            {
                String productID = row.Cells[0].Value.ToString().Trim();
                String productName = row.Cells[1].Value.ToString().Trim();
                String productPrice = row.Cells[2].Value.ToString().Trim();
                String productQuantity = row.Cells[3].Value.ToString().Trim();
                String productOrigin = row.Cells[4].Value.ToString().Trim();

                if(checkProductExist(productID) == true)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(Program.strConn);
                        conn.Open();

                        String sSQL = "update Product set productQuantity = productQuantity + @productQuantity where productID = @productID";
                        SqlCommand cmd = new SqlCommand(sSQL, conn);
                        cmd.Parameters.AddWithValue("@productQuantity", productQuantity);
                        cmd.Parameters.AddWithValue("@productID", productID);
                        
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
                else
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(Program.strConn);
                        conn.Open();

                        String sSQL = "insert into Product values (@productID, @productName, @productPrice, @productQuantity, @productOrigin)";
                        SqlCommand cmd = new SqlCommand(sSQL, conn);
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
        }
        private void btnCreate_Click(object sender, EventArgs e)
        { 
            if(dataGridViewImportProduct.Rows.Count == 0)
            {
                MessageBox.Show("Can not create an Import Request because there are no data", "Warning no data on create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dt = MessageBox.Show("Do you want to Create Import Bill", "System Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dt == DialogResult.Yes)
                {
                    //insert new product, error proof for FK
                    insertProduct();

                    String importBillID = createImportBillID();
                    insertImportBill(importBillID);
                    insertImportBillDetail(importBillID);

                    MessageBox.Show("Created Import Bill: " + importBillID + "", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearDataFromInsert();
                    clearDataGridView();
                }
                //need to add question do you want to keep importing
            }
        }
    }
}
