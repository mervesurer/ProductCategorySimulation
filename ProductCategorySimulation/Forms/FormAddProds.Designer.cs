
namespace ProductCategorySimulation
{
    partial class FormAddProds
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
            this.buttonShowProds = new System.Windows.Forms.Button();
            this.buttonBackToFrom = new System.Windows.Forms.Button();
            this.buttonAddProds = new System.Windows.Forms.Button();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.comboBoxShowCats = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProdRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProdImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProdPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProdInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewShowProds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowProds)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonShowProds);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackToFrom);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddProds);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProdName);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxShowCats);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProdRating);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProdImage);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProdPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProdInfo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewShowProds);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonShowProds
            // 
            this.buttonShowProds.Location = new System.Drawing.Point(74, 12);
            this.buttonShowProds.Name = "buttonShowProds";
            this.buttonShowProds.Size = new System.Drawing.Size(156, 39);
            this.buttonShowProds.TabIndex = 24;
            this.buttonShowProds.Text = "Ürünleri Göster";
            this.buttonShowProds.UseVisualStyleBackColor = true;
            this.buttonShowProds.Click += new System.EventHandler(this.buttonShowProds_Click_1);
            // 
            // buttonBackToFrom
            // 
            this.buttonBackToFrom.Location = new System.Drawing.Point(128, 386);
            this.buttonBackToFrom.Name = "buttonBackToFrom";
            this.buttonBackToFrom.Size = new System.Drawing.Size(156, 61);
            this.buttonBackToFrom.TabIndex = 23;
            this.buttonBackToFrom.Text = "Önceki Sayfaya Dön";
            this.buttonBackToFrom.UseVisualStyleBackColor = true;
            this.buttonBackToFrom.Click += new System.EventHandler(this.buttonBackToFrom_Click);
            // 
            // buttonAddProds
            // 
            this.buttonAddProds.Location = new System.Drawing.Point(3, 386);
            this.buttonAddProds.Name = "buttonAddProds";
            this.buttonAddProds.Size = new System.Drawing.Size(119, 61);
            this.buttonAddProds.TabIndex = 22;
            this.buttonAddProds.Text = "Ürünleri Ekle";
            this.buttonAddProds.UseVisualStyleBackColor = true;
            this.buttonAddProds.Click += new System.EventHandler(this.buttonAddProds_Click);
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(128, 57);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(156, 26);
            this.textBoxProdName.TabIndex = 20;
            // 
            // comboBoxShowCats
            // 
            this.comboBoxShowCats.FormattingEnabled = true;
            this.comboBoxShowCats.Location = new System.Drawing.Point(128, 352);
            this.comboBoxShowCats.Name = "comboBoxShowCats";
            this.comboBoxShowCats.Size = new System.Drawing.Size(156, 28);
            this.comboBoxShowCats.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kategorisi :";
            // 
            // textBoxProdRating
            // 
            this.textBoxProdRating.Location = new System.Drawing.Point(128, 317);
            this.textBoxProdRating.Name = "textBoxProdRating";
            this.textBoxProdRating.Size = new System.Drawing.Size(156, 26);
            this.textBoxProdRating.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ürünün Puanı :";
            // 
            // textBoxProdImage
            // 
            this.textBoxProdImage.Location = new System.Drawing.Point(128, 104);
            this.textBoxProdImage.Name = "textBoxProdImage";
            this.textBoxProdImage.Size = new System.Drawing.Size(156, 26);
            this.textBoxProdImage.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ürünün Resmi :";
            // 
            // textBoxProdPrice
            // 
            this.textBoxProdPrice.Location = new System.Drawing.Point(128, 151);
            this.textBoxProdPrice.Name = "textBoxProdPrice";
            this.textBoxProdPrice.Size = new System.Drawing.Size(156, 26);
            this.textBoxProdPrice.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürünün Fiyatı :";
            // 
            // textBoxProdInfo
            // 
            this.textBoxProdInfo.Location = new System.Drawing.Point(128, 198);
            this.textBoxProdInfo.Multiline = true;
            this.textBoxProdInfo.Name = "textBoxProdInfo";
            this.textBoxProdInfo.Size = new System.Drawing.Size(156, 92);
            this.textBoxProdInfo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Bilgisi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürünün Adı :";
            // 
            // dataGridViewShowProds
            // 
            this.dataGridViewShowProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowProds.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewShowProds.Name = "dataGridViewShowProds";
            this.dataGridViewShowProds.RowHeadersWidth = 62;
            this.dataGridViewShowProds.RowTemplate.Height = 28;
            this.dataGridViewShowProds.Size = new System.Drawing.Size(500, 444);
            this.dataGridViewShowProds.TabIndex = 0;
            // 
            // FormAddProds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAddProds";
            this.Text = "FormAddProds";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddProds_FormClosed);
            this.Load += new System.EventHandler(this.FormAddProds_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewShowProds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProdImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProdPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProdInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProdRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxShowCats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.Button buttonAddProds;
        private System.Windows.Forms.Button buttonBackToFrom;
        private System.Windows.Forms.Button buttonShowProds;
    }
}