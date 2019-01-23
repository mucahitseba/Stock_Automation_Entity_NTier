using Stock.BLL.Store;
using Stock.MODELS.Entities;
using Stock.WFA.Dialogs;
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
    public partial class GoodsAcceptance : Form
    {
        public GoodsAcceptance()
        {
            InitializeComponent();
        }
        private void GoodsAcceptance_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            lblInformation.Visible = false;
            GetAllCategory();
        }

        private void GetAllCategory()
        {
            tvProducts.Nodes.Clear();
            FormClear();
            var categories = new CategoryStore().GetAll().OrderBy(x => x.CategoryName).ToList();
            foreach (var category in categories)
            {
                TreeNode node = new TreeNode(category.CategoryName);
                node.Tag = category.CategoryId;
                tvProducts.Nodes.Add(node);
                if (category.Products.Count > 0)
                {
                    var products = new ProductStore().GetAll(x => x.CategoryId == category.CategoryId).ToList();
                    foreach (var product in products)
                    {
                        TreeNode subNode = new TreeNode(product.ProductName);
                        subNode.ContextMenuStrip = cmsProductOperations;
                        subNode.Tag = product.ProductId;
                        node.Nodes.Add(subNode);
                    }
                }
            }
            tvProducts.ExpandAll();
        }

        private void FormClear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtSearch")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is NumericUpDown nu)
                    nu.Value = 0;
            }
            lblInformation.Text = string.Empty;
        }

        private void btnBarcodeReading_Click(object sender, EventArgs e)
        {
            BarcodeReading barcode = new BarcodeReading();
            DialogResult answer = barcode.ShowDialog();
            if (answer == DialogResult.OK)
            {
                ProductOperations productOperations = new ProductOperations();
                productOperations.Barcode(barcode.Barcode, barcode.BoxPiece);
                productOperations.ShowDialog();
                GetAllCategory();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                new CategoryStore().Insert(new Category()
                {
                    CategoryName=txtCategoryName.Text,
                    KDV=nuKDV.Value,
                    Avails=nuAvails.Value
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category registration successful");
                
            }
            GetAllCategory();
            FormClear();
        }
        Category category;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCategory = new CategoryStore().Queryable().First(x => x.CategoryId == category.CategoryId);
                selectedCategory.CategoryName = txtCategoryName.Text;
                selectedCategory.KDV = nuKDV.Value;
                selectedCategory.Avails = nuAvails.Value;
                new CategoryStore().Update();
                MessageBox.Show("Category update successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            GetAllCategory();
            FormClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(category.Products.Count!=0)
                    MessageBox.Show("You can not delete because this product is under category");
                else
                {
                    new CategoryStore().Delete(category);
                    MessageBox.Show("Category delete successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetAllCategory();
            FormClear();
        }
        Product product;
        private int ProductId;
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductOperations productOperations = new ProductOperations();
            productOperations.product = product;
            DialogResult answer = productOperations.ShowDialog();
            if (answer == DialogResult.OK)
                GetAllCategory();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductStore().Queryable().First(x => x.ProductId == ProductId);
                new ProductStore().Delete(product);
                MessageBox.Show("Product delete successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            GetAllCategory();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FormClear();
            string search = txtSearch.Text.ToLower();
            List<Product> existing = new List<Product>();
            new ProductStore().Queryable().Where(x => x.ProductName.ToLower().Contains(search) || x.ProductBarcode.ToLower().Contains(search)).ToList().ForEach(x => existing.Add(new Product()
            {
                ProductId = x.ProductId,
                UnitPrice = x.UnitPrice,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                PerBoxPiece = x.PerBoxPiece,
                Discount = x.Discount,
                Stock = x.Stock
            }));
            tvProducts.Nodes.Clear();
            foreach (var Existing in existing)
            {
                if (search == "")
                {
                    tvProducts.Nodes.Clear();
                    GetAllCategory();
                }
                else
                {
                    TreeNode node = new TreeNode(Existing.ProductName);
                    node.Tag = Existing.ProductId;
                    node.ContextMenuStrip = cmsProductOperations;
                    tvProducts.Nodes.Add(node);
                }
            }
            tvProducts.ExpandAll();
        }
        private int categoryId;
        private void tvProducts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblInformation.Visible = true;
            FormClear();
            if (e.Node == null) return;
            if(new ProductStore().Queryable().FirstOrDefault(x => x.ProductName == e.Node.Text) != null)
            {
                ProductId = (int)e.Node.Tag;
                product = new ProductStore().GetById(ProductId);
                if (product == null) return;
                lblInformation.Text = $"Product Name:{product.ProductName}\nBarcode Number:{product.ProductBarcode}\nUnit Price:{product.UnitPrice:c2}"+$"\nStock:{product.Stock} adet\nProduct Category:{product.Category}\nPer Box Piece:{product.PerBoxPiece}";
            }
            if(new CategoryStore().Queryable().FirstOrDefault(x => x.CategoryName == e.Node.Text) != null)
            {
                categoryId = (int)e.Node.Tag;
                category = new CategoryStore().GetById(categoryId);
                if (category == null) return;
                txtCategoryName.Text = category.CategoryName;
                nuAvails.Value = category.Avails;
                nuKDV.Value = category.KDV;
                lblInformation.Text = $"Products in Category:\n";
                var selected = new ProductStore().GetAll(x => x.CategoryId == category.CategoryId);
                foreach (var item in selected)
                {
                    lblInformation.Text += $"{item}  {item.Stock} Piece\n";
                }
            }
        }
    }
}
