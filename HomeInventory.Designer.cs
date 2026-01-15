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
            this.lblOutRowSuccess = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.lblQItemQuantity = new System.Windows.Forms.Label();
            this.lblQItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.gbxDatabase = new System.Windows.Forms.GroupBox();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnJSONExport = new System.Windows.Forms.Button();
            this.btnCSVExport = new System.Windows.Forms.Button();
            this.btnSaveShoppingList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxSorting = new System.Windows.Forms.GroupBox();
            this.btnShowEmpties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeInventory)).BeginInit();
            this.gbxItemInfo.SuspendLayout();
            this.gbxDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHomeInventory
            // 
            this.dgvHomeInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeInventory.Location = new System.Drawing.Point(13, 12);
            this.dgvHomeInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHomeInventory.Name = "dgvHomeInventory";
            this.dgvHomeInventory.Size = new System.Drawing.Size(776, 301);
            this.dgvHomeInventory.TabIndex = 0;
            this.dgvHomeInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblQItemID
            // 
            this.lblQItemID.AutoSize = true;
            this.lblQItemID.Location = new System.Drawing.Point(7, 23);
            this.lblQItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQItemID.Name = "lblQItemID";
            this.lblQItemID.Size = new System.Drawing.Size(49, 15);
            this.lblQItemID.TabIndex = 1;
            this.lblQItemID.Text = "Item ID:";
            // 
            // txtItemID
            // 
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(84, 20);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(56, 21);
            this.txtItemID.TabIndex = 2;
            // 
            // gbxItemInfo
            // 
            this.gbxItemInfo.Controls.Add(this.btnReset);
            this.gbxItemInfo.Controls.Add(this.lblOutRowSuccess);
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
            this.gbxItemInfo.Size = new System.Drawing.Size(201, 205);
            this.gbxItemInfo.TabIndex = 3;
            this.gbxItemInfo.TabStop = false;
            this.gbxItemInfo.Text = "Item Information";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(104, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblOutRowSuccess
            // 
            this.lblOutRowSuccess.AutoSize = true;
            this.lblOutRowSuccess.Location = new System.Drawing.Point(7, 114);
            this.lblOutRowSuccess.Name = "lblOutRowSuccess";
            this.lblOutRowSuccess.Size = new System.Drawing.Size(0, 15);
            this.lblOutRowSuccess.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(104, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 176);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(84, 76);
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
            this.lblQItemName.Size = new System.Drawing.Size(71, 15);
            this.lblQItemName.TabIndex = 4;
            this.lblQItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(84, 48);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(110, 21);
            this.txtItemName.TabIndex = 3;
            // 
            // gbxDatabase
            // 
            this.gbxDatabase.Controls.Add(this.btnExportPDF);
            this.gbxDatabase.Controls.Add(this.btnJSONExport);
            this.gbxDatabase.Controls.Add(this.btnCSVExport);
            this.gbxDatabase.Controls.Add(this.btnSaveShoppingList);
            this.gbxDatabase.Location = new System.Drawing.Point(397, 319);
            this.gbxDatabase.Name = "gbxDatabase";
            this.gbxDatabase.Size = new System.Drawing.Size(200, 205);
            this.gbxDatabase.TabIndex = 4;
            this.gbxDatabase.TabStop = false;
            this.gbxDatabase.Text = "Export";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(6, 107);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(188, 23);
            this.btnExportPDF.TabIndex = 3;
            this.btnExportPDF.Text = "PDF Export (In Development)";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // btnJSONExport
            // 
            this.btnJSONExport.Location = new System.Drawing.Point(6, 78);
            this.btnJSONExport.Name = "btnJSONExport";
            this.btnJSONExport.Size = new System.Drawing.Size(188, 23);
            this.btnJSONExport.TabIndex = 2;
            this.btnJSONExport.Text = "JSON Export (In Development)";
            this.btnJSONExport.UseVisualStyleBackColor = true;
            // 
            // btnCSVExport
            // 
            this.btnCSVExport.Location = new System.Drawing.Point(6, 49);
            this.btnCSVExport.Name = "btnCSVExport";
            this.btnCSVExport.Size = new System.Drawing.Size(188, 23);
            this.btnCSVExport.TabIndex = 1;
            this.btnCSVExport.Text = "CSV Export (In Development)";
            this.btnCSVExport.UseVisualStyleBackColor = true;
            // 
            // btnSaveShoppingList
            // 
            this.btnSaveShoppingList.Location = new System.Drawing.Point(6, 20);
            this.btnSaveShoppingList.Name = "btnSaveShoppingList";
            this.btnSaveShoppingList.Size = new System.Drawing.Size(188, 23);
            this.btnSaveShoppingList.TabIndex = 0;
            this.btnSaveShoppingList.Text = "Save Shopping List";
            this.btnSaveShoppingList.UseVisualStyleBackColor = true;
            this.btnSaveShoppingList.Click += new System.EventHandler(this.btnSaveShoppingList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(603, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gbxSorting
            // 
            this.gbxSorting.Controls.Add(this.btnShowEmpties);
            this.gbxSorting.Location = new System.Drawing.Point(221, 319);
            this.gbxSorting.Name = "gbxSorting";
            this.gbxSorting.Size = new System.Drawing.Size(170, 205);
            this.gbxSorting.TabIndex = 6;
            this.gbxSorting.TabStop = false;
            this.gbxSorting.Text = "Sorting";
            // 
            // btnShowEmpties
            // 
            this.btnShowEmpties.Location = new System.Drawing.Point(6, 20);
            this.btnShowEmpties.Name = "btnShowEmpties";
            this.btnShowEmpties.Size = new System.Drawing.Size(158, 23);
            this.btnShowEmpties.TabIndex = 0;
            this.btnShowEmpties.Text = "Show Empties";
            this.btnShowEmpties.UseVisualStyleBackColor = true;
            this.btnShowEmpties.Click += new System.EventHandler(this.btnShowEmpties_Click);
            // 
            // HomeInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 533);
            this.Controls.Add(this.gbxSorting);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblOutRowSuccess;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnJSONExport;
        private System.Windows.Forms.Button btnCSVExport;
        private System.Windows.Forms.Button btnSaveShoppingList;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbxSorting;
        private System.Windows.Forms.Button btnShowEmpties;
    }
}

