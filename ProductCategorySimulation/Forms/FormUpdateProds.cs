using ProductCategorySimulation.Data;
using ProductCategorySimulation.Models;
using ProductCategorySimulation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategorySimulation.Forms
{
    public partial class FormUpdateProds : Form
    {
        public FormUpdateProds()
        {
            InitializeComponent();
        }

        Form3 form3 = new Form3();

        private void FormUpdateProds_Load(object sender, EventArgs e)
        {
            form3.getProductsToSelect(comboBoxShowProds);
            Form2 form2 = new Form2();
            form2.getCategoriesToSelect(comboBoxShowCats);

        }

        private void buttonShowProds_Click(object sender, EventArgs e)
        {
            showProducts.ShowProducts(dataGridViewShowProds);
        }

        ProductCategoryDbContext dbContext = new ProductCategoryDbContext();
        ProductBusiness productBusiness = new ProductBusiness();
        FormShowProducts showProducts = new FormShowProducts();

        Product selectedProduct = null;
        CategoryBusiness categoryBusiness = new CategoryBusiness();

        private void comboBoxShowProds_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxShowProds.SelectedValue;

            var product = productBusiness. GetProductById(selectedProductId);
            selectedProduct = product;

            int currentCategoryId = selectedProduct.CategoryId;
            var currentCategory = categoryBusiness.GetCategoryById(currentCategoryId);

            textBoxProdsName.Text = selectedProduct.Name;
            textBoxProdImage.Text = selectedProduct.ImgAddress;
            textBoxProdPrice.Text = selectedProduct.Price.ToString();
            textBoxProdInfo.Text = selectedProduct.Info;
            textBoxProdRating.Text = selectedProduct.Rating.ToString();
            comboBoxShowCats.SelectedValue = selectedProduct.CategoryId;

            buttonUpdateProds.Enabled = true;

            showProducts.ShowProducts(dataGridViewShowProds);
        }

        private void buttonUpdateProds_Click(object sender, EventArgs e)
        {
            selectedProduct.Name = textBoxProdsName.Text;
            selectedProduct.ImgAddress = textBoxProdImage.Text;
            selectedProduct.Price = Convert.ToDecimal(textBoxProdPrice.Text);
            selectedProduct.Info = textBoxProdInfo.Text;
            selectedProduct.Rating = Convert.ToDouble(textBoxProdRating.Text);
            selectedProduct.CategoryId = (int)comboBoxShowCats.SelectedValue;

            productBusiness.Edit(selectedProduct);

            MessageBox.Show("Kaydınız başarıyla güncellendi!");

            showProducts.ShowProducts(dataGridViewShowProds);
        }

        private void buttonBackToFrom_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
        }

        private void FormUpdateProds_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
