using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finals_Project
{
    public partial class frmChart : Form
    {
        private DataTable dtImport = new DataTable();
        private DataTable dtExport = new DataTable();
        private String seriesName1 = "";
        private String seriesName2 = "";
        private int maxValue = 0;
        private String frmName = "";

        public frmChart(DataTable dtImport, DataTable dtExport, String name1, String name2, int maxValue, String frmName)
        {
            InitializeComponent();
            this.dtImport = dtImport;
            this.dtExport = dtExport;
            this.seriesName1 = name1;
            this.seriesName2 = name2;
            this.maxValue = maxValue;
            this.frmName = frmName;
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            ////clear all of the name (series)
            this.chart1.Series.Clear();

            ////set up the name of the series
            Series ser1 = chart1.Series.Add(seriesName1);
            ser1.Name = seriesName1;
            Series ser2 = chart1.Series.Add(seriesName2);
            ser2.Name = seriesName2;

            ////set max value
            this.chart1.ChartAreas[0].AxisY.Maximum = maxValue;

            ////load the product
            foreach (DataRow item in dtImport.Rows)
            {
                String name = item[4].ToString();
                String quantity = item[6].ToString();
                //the AddXY is set to Auto
                this.chart1.Series[seriesName1].Points.AddXY(name, quantity);
            }
            foreach (DataRow item in dtExport.Rows)
            {
                String name = item[7].ToString();
                String quantity = item[9].ToString();
                //the AddXY is set to Auto
                this.chart1.Series[seriesName2].Points.AddXY(name, quantity);
            }

            ////sort the bar chart
            this.chart1.DataBind();
            this.chart1.Series[seriesName1].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Ascending);
            this.chart1.Series[seriesName2].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Ascending);

            this.Text = frmName + " bar chart";
        }

    }
}
