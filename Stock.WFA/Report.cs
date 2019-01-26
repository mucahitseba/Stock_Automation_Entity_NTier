using Stock.BLL.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        
    }
}
