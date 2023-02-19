using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Project
{
    public partial class frmChart : Form
    {
        private DataTable dtImport = new DataTable();
        private DataTable dtExport = new DataTable();
        private String seriesName1 = "";
        private String seriesName2 = "";
        private int maxValue = 0;

        public frmChart()
        {
            InitializeComponent();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {

        }
    }
}
