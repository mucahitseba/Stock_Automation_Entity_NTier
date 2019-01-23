﻿namespace Stock.WFA
{
    partial class GoodsAcceptance
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tvProducts = new System.Windows.Forms.TreeView();
            this.btnBarcodeReading = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nuKDV = new System.Windows.Forms.NumericUpDown();
            this.nuAvails = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmsProductOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nuKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAvails)).BeginInit();
            this.cmsProductOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(50, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // tvProducts
            // 
            this.tvProducts.Location = new System.Drawing.Point(36, 142);
            this.tvProducts.Name = "tvProducts";
            this.tvProducts.Size = new System.Drawing.Size(193, 281);
            this.tvProducts.TabIndex = 2;
            this.tvProducts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProducts_AfterSelect);
            // 
            // btnBarcodeReading
            // 
            this.btnBarcodeReading.Location = new System.Drawing.Point(240, 82);
            this.btnBarcodeReading.Name = "btnBarcodeReading";
            this.btnBarcodeReading.Size = new System.Drawing.Size(139, 23);
            this.btnBarcodeReading.TabIndex = 3;
            this.btnBarcodeReading.Text = "Barcode Reading";
            this.btnBarcodeReading.UseVisualStyleBackColor = true;
            this.btnBarcodeReading.Click += new System.EventHandler(this.btnBarcodeReading_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(249, 142);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(78, 17);
            this.lblInformation.TabIndex = 4;
            this.lblInformation.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(746, 68);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 22);
            this.txtCategoryName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "KDV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Avails:";
            // 
            // nuKDV
            // 
            this.nuKDV.DecimalPlaces = 2;
            this.nuKDV.Location = new System.Drawing.Point(746, 114);
            this.nuKDV.Name = "nuKDV";
            this.nuKDV.Size = new System.Drawing.Size(120, 22);
            this.nuKDV.TabIndex = 7;
            // 
            // nuAvails
            // 
            this.nuAvails.DecimalPlaces = 2;
            this.nuAvails.Location = new System.Drawing.Point(746, 154);
            this.nuAvails.Name = "nuAvails";
            this.nuAvails.Size = new System.Drawing.Size(120, 22);
            this.nuAvails.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(620, 228);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(715, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(796, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmsProductOperations
            // 
            this.cmsProductOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProductOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsProductOperations.Name = "cmsProductOperations";
            this.cmsProductOperations.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // GoodsAcceptance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 501);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.nuAvails);
            this.Controls.Add(this.nuKDV);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnBarcodeReading);
            this.Controls.Add(this.tvProducts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "GoodsAcceptance";
            this.Text = "GoodsAcceptance";
            this.Load += new System.EventHandler(this.GoodsAcceptance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAvails)).EndInit();
            this.cmsProductOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TreeView tvProducts;
        private System.Windows.Forms.Button btnBarcodeReading;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuKDV;
        private System.Windows.Forms.NumericUpDown nuAvails;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip cmsProductOperations;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}