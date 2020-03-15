namespace StockManager.WF
{
    partial class FormManageCategory
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonDelCategory = new System.Windows.Forms.Button();
            this.buttonModCatProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.Location = new System.Drawing.Point(213, 161);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Retour";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(12, 48);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(135, 45);
            this.buttonAddCategory.TabIndex = 1;
            this.buttonAddCategory.Text = "Ajouter une catégorie";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonDelCategory
            // 
            this.buttonDelCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDelCategory.Location = new System.Drawing.Point(153, 48);
            this.buttonDelCategory.Name = "buttonDelCategory";
            this.buttonDelCategory.Size = new System.Drawing.Size(135, 45);
            this.buttonDelCategory.TabIndex = 2;
            this.buttonDelCategory.Text = "Supprimer une catégorie";
            this.buttonDelCategory.UseVisualStyleBackColor = true;
            this.buttonDelCategory.Click += new System.EventHandler(this.buttonDelCategory_Click);
            // 
            // buttonModCatProd
            // 
            this.buttonModCatProd.Location = new System.Drawing.Point(80, 99);
            this.buttonModCatProd.Name = "buttonModCatProd";
            this.buttonModCatProd.Size = new System.Drawing.Size(135, 45);
            this.buttonModCatProd.TabIndex = 3;
            this.buttonModCatProd.Text = "Modifier une catégorie";
            this.buttonModCatProd.UseVisualStyleBackColor = true;
            this.buttonModCatProd.Click += new System.EventHandler(this.buttonModCatProd_Click);
            // 
            // FormManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 196);
            this.Controls.Add(this.buttonModCatProd);
            this.Controls.Add(this.buttonDelCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.buttonReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 235);
            this.Name = "FormManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des Catégories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonDelCategory;
        private System.Windows.Forms.Button buttonModCatProd;
    }
}