namespace Stock.WFA.Dialogs
{
    partial class BarcodeReading
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
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.nuBox = new System.Windows.Forms.NumericUpDown();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(164, 48);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(353, 163);
            this.pbBarcode.TabIndex = 0;
            this.pbBarcode.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(25, 232);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(52, 18);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "label1";
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBox.Location = new System.Drawing.Point(270, 253);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(42, 18);
            this.lblBox.TabIndex = 2;
            this.lblBox.Text = "Box:";
            // 
            // nuBox
            // 
            this.nuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuBox.Location = new System.Drawing.Point(357, 248);
            this.nuBox.Name = "nuBox";
            this.nuBox.Size = new System.Drawing.Size(58, 24);
            this.nuBox.TabIndex = 3;
            this.nuBox.ValueChanged += new System.EventHandler(this.nuBox_ValueChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcode.Location = new System.Drawing.Point(164, 309);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(353, 24);
            this.txtBarcode.TabIndex = 4;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
            // 
            // BarcodeReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.nuBox);
            this.Controls.Add(this.lblBox);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pbBarcode);
            this.Name = "BarcodeReading";
            this.Text = "Barcode Reading";
            this.Load += new System.EventHandler(this.BarcodeReading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.NumericUpDown nuBox;
        private System.Windows.Forms.TextBox txtBarcode;
    }
}