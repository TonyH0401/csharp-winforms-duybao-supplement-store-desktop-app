namespace Finals_Project
{
    partial class frmImport
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
            this.listBoxImportID = new System.Windows.Forms.ListBox();
            this.dataGridViewImportDetail = new System.Windows.Forms.DataGridView();
            this.lblAccountImport = new System.Windows.Forms.Label();
            this.lblImportID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNewImport = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblTimeCreated = new System.Windows.Forms.Label();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.dateTimePickerImportCreated = new System.Windows.Forms.DateTimePicker();
            this.lblImport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxImportID
            // 
            this.listBoxImportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxImportID.FormattingEnabled = true;
            this.listBoxImportID.ItemHeight = 15;
            this.listBoxImportID.Location = new System.Drawing.Point(630, 49);
            this.listBoxImportID.Name = "listBoxImportID";
            this.listBoxImportID.Size = new System.Drawing.Size(153, 334);
            this.listBoxImportID.TabIndex = 0;
            this.listBoxImportID.SelectedIndexChanged += new System.EventHandler(this.listBoxImportID_SelectedIndexChanged);
            // 
            // dataGridViewImportDetail
            // 
            this.dataGridViewImportDetail.AllowUserToAddRows = false;
            this.dataGridViewImportDetail.AllowUserToDeleteRows = false;
            this.dataGridViewImportDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportDetail.Location = new System.Drawing.Point(12, 217);
            this.dataGridViewImportDetail.Name = "dataGridViewImportDetail";
            this.dataGridViewImportDetail.ReadOnly = true;
            this.dataGridViewImportDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImportDetail.Size = new System.Drawing.Size(597, 166);
            this.dataGridViewImportDetail.TabIndex = 1;
            // 
            // lblAccountImport
            // 
            this.lblAccountImport.AutoSize = true;
            this.lblAccountImport.Location = new System.Drawing.Point(14, 45);
            this.lblAccountImport.Name = "lblAccountImport";
            this.lblAccountImport.Size = new System.Drawing.Size(50, 13);
            this.lblAccountImport.TabIndex = 2;
            this.lblAccountImport.Text = "Account:";
            // 
            // lblImportID
            // 
            this.lblImportID.AutoSize = true;
            this.lblImportID.Location = new System.Drawing.Point(299, 46);
            this.lblImportID.Name = "lblImportID";
            this.lblImportID.Size = new System.Drawing.Size(53, 13);
            this.lblImportID.TabIndex = 3;
            this.lblImportID.Text = "Import ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnNewImport);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.lblTimeCreated);
            this.panel1.Controls.Add(this.txtImportID);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.dateTimePickerImportCreated);
            this.panel1.Controls.Add(this.lblAccountImport);
            this.panel1.Controls.Add(this.lblImportID);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 162);
            this.panel1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Location = new System.Drawing.Point(302, 116);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(457, 117);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(160, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(82, 79);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(149, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // btnNewImport
            // 
            this.btnNewImport.BackColor = System.Drawing.Color.LawnGreen;
            this.btnNewImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewImport.Location = new System.Drawing.Point(17, 116);
            this.btnNewImport.Name = "btnNewImport";
            this.btnNewImport.Size = new System.Drawing.Size(100, 30);
            this.btnNewImport.TabIndex = 7;
            this.btnNewImport.Text = "New Import";
            this.btnNewImport.UseVisualStyleBackColor = false;
            this.btnNewImport.Click += new System.EventHandler(this.btnNewImport_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(14, 8);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(136, 17);
            this.lblDisplay.TabIndex = 9;
            this.lblDisplay.Text = "DISPLAY IMPORT";
            // 
            // lblTimeCreated
            // 
            this.lblTimeCreated.AutoSize = true;
            this.lblTimeCreated.Location = new System.Drawing.Point(299, 83);
            this.lblTimeCreated.Name = "lblTimeCreated";
            this.lblTimeCreated.Size = new System.Drawing.Size(73, 13);
            this.lblTimeCreated.TabIndex = 11;
            this.lblTimeCreated.Text = "Time Created:";
            // 
            // txtImportID
            // 
            this.txtImportID.Location = new System.Drawing.Point(386, 46);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.Size = new System.Drawing.Size(149, 20);
            this.txtImportID.TabIndex = 9;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(82, 45);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(149, 20);
            this.txtAccount.TabIndex = 10;
            // 
            // dateTimePickerImportCreated
            // 
            this.dateTimePickerImportCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerImportCreated.Location = new System.Drawing.Point(386, 80);
            this.dateTimePickerImportCreated.Name = "dateTimePickerImportCreated";
            this.dateTimePickerImportCreated.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerImportCreated.TabIndex = 5;
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImport.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblImport.Location = new System.Drawing.Point(271, 8);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(278, 31);
            this.lblImport.TabIndex = 6;
            this.lblImport.Text = "IMPORT MANAGER";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewImportDetail);
            this.Controls.Add(this.listBoxImportID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxImportID;
        private System.Windows.Forms.DataGridView dataGridViewImportDetail;
        private System.Windows.Forms.Label lblAccountImport;
        private System.Windows.Forms.Label lblImportID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerImportCreated;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Button btnNewImport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtImportID;
        private System.Windows.Forms.Label lblTimeCreated;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
    }
}