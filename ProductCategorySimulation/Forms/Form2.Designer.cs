
namespace ProductCategorySimulation
{
    partial class Form2
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
            this.buttonAddCat = new System.Windows.Forms.Button();
            this.buttonUpdateCat = new System.Windows.Forms.Button();
            this.buttonRemoveCat = new System.Windows.Forms.Button();
            this.buttonBackMainForm = new System.Windows.Forms.Button();
            this.buttonShowCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.Location = new System.Drawing.Point(282, 131);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(234, 61);
            this.buttonAddCat.TabIndex = 1;
            this.buttonAddCat.Text = "Kategori eklemek için tıkla";
            this.buttonAddCat.UseVisualStyleBackColor = true;
            this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
            // 
            // buttonUpdateCat
            // 
            this.buttonUpdateCat.Location = new System.Drawing.Point(282, 217);
            this.buttonUpdateCat.Name = "buttonUpdateCat";
            this.buttonUpdateCat.Size = new System.Drawing.Size(234, 61);
            this.buttonUpdateCat.TabIndex = 2;
            this.buttonUpdateCat.Text = "Kategori güncellemek için tıkla";
            this.buttonUpdateCat.UseVisualStyleBackColor = true;
            this.buttonUpdateCat.Click += new System.EventHandler(this.buttonUpdateCat_Click);
            // 
            // buttonRemoveCat
            // 
            this.buttonRemoveCat.Location = new System.Drawing.Point(282, 310);
            this.buttonRemoveCat.Name = "buttonRemoveCat";
            this.buttonRemoveCat.Size = new System.Drawing.Size(234, 61);
            this.buttonRemoveCat.TabIndex = 3;
            this.buttonRemoveCat.Text = "Kategori silmek için tıkla";
            this.buttonRemoveCat.UseVisualStyleBackColor = true;
            this.buttonRemoveCat.Click += new System.EventHandler(this.buttonRemoveCat_Click);
            // 
            // buttonBackMainForm
            // 
            this.buttonBackMainForm.Location = new System.Drawing.Point(535, 378);
            this.buttonBackMainForm.Name = "buttonBackMainForm";
            this.buttonBackMainForm.Size = new System.Drawing.Size(229, 48);
            this.buttonBackMainForm.TabIndex = 4;
            this.buttonBackMainForm.Text = "Anasayfaya dön";
            this.buttonBackMainForm.UseVisualStyleBackColor = true;
            this.buttonBackMainForm.Click += new System.EventHandler(this.buttonBackForm1_Click);
            // 
            // buttonShowCategories
            // 
            this.buttonShowCategories.Location = new System.Drawing.Point(282, 44);
            this.buttonShowCategories.Name = "buttonShowCategories";
            this.buttonShowCategories.Size = new System.Drawing.Size(234, 61);
            this.buttonShowCategories.TabIndex = 5;
            this.buttonShowCategories.Text = "Kategorileri görmek için tıkla";
            this.buttonShowCategories.UseVisualStyleBackColor = true;
            this.buttonShowCategories.Click += new System.EventHandler(this.buttonShowCategories_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowCategories);
            this.Controls.Add(this.buttonBackMainForm);
            this.Controls.Add(this.buttonRemoveCat);
            this.Controls.Add(this.buttonUpdateCat);
            this.Controls.Add(this.buttonAddCat);
            this.Name = "Form2";
            this.Text = "Kategori Menüsü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonAddCat;
        public System.Windows.Forms.Button buttonUpdateCat;
        public System.Windows.Forms.Button buttonRemoveCat;
        public System.Windows.Forms.Button buttonBackMainForm;
        public System.Windows.Forms.Button buttonShowCategories;
    }
}