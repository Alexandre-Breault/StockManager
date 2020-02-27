namespace StockManager.WF
{
    partial class FormDelCategory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelCategory = new System.Windows.Forms.Button();
            this.textBoxDelCategory = new System.Windows.Forms.TextBox();
            this.labelDelCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(713, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Retour";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelCategory
            // 
            this.buttonDelCategory.Location = new System.Drawing.Point(452, 186);
            this.buttonDelCategory.Name = "buttonDelCategory";
            this.buttonDelCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonDelCategory.TabIndex = 2;
            this.buttonDelCategory.Text = "Supprimer";
            this.buttonDelCategory.UseVisualStyleBackColor = true;
            this.buttonDelCategory.Click += new System.EventHandler(this.buttonDelCategory_Click);
            // 
            // textBoxDelCategory
            // 
            this.textBoxDelCategory.Location = new System.Drawing.Point(426, 160);
            this.textBoxDelCategory.Name = "textBoxDelCategory";
            this.textBoxDelCategory.Size = new System.Drawing.Size(138, 20);
            this.textBoxDelCategory.TabIndex = 3;
            // 
            // labelDelCategory
            // 
            this.labelDelCategory.AutoSize = true;
            this.labelDelCategory.Location = new System.Drawing.Point(261, 163);
            this.labelDelCategory.Name = "labelDelCategory";
            this.labelDelCategory.Size = new System.Drawing.Size(159, 13);
            this.labelDelCategory.TabIndex = 4;
            this.labelDelCategory.Text = "Nom de la catégorie à supprimer";
            // 
            // FormDelCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDelCategory);
            this.Controls.Add(this.textBoxDelCategory);
            this.Controls.Add(this.buttonDelCategory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDelCategory";
            this.Text = "FormDelCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelCategory;
        private System.Windows.Forms.TextBox textBoxDelCategory;
        private System.Windows.Forms.Label labelDelCategory;
    }
}