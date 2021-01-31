
namespace ProductCategorySimulation.Forms
{
    partial class FormRemoveProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBackCatsForm = new System.Windows.Forms.Button();
            this.buttonShowCats = new System.Windows.Forms.Button();
            this.buttonRemoveCats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectProd = new System.Windows.Forms.ComboBox();
            this.dataGridViewShowProds = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowProds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonBackCatsForm);
            this.panel2.Controls.Add(this.buttonShowCats);
            this.panel2.Controls.Add(this.buttonRemoveCats);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxSelectProd);
            this.panel2.Location = new System.Drawing.Point(11, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 318);
            this.panel2.TabIndex = 3;
            // 
            // buttonBackCatsForm
            // 
            this.buttonBackCatsForm.Location = new System.Drawing.Point(16, 258);
            this.buttonBackCatsForm.Name = "buttonBackCatsForm";
            this.buttonBackCatsForm.Size = new System.Drawing.Size(195, 37);
            this.buttonBackCatsForm.TabIndex = 23;
            this.buttonBackCatsForm.Text = "Önceki Sayfaya Dön";
            this.buttonBackCatsForm.UseVisualStyleBackColor = true;
            this.buttonBackCatsForm.Click += new System.EventHandler(this.buttonBackCatsForm_Click);
            // 
            // buttonShowCats
            // 
            this.buttonShowCats.Location = new System.Drawing.Point(16, 16);
            this.buttonShowCats.Name = "buttonShowCats";
            this.buttonShowCats.Size = new System.Drawing.Size(195, 37);
            this.buttonShowCats.TabIndex = 15;
            this.buttonShowCats.Text = "Ürünleri Göster";
            this.buttonShowCats.UseVisualStyleBackColor = true;
            this.buttonShowCats.Click += new System.EventHandler(this.buttonShowCats_Click);
            // 
            // buttonRemoveCats
            // 
            this.buttonRemoveCats.Location = new System.Drawing.Point(16, 190);
            this.buttonRemoveCats.Name = "buttonRemoveCats";
            this.buttonRemoveCats.Size = new System.Drawing.Size(195, 37);
            this.buttonRemoveCats.TabIndex = 22;
            this.buttonRemoveCats.Text = "Ürünleri Sil";
            this.buttonRemoveCats.UseVisualStyleBackColor = true;
            this.buttonRemoveCats.Click += new System.EventHandler(this.buttonRemoveCats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ürünler :";
            // 
            // comboBoxSelectProd
            // 
            this.comboBoxSelectProd.FormattingEnabled = true;
            this.comboBoxSelectProd.Location = new System.Drawing.Point(16, 114);
            this.comboBoxSelectProd.Name = "comboBoxSelectProd";
            this.comboBoxSelectProd.Size = new System.Drawing.Size(208, 28);
            this.comboBoxSelectProd.TabIndex = 17;
            // 
            // dataGridViewShowProds
            // 
            this.dataGridViewShowProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowProds.Location = new System.Drawing.Point(351, -2);
            this.dataGridViewShowProds.Name = "dataGridViewShowProds";
            this.dataGridViewShowProds.RowHeadersWidth = 62;
            this.dataGridViewShowProds.RowTemplate.Height = 28;
            this.dataGridViewShowProds.Size = new System.Drawing.Size(438, 454);
            this.dataGridViewShowProds.TabIndex = 4;
            // 
            // FormRemoveProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewShowProds);
            this.Name = "FormRemoveProd";
            this.Text = "FormRemoveProd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRemoveProd_FormClosed);
            this.Load += new System.EventHandler(this.FormRemoveProd_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBackCatsForm;
        private System.Windows.Forms.Button buttonShowCats;
        private System.Windows.Forms.Button buttonRemoveCats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectProd;
        public System.Windows.Forms.DataGridView dataGridViewShowProds;
    }
}