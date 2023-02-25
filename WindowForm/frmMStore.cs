using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Project
{
    public partial class frmMStore : Form
    {
        public frmMStore()
        {
            InitializeComponent();
        }

        private void frmMStore_Load(object sender, EventArgs e)
        {
            Load_DataGridViewStore();
            dataGridViewStore.ClearSelection();

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            this.Text = "Store Management - " + Program.sessionAccount.ToString().Trim();
        }

        private void Load_DataGridViewStore()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "select * from Store order by storeID asc";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewStore.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Store", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Error! Please reload the Application. Code Error 56", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_DataGridViewStore();
            clearAllTextBox();
            MessageBox.Show("Refreshed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewStore.ClearSelection();
        }

        private void clearAllTextBox()
        {
            txtbxStoreID.Clear();
            txtbxName.Clear();
            txtbxLocation.Clear();
            txtbxTax.Clear();
        }

        private void dataGridViewStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;

            txtbxStoreID.Enabled = false;

            try
            {
                DataGridViewRow row = dataGridViewStore.SelectedRows[0];
                txtbxStoreID.Text = row.Cells[0].Value.ToString().Trim();
                txtbxName.Text = row.Cells[1].Value.ToString().Trim();
                txtbxLocation.Text = row.Cells[2].Value.ToString().Trim();
                txtbxTax.Text = row.Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error has occured. Error code 96", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtbxStoreID.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtbxStoreID.Text.ToString().Trim();
            if (id.Length == 0)
            {
                MessageBox.Show("No Store ID to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (storeIdExist(id) == false)
            {
                MessageBox.Show("Store does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Do you want to delete " + id + " ?");
            if(dr == DialogResult.OK)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Program.strConn);
                    conn.Open();
                    String sSQL = "delete from Store where storeID=@id";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Deleted Store!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefresh_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error in deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Error! Please reload the Application. Code 229", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String id = txtbxStoreID.Text.ToString().Trim();
            String name = txtbxName.Text.ToString().Trim();
            String location = txtbxLocation.Text.ToString().Trim();
            String tax = txtbxTax.Text.ToString().Trim();
            if ((id.Length * name.Length * location.Length * tax.Length != 0))
            {
                if (storeIdExist(id.ToUpper()) == true)
                {
                    MessageBox.Show("Store ID existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (id.Length > 15)
                {
                    MessageBox.Show("Invalid ProductID - Length not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int taxValue = 0;
                bool taxTemp = int.TryParse(tax, out taxValue);
                if (taxTemp == false)
                {
                    MessageBox.Show("Please enter the correct data type of tax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (taxValue <= 0)
                    {
                        MessageBox.Show("Tax can not be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                name = textInfo.ToTitleCase(name.ToLower());
                addStore(id.ToUpper(), name, location, taxValue);
                btnRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Empty field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool storeIdExist(String id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "select * from Store where storeID=@id";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@id", id);
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
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Error! Please reload the Application. Code 216", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void addStore(String id, String name, String location, int tax)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.strConn);
                conn.Open();
                String sSQL = "insert into Store values (@id, @name, @location, @tax)";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@tax", tax);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Saved new Store", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot insert new Store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error! Please reload the Application. Code 229", "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String id = txtbxStoreID.Text.ToString().Trim();
            if (id.Length == 0)
            {
                MessageBox.Show("No Store id to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //String id = txtbxUsername.Text.ToString().Trim();
            String name = txtbxName.Text.ToString().Trim();
            String location = txtbxLocation.Text.ToString().Trim();
            String tax = txtbxTax.Text.ToString().Trim();
            if ((id.Length * name.Length * location.Length * tax.Length != 0))
            {
                //if (storeIdExist(id.ToUpper()) == true)
                //{
                //    MessageBox.Show("Store ID existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (id.Length > 20)
                {
                    MessageBox.Show("Invalid StoreID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int taxValue = 0;
                bool taxTemp = int.TryParse(tax, out taxValue);
                if (taxTemp == false)
                {
                    MessageBox.Show("Please enter the correct data type of tax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (taxValue <= 0)
                    {
                        MessageBox.Show("Tax can not be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                name = textInfo.ToTitleCase(name.ToLower());
                DialogResult dr = MessageBox.Show("Do you want to update?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(Program.strConn);
                        conn.Open();
                        String sSQL = "update Store set storeName=@name, storeLocation=@location, taxValue=@tax where storeID=@id";
                        SqlCommand cmd = new SqlCommand(sSQL, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@location", location);
                        cmd.Parameters.AddWithValue("@tax", taxValue);
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            MessageBox.Show("Updated Store: " + id, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnRefresh_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Error cannot update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
            dataGridViewStore.ClearSelection();
        }
    }
}
