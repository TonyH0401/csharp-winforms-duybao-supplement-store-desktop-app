namespace Finals_Project
{
    partial class frmExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxPaymentMethod = new System.Windows.Forms.TextBox();
            this.txtbxExportStatus = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblExportStatus = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnNewExport = new System.Windows.Forms.Button();
            this.txtbxStoreID = new System.Windows.Forms.TextBox();
            this.lblDisplayExport = new System.Windows.Forms.Label();
            this.lblTimeCreated = new System.Windows.Forms.Label();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.txtExportID = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.dateTimePickerExportCreated = new System.Windows.Forms.DateTimePicker();
            this.lblAccountExport = new System.Windows.Forms.Label();
            this.lblExportID = new System.Windows.Forms.Label();
            this.listBoxExportID = new System.Windows.Forms.ListBox();
            this.dataGridViewExportDetail = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblExport.Location = new System.Drawing.Point(279, 9);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(284, 31);
            this.lblExport.TabIndex = 7;
            this.lblExport.Text = "EXPORT MANAGER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtbxPaymentMethod);
            this.panel1.Controls.Add(this.txtbxExportStatus);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblPaymentMethod);
            this.panel1.Controls.Add(this.lblExportStatus);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnNewExport);
            this.panel1.Controls.Add(this.txtbxStoreID);
            this.panel1.Controls.Add(this.lblDisplayExport);
            this.panel1.Controls.Add(this.lblTimeCreated);
            this.panel1.Controls.Add(this.lblStoreID);
            this.panel1.Controls.Add(this.txtExportID);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.dateTimePickerExportCreated);
            this.panel1.Controls.Add(this.lblAccountExport);
            this.panel1.Controls.Add(this.lblExportID);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 197);
            this.panel1.TabIndex = 8;
            // 
            // txtbxPaymentMethod
            // 
            this.txtbxPaymentMethod.Location = new System.Drawing.Point(398, 71);
            this.txtbxPaymentMethod.Name = "txtbxPaymentMethod";
            this.txtbxPaymentMethod.Size = new System.Drawing.Size(149, 20);
            this.txtbxPaymentMethod.TabIndex = 19;
            // 
            // txtbxExportStatus
            // 
            this.txtbxExportStatus.Location = new System.Drawing.Point(107, 130);
            this.txtbxExportStatus.Name = "txtbxExportStatus";
            this.txtbxExportStatus.Size = new System.Drawing.Size(81, 20);
            this.txtbxExportStatus.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(398, 102);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(149, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Location = new System.Drawing.Point(312, 158);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(303, 105);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(302, 76);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(90, 13);
            this.lblPaymentMethod.TabIndex = 18;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblExportStatus
            // 
            this.lblExportStatus.AutoSize = true;
            this.lblExportStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportStatus.Location = new System.Drawing.Point(14, 133);
            this.lblExportStatus.Name = "lblExportStatus";
            this.lblExportStatus.Size = new System.Drawing.Size(87, 13);
            this.lblExportStatus.TabIndex = 20;
            this.lblExportStatus.Text = "Export Status:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(467, 159);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Orange;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(28, 158);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnNewExport
            // 
            this.btnNewExport.BackColor = System.Drawing.Color.LawnGreen;
            this.btnNewExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExport.Location = new System.Drawing.Point(167, 159);
            this.btnNewExport.Name = "btnNewExport";
            this.btnNewExport.Size = new System.Drawing.Size(100, 30);
            this.btnNewExport.TabIndex = 7;
            this.btnNewExport.Text = "New Export";
            this.btnNewExport.UseVisualStyleBackColor = false;
            this.btnNewExport.Click += new System.EventHandler(this.btnNewExport_Click);
            // 
            // txtbxStoreID
            // 
            this.txtbxStoreID.Location = new System.Drawing.Point(107, 102);
            this.txtbxStoreID.Name = "txtbxStoreID";
            this.txtbxStoreID.Size = new System.Drawing.Size(149, 20);
            this.txtbxStoreID.TabIndex = 17;
            // 
            // lblDisplayExport
            // 
            this.lblDisplayExport.AutoSize = true;
            this.lblDisplayExport.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDisplayExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayExport.Location = new System.Drawing.Point(14, 8);
            this.lblDisplayExport.Name = "lblDisplayExport";
            this.lblDisplayExport.Size = new System.Drawing.Size(140, 17);
            this.lblDisplayExport.TabIndex = 9;
            this.lblDisplayExport.Text = "DISPLAY EXPORT";
            // 
            // lblTimeCreated
            // 
            this.lblTimeCreated.AutoSize = true;
            this.lblTimeCreated.Location = new System.Drawing.Point(302, 48);
            this.lblTimeCreated.Name = "lblTimeCreated";
            this.lblTimeCreated.Size = new System.Drawing.Size(73, 13);
            this.lblTimeCreated.TabIndex = 11;
            this.lblTimeCreated.Text = "Time Created:";
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(14, 105);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(49, 13);
            this.lblStoreID.TabIndex = 16;
            this.lblStoreID.Text = "Store ID:";
            // 
            // txtExportID
            // 
            this.txtExportID.Location = new System.Drawing.Point(107, 73);
            this.txtExportID.Name = "txtExportID";
            this.txtExportID.Size = new System.Drawing.Size(149, 20);
            this.txtExportID.TabIndex = 9;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(107, 45);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(149, 20);
            this.txtAccount.TabIndex = 10;
            // 
            // dateTimePickerExportCreated
            // 
            this.dateTimePickerExportCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExportCreated.Location = new System.Drawing.Point(398, 45);
            this.dateTimePickerExportCreated.Name = "dateTimePickerExportCreated";
            this.dateTimePickerExportCreated.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerExportCreated.TabIndex = 5;
            // 
            // lblAccountExport
            // 
            this.lblAccountExport.AutoSize = true;
            this.lblAccountExport.Location = new System.Drawing.Point(14, 48);
            this.lblAccountExport.Name = "lblAccountExport";
            this.lblAccountExport.Size = new System.Drawing.Size(50, 13);
            this.lblAccountExport.TabIndex = 2;
            this.lblAccountExport.Text = "Account:";
            // 
            // lblExportID
            // 
            this.lblExportID.AutoSize = true;
            this.lblExportID.Location = new System.Drawing.Point(14, 76);
            this.lblExportID.Name = "lblExportID";
            this.lblExportID.Size = new System.Drawing.Size(54, 13);
            this.lblExportID.TabIndex = 3;
            this.lblExportID.Text = "Export ID:";
            // 
            // listBoxExportID
            // 
            this.listBoxExportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExportID.FormattingEnabled = true;
            this.listBoxExportID.ItemHeight = 15;
            this.listBoxExportID.Location = new System.Drawing.Point(626, 44);
            this.listBoxExportID.Name = "listBoxExportID";
            this.listBoxExportID.Size = new System.Drawing.Size(153, 379);
            this.listBoxExportID.TabIndex = 9;
            this.listBoxExportID.SelectedIndexChanged += new System.EventHandler(this.listBoxExportID_SelectedIndexChanged);
            // 
            // dataGridViewExportDetail
            // 
            this.dataGridViewExportDetail.AllowUserToAddRows = false;
            this.dataGridViewExportDetail.AllowUserToDeleteRows = false;
            this.dataGridViewExportDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExportDetail.Location = new System.Drawing.Point(12, 256);
            this.dataGridViewExportDetail.Name = "dataGridViewExportDetail";
            this.dataGridViewExportDetail.ReadOnly = true;
            this.dataGridViewExportDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExportDetail.Size = new System.Drawing.Size(597, 166);
            this.dataGridViewExportDetail.TabIndex = 10;
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 434);
            this.Controls.Add(this.dataGridViewExportDetail);
            this.Controls.Add(this.listBoxExportID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExport";
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNewExport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDisplayExport;
        private System.Windows.Forms.Label lblTimeCreated;
        private System.Windows.Forms.TextBox txtExportID;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.DateTimePicker dateTimePickerExportCreated;
        private System.Windows.Forms.Label lblAccountExport;
        private System.Windows.Forms.Label lblExportID;
        private System.Windows.Forms.TextBox txtbxPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtbxStoreID;
        private System.Windows.Forms.Label lblStoreID;
        private System.Windows.Forms.TextBox txtbxExportStatus;
        private System.Windows.Forms.Label lblExportStatus;
        private System.Windows.Forms.ListBox listBoxExportID;
        private System.Windows.Forms.DataGridView dataGridViewExportDetail;
    }
}