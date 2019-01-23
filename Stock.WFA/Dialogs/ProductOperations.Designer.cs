namespace Stock.WFA.Dialogs
{
    partial class ProductOperations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.nuPerBoxPiece = new System.Windows.Forms.NumericUpDown();
            this.nuUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nuDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnFinishTheProcess = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuPerBoxPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Per Box Piece";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unit Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Discount:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(138, 40);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(100, 22);
            this.txtBarcode.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 116);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // nuPerBoxPiece
            // 
            this.nuPerBoxPiece.Location = new System.Drawing.Point(138, 154);
            this.nuPerBoxPiece.Name = "nuPerBoxPiece";
            this.nuPerBoxPiece.Size = new System.Drawing.Size(120, 22);
            this.nuPerBoxPiece.TabIndex = 3;
            // 
            // nuUnitPrice
            // 
            this.nuUnitPrice.DecimalPlaces = 2;
            this.nuUnitPrice.Location = new System.Drawing.Point(138, 186);
            this.nuUnitPrice.Name = "nuUnitPrice";
            this.nuUnitPrice.Size = new System.Drawing.Size(120, 22);
            this.nuUnitPrice.TabIndex = 3;
            // 
            // nuDiscount
            // 
            this.nuDiscount.DecimalPlaces = 2;
            this.nuDiscount.Location = new System.Drawing.Point(138, 214);
            this.nuDiscount.Name = "nuDiscount";
            this.nuDiscount.Size = new System.Drawing.Size(120, 22);
            this.nuDiscount.TabIndex = 3;
            // 
            // btnFinishTheProcess
            // 
            this.btnFinishTheProcess.Location = new System.Drawing.Point(42, 282);
            this.btnFinishTheProcess.Name = "btnFinishTheProcess";
            this.btnFinishTheProcess.Size = new System.Drawing.Size(220, 23);
            this.btnFinishTheProcess.TabIndex = 4;
            this.btnFinishTheProcess.Text = "Finish The Process";
            this.btnFinishTheProcess.UseVisualStyleBackColor = true;
            this.btnFinishTheProcess.Click += new System.EventHandler(this.btnFinishTheProcess_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(137, 77);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 5;
            // 
            // ProductOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnFinishTheProcess);
            this.Controls.Add(this.nuDiscount);
            this.Controls.Add(this.nuUnitPrice);
            this.Controls.Add(this.nuPerBoxPiece);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ProductOperations";
            this.Text = "ProductOperations";
            this.Load += new System.EventHandler(this.ProductOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPerBoxPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.NumericUpDown nuPerBoxPiece;
        private System.Windows.Forms.NumericUpDown nuUnitPrice;
        private System.Windows.Forms.NumericUpDown nuDiscount;
        private System.Windows.Forms.Button btnFinishTheProcess;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}