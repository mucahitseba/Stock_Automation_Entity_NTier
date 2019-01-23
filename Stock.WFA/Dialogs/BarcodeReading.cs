using Stock.BLL.Store;
using Stock.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock.WFA.Dialogs
{
    public partial class BarcodeReading : Form
    {
        public BarcodeReading()
        {
            InitializeComponent();
        }
        public string Barcode { get; set; }
        public int BoxPiece { get; set; }
        Product product;
        private void BarcodeReading_Load(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            Ean13Barcode2005.Ean13 barcode = new Ean13Barcode2005.Ean13();
            barcode.Height = 30f;
            barcode.Width = 70f;
            barcode.FontSize = 16f;
            barcode.CountryCode = "86";
            barcode.ManufacturerCode = "95525";
            barcode.ProductCode = ProductCode();
            barcode.ChecksumDigit = "0";
            pbBarcode.Image = barcode.CreateBitmap();
            txtBarcode.Text = barcode.ToString();
            product = new ProductStore().GetAll().FirstOrDefault(x => x.ProductBarcode == txtBarcode.Text);
            if (product != null)
            {
                lblProductName.Visible = true;
                lblProductName.Text = "Incoming Product:" + product.ProductName;
                lblProductName.Location = new Point((this.Width / 2) - 5 * (lblProductName.Text.Length), lblProductName.Location.Y);
            }
            this.ActiveControl = txtBarcode;
            txtBarcode.Focus();
            txtBarcode.Select(0, 0);
            txtBarcode.SelectionStart = txtBarcode.MaxLength;
        }
        private string ProductCode()
        {
            Random rnd = new Random();
            int number = rnd.Next(10000, 10005);
            return number.ToString();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (product == null)
                {
                    Barcode = txtBarcode.Text;
                    BoxPiece = Convert.ToInt32(nuBox.Value);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    var oldStock = product.Stock;
                    BoxPiece = Convert.ToInt32(nuBox.Value);
                    product.Stock += BoxPiece * product.PerBoxPiece;
                    new ProductStore().Update();
                    MessageBox.Show($"{product.ProductName} addition successful.\nOld Stock:{oldStock}\nNew Stock{product.Stock}");
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            product = new ProductStore().GetAll().FirstOrDefault(x => x.ProductBarcode == txtBarcode.Text);
            if (product != null)
            {
                lblProductName.Visible = true;
                lblProductName.Text = "Incoming Product: " + product.ProductName;
                lblProductName.Location = new Point((this.Width / 2) - 5 * (lblProductName.Text.Length), lblProductName.Location.Y);
            }
            this.ActiveControl = txtBarcode;
            txtBarcode.Focus();
            txtBarcode.Select(0, 0);
            txtBarcode.SelectionStart = txtBarcode.MaxLength;
        }

        private void nuBox_ValueChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarcode;
            txtBarcode.Focus();
            txtBarcode.Select(0, 0);
            txtBarcode.SelectionStart = txtBarcode.MaxLength;
        }
    }
}
