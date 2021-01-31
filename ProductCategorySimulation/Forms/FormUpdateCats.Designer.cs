
namespace ProductCategorySimulation
{
    partial class FormUpdateCats
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBackCatsForm = new System.Windows.Forms.Button();
            this.buttonUpdateCats = new System.Windows.Forms.Button();
            this.textBoxCatsInfo = new System.Windows.Forms.TextBox();
            this.textBoxCatsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelectCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowCats = new System.Windows.Forms.Button();
            this.dataGridViewShowCats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCats)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackCatsForm);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdateCats);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCatsInfo);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCatsName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxSelectCat);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonShowCats);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewShowCats);
            this.splitContainer1.Size = new System.Drawing.Size(950, 450);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBackCatsForm
            // 
            this.buttonBackCatsForm.Location = new System.Drawing.Point(43, 391);
            this.buttonBackCatsForm.Name = "buttonBackCatsForm";
            this.buttonBackCatsForm.Size = new System.Drawing.Size(195, 37);
            this.buttonBackCatsForm.TabIndex = 14;
            this.buttonBackCatsForm.Text = "Önceki Sayfaya Dön";
            this.buttonBackCatsForm.UseVisualStyleBackColor = true;
            this.buttonBackCatsForm.Click += new System.EventHandler(this.buttonBackCatsForm_Click);
            // 
            // buttonUpdateCats
            // 
            this.buttonUpdateCats.Enabled = false;
            this.buttonUpdateCats.Location = new System.Drawing.Point(43, 339);
            this.buttonUpdateCats.Name = "buttonUpdateCats";
            this.buttonUpdateCats.Size = new System.Drawing.Size(195, 37);
            this.buttonUpdateCats.TabIndex = 13;
            this.buttonUpdateCats.Text = "Kategorileri Güncelle";
            this.buttonUpdateCats.UseVisualStyleBackColor = true;
            this.buttonUpdateCats.Click += new System.EventHandler(this.buttonUpdateCats_Click);
            // 
            // textBoxCatsInfo
            // 
            this.textBoxCatsInfo.Location = new System.Drawing.Point(30, 293);
            this.textBoxCatsInfo.Name = "textBoxCatsInfo";
            this.textBoxCatsInfo.Size = new System.Drawing.Size(208, 26);
            this.textBoxCatsInfo.TabIndex = 12;
            // 
            // textBoxCatsName
            // 
            this.textBoxCatsName.Location = new System.Drawing.Point(30, 203);
            this.textBoxCatsName.Name = "textBoxCatsName";
            this.textBoxCatsName.Size = new System.Drawing.Size(208, 26);
            this.textBoxCatsName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kategori Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategori Bilgisi :";
            // 
            // comboBoxSelectCat
            // 
            this.comboBoxSelectCat.FormattingEnabled = true;
            this.comboBoxSelectCat.Location = new System.Drawing.Point(30, 118);
            this.comboBoxSelectCat.Name = "comboBoxSelectCat";
            this.comboBoxSelectCat.Size = new System.Drawing.Size(208, 28);
            this.comboBoxSelectCat.TabIndex = 8;
            this.comboBoxSelectCat.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectCat_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategoriler :";
            // 
            // buttonShowCats
            // 
            this.buttonShowCats.Location = new System.Drawing.Point(43, 22);
            this.buttonShowCats.Name = "buttonShowCats";
            this.buttonShowCats.Size = new System.Drawing.Size(195, 37);
            this.buttonShowCats.TabIndex = 6;
            this.buttonShowCats.Text = "Kategorileri Göster";
            this.buttonShowCats.UseVisualStyleBackColor = true;
            this.buttonShowCats.Click += new System.EventHandler(this.buttonShowCats_Click);
            // 
            // dataGridViewShowCats
            // 
            this.dataGridViewShowCats.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewShowCats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCats.Location = new System.Drawing.Point(4, 0);
            this.dataGridViewShowCats.Name = "dataGridViewShowCats";
            this.dataGridViewShowCats.RowHeadersWidth = 62;
            this.dataGridViewShowCats.RowTemplate.Height = 28;
            this.dataGridViewShowCats.Size = new System.Drawing.Size(605, 450);
            this.dataGridViewShowCats.TabIndex = 0;
            // 
            // FormUpdateCats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormUpdateCats";
            this.Text = "FormUpdateCats";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpdateCats_FormClosed);
            this.Load += new System.EventHandler(this.FormUpdateCats_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonShowCats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectCat;
        private System.Windows.Forms.TextBox textBoxCatsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBackCatsForm;
        private System.Windows.Forms.Button buttonUpdateCats;
        private System.Windows.Forms.TextBox textBoxCatsInfo;
        private System.Windows.Forms.DataGridView dataGridViewShowCats;
    }
}