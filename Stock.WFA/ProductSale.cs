using iTextSharp.text;
using iTextSharp.text.pdf;
using Stock.BLL.Store;
using Stock.MODELS.Entities;
using Stock.MODELS.Enums;
using Stock.MODELS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Stock.WFA
{
    public partial class ProductSale : Form
    {
        public ProductSale()
        {
            InitializeComponent();
        }
        private List<SaleDetailViewModel> sale = new List<SaleDetailViewModel>();

        private void ProductSale_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            GetProducts();
            GetSales();
            FormClear();
        }
        private void FormClear()
        {
            nuPiece.Value = 1;
            nuMoney.Value = 0;
            nuBag.Value = 0;
            txtBarcode.Clear();
            lstSale.Items.Clear();
            cbBag.CheckState = CheckState.Unchecked;
            rbCash.Checked = false;
            rbCreditCard.Checked = false;
            sale = new List<SaleDetailViewModel>();  
        }

        private void GetSales()
        {
            lstSale.Items.Clear();
            foreach (var _sale in sale)
            {
                lstSale.Items.Add(_sale);
            }
        }
        private void GetProducts()
        {
            var products = new ProductStore().GetAll().ToList();
            lstProducts.DataSource = products;
        }

        private void cbBag_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBag.CheckState == CheckState.Checked)
            {
                nuBag.Enabled = true;
                try
                {
                    sale.Add(new SaleDetailViewModel()
                    {
                        ProductId=0,
                        ProductName="Bag",
                        Piece=(int)nuBag.Value,
                        SalePrice=(decimal)0.25,
                        KDV=0,
                        Discount=0
                    });
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                nuBag.Enabled = false;
                nuBag.Value = 0;
                if (sale.Contains(sale.Find(x => x.ProductId.Equals(0))))
                    sale.Remove(sale.Find(x => x.ProductId.Equals(0)));
            }
            GetSales();
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked == true)
                pnlCash.Visible = true;
            else pnlCash.Visible = false;
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = lstProducts.SelectedItem as Product;
            txtBarcode.Text = new ProductStore().GetById(product.ProductId).ProductBarcode.ToString();
            txtBarcode.Focus();
            txtBarcode.Select(0, 0);
            txtBarcode.SelectionStart = txtBarcode.MaxLength;
        }
        private decimal Total()
        {
            lstSale.Items.Clear();
            foreach (var item in sale)
            {
                lstSale.Items.Add(item);
            }
            var total = sale.Sum(x => x.Total());
            lblTotal.Text = $"{total:c2}";
            return total;
        }
        private void nuMoney_ValueChanged(object sender, EventArgs e)
        {
            lblChange.Text = (nuMoney.Value - Total()).ToString("c2", CultureInfo.CurrentCulture);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSale.SelectedItem == null) return;
            var selectedSale = lstSale.SelectedItem as SaleDetailViewModel;
            new ProductStore().GetById(selectedSale.ProductId).Stock += selectedSale.Piece;
            new ProductStore().Update();
            sale.Remove(selectedSale);
            GetSales();
        }

        private void nuBag_ValueChanged(object sender, EventArgs e)
        {
            SaleDetailViewModel bag = sale.Find(x => x.ProductId.Equals(0));
            bag.Piece = (int)nuBag.Value;
            GetSales();
            Total();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstProducts.SelectedItem == null || txtBarcode.Text == "")
                {
                    MessageBox.Show("Lütfen listeden bir ürün seçin ya da barkodu girin.");
                    return;
                }
                var selectedProduct = lstProducts.SelectedItem as Product;
                if (selectedProduct.Stock == 0)
                {
                    MessageBox.Show("Ürünün stoğu yok!");
                    return;
                }
                if ((int)nuPiece.Value > selectedProduct.Stock)
                {
                    MessageBox.Show("Stokta bu kadar ürün yok!");
                    return;
                }
                bool isThereAList= false;
                var productInTheList = new SaleDetailViewModel();
                foreach (var item in sale)
                {
                    if (selectedProduct.ProductId == item.ProductId)
                    {
                        isThereAList = true;
                        productInTheList = item;
                        break;
                    }
                }
                if (isThereAList)
                {
                    var product = new ProductStore().GetById(selectedProduct.ProductId);
                    if (((int)nuPiece.Value <= product.Stock))
                    {
                        productInTheList.Piece += (int)nuPiece.Value;
                        product.Stock -= (int)nuPiece.Value;
                        new ProductStore().Update();
                    }
                    else
                    {
                        MessageBox.Show("Stokta bu kadar ürün yok!");
                        return;
                    }
                }
                else
                {
                    sale.Add(new SaleDetailViewModel()
                    {
                        ProductId=selectedProduct.ProductId,
                        ProductName=selectedProduct.ProductName,
                        Piece=(int)nuPiece.Value,
                        Discount=selectedProduct.Discount,
                        KDV=new CategoryStore().GetById(selectedProduct.CategoryId).KDV,
                        SalePrice=selectedProduct.UnitPrice*(1+selectedProduct.Category.KDV+selectedProduct.Category.Avails)*(1-selectedProduct.Discount)

                    });
                    selectedProduct.Stock -= (int)nuPiece.Value;
                    new ProductStore().Update();
                }
                Total();
                nuPiece.Value = 1;
            }
        }

        private void nuPiece_ValueChanged(object sender, EventArgs e)
        {
            txtBarcode.Focus();
            txtBarcode.Select(0, 0);
            txtBarcode.SelectionStart = txtBarcode.MaxLength;
        }

        private void btnFinishTheProcess_Click(object sender, EventArgs e)
        {
            var radioButtons = groupBox1.Controls.OfType<RadioButton>().ToArray();
            if (!(rbCash.Checked || rbCreditCard.Checked))
            {
                MessageBox.Show("Lütfen önce bir ödeme yöntemi seçin.");
                return;
            }
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));
            try
            {
                var newSale = new SaleStore().Insert(new Sale()
                {
                    PaymentMethod=(PaymentMethod)selectedIndex
                });
                foreach (var _sale in sale)
                {
                    if (_sale.ProductId == 0) continue;
                    new SaleDetailStore().Insert(new SaleDetail()
                    {
                        SaleId=new SaleStore().GetAll().Last().SaleId,
                        ProductId=_sale.ProductId,
                        Piece=_sale.Piece,
                        SalePrice=_sale.SalePrice
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            using(SaveFileDialog saveFileDialog=new SaveFileDialog() {Filter="PDF File|*.pdf",ValidateNames=true })
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A5.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();
                        var productSale = lstSale.Items;

                        DateTime history = DateTime.Now;

                        iTextSharp.text.pdf.BaseFont Courier_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Courier", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                        iTextSharp.text.Font font = new iTextSharp.text.Font(Courier_Turkish, 12, iTextSharp.text.Font.NORMAL);

                        doc.Add(new Paragraph("Stock AutoMation \nISTANBUL", font));
                        doc.Add(new Paragraph($"\nNumber:{new SaleStore().GetAll().Last().SaleId}\nHistory:{history.ToString("dd.MM.yyyy")}\n Time:{history.ToString("HH:mm:ss")}", font));
                        doc.Add(new Paragraph("\nProduct Name                        Piece    KDV    Price\n", font));
                        foreach (var item in productSale)
                        {
                            doc.Add(new Paragraph(item.ToString(), font));
                        }
                        doc.Add(new Paragraph($"\nTotal : {lblTotal.Text:c2}", font));
                        if (rbCash.Checked == true)
                        {
                            doc.Add(new Paragraph($"Received: {nuMoney.Value.ToString()}\nChange:{lblChange.Text:c2}", font));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        doc.Close();
                    }
                }
            MessageBox.Show("Sale Succesful");
            DialogResult = DialogResult.OK;
            FormClear();
            GetSales();
        }
    }
}
