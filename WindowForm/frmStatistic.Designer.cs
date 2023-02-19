namespace Finals_Project
{
    partial class frmStatistic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            this.dataGridViewExport = new System.Windows.Forms.DataGridView();
            this.dateTimePickerImportExportBill = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.dateTimePickerCurrentTime = new System.Windows.Forms.DateTimePicker();
            this.lblSelectTime = new System.Windows.Forms.Label();
            this.lblImport = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblImportValue = new System.Windows.Forms.Label();
            this.lblExportValue = new System.Windows.Forms.Label();
            this.txtbxImportValue = new System.Windows.Forms.TextBox();
            this.txtbxExportValue = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.dataGridViewTopImport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTopExport = new System.Windows.Forms.DataGridView();
            this.lblTopImport = new System.Windows.Forms.Label();
            this.lblTopExport = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopExport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.dateTimePickerImportExportBill);
            this.panel1.Controls.Add(this.lblSelectTime);
            this.panel1.Controls.Add(this.dateTimePickerCurrentTime);
            this.panel1.Controls.Add(this.lblCurrentTime);
            this.panel1.Location = new System.Drawing.Point(16, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 111);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.AllowUserToAddRows = false;
            this.dataGridViewImport.AllowUserToDeleteRows = false;
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImport.Location = new System.Drawing.Point(12, 260);
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.ReadOnly = true;
            this.dataGridViewImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImport.Size = new System.Drawing.Size(382, 150);
            this.dataGridViewImport.TabIndex = 1;
            // 
            // dataGridViewExport
            // 
            this.dataGridViewExport.AllowUserToAddRows = false;
            this.dataGridViewExport.AllowUserToDeleteRows = false;
            this.dataGridViewExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExport.Location = new System.Drawing.Point(406, 260);
            this.dataGridViewExport.Name = "dataGridViewExport";
            this.dataGridViewExport.ReadOnly = true;
            this.dataGridViewExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExport.Size = new System.Drawing.Size(382, 150);
            this.dataGridViewExport.TabIndex = 2;
            // 
            // dateTimePickerImportExportBill
            // 
            this.dateTimePickerImportExportBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerImportExportBill.Location = new System.Drawing.Point(101, 46);
            this.dateTimePickerImportExportBill.Name = "dateTimePickerImportExportBill";
            this.dateTimePickerImportExportBill.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerImportExportBill.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(15, 75);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 16);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "Current Time:";
            // 
            // dateTimePickerCurrentTime
            // 
            this.dateTimePickerCurrentTime.Location = new System.Drawing.Point(101, 13);
            this.dateTimePickerCurrentTime.Name = "dateTimePickerCurrentTime";
            this.dateTimePickerCurrentTime.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerCurrentTime.TabIndex = 6;
            // 
            // lblSelectTime
            // 
            this.lblSelectTime.AutoSize = true;
            this.lblSelectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTime.Location = new System.Drawing.Point(12, 48);
            this.lblSelectTime.Name = "lblSelectTime";
            this.lblSelectTime.Size = new System.Drawing.Size(78, 13);
            this.lblSelectTime.TabIndex = 7;
            this.lblSelectTime.Text = "Select Time:";
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImport.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblImport.Location = new System.Drawing.Point(133, 227);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(126, 31);
            this.lblImport.TabIndex = 3;
            this.lblImport.Text = "IMPORT";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.ForeColor = System.Drawing.Color.Red;
            this.lblExport.Location = new System.Drawing.Point(536, 229);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(132, 31);
            this.lblExport.TabIndex = 4;
            this.lblExport.Text = "EXPORT";
            // 
            // lblImportValue
            // 
            this.lblImportValue.AutoSize = true;
            this.lblImportValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportValue.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblImportValue.Location = new System.Drawing.Point(12, 413);
            this.lblImportValue.Name = "lblImportValue";
            this.lblImportValue.Size = new System.Drawing.Size(145, 20);
            this.lblImportValue.TabIndex = 5;
            this.lblImportValue.Text = "IMPORT VALUE:";
            // 
            // lblExportValue
            // 
            this.lblExportValue.AutoSize = true;
            this.lblExportValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportValue.ForeColor = System.Drawing.Color.Red;
            this.lblExportValue.Location = new System.Drawing.Point(402, 413);
            this.lblExportValue.Name = "lblExportValue";
            this.lblExportValue.Size = new System.Drawing.Size(149, 20);
            this.lblExportValue.TabIndex = 6;
            this.lblExportValue.Text = "EXPORT VALUE:";
            // 
            // txtbxImportValue
            // 
            this.txtbxImportValue.Location = new System.Drawing.Point(163, 415);
            this.txtbxImportValue.Name = "txtbxImportValue";
            this.txtbxImportValue.Size = new System.Drawing.Size(146, 20);
            this.txtbxImportValue.TabIndex = 7;
            // 
            // txtbxExportValue
            // 
            this.txtbxExportValue.Location = new System.Drawing.Point(557, 416);
            this.txtbxExportValue.Name = "txtbxExportValue";
            this.txtbxExportValue.Size = new System.Drawing.Size(146, 20);
            this.txtbxExportValue.TabIndex = 8;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLabel.Location = new System.Drawing.Point(183, 6);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(427, 29);
            this.lblLabel.TabIndex = 9;
            this.lblLabel.Text = "IMPORT AND EXPORT STATISTIC";
            // 
            // dataGridViewTopImport
            // 
            this.dataGridViewTopImport.AllowUserToAddRows = false;
            this.dataGridViewTopImport.AllowUserToDeleteRows = false;
            this.dataGridViewTopImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopImport.Location = new System.Drawing.Point(98, 12);
            this.dataGridViewTopImport.Name = "dataGridViewTopImport";
            this.dataGridViewTopImport.ReadOnly = true;
            this.dataGridViewTopImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTopImport.Size = new System.Drawing.Size(351, 79);
            this.dataGridViewTopImport.TabIndex = 10;
            // 
            // dataGridViewTopExport
            // 
            this.dataGridViewTopExport.AllowUserToAddRows = false;
            this.dataGridViewTopExport.AllowUserToDeleteRows = false;
            this.dataGridViewTopExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopExport.Location = new System.Drawing.Point(98, 107);
            this.dataGridViewTopExport.Name = "dataGridViewTopExport";
            this.dataGridViewTopExport.ReadOnly = true;
            this.dataGridViewTopExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTopExport.Size = new System.Drawing.Size(351, 79);
            this.dataGridViewTopExport.TabIndex = 11;
            // 
            // lblTopImport
            // 
            this.lblTopImport.AutoSize = true;
            this.lblTopImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopImport.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTopImport.Location = new System.Drawing.Point(6, 12);
            this.lblTopImport.Name = "lblTopImport";
            this.lblTopImport.Size = new System.Drawing.Size(86, 17);
            this.lblTopImport.TabIndex = 12;
            this.lblTopImport.Text = "Top Import";
            // 
            // lblTopExport
            // 
            this.lblTopExport.AutoSize = true;
            this.lblTopExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopExport.ForeColor = System.Drawing.Color.Red;
            this.lblTopExport.Location = new System.Drawing.Point(6, 107);
            this.lblTopExport.Name = "lblTopExport";
            this.lblTopExport.Size = new System.Drawing.Size(87, 17);
            this.lblTopExport.TabIndex = 13;
            this.lblTopExport.Text = "Top Export";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.dataGridViewTopExport);
            this.panel2.Controls.Add(this.lblTopImport);
            this.panel2.Controls.Add(this.lblTopExport);
            this.panel2.Controls.Add(this.dataGridViewTopImport);
            this.panel2.Location = new System.Drawing.Point(333, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 193);
            this.panel2.TabIndex = 14;
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.txtbxExportValue);
            this.Controls.Add(this.txtbxImportValue);
            this.Controls.Add(this.lblExportValue);
            this.Controls.Add(this.lblImportValue);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.dataGridViewExport);
            this.Controls.Add(this.dataGridViewImport);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopExport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewImport;
        private System.Windows.Forms.DataGridView dataGridViewExport;
        private System.Windows.Forms.DateTimePicker dateTimePickerImportExportBill;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblSelectTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblImportValue;
        private System.Windows.Forms.Label lblExportValue;
        private System.Windows.Forms.TextBox txtbxImportValue;
        private System.Windows.Forms.TextBox txtbxExportValue;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.DataGridView dataGridViewTopImport;
        private System.Windows.Forms.DataGridView dataGridViewTopExport;
        private System.Windows.Forms.Label lblTopImport;
        private System.Windows.Forms.Label lblTopExport;
        private System.Windows.Forms.Panel panel2;
    }
}