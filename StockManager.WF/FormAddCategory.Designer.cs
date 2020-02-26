namespace StockManager.WF
{
    partial class FormAddCategory
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
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(420, 188);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCategory.TabIndex = 0;
            this.buttonAddCategory.Text = "Ajouter";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(12, 12);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(251, 420);
            this.listBoxCategory.TabIndex = 1;
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Location = new System.Drawing.Point(393, 162);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(133, 20);
            this.textBoxAddCategory.TabIndex = 2;
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(285, 162);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(102, 13);
            this.labelAddCategory.TabIndex = 3;
            this.labelAddCategory.Text = "Nom de la catégorie";
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAddCategory);
            this.Controls.Add(this.textBoxAddCategory);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Name = "FormAddCategory";
            this.Text = "Ajouter une catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Label labelAddCategory;
    }
}