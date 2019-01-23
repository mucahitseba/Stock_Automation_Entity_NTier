using Stock.BLL.Store;
using Stock.MODELS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock.WFA.Dialogs
{
    public partial class ProductOperations : Form
    {
        public ProductOperations()
        {
            InitializeComponent();
        }
        public Product product;

        private void ProductOperations_Load(object sender, EventArgs e)
        {
            var categories = new CategoryStore().GetAll().ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = -1;
            if (product != null) GetProduct(product);
        }
        int boxPiece;
        public void Barcode(string barcode,int piece)
        {
            txtBarcode.Text = barcode;
            boxPiece = piece;
        }
        bool newProduct = true;

        public void GetProduct(Product selectedProduct)
        {
            newProduct = false;
            txtBarcode.Text = selectedProduct.ProductBarcode;
            txtProductName.Text = selectedProduct.ProductName;
            nuPerBoxPiece.Value = selectedProduct.PerBoxPiece;
            nuUnitPrice.Value = selectedProduct.UnitPrice;
            nuDiscount.Value = selectedProduct.Discount;
            cmbCategory.Text = selectedProduct.Category.CategoryName;
        }

        private void btnFinishTheProcess_Click(object sender, EventArgs e)
        {
            if (newProduct)
            {
                var selected = cmbCategory.SelectedItem as Category;
                try
                {
                    new ProductStore().Insert(new Product()
                    {
                        ProductName = txtProductName.Text,
                        UnitPrice = nuUnitPrice.Value,
                        PerBoxPiece = Convert.ToInt32(nuPerBoxPiece.Value),
                        ProductBarcode = txtBarcode.Text,
                        CategoryId = selected.CategoryId,
                        Stock = boxPiece * Convert.ToInt32(nuPerBoxPiece.Value)
                    });
                    MessageBox.Show("Product registration successful");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
            else
            {
                try
                {
                    var selectedProduct = new ProductStore().Queryable().First(x => x.ProductBarcode == txtBarcode.Text);
                    selectedProduct.ProductName = txtProductName.Text;
                    selectedProduct.UnitPrice = nuUnitPrice.Value;
                    selectedProduct.PerBoxPiece = (int)nuPerBoxPiece.Value;
                    selectedProduct.Discount = nuDiscount.Value;
                    selectedProduct.Category.CategoryName = (cmbCategory.SelectedItem as Category).CategoryName;
                    new ProductStore().Update();
                    MessageBox.Show("Product update successful");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   
                }
            }
        }
    }
}
