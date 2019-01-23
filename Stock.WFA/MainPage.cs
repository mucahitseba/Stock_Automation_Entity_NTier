using Stock.BLL.ReadyData;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private Report report;
        private GoodsAcceptance goodsAcceptance;
        private ProductSale productSale;

        private void saleOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productSale == null || productSale.IsDisposed)
            {
                productSale = new ProductSale
                {
                    MdiParent = this
                };
                productSale.Show();
            }
            else productSale.Activate();
        }

        private void goodsAcceptanceOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (goodsAcceptance == null || goodsAcceptance.IsDisposed)
            {
                goodsAcceptance = new GoodsAcceptance
                {
                    MdiParent = this
                };
                goodsAcceptance.Show();
            }
            else goodsAcceptance.Activate();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (report == null || report.IsDisposed)
            {
                report = new Report
                {
                    MdiParent = this
                };
                report.Show();
            }
            else report.Activate();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            new ReadyData().DataProduce();
        }
    }
}
