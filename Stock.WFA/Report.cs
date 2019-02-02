using Stock.BLL.Store;
using Stock.MODELS.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock.WFA
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            tabControl1.SelectedIndex = -1;
        }

        private void Report_Activated(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = -1;
            cmbMonths.SelectedIndex = -1;
            cmbYears.SelectedIndex = -1;
            cmbYearsMonthly.SelectedIndex = -1;
            dtpHistory.Value = DateTime.Now;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1) return;
            var selectedtab = tabControl1.SelectedIndex;
            switch (selectedtab)
            {
                case 0:
                    Stock();
                    break;
                case 1:
                    dtpHistory.Value = DateTime.Now;
                    DailySale(dtpHistory.Value);
                    break;
                case 2:
                    cmbYearsMonthly.SelectedIndex = -1;
                    cmbMonths.SelectedIndex = -1;
                    dgvMonthlySale.Columns.Clear();
                    if (cmbMonths.SelectedItem == null && cmbYearsMonthly.SelectedItem == null)
                        return;
                    break;
                case 3:
                    cmbYears.SelectedIndex = -1;
                    dgvYearlySale.Columns.Clear();
                    if (cmbYears.SelectedItem == null)
                        return;
                    break;
                case 4:
                    rbCreditCard.Checked = false;
                    rbCash.Checked = false;
                    dgvPaymentDetail.Columns.Clear();
                    if (!(rbCreditCard.Checked) || rbCash.Checked)
                        return;
                    break;
                default:
                    break;
            }
        }
        private void dtpHistory_ValueChanged(object sender, EventArgs e)
        {
            var history = dtpHistory.Value;
            DailySale(history);
        }
        private void DailySale(DateTime history)
        {
            var categories = new CategoryStore().GetAll();
            var products = new ProductStore().GetAll();
            var sale = new SaleStore().GetAll();
            var saledetail = new SaleDetailStore().GetAll();
            if (cbDailyByCategory.Checked)
            {
                var dailysalelist = from p in products
                                    join c in categories on p.CategoryId equals c.CategoryId
                                    join sd in saledetail on p.ProductId equals sd.ProductId
                                    join s in sale on sd.SaleId equals s.SaleId
                                    where s.SaleTime.ToShortDateString() == history.ToShortDateString()
                                    group new
                                    {
                                        p,
                                        c,
                                        sd,
                                        s
                                    } by new
                                    {
                                        c.CategoryName,
                                        c.Avails,
                                        c.CategoryId,
                                        p.UnitPrice
                                    }
                                  into gp
                                    orderby gp.Key.CategoryName
                                    select new
                                    {
                                        gp.Key.CategoryId,
                                        gp.Key.CategoryName,
                                        Total = gp.Sum(x => x.sd.Piece),
                                        TotalAvail = Math.Round((gp.Sum(x => x.sd.Piece) * gp.Key.UnitPrice * gp.Key.Avails), 2)
                                    };
                dgvDailySale.DataSource = dailysalelist.ToList();
            }
            else
            {
                var dailysalelist = from p in products
                                    join c in categories on p.CategoryId equals c.CategoryId
                                    join sd in saledetail on p.ProductId equals sd.ProductId
                                    join s in sale on sd.SaleId equals s.SaleId
                                    where s.SaleTime.ToShortDateString() == history.ToShortDateString()
                                    group new
                                    {
                                        p,
                                        c,
                                        sd,
                                        s
                                    } by new
                                    {
                                        p.ProductBarcode,
                                        c.CategoryName,
                                        p.ProductName,
                                        c.Avails,
                                        p.UnitPrice,
                                        p.ProductId
                                    }
                                    into gp
                                    orderby gp.Key.ProductId
                                    select new
                                    {
                                        gp.Key.ProductId,
                                        gp.Key.ProductBarcode,
                                        gp.Key.ProductName,
                                        gp.Key.CategoryName,
                                        SalePiece = gp.Sum(x => x.sd.Piece),
                                        TotalAvail = Math.Round((gp.Sum(x => x.sd.Piece) * gp.Key.UnitPrice * gp.Key.Avails), 2)
                                    };
                dgvDailySale.DataSource = dailysalelist.ToList();

            }


        }
        private void Stock()
        {
            var products = new ProductStore().GetAll();
            var categories = new CategoryStore().GetAll();
            var productlist = from p in products
                              join c in categories on p.CategoryId equals c.CategoryId
                              orderby c.CategoryName
                              select new
                              {
                                  p.ProductBarcode,
                                  c.CategoryName,
                                  p.ProductName,
                                  p.UnitPrice,
                                  p.Discount,
                                  p.PerBoxPiece,
                                  p.Stock
                              };
            dgvStock.DataSource = productlist.ToList();
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (Convert.ToInt32(row.Cells[6].Value) < 100)
                    row.DefaultCellStyle.BackColor = Color.DarkSalmon;

            }
        }
        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = Convert.ToInt32(cmbYearsMonthly.SelectedItem);
            if (cmbYearsMonthly.SelectedItem == null)
            {
                if (cmbMonths.SelectedIndex != -1)
                {
                    cmbMonths.SelectedIndex = -1; return;
                }

            }
            var selectedMonth = Convert.ToInt32(cmbMonths.SelectedItem);
            MonthlySales(selectedMonth, selectedYear);

        }
        private void MonthlySales(int month, int year)
        {
            var categories = new CategoryStore().GetAll();
            var products = new ProductStore().GetAll();
            var sale = new SaleStore().GetAll();
            var saledetail = new SaleDetailStore().GetAll();
            if (cbMonthlyByCategory.Checked)
            {
                var monthlySaleList = from p in products
                                      join c in categories on p.CategoryId equals c.CategoryId
                                      join sd in saledetail on p.ProductId equals sd.ProductId
                                      join s in sale on sd.SaleId equals s.SaleId
                                      where s.SaleTime.Month == month && s.SaleTime.Year == year
                                      group new
                                      {
                                          p,
                                          c,
                                          sd,
                                          s
                                      } by new
                                      {
                                          c.CategoryId,
                                          c.CategoryName,
                                          p.UnitPrice,
                                          c.Avails
                                      }
                                    into gp
                                      orderby gp.Key.CategoryId
                                      select new
                                      {
                                          gp.Key.CategoryId,
                                          gp.Key.CategoryName,
                                          TotalPiece = gp.Sum(x => x.sd.Piece),
                                          TotalAvail = Math.Round((gp.Sum(x => x.sd.Piece) * gp.Key.UnitPrice * gp.Key.Avails), 2)
                                      };
                dgvMonthlySale.DataSource = monthlySaleList.ToList(); 
            }
            else
            {
                var monthlySaleList = from p in products
                                      join c in categories on p.CategoryId equals c.CategoryId
                                      join sd in saledetail on p.ProductId equals sd.ProductId
                                      join s in sale on sd.SaleId equals s.SaleId
                                      where s.SaleTime.Month == month && s.SaleTime.Year == year
                                      group new
                                      {
                                          p,
                                          c,
                                          sd,
                                          s
                                      } by new
                                      {
                                          p.ProductBarcode,
                                          c.CategoryName,
                                          p.ProductName,
                                          p.UnitPrice,
                                          c.Avails

                                      }
                                    into gp
                                      orderby gp.Key.CategoryName
                                      select new
                                      {
                                          gp.Key.ProductBarcode,
                                          gp.Key.CategoryName,
                                          gp.Key.ProductName,
                                          Total = gp.Sum(x => x.sd.Piece),
                                          TotalAvail = Math.Round((gp.Sum(x => x.sd.Piece) * gp.Key.UnitPrice * gp.Key.Avails), 2)
                                      };
                dgvMonthlySale.DataSource = monthlySaleList.ToList();

            }
        }
        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = Convert.ToInt32(cmbYears.SelectedItem);
            YearlySales(selectedYear);
        }
        private void YearlySales(int year)
        {
            var categories = new CategoryStore().GetAll();
            var products = new ProductStore().GetAll();
            var sale = new SaleStore().GetAll();
            var saledetail = new SaleDetailStore().GetAll();
            if (cbYearlyByCategory.Checked)
            {
                var yearlySaleList = from p in products
                                     join c in categories on p.CategoryId equals c.CategoryId
                                     join sd in saledetail on p.ProductId equals sd.ProductId
                                     join s in sale on sd.SaleId equals s.SaleId
                                     where s.SaleTime.Year == year
                                     group new
                                     {
                                         c,
                                         p,
                                         sd,
                                         s
                                     } by new
                                     {
                                         c.CategoryId,
                                         c.CategoryName,
                                         p.UnitPrice,
                                         c.Avails
                                     }
                                     into gp orderby gp.Key.CategoryName
                                     select new
                                     {
                                         gp.Key.CategoryId,
                                         gp.Key.CategoryName,
                                         Total = gp.Sum(x => x.sd.Piece),
                                         TotalAvail = Math.Round((gp.Sum(x => x.sd.Piece) * gp.Key.UnitPrice * gp.Key.Avails), 2)
                                     };
                dgvYearlySale.DataSource = yearlySaleList.ToList();
            }
            else
            {
                var yearlySaleList = from p in products
                                     join c in categories on p.CategoryId equals c.CategoryId
                                     join sd in saledetail on p.ProductId equals sd.ProductId
                                     join s in sale on sd.SaleId equals s.SaleId
                                     where s.SaleTime.Year == year
                                     group new
                                     {
                                         c,
                                         p,
                                         sd,
                                         s
                                     } by new
                                     {
                                         p.ProductId,
                                         p.ProductBarcode,
                                         c.CategoryName,
                                         p.ProductName,
                                         p.UnitPrice,
                                         c.Avails
                                     }
                                     into gp orderby gp.Key.CategoryName
                                     select new
                                     {
                                         gp.Key.ProductId,gp.Key.ProductBarcode,
                                         gp.Key.ProductName,
                                         Total = gp.Sum(x => x.sd.Piece),
                                         TotalAvail = Math.Round((gp.Sum(x => x.sd.Piece) * gp.Key.UnitPrice * gp.Key.Avails), 2)
                                     };
                dgvYearlySale.DataSource = yearlySaleList.ToList();
            }
        }
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            var selectedrb = PaymentMethod.Cash;
            GetByPaymentMethod(selectedrb);
        }
        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            var selectedrb = PaymentMethod.CreditCard;
            GetByPaymentMethod(selectedrb);
        }
        private void GetByPaymentMethod(PaymentMethod paymentmethod)
        {
            var categories = new CategoryStore().GetAll();
            var products = new ProductStore().GetAll();
            var sale = new SaleStore().GetAll();
            var saledetail = new SaleDetailStore().GetAll();
            var paymentDetailList = from p in products
                                    join c in categories on p.CategoryId equals c.CategoryId
                                    join sd in saledetail on p.ProductId equals sd.ProductId
                                    join s in sale on sd.SaleId equals s.SaleId
                                    where s.PaymentMethod == paymentmethod
                                    group new
                                    {
                                        p,
                                        c,
                                        s,
                                        sd
                                    } by new
                                    {
                                        s.SaleId,
                                        s.SaleTime,
                                        s.PaymentMethod,
                                        p.UnitPrice,
                                        c.Avails,
                                        c.KDV,
                                        sd.Piece,
                                        p.Discount
                                    }
                                   into gp
                                    orderby gp.Key.SaleId
                                    select new
                                    {
                                        gp.Key.SaleId,
                                        TotalPiece = gp.Sum(x => x.sd.Piece),
                                        gp.Key.SaleTime,
                                        gp.Key.PaymentMethod,
                                        TotalSale = Math.Round((gp.Sum(x => x.sd.Piece) * gp.Key.UnitPrice * (1 + gp.Key.KDV) * (1 + gp.Key.Avails) * (1 - gp.Key.Discount)), 2)
                                    };
            dgvPaymentDetail.DataSource = paymentDetailList.ToList();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents(*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelDocument(dgvStock, sfd.FileName);
                    MessageBox.Show("Successful transfer to excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail transfer to excel{ex.Message}");
            }
        }
        private void btnDaily_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents(*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelDocument(dgvDailySale, sfd.FileName);
                    MessageBox.Show("Successful transfer to excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail transfer to excel{ex.Message}");

            }
        }
        private void btnMonthly_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents(*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelDocument(dgvMonthlySale, sfd.FileName);
                    MessageBox.Show("Successful transfer to excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail transfer to excel{ex.Message}");
            }
        }
        private void btnYearly_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents(*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelDocument(dgvYearlySale, sfd.FileName);
                    MessageBox.Show("Successful transfer to excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail transfer to excel{ex.Message}");

            }
        }
        private void btnPaymentDetail_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents(*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelDocument(dgvPaymentDetail, sfd.FileName);
                    MessageBox.Show("Successful transfer to excel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail transfer to excel{ex.Message}");
            }
        }
        private void ExcelDocument(DataGridView dgv, string fileName)
        {
            string stOutput = "";
            string sHeaders = "";
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                sHeaders = sHeaders.ToString() + Convert.ToString(dgv.Columns[j].HeaderText) + "\t";
            }
            stOutput += sHeaders + "\r\n";
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                {
                    stLine = stLine.ToString() + Convert.ToString(dgv.Rows[i].Cells[j].Value) + "\t";
                }
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void cbDailyByCategory_CheckedChanged(object sender, EventArgs e)
        {
            dtpHistory_ValueChanged(sender, e);
        }
        private void cbMonthlyByCategory_CheckedChanged(object sender, EventArgs e)
        {
            cmbMonths_SelectedIndexChanged(sender, e);
        }
        private void cbYearlyByCategory_CheckedChanged(object sender, EventArgs e)
        {
            cmbYears_SelectedIndexChanged(sender, e);
        }

        private void dgvPaymentDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
