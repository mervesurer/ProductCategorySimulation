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
    public partial class FormShowProducts : Form
    {
        public FormShowProducts()
        {
            InitializeComponent();
        }

        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            ShowProducts(dataGridViewShowProducts);
        }

        public void ShowProducts(DataGridView dataGridView)
        {
            ProductBusiness productBusiness = new ProductBusiness();
            dataGridView.DataSource = productBusiness.ShowProducts();
        }

        private void buttonBackMainForm_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
        }

        private void FormShowProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
