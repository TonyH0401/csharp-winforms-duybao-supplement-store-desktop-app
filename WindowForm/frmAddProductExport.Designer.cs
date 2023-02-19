namespace Finals_Project
{
    partial class frmAddProductExport
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
            this.cbbxProductID = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductOrigin = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.txtbxProductID = new System.Windows.Forms.TextBox();
            this.txtbxProductPrice = new System.Windows.Forms.TextBox();
            this.txtbxOrigin = new System.Windows.Forms.TextBox();
            this.txtbxProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.dataGridViewAddedProduct = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblADDPROD = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSessionUser = new System.Windows.Forms.Label();
            this.txtbxSessionUser = new System.Windows.Forms.TextBox();
            this.lblProductChoose = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.cbbxStoreName = new System.Windows.Forms.ComboBox();
            this.lblStoreLocation = new System.Windows.Forms.Label();
            this.lblProductToImport = new System.Windows.Forms.Label();
            this.txtbxStoreID = new System.Windows.Forms.TextBox();
            this.txtbxStoreLocation = new System.Windows.Forms.TextBox();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.txtbxQuantityToImport = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbxTotalCost = new System.Windows.Forms.TextBox();
            this.cbbxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCreateExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbxProductID
            // 
            this.cbbxProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxProductID.FormattingEnabled = true;
            this.cbbxProductID.Location = new System.Drawing.Point(114, 23);
            this.cbbxProductID.Name = "cbbxProductID";
            this.cbbxProductID.Size = new System.Drawing.Size(221, 21);
            this.cbbxProductID.TabIndex = 1;
            this.cbbxProductID.SelectedIndexChanged += new System.EventHandler(this.cbbxProductID_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(5, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(5, 88);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductOrigin
            // 
            this.lblProductOrigin.AutoSize = true;
            this.lblProductOrigin.Location = new System.Drawing.Point(5, 153);
            this.lblProductOrigin.Name = "lblProductOrigin";
            this.lblProductOrigin.Size = new System.Drawing.Size(49, 13);
            this.lblProductOrigin.TabIndex = 5;
            this.lblProductOrigin.Text = "Originate";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(5, 120);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(86, 13);
            this.lblProductQuantity.TabIndex = 4;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // txtbxProductID
            // 
            this.txtbxProductID.Location = new System.Drawing.Point(114, 58);
            this.txtbxProductID.Name = "txtbxProductID";
            this.txtbxProductID.Size = new System.Drawing.Size(79, 20);
            this.txtbxProductID.TabIndex = 6;
            // 
            // txtbxProductPrice
            // 
            this.txtbxProductPrice.Location = new System.Drawing.Point(114, 88);
            this.txtbxProductPrice.Name = "txtbxProductPrice";
            this.txtbxProductPrice.Size = new System.Drawing.Size(79, 20);
            this.txtbxProductPrice.TabIndex = 7;
            // 
            // txtbxOrigin
            // 
            this.txtbxOrigin.Location = new System.Drawing.Point(114, 153);
            this.txtbxOrigin.Name = "txtbxOrigin";
            this.txtbxOrigin.Size = new System.Drawing.Size(151, 20);
            this.txtbxOrigin.TabIndex = 9;
            // 
            // txtbxProductQuantity
            // 
            this.txtbxProductQuantity.Location = new System.Drawing.Point(114, 120);
            this.txtbxProductQuantity.Name = "txtbxProductQuantity";
            this.txtbxProductQuantity.Size = new System.Drawing.Size(79, 20);
            this.txtbxProductQuantity.TabIndex = 8;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(5, 58);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 10;
            this.lblProductID.Text = "Product ID";
            // 
            // dataGridViewAddedProduct
            // 
            this.dataGridViewAddedProduct.AllowUserToAddRows = false;
            this.dataGridViewAddedProduct.AllowUserToDeleteRows = false;
            this.dataGridViewAddedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddedProduct.Location = new System.Drawing.Point(365, 8);
            this.dataGridViewAddedProduct.Name = "dataGridViewAddedProduct";
            this.dataGridViewAddedProduct.ReadOnly = true;
            this.dataGridViewAddedProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddedProduct.Size = new System.Drawing.Size(649, 376);
            this.dataGridViewAddedProduct.TabIndex = 11;
            this.dataGridViewAddedProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddedProduct_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 37);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add/Add more";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.cbbxProductID);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Controls.Add(this.lblProductQuantity);
            this.panel1.Controls.Add(this.lblProductOrigin);
            this.panel1.Controls.Add(this.txtbxProductID);
            this.panel1.Controls.Add(this.txtbxProductPrice);
            this.panel1.Controls.Add(this.lblProductID);
            this.panel1.Controls.Add(this.txtbxProductQuantity);
            this.panel1.Controls.Add(this.txtbxOrigin);
            this.panel1.Location = new System.Drawing.Point(9, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 186);
            this.panel1.TabIndex = 13;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(21, -3);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(133, 15);
            this.lblDisplay.TabIndex = 18;
            this.lblDisplay.Text = "Product Information";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(117, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(235, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 37);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblADDPROD
            // 
            this.lblADDPROD.AutoSize = true;
            this.lblADDPROD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADDPROD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblADDPROD.Location = new System.Drawing.Point(36, 16);
            this.lblADDPROD.Name = "lblADDPROD";
            this.lblADDPROD.Size = new System.Drawing.Size(299, 25);
            this.lblADDPROD.TabIndex = 17;
            this.lblADDPROD.Text = "ADD PRODUCT TO EXPORT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.lblSessionUser);
            this.panel2.Controls.Add(this.txtbxSessionUser);
            this.panel2.Controls.Add(this.lblProductChoose);
            this.panel2.Controls.Add(this.lblStoreName);
            this.panel2.Controls.Add(this.cbbxStoreName);
            this.panel2.Controls.Add(this.lblStoreLocation);
            this.panel2.Controls.Add(this.txtbxStoreID);
            this.panel2.Controls.Add(this.txtbxStoreLocation);
            this.panel2.Controls.Add(this.lblStoreID);
            this.panel2.Location = new System.Drawing.Point(9, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 143);
            this.panel2.TabIndex = 19;
            // 
            // lblSessionUser
            // 
            this.lblSessionUser.AutoSize = true;
            this.lblSessionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionUser.Location = new System.Drawing.Point(5, 18);
            this.lblSessionUser.Name = "lblSessionUser";
            this.lblSessionUser.Size = new System.Drawing.Size(99, 13);
            this.lblSessionUser.TabIndex = 19;
            this.lblSessionUser.Text = "Current Account";
            // 
            // txtbxSessionUser
            // 
            this.txtbxSessionUser.Location = new System.Drawing.Point(114, 18);
            this.txtbxSessionUser.Name = "txtbxSessionUser";
            this.txtbxSessionUser.Size = new System.Drawing.Size(96, 20);
            this.txtbxSessionUser.TabIndex = 20;
            // 
            // lblProductChoose
            // 
            this.lblProductChoose.AutoSize = true;
            this.lblProductChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductChoose.Location = new System.Drawing.Point(21, -3);
            this.lblProductChoose.Name = "lblProductChoose";
            this.lblProductChoose.Size = new System.Drawing.Size(144, 15);
            this.lblProductChoose.TabIndex = 18;
            this.lblProductChoose.Text = "Select Store Location";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Location = new System.Drawing.Point(5, 48);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(63, 13);
            this.lblStoreName.TabIndex = 2;
            this.lblStoreName.Text = "Store Name";
            // 
            // cbbxStoreName
            // 
            this.cbbxStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxStoreName.FormattingEnabled = true;
            this.cbbxStoreName.Location = new System.Drawing.Point(114, 48);
            this.cbbxStoreName.Name = "cbbxStoreName";
            this.cbbxStoreName.Size = new System.Drawing.Size(221, 21);
            this.cbbxStoreName.TabIndex = 1;
            this.cbbxStoreName.SelectedIndexChanged += new System.EventHandler(this.cbbxStoreName_SelectedIndexChanged);
            // 
            // lblStoreLocation
            // 
            this.lblStoreLocation.AutoSize = true;
            this.lblStoreLocation.Location = new System.Drawing.Point(5, 113);
            this.lblStoreLocation.Name = "lblStoreLocation";
            this.lblStoreLocation.Size = new System.Drawing.Size(76, 13);
            this.lblStoreLocation.TabIndex = 3;
            this.lblStoreLocation.Text = "Store Location";
            // 
            // lblProductToImport
            // 
            this.lblProductToImport.AutoSize = true;
            this.lblProductToImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductToImport.Location = new System.Drawing.Point(5, 12);
            this.lblProductToImport.Name = "lblProductToImport";
            this.lblProductToImport.Size = new System.Drawing.Size(157, 13);
            this.lblProductToImport.TabIndex = 4;
            this.lblProductToImport.Text = "Product Quantity to Export";
            // 
            // txtbxStoreID
            // 
            this.txtbxStoreID.Location = new System.Drawing.Point(114, 83);
            this.txtbxStoreID.Name = "txtbxStoreID";
            this.txtbxStoreID.Size = new System.Drawing.Size(79, 20);
            this.txtbxStoreID.TabIndex = 6;
            // 
            // txtbxStoreLocation
            // 
            this.txtbxStoreLocation.Location = new System.Drawing.Point(114, 113);
            this.txtbxStoreLocation.Name = "txtbxStoreLocation";
            this.txtbxStoreLocation.Size = new System.Drawing.Size(221, 20);
            this.txtbxStoreLocation.TabIndex = 7;
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(5, 83);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(46, 13);
            this.lblStoreID.TabIndex = 10;
            this.lblStoreID.Text = "Store ID";
            // 
            // txtbxQuantityToImport
            // 
            this.txtbxQuantityToImport.Location = new System.Drawing.Point(168, 9);
            this.txtbxQuantityToImport.Name = "txtbxQuantityToImport";
            this.txtbxQuantityToImport.Size = new System.Drawing.Size(79, 20);
            this.txtbxQuantityToImport.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblProductToImport);
            this.panel3.Controls.Add(this.txtbxQuantityToImport);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Location = new System.Drawing.Point(9, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 91);
            this.panel3.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Cost";
            // 
            // txtbxTotalCost
            // 
            this.txtbxTotalCost.Location = new System.Drawing.Point(110, 9);
            this.txtbxTotalCost.Name = "txtbxTotalCost";
            this.txtbxTotalCost.Size = new System.Drawing.Size(107, 20);
            this.txtbxTotalCost.TabIndex = 22;
            // 
            // cbbxPaymentMethod
            // 
            this.cbbxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxPaymentMethod.FormattingEnabled = true;
            this.cbbxPaymentMethod.Location = new System.Drawing.Point(110, 53);
            this.cbbxPaymentMethod.Name = "cbbxPaymentMethod";
            this.cbbxPaymentMethod.Size = new System.Drawing.Size(107, 21);
            this.cbbxPaymentMethod.TabIndex = 21;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(3, 56);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(101, 13);
            this.lblPaymentMethod.TabIndex = 23;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.lblPaymentMethod);
            this.panel4.Controls.Add(this.txtbxTotalCost);
            this.panel4.Controls.Add(this.cbbxPaymentMethod);
            this.panel4.Location = new System.Drawing.Point(488, 406);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 80);
            this.panel4.TabIndex = 24;
            // 
            // btnCreateExport
            // 
            this.btnCreateExport.BackColor = System.Drawing.Color.Green;
            this.btnCreateExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateExport.Location = new System.Drawing.Point(751, 409);
            this.btnCreateExport.Name = "btnCreateExport";
            this.btnCreateExport.Size = new System.Drawing.Size(239, 41);
            this.btnCreateExport.TabIndex = 25;
            this.btnCreateExport.Text = "Create Export Bill";
            this.btnCreateExport.UseVisualStyleBackColor = false;
            this.btnCreateExport.Click += new System.EventHandler(this.btnCreateExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(842, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddProductExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1024, 514);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateExport);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblADDPROD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewAddedProduct);
            this.Name = "frmAddProductExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProductExport";
            this.Load += new System.EventHandler(this.frmAddProductImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbxProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductOrigin;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.TextBox txtbxProductID;
        private System.Windows.Forms.TextBox txtbxProductPrice;
        private System.Windows.Forms.TextBox txtbxOrigin;
        private System.Windows.Forms.TextBox txtbxProductQuantity;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.DataGridView dataGridViewAddedProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblADDPROD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProductChoose;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.ComboBox cbbxStoreName;
        private System.Windows.Forms.Label lblStoreLocation;
        private System.Windows.Forms.Label lblProductToImport;
        private System.Windows.Forms.TextBox txtbxStoreID;
        private System.Windows.Forms.TextBox txtbxStoreLocation;
        private System.Windows.Forms.Label lblStoreID;
        private System.Windows.Forms.TextBox txtbxQuantityToImport;
        private System.Windows.Forms.Label lblSessionUser;
        private System.Windows.Forms.TextBox txtbxSessionUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtbxTotalCost;
        private System.Windows.Forms.ComboBox cbbxPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCreateExport;
        private System.Windows.Forms.Button btnExit;
    }
}