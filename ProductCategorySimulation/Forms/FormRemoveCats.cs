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
    public partial class FormRemoveCats : Form
    {
        public FormRemoveCats()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();
        FormShowCategories showCategories = new FormShowCategories();

        private void FormRemoveCats_Load(object sender, EventArgs e)
        {
            form2.getCategoriesToSelect(comboBoxSelectCat);
        }        

        private void buttonShowCats_Click(object sender, EventArgs e)
        {
            showCategories.ShowCategories(dataGridViewShowCats);
        }

        private void buttonRemoveCats_Click(object sender, EventArgs e)
        {
            CategoryBusiness categoryBusiness = new CategoryBusiness();

            int selectedCategoryId = (int)comboBoxSelectCat.SelectedValue;
            var selectedCategory = categoryBusiness.GetCategoryById(selectedCategoryId);
            string result = categoryBusiness.Remove(selectedCategory);

            MessageBox.Show(result);

            showCategories.ShowCategories(dataGridViewShowCats);
        }

        private void buttonBackCatsForm_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void FormRemoveCats_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
