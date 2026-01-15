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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblQItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.gbxItemInfo = new System.Windows.Forms.GroupBox();
            this.lblOutRowSuccess = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxItemInfo.SuspendLayout();
            this.gbxDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 495);
            this.dataGridView1.TabIndex = 0;
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
            this.txtItemID.Location = new System.Drawing.Point(84, 20);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(56, 21);
            this.txtItemID.TabIndex = 2;
            // 
            // gbxItemInfo
            // 
            this.gbxItemInfo.Controls.Add(this.lblOutRowSuccess);
            this.gbxItemInfo.Controls.Add(this.btnDelete);
            this.gbxItemInfo.Controls.Add(this.btnUpdate);
            this.gbxItemInfo.Controls.Add(this.btnSave);
            this.gbxItemInfo.Controls.Add(this.btnAdd);
            this.gbxItemInfo.Controls.Add(this.txtItemQuantity);
            this.gbxItemInfo.Controls.Add(this.lblQItemQuantity);
            this.gbxItemInfo.Controls.Add(this.lblQItemName);
            this.gbxItemInfo.Controls.Add(this.txtItemName);
            this.gbxItemInfo.Controls.Add(this.txtItemID);
            this.gbxItemInfo.Controls.Add(this.lblQItemID);
            this.gbxItemInfo.Location = new System.Drawing.Point(424, 12);
            this.gbxItemInfo.Name = "gbxItemInfo";
            this.gbxItemInfo.Size = new System.Drawing.Size(201, 205);
            this.gbxItemInfo.TabIndex = 3;
            this.gbxItemInfo.TabStop = false;
            this.gbxItemInfo.Text = "Item Information";
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.gbxDatabase.Location = new System.Drawing.Point(425, 223);
            this.gbxDatabase.Name = "gbxDatabase";
            this.gbxDatabase.Size = new System.Drawing.Size(200, 142);
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
            this.btnExportPDF.Text = "PDF Export";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // btnJSONExport
            // 
            this.btnJSONExport.Location = new System.Drawing.Point(6, 78);
            this.btnJSONExport.Name = "btnJSONExport";
            this.btnJSONExport.Size = new System.Drawing.Size(188, 23);
            this.btnJSONExport.TabIndex = 2;
            this.btnJSONExport.Text = "JSON Export";
            this.btnJSONExport.UseVisualStyleBackColor = true;
            // 
            // btnCSVExport
            // 
            this.btnCSVExport.Location = new System.Drawing.Point(6, 49);
            this.btnCSVExport.Name = "btnCSVExport";
            this.btnCSVExport.Size = new System.Drawing.Size(188, 23);
            this.btnCSVExport.TabIndex = 1;
            this.btnCSVExport.Text = "CSV Export";
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // HomeInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxDatabase);
            this.Controls.Add(this.gbxItemInfo);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomeInventory";
            this.Text = "Home Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxItemInfo.ResumeLayout(false);
            this.gbxItemInfo.PerformLayout();
            this.gbxDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnJSONExport;
        private System.Windows.Forms.Button btnCSVExport;
        private System.Windows.Forms.Button btnSaveShoppingList;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

