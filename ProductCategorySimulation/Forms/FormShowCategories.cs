using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategorySimulation.Services
{
    public partial class FormShowCategories : Form
    {
        public FormShowCategories()
        {
            InitializeComponent();
        }

        private void FormShowCategories_Load(object sender, EventArgs e)
        {
            ShowCategories(dataGridViewShowCategories);
        }

        private void buttonBackMainForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }

        public void ShowCategories(DataGridView dataGridView)
        {
            CategoryBusiness categoryBusiness = new CategoryBusiness();
            dataGridView.DataSource = categoryBusiness.ShowCategories();
        }

        private void FormShowCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
