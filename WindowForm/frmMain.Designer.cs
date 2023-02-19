namespace Finals_Project
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimePickerCurrentTime = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtbxAccountEmail = new System.Windows.Forms.TextBox();
            this.lblAccountEmail = new System.Windows.Forms.Label();
            this.txtbxAccountPhone = new System.Windows.Forms.TextBox();
            this.lblAccountPhone = new System.Windows.Forms.Label();
            this.txtbxAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtbxAccountID = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createExportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewImportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createImportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.txtbxAccountEmail);
            this.panel1.Controls.Add(this.lblAccountEmail);
            this.panel1.Controls.Add(this.txtbxAccountPhone);
            this.panel1.Controls.Add(this.lblAccountPhone);
            this.panel1.Controls.Add(this.txtbxAccountName);
            this.panel1.Controls.Add(this.lblAccountName);
            this.panel1.Controls.Add(this.txtbxAccountID);
            this.panel1.Controls.Add(this.lblAccountID);
            this.panel1.Location = new System.Drawing.Point(89, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 163);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.dateTimePickerCurrentTime);
            this.panel2.Controls.Add(this.lblCurrentTime);
            this.panel2.Location = new System.Drawing.Point(327, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 141);
            this.panel2.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(25, 79);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(182, 46);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "20:02:56";
            // 
            // dateTimePickerCurrentTime
            // 
            this.dateTimePickerCurrentTime.Location = new System.Drawing.Point(18, 53);
            this.dateTimePickerCurrentTime.Name = "dateTimePickerCurrentTime";
            this.dateTimePickerCurrentTime.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerCurrentTime.TabIndex = 1;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(15, 23);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "Current Time:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(30, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(92, 22);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "DISPLAY";
            // 
            // txtbxAccountEmail
            // 
            this.txtbxAccountEmail.Location = new System.Drawing.Point(135, 124);
            this.txtbxAccountEmail.Name = "txtbxAccountEmail";
            this.txtbxAccountEmail.Size = new System.Drawing.Size(152, 20);
            this.txtbxAccountEmail.TabIndex = 7;
            // 
            // lblAccountEmail
            // 
            this.lblAccountEmail.AutoSize = true;
            this.lblAccountEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountEmail.Location = new System.Drawing.Point(31, 124);
            this.lblAccountEmail.Name = "lblAccountEmail";
            this.lblAccountEmail.Size = new System.Drawing.Size(92, 13);
            this.lblAccountEmail.TabIndex = 6;
            this.lblAccountEmail.Text = "Account Email:";
            // 
            // txtbxAccountPhone
            // 
            this.txtbxAccountPhone.Location = new System.Drawing.Point(135, 96);
            this.txtbxAccountPhone.Name = "txtbxAccountPhone";
            this.txtbxAccountPhone.Size = new System.Drawing.Size(152, 20);
            this.txtbxAccountPhone.TabIndex = 5;
            // 
            // lblAccountPhone
            // 
            this.lblAccountPhone.AutoSize = true;
            this.lblAccountPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountPhone.Location = new System.Drawing.Point(31, 96);
            this.lblAccountPhone.Name = "lblAccountPhone";
            this.lblAccountPhone.Size = new System.Drawing.Size(98, 13);
            this.lblAccountPhone.TabIndex = 4;
            this.lblAccountPhone.Text = "Account Phone:";
            // 
            // txtbxAccountName
            // 
            this.txtbxAccountName.Location = new System.Drawing.Point(135, 65);
            this.txtbxAccountName.Name = "txtbxAccountName";
            this.txtbxAccountName.Size = new System.Drawing.Size(152, 20);
            this.txtbxAccountName.TabIndex = 3;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(31, 65);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(94, 13);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Account Name:";
            // 
            // txtbxAccountID
            // 
            this.txtbxAccountID.Location = new System.Drawing.Point(135, 35);
            this.txtbxAccountID.Name = "txtbxAccountID";
            this.txtbxAccountID.Size = new System.Drawing.Size(152, 20);
            this.txtbxAccountID.TabIndex = 1;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(31, 35);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(75, 13);
            this.lblAccountID.TabIndex = 0;
            this.lblAccountID.Text = "Account ID:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblWelcome.Location = new System.Drawing.Point(12, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(759, 31);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "WELCOME TO DUYPHU SUPPLYMENT SUPPLIER INC.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStripMenuItem,
            this.exportImportToolStripMenuItem,
            this.viewStatisticToolStripMenuItem,
            this.viewProductsToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportImportToolStripMenuItem
            // 
            this.exportImportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportListToolStripMenuItem,
            this.importListToolStripMenuItem});
            this.exportImportToolStripMenuItem.Name = "exportImportToolStripMenuItem";
            this.exportImportToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.exportImportToolStripMenuItem.Text = "Export && Import";
            // 
            // exportListToolStripMenuItem
            // 
            this.exportListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewExportListToolStripMenuItem,
            this.createExportListToolStripMenuItem});
            this.exportListToolStripMenuItem.Name = "exportListToolStripMenuItem";
            this.exportListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportListToolStripMenuItem.Text = "Export List";
            // 
            // viewExportListToolStripMenuItem
            // 
            this.viewExportListToolStripMenuItem.Name = "viewExportListToolStripMenuItem";
            this.viewExportListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewExportListToolStripMenuItem.Text = "View Export List";
            this.viewExportListToolStripMenuItem.Click += new System.EventHandler(this.viewExportListToolStripMenuItem_Click);
            // 
            // createExportListToolStripMenuItem
            // 
            this.createExportListToolStripMenuItem.Name = "createExportListToolStripMenuItem";
            this.createExportListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createExportListToolStripMenuItem.Text = "Create Export List";
            this.createExportListToolStripMenuItem.Click += new System.EventHandler(this.createExportListToolStripMenuItem_Click);
            // 
            // importListToolStripMenuItem
            // 
            this.importListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewImportListToolStripMenuItem,
            this.createImportListToolStripMenuItem});
            this.importListToolStripMenuItem.Name = "importListToolStripMenuItem";
            this.importListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importListToolStripMenuItem.Text = "Import List";
            // 
            // viewImportListToolStripMenuItem
            // 
            this.viewImportListToolStripMenuItem.Name = "viewImportListToolStripMenuItem";
            this.viewImportListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewImportListToolStripMenuItem.Text = "View Import List";
            this.viewImportListToolStripMenuItem.Click += new System.EventHandler(this.viewImportListToolStripMenuItem_Click);
            // 
            // createImportListToolStripMenuItem
            // 
            this.createImportListToolStripMenuItem.Name = "createImportListToolStripMenuItem";
            this.createImportListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createImportListToolStripMenuItem.Text = "Create Import List";
            this.createImportListToolStripMenuItem.Click += new System.EventHandler(this.createImportListToolStripMenuItem_Click);
            // 
            // viewStatisticToolStripMenuItem
            // 
            this.viewStatisticToolStripMenuItem.Name = "viewStatisticToolStripMenuItem";
            this.viewStatisticToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.viewStatisticToolStripMenuItem.Text = "View Statistic";
            this.viewStatisticToolStripMenuItem.Click += new System.EventHandler(this.viewStatisticToolStripMenuItem_Click);
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.userAccountToolStripMenuItem.Text = "User Account";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 299);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbxAccountEmail;
        private System.Windows.Forms.Label lblAccountEmail;
        private System.Windows.Forms.TextBox txtbxAccountPhone;
        private System.Windows.Forms.Label lblAccountPhone;
        private System.Windows.Forms.TextBox txtbxAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtbxAccountID;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createExportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewImportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createImportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
    }
}

