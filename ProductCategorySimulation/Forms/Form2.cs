using ProductCategorySimulation.Data;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void passForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void buttonShowCategories_Click(object sender, EventArgs e)
        {
            FormShowCategories showCategories = new FormShowCategories();
            passForm(showCategories);
        }

        private void buttonBackForm1_Click(object sender, EventArgs e)
        {
            FormMain mainForm = new FormMain();
            passForm(mainForm);
        }

        private void buttonUpdateCat_Click(object sender, EventArgs e)
        {
            FormUpdateCats updateForm = new FormUpdateCats();
            passForm(updateForm);
        }

        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            FormAddCat addForm = new FormAddCat();
            passForm(addForm);
        }

        private void buttonRemoveCat_Click(object sender, EventArgs e)
        {
            FormRemoveCats removeForm = new FormRemoveCats();
            passForm(removeForm);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void getCategoriesToSelect(ComboBox comboBox)
        {
            ProductCategoryDbContext dbContext = new ProductCategoryDbContext();

            comboBox.DataSource = dbContext.Categories.ToList();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }
    }
}
