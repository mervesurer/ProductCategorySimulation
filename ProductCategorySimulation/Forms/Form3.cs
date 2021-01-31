using ProductCategorySimulation.Data;
using ProductCategorySimulation.Forms;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void passForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void buttonShowProducts_Click(object sender, EventArgs e)
        {
            FormShowProducts formShowProducts = new FormShowProducts();
            passForm(formShowProducts);
        }

        private void buttonAddProds_Click(object sender, EventArgs e)
        {
            FormAddProds addForm = new FormAddProds();
            passForm(addForm);
        }

        private void buttonUpdateProds_Click(object sender, EventArgs e)
        {
            FormUpdateProds updateProds = new FormUpdateProds();
            passForm(updateProds);
        }

        private void buttonRemoveProds_Click(object sender, EventArgs e)
        {
            FormRemoveProd removeProd = new FormRemoveProd();
            passForm(removeProd);
        }

        private void buttonBackMainForm_Click(object sender, EventArgs e)
        {
            FormMain mainForm = new FormMain();
            passForm(mainForm);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void getProductsToSelect(ComboBox comboBox)
        {
            ProductCategoryDbContext dbContext = new ProductCategoryDbContext();

            comboBox.DataSource = dbContext.Products.ToList();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }
    }
}
