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
    public partial class FormRemoveProd : Form
    {
        public FormRemoveProd()
        {
            InitializeComponent();
        }

        Form3 form3 = new Form3();

        private void FormRemoveProd_Load(object sender, EventArgs e)
        {
            form3.getProductsToSelect(comboBoxSelectProd);
        }

        FormShowProducts showProducts = new FormShowProducts();

        private void buttonShowCats_Click(object sender, EventArgs e)
        {
            showProducts.ShowProducts(dataGridViewShowProds);
        }

        private void buttonBackCatsForm_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }


        private void buttonRemoveCats_Click(object sender, EventArgs e)
        {
            ProductBusiness productBusiness = new ProductBusiness();

            int selectedProductId = (int)comboBoxSelectProd.SelectedValue;
            var selectedProduct = productBusiness.GetProductById(selectedProductId);
            productBusiness.Remove(selectedProduct);

            MessageBox.Show("Kaydınız başarıyla silinmiştir");

            showProducts.ShowProducts(dataGridViewShowProds);
        }

        private void FormRemoveProd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
