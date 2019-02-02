namespace Stock.WFA
{
    partial class ProductSale
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
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.nuPiece = new System.Windows.Forms.NumericUpDown();
            this.nuBag = new System.Windows.Forms.NumericUpDown();
            this.cbBag = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.nuMoney = new System.Windows.Forms.NumericUpDown();
            this.lblChange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSale = new System.Windows.Forms.ListBox();
            this.cmsSale = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinishTheProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBag)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMoney)).BeginInit();
            this.cmsSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 18;
            this.lstProducts.Location = new System.Drawing.Point(24, 48);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(451, 274);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcode.Location = new System.Drawing.Point(102, 350);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(373, 24);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // nuPiece
            // 
            this.nuPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuPiece.Location = new System.Drawing.Point(102, 400);
            this.nuPiece.Name = "nuPiece";
            this.nuPiece.Size = new System.Drawing.Size(120, 24);
            this.nuPiece.TabIndex = 3;
            this.nuPiece.ValueChanged += new System.EventHandler(this.nuPiece_ValueChanged);
            // 
            // nuBag
            // 
            this.nuBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuBag.Location = new System.Drawing.Point(355, 400);
            this.nuBag.Name = "nuBag";
            this.nuBag.Size = new System.Drawing.Size(120, 24);
            this.nuBag.TabIndex = 3;
            this.nuBag.ValueChanged += new System.EventHandler(this.nuBag_ValueChanged);
            // 
            // cbBag
            // 
            this.cbBag.AutoSize = true;
            this.cbBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBag.Location = new System.Drawing.Point(273, 401);
            this.cbBag.Name = "cbBag";
            this.cbBag.Size = new System.Drawing.Size(59, 22);
            this.cbBag.TabIndex = 4;
            this.cbBag.Text = "Bag";
            this.cbBag.UseVisualStyleBackColor = true;
            this.cbBag.CheckedChanged += new System.EventHandler(this.cbBag_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piece:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCreditCard);
            this.groupBox1.Controls.Add(this.rbCash);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(24, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCreditCard.Location = new System.Drawing.Point(262, 44);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(115, 22);
            this.rbCreditCard.TabIndex = 0;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCash.Location = new System.Drawing.Point(78, 44);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(68, 22);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.nuMoney);
            this.pnlCash.Controls.Add(this.lblChange);
            this.pnlCash.Controls.Add(this.label5);
            this.pnlCash.Controls.Add(this.label4);
            this.pnlCash.Location = new System.Drawing.Point(24, 553);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(451, 54);
            this.pnlCash.TabIndex = 7;
            // 
            // nuMoney
            // 
            this.nuMoney.DecimalPlaces = 2;
            this.nuMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuMoney.Location = new System.Drawing.Point(104, 16);
            this.nuMoney.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nuMoney.Name = "nuMoney";
            this.nuMoney.Size = new System.Drawing.Size(120, 24);
            this.nuMoney.TabIndex = 13;
            this.nuMoney.ValueChanged += new System.EventHandler(this.nuMoney_ValueChanged);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChange.Location = new System.Drawing.Point(346, 20);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(40, 18);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(259, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Change:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Received:";
            // 
            // lstSale
            // 
            this.lstSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSale.FormattingEnabled = true;
            this.lstSale.ItemHeight = 25;
            this.lstSale.Location = new System.Drawing.Point(588, 48);
            this.lstSale.Name = "lstSale";
            this.lstSale.Size = new System.Drawing.Size(882, 604);
            this.lstSale.TabIndex = 8;
            // 
            // cmsSale
            // 
            this.cmsSale.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsSale.Name = "cmsSale";
            this.cmsSale.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1317, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(1422, 668);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 24);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Tag = "";
            this.lblTotal.Text = "0.00";
            // 
            // btnFinishTheProcess
            // 
            this.btnFinishTheProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinishTheProcess.Location = new System.Drawing.Point(24, 630);
            this.btnFinishTheProcess.Name = "btnFinishTheProcess";
            this.btnFinishTheProcess.Size = new System.Drawing.Size(451, 62);
            this.btnFinishTheProcess.TabIndex = 12;
            this.btnFinishTheProcess.Text = "Finish The Process";
            this.btnFinishTheProcess.UseVisualStyleBackColor = true;
            this.btnFinishTheProcess.Click += new System.EventHandler(this.btnFinishTheProcess_Click);
            // 
            // ProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.btnFinishTheProcess);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstSale);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBag);
            this.Controls.Add(this.nuBag);
            this.Controls.Add(this.nuPiece);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductSale";
            this.Text = "Product Sale";
            this.Load += new System.EventHandler(this.ProductSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBag)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMoney)).EndInit();
            this.cmsSale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.NumericUpDown nuPiece;
        private System.Windows.Forms.NumericUpDown nuBag;
        private System.Windows.Forms.CheckBox cbBag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSale;
        private System.Windows.Forms.ContextMenuStrip cmsSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinishTheProcess;
        private System.Windows.Forms.NumericUpDown nuMoney;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}