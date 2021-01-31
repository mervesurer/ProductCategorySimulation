
namespace ProductCategorySimulation
{
    partial class FormRemoveCats
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
            this.buttonRemoveCats = new System.Windows.Forms.Button();
            this.comboBoxSelectCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowCats = new System.Windows.Forms.Button();
            this.dataGridViewShowCats = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCats)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonBackCatsForm);
            this.panel2.Controls.Add(this.buttonShowCats);
            this.panel2.Controls.Add(this.buttonRemoveCats);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxSelectCat);
            this.panel2.Location = new System.Drawing.Point(22, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 318);
            this.panel2.TabIndex = 1;
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
            // buttonRemoveCats
            // 
            this.buttonRemoveCats.Location = new System.Drawing.Point(16, 190);
            this.buttonRemoveCats.Name = "buttonRemoveCats";
            this.buttonRemoveCats.Size = new System.Drawing.Size(195, 37);
            this.buttonRemoveCats.TabIndex = 22;
            this.buttonRemoveCats.Text = "Kategorileri Sil";
            this.buttonRemoveCats.UseVisualStyleBackColor = true;
            this.buttonRemoveCats.Click += new System.EventHandler(this.buttonRemoveCats_Click);
            // 
            // comboBoxSelectCat
            // 
            this.comboBoxSelectCat.FormattingEnabled = true;
            this.comboBoxSelectCat.Location = new System.Drawing.Point(16, 114);
            this.comboBoxSelectCat.Name = "comboBoxSelectCat";
            this.comboBoxSelectCat.Size = new System.Drawing.Size(208, 28);
            this.comboBoxSelectCat.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kategoriler :";
            // 
            // buttonShowCats
            // 
            this.buttonShowCats.Location = new System.Drawing.Point(16, 16);
            this.buttonShowCats.Name = "buttonShowCats";
            this.buttonShowCats.Size = new System.Drawing.Size(195, 37);
            this.buttonShowCats.TabIndex = 15;
            this.buttonShowCats.Text = "Kategorileri Göster";
            this.buttonShowCats.UseVisualStyleBackColor = true;
            this.buttonShowCats.Click += new System.EventHandler(this.buttonShowCats_Click);
            // 
            // dataGridViewShowCats
            // 
            this.dataGridViewShowCats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCats.Location = new System.Drawing.Point(362, 1);
            this.dataGridViewShowCats.Name = "dataGridViewShowCats";
            this.dataGridViewShowCats.RowHeadersWidth = 62;
            this.dataGridViewShowCats.RowTemplate.Height = 28;
            this.dataGridViewShowCats.Size = new System.Drawing.Size(438, 454);
            this.dataGridViewShowCats.TabIndex = 2;
            // 
            // FormRemoveCats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewShowCats);
            this.Controls.Add(this.panel2);
            this.Name = "FormRemoveCats";
            this.Text = "Kategori Silme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRemoveCats_FormClosed);
            this.Load += new System.EventHandler(this.FormRemoveCats_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBackCatsForm;
        private System.Windows.Forms.Button buttonShowCats;
        private System.Windows.Forms.Button buttonRemoveCats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectCat;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridViewShowCats;
    }
}