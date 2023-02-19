namespace Finals_Project
{
    partial class frmCreateImport
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
            this.rdbtnImportOldProduct = new System.Windows.Forms.RadioButton();
            this.rdbtnImportNewProduct = new System.Windows.Forms.RadioButton();
            this.btnChooseImportType = new System.Windows.Forms.Button();
            this.lblTypeOfProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbxProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName_ID = new System.Windows.Forms.Label();
            this.txtbxProductQuantityOld = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtbxProductID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtbxProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtbxProductQuantityNew = new System.Windows.Forms.TextBox();
            this.lblProductOrigin = new System.Windows.Forms.Label();
            this.txtbxProductName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbxProductOriginOld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxProductPriceOld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxProductIDOld = new System.Windows.Forms.TextBox();
            this.lblProductQuantityNew = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbxProductOrigin = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewImportProduct = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtsessionAccountPhone = new System.Windows.Forms.TextBox();
            this.txtsessionAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblAccountPhone = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportProduct)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnImportOldProduct
            // 
            this.rdbtnImportOldProduct.AutoSize = true;
            this.rdbtnImportOldProduct.Location = new System.Drawing.Point(20, 18);
            this.rdbtnImportOldProduct.Name = "rdbtnImportOldProduct";
            this.rdbtnImportOldProduct.Size = new System.Drawing.Size(113, 17);
            this.rdbtnImportOldProduct.TabIndex = 0;
            this.rdbtnImportOldProduct.TabStop = true;
            this.rdbtnImportOldProduct.Text = "Import Old Product";
            this.rdbtnImportOldProduct.UseVisualStyleBackColor = true;
            // 
            // rdbtnImportNewProduct
            // 
            this.rdbtnImportNewProduct.AutoSize = true;
            this.rdbtnImportNewProduct.Location = new System.Drawing.Point(20, 41);
            this.rdbtnImportNewProduct.Name = "rdbtnImportNewProduct";
            this.rdbtnImportNewProduct.Size = new System.Drawing.Size(119, 17);
            this.rdbtnImportNewProduct.TabIndex = 1;
            this.rdbtnImportNewProduct.TabStop = true;
            this.rdbtnImportNewProduct.Text = "Import New Product";
            this.rdbtnImportNewProduct.UseVisualStyleBackColor = true;
            // 
            // btnChooseImportType
            // 
            this.btnChooseImportType.Location = new System.Drawing.Point(40, 68);
            this.btnChooseImportType.Name = "btnChooseImportType";
            this.btnChooseImportType.Size = new System.Drawing.Size(75, 23);
            this.btnChooseImportType.TabIndex = 2;
            this.btnChooseImportType.Text = "Select";
            this.btnChooseImportType.UseVisualStyleBackColor = true;
            this.btnChooseImportType.Click += new System.EventHandler(this.btnChooseImportType_Click);
            // 
            // lblTypeOfProduct
            // 
            this.lblTypeOfProduct.AutoSize = true;
            this.lblTypeOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfProduct.Location = new System.Drawing.Point(17, 0);
            this.lblTypeOfProduct.Name = "lblTypeOfProduct";
            this.lblTypeOfProduct.Size = new System.Drawing.Size(112, 15);
            this.lblTypeOfProduct.TabIndex = 3;
            this.lblTypeOfProduct.Text = "Type Of Product:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTypeOfProduct);
            this.panel1.Controls.Add(this.btnChooseImportType);
            this.panel1.Controls.Add(this.rdbtnImportOldProduct);
            this.panel1.Controls.Add(this.rdbtnImportNewProduct);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 100);
            this.panel1.TabIndex = 5;
            // 
            // cbbxProductName
            // 
            this.cbbxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxProductName.FormattingEnabled = true;
            this.cbbxProductName.Location = new System.Drawing.Point(117, 15);
            this.cbbxProductName.Name = "cbbxProductName";
            this.cbbxProductName.Size = new System.Drawing.Size(116, 21);
            this.cbbxProductName.TabIndex = 6;
            this.cbbxProductName.SelectedIndexChanged += new System.EventHandler(this.cbbxProductName_SelectedIndexChanged);
            // 
            // lblProductName_ID
            // 
            this.lblProductName_ID.AutoSize = true;
            this.lblProductName_ID.Location = new System.Drawing.Point(7, 14);
            this.lblProductName_ID.Name = "lblProductName_ID";
            this.lblProductName_ID.Size = new System.Drawing.Size(75, 13);
            this.lblProductName_ID.TabIndex = 7;
            this.lblProductName_ID.Text = "Product Name";
            // 
            // txtbxProductQuantityOld
            // 
            this.txtbxProductQuantityOld.Location = new System.Drawing.Point(117, 154);
            this.txtbxProductQuantityOld.Name = "txtbxProductQuantityOld";
            this.txtbxProductQuantityOld.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductQuantityOld.TabIndex = 8;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(6, 154);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(86, 13);
            this.lblProductQuantity.TabIndex = 9;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(10, 43);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 11;
            this.lblProductID.Text = "Product ID";
            // 
            // txtbxProductID
            // 
            this.txtbxProductID.Location = new System.Drawing.Point(121, 44);
            this.txtbxProductID.Name = "txtbxProductID";
            this.txtbxProductID.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductID.TabIndex = 10;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(10, 14);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 13;
            this.lblProductName.Text = "Product Name";
            // 
            // txtbxProductPrice
            // 
            this.txtbxProductPrice.Location = new System.Drawing.Point(121, 117);
            this.txtbxProductPrice.Name = "txtbxProductPrice";
            this.txtbxProductPrice.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductPrice.TabIndex = 12;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(10, 117);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 17;
            this.lblProductPrice.Text = "Product Price";
            // 
            // txtbxProductQuantityNew
            // 
            this.txtbxProductQuantityNew.Location = new System.Drawing.Point(121, 78);
            this.txtbxProductQuantityNew.Name = "txtbxProductQuantityNew";
            this.txtbxProductQuantityNew.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductQuantityNew.TabIndex = 16;
            // 
            // lblProductOrigin
            // 
            this.lblProductOrigin.AutoSize = true;
            this.lblProductOrigin.Location = new System.Drawing.Point(10, 150);
            this.lblProductOrigin.Name = "lblProductOrigin";
            this.lblProductOrigin.Size = new System.Drawing.Size(49, 13);
            this.lblProductOrigin.TabIndex = 15;
            this.lblProductOrigin.Text = "Originate";
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.Location = new System.Drawing.Point(121, 14);
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductName.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtbxProductOriginOld);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtbxProductPriceOld);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblProductName_ID);
            this.panel2.Controls.Add(this.txtbxProductIDOld);
            this.panel2.Controls.Add(this.cbbxProductName);
            this.panel2.Controls.Add(this.lblProductQuantity);
            this.panel2.Controls.Add(this.txtbxProductQuantityOld);
            this.panel2.Location = new System.Drawing.Point(216, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 188);
            this.panel2.TabIndex = 18;
            // 
            // txtbxProductOriginOld
            // 
            this.txtbxProductOriginOld.Location = new System.Drawing.Point(117, 117);
            this.txtbxProductOriginOld.Name = "txtbxProductOriginOld";
            this.txtbxProductOriginOld.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductOriginOld.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Originate";
            // 
            // txtbxProductPriceOld
            // 
            this.txtbxProductPriceOld.Location = new System.Drawing.Point(117, 82);
            this.txtbxProductPriceOld.Name = "txtbxProductPriceOld";
            this.txtbxProductPriceOld.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductPriceOld.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product ID";
            // 
            // txtbxProductIDOld
            // 
            this.txtbxProductIDOld.Location = new System.Drawing.Point(117, 47);
            this.txtbxProductIDOld.Name = "txtbxProductIDOld";
            this.txtbxProductIDOld.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductIDOld.TabIndex = 21;
            // 
            // lblProductQuantityNew
            // 
            this.lblProductQuantityNew.AutoSize = true;
            this.lblProductQuantityNew.Location = new System.Drawing.Point(10, 78);
            this.lblProductQuantityNew.Name = "lblProductQuantityNew";
            this.lblProductQuantityNew.Size = new System.Drawing.Size(83, 13);
            this.lblProductQuantityNew.TabIndex = 19;
            this.lblProductQuantityNew.Text = "Product Quanity";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtbxProductOrigin);
            this.panel3.Controls.Add(this.lblProductID);
            this.panel3.Controls.Add(this.lblProductQuantityNew);
            this.panel3.Controls.Add(this.txtbxProductPrice);
            this.panel3.Controls.Add(this.txtbxProductQuantityNew);
            this.panel3.Controls.Add(this.txtbxProductID);
            this.panel3.Controls.Add(this.lblProductPrice);
            this.panel3.Controls.Add(this.txtbxProductName);
            this.panel3.Controls.Add(this.lblProductName);
            this.panel3.Controls.Add(this.lblProductOrigin);
            this.panel3.Location = new System.Drawing.Point(523, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 188);
            this.panel3.TabIndex = 19;
            // 
            // txtbxProductOrigin
            // 
            this.txtbxProductOrigin.Location = new System.Drawing.Point(121, 150);
            this.txtbxProductOrigin.Name = "txtbxProductOrigin";
            this.txtbxProductOrigin.Size = new System.Drawing.Size(116, 20);
            this.txtbxProductOrigin.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewImportProduct
            // 
            this.dataGridViewImportProduct.AllowUserToAddRows = false;
            this.dataGridViewImportProduct.AllowUserToDeleteRows = false;
            this.dataGridViewImportProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportProduct.Location = new System.Drawing.Point(202, 206);
            this.dataGridViewImportProduct.Name = "dataGridViewImportProduct";
            this.dataGridViewImportProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImportProduct.Size = new System.Drawing.Size(594, 183);
            this.dataGridViewImportProduct.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(111, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(111, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.txtsessionAccountPhone);
            this.panel4.Controls.Add(this.txtsessionAccount);
            this.panel4.Controls.Add(this.lblAccount);
            this.panel4.Controls.Add(this.lblAccountPhone);
            this.panel4.Location = new System.Drawing.Point(9, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 82);
            this.panel4.TabIndex = 25;
            // 
            // txtsessionAccountPhone
            // 
            this.txtsessionAccountPhone.Location = new System.Drawing.Point(68, 51);
            this.txtsessionAccountPhone.Name = "txtsessionAccountPhone";
            this.txtsessionAccountPhone.Size = new System.Drawing.Size(100, 20);
            this.txtsessionAccountPhone.TabIndex = 29;
            // 
            // txtsessionAccount
            // 
            this.txtsessionAccount.Location = new System.Drawing.Point(68, 14);
            this.txtsessionAccount.Name = "txtsessionAccount";
            this.txtsessionAccount.Size = new System.Drawing.Size(100, 20);
            this.txtsessionAccount.TabIndex = 28;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(15, 14);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(54, 13);
            this.lblAccount.TabIndex = 26;
            this.lblAccount.Text = "Account";
            // 
            // lblAccountPhone
            // 
            this.lblAccountPhone.AutoSize = true;
            this.lblAccountPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountPhone.Location = new System.Drawing.Point(15, 50);
            this.lblAccountPhone.Name = "lblAccountPhone";
            this.lblAccountPhone.Size = new System.Drawing.Size(43, 13);
            this.lblAccountPhone.TabIndex = 27;
            this.lblAccountPhone.Text = "Phone";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(27, 336);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(146, 53);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "&Create Import";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmCreateImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 401);
            this.ControlBox = false;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewImportProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCreateImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateImport";
            this.Load += new System.EventHandler(this.frmCreateImport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnImportOldProduct;
        private System.Windows.Forms.RadioButton rdbtnImportNewProduct;
        private System.Windows.Forms.Button btnChooseImportType;
        private System.Windows.Forms.Label lblTypeOfProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbxProductName;
        private System.Windows.Forms.Label lblProductName_ID;
        private System.Windows.Forms.TextBox txtbxProductQuantityOld;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtbxProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtbxProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtbxProductQuantityNew;
        private System.Windows.Forms.Label lblProductOrigin;
        private System.Windows.Forms.TextBox txtbxProductName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProductQuantityNew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbxProductOrigin;
        private System.Windows.Forms.TextBox txtbxProductOriginOld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxProductPriceOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxProductIDOld;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewImportProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtsessionAccountPhone;
        private System.Windows.Forms.TextBox txtsessionAccount;
        private System.Windows.Forms.Label lblAccountPhone;
        private System.Windows.Forms.Button btnCreate;
    }
}