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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void passForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            Form2 formCategories = new Form2();
            passForm(formCategories);
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Form3 formProducts = new Form3();
            passForm(formProducts);
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
