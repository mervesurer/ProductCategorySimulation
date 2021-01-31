
namespace ProductCategorySimulation.Services
{
    partial class FormShowCategories
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
            this.dataGridViewShowCategories = new System.Windows.Forms.DataGridView();
            this.buttonBackMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowCategories
            // 
            this.dataGridViewShowCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCategories.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewShowCategories.Name = "dataGridViewShowCategories";
            this.dataGridViewShowCategories.RowHeadersWidth = 62;
            this.dataGridViewShowCategories.RowTemplate.Height = 28;
            this.dataGridViewShowCategories.Size = new System.Drawing.Size(801, 450);
            this.dataGridViewShowCategories.TabIndex = 0;
            // 
            // buttonBackMainForm
            // 
            this.buttonBackMainForm.Location = new System.Drawing.Point(565, 379);
            this.buttonBackMainForm.Name = "buttonBackMainForm";
            this.buttonBackMainForm.Size = new System.Drawing.Size(238, 71);
            this.buttonBackMainForm.TabIndex = 5;
            this.buttonBackMainForm.Text = "Önceki Sayfaya Dön";
            this.buttonBackMainForm.UseVisualStyleBackColor = true;
            this.buttonBackMainForm.Click += new System.EventHandler(this.buttonBackMainForm_Click);
            // 
            // FormShowCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackMainForm);
            this.Controls.Add(this.dataGridViewShowCategories);
            this.Name = "FormShowCategories";
            this.Text = "FormShowCategories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShowCategories_FormClosed);
            this.Load += new System.EventHandler(this.FormShowCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowCategories;
        public System.Windows.Forms.Button buttonBackMainForm;
    }
}