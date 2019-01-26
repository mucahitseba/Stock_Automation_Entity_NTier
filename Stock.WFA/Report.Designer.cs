namespace Stock.WFA
{
    partial class Report
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStock = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbDailyByCategory = new System.Windows.Forms.CheckBox();
            this.dtpHistory = new System.Windows.Forms.DateTimePicker();
            this.btnDaily = new System.Windows.Forms.Button();
            this.dgvDailySale = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYearsMonthly = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.cbMonthlyByCategory = new System.Windows.Forms.CheckBox();
            this.dgvMonthlySale = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYearly = new System.Windows.Forms.Button();
            this.cbYearlyByCategory = new System.Windows.Forms.CheckBox();
            this.dgvYearlySale = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnPaymentDetail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPaymentDetail = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySale)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySale)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYearlySale)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 506);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStock);
            this.tabPage1.Controls.Add(this.dgvStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(3, 8);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(174, 38);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Excel";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStock.Location = new System.Drawing.Point(3, 54);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(815, 420);
            this.dgvStock.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbDailyByCategory);
            this.tabPage2.Controls.Add(this.dtpHistory);
            this.tabPage2.Controls.Add(this.btnDaily);
            this.tabPage2.Controls.Add(this.dgvDailySale);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbDailyByCategory
            // 
            this.cbDailyByCategory.AutoSize = true;
            this.cbDailyByCategory.Location = new System.Drawing.Point(722, 14);
            this.cbDailyByCategory.Name = "cbDailyByCategory";
            this.cbDailyByCategory.Size = new System.Drawing.Size(141, 21);
            this.cbDailyByCategory.TabIndex = 4;
            this.cbDailyByCategory.Text = "Daily by Category";
            this.cbDailyByCategory.UseVisualStyleBackColor = true;
            // 
            // dtpHistory
            // 
            this.dtpHistory.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpHistory.CustomFormat = "dd.MM.yyyy";
            this.dtpHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpHistory.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHistory.Location = new System.Drawing.Point(183, 8);
            this.dtpHistory.Name = "dtpHistory";
            this.dtpHistory.Size = new System.Drawing.Size(200, 38);
            this.dtpHistory.TabIndex = 3;
            this.dtpHistory.ValueChanged += new System.EventHandler(this.dtpHistory_ValueChanged);
            // 
            // btnDaily
            // 
            this.btnDaily.Location = new System.Drawing.Point(3, 8);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(174, 38);
            this.btnDaily.TabIndex = 2;
            this.btnDaily.Text = "Excel";
            this.btnDaily.UseVisualStyleBackColor = true;
            // 
            // dgvDailySale
            // 
            this.dgvDailySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailySale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDailySale.Location = new System.Drawing.Point(3, 54);
            this.dgvDailySale.Name = "dgvDailySale";
            this.dgvDailySale.RowTemplate.Height = 24;
            this.dgvDailySale.Size = new System.Drawing.Size(815, 420);
            this.dgvDailySale.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbMonths);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cmbYearsMonthly);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnMonthly);
            this.tabPage3.Controls.Add(this.cbMonthlyByCategory);
            this.tabPage3.Controls.Add(this.dgvMonthlySale);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(821, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbMonths
            // 
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Location = new System.Drawing.Point(493, 16);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(121, 24);
            this.cmbMonths.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Month";
            // 
            // cmbYearsMonthly
            // 
            this.cmbYearsMonthly.FormattingEnabled = true;
            this.cmbYearsMonthly.Location = new System.Drawing.Point(270, 16);
            this.cmbYearsMonthly.Name = "cmbYearsMonthly";
            this.cmbYearsMonthly.Size = new System.Drawing.Size(121, 24);
            this.cmbYearsMonthly.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Year";
            // 
            // btnMonthly
            // 
            this.btnMonthly.Location = new System.Drawing.Point(3, 8);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(174, 38);
            this.btnMonthly.TabIndex = 6;
            this.btnMonthly.Text = "Excel";
            this.btnMonthly.UseVisualStyleBackColor = true;
            // 
            // cbMonthlyByCategory
            // 
            this.cbMonthlyByCategory.AutoSize = true;
            this.cbMonthlyByCategory.Location = new System.Drawing.Point(710, 8);
            this.cbMonthlyByCategory.Name = "cbMonthlyByCategory";
            this.cbMonthlyByCategory.Size = new System.Drawing.Size(159, 21);
            this.cbMonthlyByCategory.TabIndex = 5;
            this.cbMonthlyByCategory.Text = "Monthly by Category";
            this.cbMonthlyByCategory.UseVisualStyleBackColor = true;
            // 
            // dgvMonthlySale
            // 
            this.dgvMonthlySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlySale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMonthlySale.Location = new System.Drawing.Point(3, 54);
            this.dgvMonthlySale.Name = "dgvMonthlySale";
            this.dgvMonthlySale.RowTemplate.Height = 24;
            this.dgvMonthlySale.Size = new System.Drawing.Size(815, 420);
            this.dgvMonthlySale.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbYears);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.btnYearly);
            this.tabPage4.Controls.Add(this.cbYearlyByCategory);
            this.tabPage4.Controls.Add(this.dgvYearlySale);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(821, 477);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbYears
            // 
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(277, 22);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(121, 24);
            this.cmbYears.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Year";
            // 
            // btnYearly
            // 
            this.btnYearly.Location = new System.Drawing.Point(6, 8);
            this.btnYearly.Name = "btnYearly";
            this.btnYearly.Size = new System.Drawing.Size(174, 38);
            this.btnYearly.TabIndex = 7;
            this.btnYearly.Text = "Excel";
            this.btnYearly.UseVisualStyleBackColor = true;
            // 
            // cbYearlyByCategory
            // 
            this.cbYearlyByCategory.AutoSize = true;
            this.cbYearlyByCategory.Location = new System.Drawing.Point(674, 8);
            this.cbYearlyByCategory.Name = "cbYearlyByCategory";
            this.cbYearlyByCategory.Size = new System.Drawing.Size(150, 21);
            this.cbYearlyByCategory.TabIndex = 6;
            this.cbYearlyByCategory.Text = "Yearly by Category";
            this.cbYearlyByCategory.UseVisualStyleBackColor = true;
            // 
            // dgvYearlySale
            // 
            this.dgvYearlySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYearlySale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvYearlySale.Location = new System.Drawing.Point(3, 54);
            this.dgvYearlySale.Name = "dgvYearlySale";
            this.dgvYearlySale.RowTemplate.Height = 24;
            this.dgvYearlySale.Size = new System.Drawing.Size(815, 420);
            this.dgvYearlySale.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnPaymentDetail);
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.dgvPaymentDetail);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(821, 477);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnPaymentDetail
            // 
            this.btnPaymentDetail.Location = new System.Drawing.Point(4, 3);
            this.btnPaymentDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaymentDetail.Name = "btnPaymentDetail";
            this.btnPaymentDetail.Size = new System.Drawing.Size(148, 42);
            this.btnPaymentDetail.TabIndex = 14;
            this.btnPaymentDetail.Text = "Excel";
            this.btnPaymentDetail.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCreditCard);
            this.panel1.Controls.Add(this.rbCash);
            this.panel1.Location = new System.Drawing.Point(316, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 43);
            this.panel1.TabIndex = 13;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(35, 12);
            this.rbCreditCard.Margin = new System.Windows.Forms.Padding(4);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(100, 21);
            this.rbCreditCard.TabIndex = 2;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(220, 12);
            this.rbCash.Margin = new System.Windows.Forms.Padding(4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(61, 21);
            this.rbCash.TabIndex = 2;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Payment Method";
            // 
            // dgvPaymentDetail
            // 
            this.dgvPaymentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPaymentDetail.Location = new System.Drawing.Point(3, 54);
            this.dgvPaymentDetail.Name = "dgvPaymentDetail";
            this.dgvPaymentDetail.RowTemplate.Height = 24;
            this.dgvPaymentDetail.Size = new System.Drawing.Size(815, 420);
            this.dgvPaymentDetail.TabIndex = 3;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Report";
            this.Text = "Report";
            this.Activated += new System.EventHandler(this.Report_Activated);
            this.Load += new System.EventHandler(this.Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySale)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySale)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYearlySale)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbDailyByCategory;
        private System.Windows.Forms.DateTimePicker dtpHistory;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.DataGridView dgvDailySale;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYearsMonthly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.CheckBox cbMonthlyByCategory;
        private System.Windows.Forms.DataGridView dgvMonthlySale;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYearly;
        private System.Windows.Forms.CheckBox cbYearlyByCategory;
        private System.Windows.Forms.DataGridView dgvYearlySale;
        private System.Windows.Forms.Button btnPaymentDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPaymentDetail;
    }
}