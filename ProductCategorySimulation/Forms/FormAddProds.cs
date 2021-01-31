using ProductCategorySimulation.Data;
using ProductCategorySimulation.Forms;
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

namespace ProductCategorySimulation
{
    public partial class FormAddProds : Form
    {
        public FormAddProds()
        {
            InitializeComponent();
        }

        private void FormAddProds_Load(object sender, EventArgs e)
        {
            getCategoriesToSelect();
        }

        ProductBusiness productBusiness = new ProductBusiness();
        ProductCategoryDbContext dbContext = new ProductCategoryDbContext();
        FormShowProducts showProducts = new FormShowProducts();

        private void getCategoriesToSelect()
        {
            comboBoxShowCats.DataSource = dbContext.Categories.ToList();
            comboBoxShowCats.DisplayMember = "Name";
            comboBoxShowCats.ValueMember = "Id";
        }

        Category selectedCategory = null;
        CategoryBusiness categoryBusiness = new CategoryBusiness();

        private void buttonAddProds_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBoxProdName.Text;
            product.ImgAddress = textBoxProdImage.Text;
            product.Price = Convert.ToDecimal(textBoxProdPrice.Text);
            product.Info = textBoxProdInfo.Text;
            product.Rating = Convert.ToDouble(textBoxProdRating.Text);
           
            int selectedCategoryId = (int)comboBoxShowCats.SelectedValue;
            selectedCategory = categoryBusiness.GetCategoryById(selectedCategoryId);
            product.CategoryId = selectedCategory.Id;

            productBusiness.Add(product);

            MessageBox.Show("Ürün başarıyla eklendi!");

            showProducts.ShowProducts(dataGridViewShowProds);
        }

        private void buttonShowProds_Click_1(object sender, EventArgs e)
        {
            showProducts.ShowProducts(dataGridViewShowProds);
        }

        private void buttonBackToFrom_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
        }

        private void FormAddProds_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
