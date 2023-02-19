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
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
        }

        private void frmStatistic_Load(object sender, EventArgs e)
        {
            initiateComponents();
        }
        public void initiateComponents()
        {
            //initiate current time
            dateTimePickerCurrentTime.Value = DateTime.Now;
            dateTimePickerCurrentTime.Enabled = false;
            //initiate select time
            dateTimePickerImportExportBill.Format = DateTimePickerFormat.Custom;
            dateTimePickerImportExportBill.CustomFormat = "MM/yyyy";
            //readOnly txtbx
            txtbxImportValue.ReadOnly = true;
            txtbxExportValue.ReadOnly = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //get selected month from user
            String dayMonthYear = dateTimePickerImportExportBill.Value.ToString("yyyy-MM-dd").Trim();
            int year = Int32.Parse(dayMonthYear.Split('-')[0]);
            int month = Int32.Parse(dayMonthYear.Split('-')[1]);
            //load total value and product by month
            txtbxImportValue.Text = getTotalPriceByMonthImport(year, month).ToString().Trim();
            getImportDetailByMonth(year, month);
            txtbxExportValue.Text = getTotalPriceByMonthExport(year, month).ToString().Trim();
            getExportDetailByMonth(year, month);
            //top product
            getTopImport(year, month);
            //top product export, WITH STATUS 1 ONLY - this explained the E.exportStatus = 1
            getTopExport(year, month);
        }
        public double getTotalPriceByMonthImport(int year, int month)
        {
            double sum = 0;
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select importTotalPrice from Import where MONTH(importCreated) = @month and YEAR(importCreated) = @year";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    double temp = double.Parse(dr[0].ToString());
                    sum = sum + temp;
                }
            }
            else
            {
                //MessageBox.Show("No Import Data for: " + month, "Warning");
            }
            return sum;
        }
        public void getImportDetailByMonth(int year, int month)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select I.importID, importTotalPrice, importCreated, productID, productName, productPrice, productQuantity, productOrigin from Import as I, ImportDetail as ID where I.importID = ID.importID and MONTH(importCreated) = @month and YEAR(importCreated) = @year";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewImport.DataSource = dt;
            }
            else
            {
                //MessageBox.Show("No Detail Import Data for month: " + month, "Warning");
                dataGridViewImport.DataSource=null;
            }
        }
        public double getTotalPriceByMonthExport(int year, int month)
        {
            double sum = 0;
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select exportTotalPrice from Export where MONTH(exportCreated) = @month and YEAR(exportCreated) = @year";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    double temp = double.Parse(dr[0].ToString());
                    sum = sum + temp;
                }
            }
            else
            {
                //MessageBox.Show("No Export Data for: " +month, "Warning");
            }
            return sum;
        }
        public void getExportDetailByMonth(int year, int month)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select E.exportStatus, E.exportID, exportTotalPrice, E.storeID, E.paymentID, exportCreated, productID, productName, productPrice, productQuantity, productOrigin from Export as E, ExportDetail as ED where E.exportID = ED.exportID and MONTH(exportCreated) = @month and YEAR(exportCreated) = @year";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewExport.DataSource = dt;
            }
            else
            {
                //MessageBox.Show("No Detail Export Data for month: " + month, "Warning");
                dataGridViewExport.DataSource=null;
            }
        }
        public void getTopImport(int year, int month)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select top 2 productID as ID, productName as Name, sum(productQuantity) as TotalQuantity from Import as I, ImportDetail as ID where I.importID = ID.importID and MONTH(importCreated) = @month and YEAR(importCreated) = @year group by productID, productName order by TotalQuantity desc";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewTopImport.DataSource = dt;
            }
            else
            {
                //MessageBox.Show("No Detail Import Data for month: " + month, "Warning");
                dataGridViewTopImport.DataSource = null;
            }
        }
        public void getTopExport(int year, int month)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select top 2 productID, productName, sum(productQuantity) as TotalQuantity from Export as E, ExportDetail as ED where E.exportID = ED.exportID and E.exportStatus = 1 and MONTH(exportCreated) = @month and YEAR(exportCreated) = @year group by productID, productName order by TotalQuantity desc, productID asc";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewTopExport.DataSource = dt;
            }
            else
            {
                //MessageBox.Show("No Detail Import Data for month: " + month, "Warning");
                dataGridViewTopExport.DataSource = null;
            }
        }

        private void btnVisualize_Click(object sender, EventArgs e)
        {
            if(dataGridViewImport.Rows.Count == 0)
            {
                MessageBox.Show("There are no data to visualize!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dtImport = (DataTable)dataGridViewImport.DataSource;
            DataTable dtExport = (DataTable)dataGridViewExport.DataSource;

            String frmName = dateTimePickerImportExportBill.Text;
            frmChart f = new frmChart(dtImport, dtExport, "Import", "Export", 300, frmName);
            f.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewTopImport.DataSource = null;
            dataGridViewTopExport.DataSource = null;
            dataGridViewImport.DataSource = null;
            dataGridViewExport.DataSource = null;

            dateTimePickerImportExportBill.Value = DateTime.Now;
        }
    }
}
