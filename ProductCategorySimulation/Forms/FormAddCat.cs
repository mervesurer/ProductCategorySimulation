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

namespace ProductCategorySimulation
{
    public partial class FormAddCat : Form
    {
        public FormAddCat()
        {
            InitializeComponent();
        }

        ProductCategoryDbContext dbContext = new ProductCategoryDbContext();
        CategoryBusiness categoryBusiness = new CategoryBusiness();
        FormShowCategories showCategories = new FormShowCategories();

        private void buttonShowCats_Click(object sender, EventArgs e)
        {
            showCategories.ShowCategories(dataGridViewShowCats);
        }

        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = textBoxCatName.Text;
            category.Info = textBoxCatDescription.Text;

            string result = categoryBusiness.Add(category);

            MessageBox.Show(result);

            showCategories.ShowCategories(dataGridViewShowCats);
        }

        private void buttonBackCatsForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }

        private void FormAddCat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
