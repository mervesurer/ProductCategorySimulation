
namespace ProductCategorySimulation
{
    partial class Form3
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
            this.buttonBackMainForm = new System.Windows.Forms.Button();
            this.buttonRemoveProds = new System.Windows.Forms.Button();
            this.buttonUpdateProds = new System.Windows.Forms.Button();
            this.buttonAddProds = new System.Windows.Forms.Button();
            this.buttonShowProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackMainForm
            // 
            this.buttonBackMainForm.Location = new System.Drawing.Point(517, 376);
            this.buttonBackMainForm.Name = "buttonBackMainForm";
            this.buttonBackMainForm.Size = new System.Drawing.Size(229, 48);
            this.buttonBackMainForm.TabIndex = 8;
            this.buttonBackMainForm.Text = "Anasayfaya dön";
            this.buttonBackMainForm.UseVisualStyleBackColor = true;
            this.buttonBackMainForm.Click += new System.EventHandler(this.buttonBackMainForm_Click);
            // 
            // buttonRemoveProds
            // 
            this.buttonRemoveProds.Location = new System.Drawing.Point(264, 302);
            this.buttonRemoveProds.Name = "buttonRemoveProds";
            this.buttonRemoveProds.Size = new System.Drawing.Size(234, 61);
            this.buttonRemoveProds.TabIndex = 7;
            this.buttonRemoveProds.Text = "Ürün silmek için tıkla";
            this.buttonRemoveProds.UseVisualStyleBackColor = true;
            this.buttonRemoveProds.Click += new System.EventHandler(this.buttonRemoveProds_Click);
            // 
            // buttonUpdateProds
            // 
            this.buttonUpdateProds.Location = new System.Drawing.Point(264, 207);
            this.buttonUpdateProds.Name = "buttonUpdateProds";
            this.buttonUpdateProds.Size = new System.Drawing.Size(234, 61);
            this.buttonUpdateProds.TabIndex = 6;
            this.buttonUpdateProds.Text = "Ürün güncellemek için tıkla";
            this.buttonUpdateProds.UseVisualStyleBackColor = true;
            this.buttonUpdateProds.Click += new System.EventHandler(this.buttonUpdateProds_Click);
            // 
            // buttonAddProds
            // 
            this.buttonAddProds.Location = new System.Drawing.Point(264, 118);
            this.buttonAddProds.Name = "buttonAddProds";
            this.buttonAddProds.Size = new System.Drawing.Size(234, 61);
            this.buttonAddProds.TabIndex = 5;
            this.buttonAddProds.Text = "Ürün eklemek için tıkla";
            this.buttonAddProds.UseVisualStyleBackColor = true;
            this.buttonAddProds.Click += new System.EventHandler(this.buttonAddProds_Click);
            // 
            // buttonShowProducts
            // 
            this.buttonShowProducts.Location = new System.Drawing.Point(264, 32);
            this.buttonShowProducts.Name = "buttonShowProducts";
            this.buttonShowProducts.Size = new System.Drawing.Size(234, 61);
            this.buttonShowProducts.TabIndex = 9;
            this.buttonShowProducts.Text = "Ürünleri görmek için tıkla";
            this.buttonShowProducts.UseVisualStyleBackColor = true;
            this.buttonShowProducts.Click += new System.EventHandler(this.buttonShowProducts_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowProducts);
            this.Controls.Add(this.buttonBackMainForm);
            this.Controls.Add(this.buttonRemoveProds);
            this.Controls.Add(this.buttonUpdateProds);
            this.Controls.Add(this.buttonAddProds);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonBackMainForm;
        public System.Windows.Forms.Button buttonRemoveProds;
        public System.Windows.Forms.Button buttonUpdateProds;
        public System.Windows.Forms.Button buttonAddProds;
        public System.Windows.Forms.Button buttonShowProducts;
    }
}