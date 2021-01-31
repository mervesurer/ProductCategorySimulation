
namespace ProductCategorySimulation.Forms
{
    partial class FormShowProducts
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
            this.dataGridViewShowProducts = new System.Windows.Forms.DataGridView();
            this.buttonBackMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowProducts
            // 
            this.dataGridViewShowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowProducts.Location = new System.Drawing.Point(-1, 0);
            this.dataGridViewShowProducts.Name = "dataGridViewShowProducts";
            this.dataGridViewShowProducts.RowHeadersWidth = 62;
            this.dataGridViewShowProducts.RowTemplate.Height = 28;
            this.dataGridViewShowProducts.Size = new System.Drawing.Size(801, 447);
            this.dataGridViewShowProducts.TabIndex = 0;
            // 
            // buttonBackMainForm
            // 
            this.buttonBackMainForm.Location = new System.Drawing.Point(562, 351);
            this.buttonBackMainForm.Name = "buttonBackMainForm";
            this.buttonBackMainForm.Size = new System.Drawing.Size(238, 71);
            this.buttonBackMainForm.TabIndex = 6;
            this.buttonBackMainForm.Text = "Önceki Sayfaya Dön";
            this.buttonBackMainForm.UseVisualStyleBackColor = true;
            this.buttonBackMainForm.Click += new System.EventHandler(this.buttonBackMainForm_Click);
            // 
            // FormShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackMainForm);
            this.Controls.Add(this.dataGridViewShowProducts);
            this.Name = "FormShowProducts";
            this.Text = "FormShowProducts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShowProducts_FormClosed);
            this.Load += new System.EventHandler(this.FormShowProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowProducts;
        public System.Windows.Forms.Button buttonBackMainForm;
    }
}