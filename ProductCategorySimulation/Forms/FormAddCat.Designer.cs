
namespace ProductCategorySimulation
{
    partial class FormAddCat
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowCats = new System.Windows.Forms.Button();
            this.buttonAddCat = new System.Windows.Forms.Button();
            this.textBoxCatDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewShowCats = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBackCatsForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(131, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(264, 11);
            this.textBoxCatName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(313, 26);
            this.textBoxCatName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonShowCats);
            this.panel1.Controls.Add(this.buttonAddCat);
            this.panel1.Controls.Add(this.textBoxCatDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCatName);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 208);
            this.panel1.TabIndex = 2;
            // 
            // buttonShowCats
            // 
            this.buttonShowCats.Location = new System.Drawing.Point(35, 154);
            this.buttonShowCats.Name = "buttonShowCats";
            this.buttonShowCats.Size = new System.Drawing.Size(258, 39);
            this.buttonShowCats.TabIndex = 5;
            this.buttonShowCats.Text = "Kategorileri Göster";
            this.buttonShowCats.UseVisualStyleBackColor = true;
            this.buttonShowCats.Click += new System.EventHandler(this.buttonShowCats_Click);
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.Location = new System.Drawing.Point(441, 154);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(258, 39);
            this.buttonAddCat.TabIndex = 4;
            this.buttonAddCat.Text = "Kategori Ekle";
            this.buttonAddCat.UseVisualStyleBackColor = true;
            this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
            // 
            // textBoxCatDescription
            // 
            this.textBoxCatDescription.Location = new System.Drawing.Point(264, 55);
            this.textBoxCatDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCatDescription.Multiline = true;
            this.textBoxCatDescription.Name = "textBoxCatDescription";
            this.textBoxCatDescription.Size = new System.Drawing.Size(313, 82);
            this.textBoxCatDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(157, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Açıklama :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewShowCats
            // 
            this.dataGridViewShowCats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCats.Location = new System.Drawing.Point(27, 274);
            this.dataGridViewShowCats.Name = "dataGridViewShowCats";
            this.dataGridViewShowCats.RowHeadersWidth = 62;
            this.dataGridViewShowCats.RowTemplate.Height = 28;
            this.dataGridViewShowCats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewShowCats.Size = new System.Drawing.Size(588, 145);
            this.dataGridViewShowCats.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(23, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategoriler  :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBackCatsForm
            // 
            this.buttonBackCatsForm.Location = new System.Drawing.Point(646, 321);
            this.buttonBackCatsForm.Name = "buttonBackCatsForm";
            this.buttonBackCatsForm.Size = new System.Drawing.Size(131, 98);
            this.buttonBackCatsForm.TabIndex = 6;
            this.buttonBackCatsForm.Text = "Önceki sayfaya dön";
            this.buttonBackCatsForm.UseVisualStyleBackColor = true;
            this.buttonBackCatsForm.Click += new System.EventHandler(this.buttonBackCatsForm_Click);
            // 
            // FormAddCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackCatsForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewShowCats);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddCat";
            this.Text = "Kategori ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddCat_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCatName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCatDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddCat;
        private System.Windows.Forms.DataGridView dataGridViewShowCats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowCats;
        public System.Windows.Forms.Button buttonBackCatsForm;
    }
}