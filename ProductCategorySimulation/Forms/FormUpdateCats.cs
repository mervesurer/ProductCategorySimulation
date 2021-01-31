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
    public partial class FormUpdateCats : Form
    {
        public FormUpdateCats()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();
        FormShowCategories showCategories = new FormShowCategories();

        private void FormUpdateCats_Load(object sender, EventArgs e)
        {
            form2.getCategoriesToSelect(comboBoxSelectCat);
        }

        ProductCategoryDbContext dbContext = new ProductCategoryDbContext();
        CategoryBusiness categoryBusiness = new CategoryBusiness();

        private void buttonShowCats_Click(object sender, EventArgs e)
        {
            showCategories.ShowCategories(dataGridViewShowCats);
        }

        Category selectedCategory = null;

        private void comboBoxSelectCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBoxSelectCat.SelectedValue;

            var category = categoryBusiness.GetCategoryById(selectedCategoryId);
            selectedCategory = category;

            textBoxCatsName.Text = selectedCategory.Name;
            textBoxCatsInfo.Text = selectedCategory.Info;

            buttonUpdateCats.Enabled = true;
        }

        private void buttonUpdateCats_Click(object sender, EventArgs e)
        {
            selectedCategory.Name = textBoxCatsName.Text;
            selectedCategory.Info = textBoxCatsInfo.Text;

            categoryBusiness.Edit(selectedCategory);

            MessageBox.Show("Kaydınız başarıyla güncellendi!");

            showCategories.ShowCategories(dataGridViewShowCats);
        }

        private void buttonBackCatsForm_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void FormUpdateCats_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
