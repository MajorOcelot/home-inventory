namespace HomeInventory
{
    partial class HomeInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeInventory));
            this.dgvHomeInventory = new System.Windows.Forms.DataGridView();
            this.lblQItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.gbxItemInfo = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.lblQItemQuantity = new System.Windows.Forms.Label();
            this.lblQItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.gbxDatabase = new System.Windows.Forms.GroupBox();
            this.btnSaveShoppingList = new System.Windows.Forms.Button();
            this.gbxSorting = new System.Windows.Forms.GroupBox();
            this.btnShowEmpties = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblQExpire = new System.Windows.Forms.Label();
            this.txtItemLocation = new System.Windows.Forms.TextBox();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lblQLocation = new System.Windows.Forms.Label();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoPDF = new System.Windows.Forms.RadioButton();
            this.rdoJSON = new System.Windows.Forms.RadioButton();
            this.rdoCSV = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeInventory)).BeginInit();
            this.gbxItemInfo.SuspendLayout();
            this.gbxDatabase.SuspendLayout();
            this.gbxSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHomeInventory
            // 
            this.dgvHomeInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeInventory.Location = new System.Drawing.Point(13, 12);
            this.dgvHomeInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHomeInventory.Name = "dgvHomeInventory";
            this.dgvHomeInventory.Size = new System.Drawing.Size(600, 301);
            this.dgvHomeInventory.TabIndex = 0;
            this.dgvHomeInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblQItemID
            // 
            this.lblQItemID.AutoSize = true;
            this.lblQItemID.Location = new System.Drawing.Point(7, 23);
            this.lblQItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQItemID.Name = "lblQItemID";
            this.lblQItemID.Size = new System.Drawing.Size(22, 15);
            this.lblQItemID.TabIndex = 1;
            this.lblQItemID.Text = "ID:";
            // 
            // txtItemID
            // 
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(77, 20);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(56, 21);
            this.txtItemID.TabIndex = 2;
            // 
            // gbxItemInfo
            // 
            this.gbxItemInfo.Controls.Add(this.lblQLocation);
            this.gbxItemInfo.Controls.Add(this.dtpExpirationDate);
            this.gbxItemInfo.Controls.Add(this.txtItemLocation);
            this.gbxItemInfo.Controls.Add(this.lblQExpire);
            this.gbxItemInfo.Controls.Add(this.btnReset);
            this.gbxItemInfo.Controls.Add(this.btnDelete);
            this.gbxItemInfo.Controls.Add(this.btnUpdate);
            this.gbxItemInfo.Controls.Add(this.btnAdd);
            this.gbxItemInfo.Controls.Add(this.txtItemQuantity);
            this.gbxItemInfo.Controls.Add(this.lblQItemQuantity);
            this.gbxItemInfo.Controls.Add(this.lblQItemName);
            this.gbxItemInfo.Controls.Add(this.txtItemName);
            this.gbxItemInfo.Controls.Add(this.txtItemID);
            this.gbxItemInfo.Controls.Add(this.lblQItemID);
            this.gbxItemInfo.Location = new System.Drawing.Point(13, 319);
            this.gbxItemInfo.Name = "gbxItemInfo";
            this.gbxItemInfo.Size = new System.Drawing.Size(218, 273);
            this.gbxItemInfo.TabIndex = 3;
            this.gbxItemInfo.TabStop = false;
            this.gbxItemInfo.Text = "Item Information";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(121, 215);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(77, 76);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(56, 21);
            this.txtItemQuantity.TabIndex = 6;
            // 
            // lblQItemQuantity
            // 
            this.lblQItemQuantity.AutoSize = true;
            this.lblQItemQuantity.Location = new System.Drawing.Point(6, 79);
            this.lblQItemQuantity.Name = "lblQItemQuantity";
            this.lblQItemQuantity.Size = new System.Drawing.Size(54, 15);
            this.lblQItemQuantity.TabIndex = 5;
            this.lblQItemQuantity.Text = "Quantity:";
            // 
            // lblQItemName
            // 
            this.lblQItemName.AutoSize = true;
            this.lblQItemName.Location = new System.Drawing.Point(6, 51);
            this.lblQItemName.Name = "lblQItemName";
            this.lblQItemName.Size = new System.Drawing.Size(44, 15);
            this.lblQItemName.TabIndex = 4;
            this.lblQItemName.Text = "Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(77, 48);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(135, 21);
            this.txtItemName.TabIndex = 3;
            // 
            // gbxDatabase
            // 
            this.gbxDatabase.Controls.Add(this.rdoCSV);
            this.gbxDatabase.Controls.Add(this.rdoJSON);
            this.gbxDatabase.Controls.Add(this.rdoPDF);
            this.gbxDatabase.Controls.Add(this.rdoText);
            this.gbxDatabase.Controls.Add(this.btnSaveShoppingList);
            this.gbxDatabase.Location = new System.Drawing.Point(413, 486);
            this.gbxDatabase.Name = "gbxDatabase";
            this.gbxDatabase.Size = new System.Drawing.Size(200, 106);
            this.gbxDatabase.TabIndex = 4;
            this.gbxDatabase.TabStop = false;
            this.gbxDatabase.Text = "Export";
            // 
            // btnSaveShoppingList
            // 
            this.btnSaveShoppingList.Location = new System.Drawing.Point(6, 72);
            this.btnSaveShoppingList.Name = "btnSaveShoppingList";
            this.btnSaveShoppingList.Size = new System.Drawing.Size(188, 23);
            this.btnSaveShoppingList.TabIndex = 0;
            this.btnSaveShoppingList.Text = "Save Shopping List";
            this.btnSaveShoppingList.UseVisualStyleBackColor = true;
            this.btnSaveShoppingList.Click += new System.EventHandler(this.btnSaveShoppingList_Click);
            // 
            // gbxSorting
            // 
            this.gbxSorting.Controls.Add(this.btnShowEmpties);
            this.gbxSorting.Location = new System.Drawing.Point(413, 319);
            this.gbxSorting.Name = "gbxSorting";
            this.gbxSorting.Size = new System.Drawing.Size(200, 161);
            this.gbxSorting.TabIndex = 6;
            this.gbxSorting.TabStop = false;
            this.gbxSorting.Text = "Sorting";
            // 
            // btnShowEmpties
            // 
            this.btnShowEmpties.Location = new System.Drawing.Point(6, 20);
            this.btnShowEmpties.Name = "btnShowEmpties";
            this.btnShowEmpties.Size = new System.Drawing.Size(102, 23);
            this.btnShowEmpties.TabIndex = 0;
            this.btnShowEmpties.Text = "Show Empties";
            this.btnShowEmpties.UseVisualStyleBackColor = true;
            this.btnShowEmpties.Click += new System.EventHandler(this.btnShowEmpties_Click);
            // 
            // lblQExpire
            // 
            this.lblQExpire.AutoSize = true;
            this.lblQExpire.Location = new System.Drawing.Point(6, 106);
            this.lblQExpire.Name = "lblQExpire";
            this.lblQExpire.Size = new System.Drawing.Size(65, 15);
            this.lblQExpire.TabIndex = 13;
            this.lblQExpire.Text = "Expiration:";
            // 
            // txtItemLocation
            // 
            this.txtItemLocation.Location = new System.Drawing.Point(77, 130);
            this.txtItemLocation.Name = "txtItemLocation";
            this.txtItemLocation.Size = new System.Drawing.Size(135, 21);
            this.txtItemLocation.TabIndex = 14;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(77, 103);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(135, 21);
            this.dtpExpirationDate.TabIndex = 15;
            // 
            // lblQLocation
            // 
            this.lblQLocation.AutoSize = true;
            this.lblQLocation.Location = new System.Drawing.Point(6, 133);
            this.lblQLocation.Name = "lblQLocation";
            this.lblQLocation.Size = new System.Drawing.Size(57, 15);
            this.lblQLocation.TabIndex = 16;
            this.lblQLocation.Text = "Location:";
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Location = new System.Drawing.Point(6, 22);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(48, 19);
            this.rdoText.TabIndex = 4;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoPDF
            // 
            this.rdoPDF.AutoSize = true;
            this.rdoPDF.Location = new System.Drawing.Point(6, 47);
            this.rdoPDF.Name = "rdoPDF";
            this.rdoPDF.Size = new System.Drawing.Size(49, 19);
            this.rdoPDF.TabIndex = 5;
            this.rdoPDF.TabStop = true;
            this.rdoPDF.Text = "PDF";
            this.rdoPDF.UseVisualStyleBackColor = true;
            // 
            // rdoJSON
            // 
            this.rdoJSON.AutoSize = true;
            this.rdoJSON.Location = new System.Drawing.Point(114, 22);
            this.rdoJSON.Name = "rdoJSON";
            this.rdoJSON.Size = new System.Drawing.Size(57, 19);
            this.rdoJSON.TabIndex = 6;
            this.rdoJSON.TabStop = true;
            this.rdoJSON.Text = "JSON";
            this.rdoJSON.UseVisualStyleBackColor = true;
            // 
            // rdoCSV
            // 
            this.rdoCSV.AutoSize = true;
            this.rdoCSV.Location = new System.Drawing.Point(60, 22);
            this.rdoCSV.Name = "rdoCSV";
            this.rdoCSV.Size = new System.Drawing.Size(48, 19);
            this.rdoCSV.TabIndex = 7;
            this.rdoCSV.TabStop = true;
            this.rdoCSV.Text = "CSV";
            this.rdoCSV.UseVisualStyleBackColor = true;
            // 
            // HomeInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 604);
            this.Controls.Add(this.gbxSorting);
            this.Controls.Add(this.gbxDatabase);
            this.Controls.Add(this.gbxItemInfo);
            this.Controls.Add(this.dgvHomeInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomeInventory";
            this.Text = "Home Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeInventory)).EndInit();
            this.gbxItemInfo.ResumeLayout(false);
            this.gbxItemInfo.PerformLayout();
            this.gbxDatabase.ResumeLayout(false);
            this.gbxDatabase.PerformLayout();
            this.gbxSorting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHomeInventory;
        private System.Windows.Forms.Label lblQItemID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.GroupBox gbxItemInfo;
        private System.Windows.Forms.Label lblQItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label lblQItemQuantity;
        private System.Windows.Forms.GroupBox gbxDatabase;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSaveShoppingList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbxSorting;
        private System.Windows.Forms.Button btnShowEmpties;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.TextBox txtItemLocation;
        private System.Windows.Forms.Label lblQExpire;
        private System.Windows.Forms.Label lblQLocation;
        private System.Windows.Forms.RadioButton rdoCSV;
        private System.Windows.Forms.RadioButton rdoJSON;
        private System.Windows.Forms.RadioButton rdoPDF;
        private System.Windows.Forms.RadioButton rdoText;
    }
}

