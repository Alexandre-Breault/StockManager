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
            this.buttonAddCategoryProduct = new System.Windows.Forms.Button();
            this.buttonDelCategoryProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(664, 399);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Retour";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(90, 70);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(131, 23);
            this.buttonAddCategory.TabIndex = 1;
            this.buttonAddCategory.Text = "Ajouter une catégorie";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonDelCategory
            // 
            this.buttonDelCategory.Location = new System.Drawing.Point(90, 134);
            this.buttonDelCategory.Name = "buttonDelCategory";
            this.buttonDelCategory.Size = new System.Drawing.Size(131, 23);
            this.buttonDelCategory.TabIndex = 2;
            this.buttonDelCategory.Text = "Supprimer une catégorie";
            this.buttonDelCategory.UseVisualStyleBackColor = true;
            this.buttonDelCategory.Click += new System.EventHandler(this.buttonDelCategory_Click);
            // 
            // buttonAddCategoryProduct
            // 
            this.buttonAddCategoryProduct.Location = new System.Drawing.Point(90, 201);
            this.buttonAddCategoryProduct.Name = "buttonAddCategoryProduct";
            this.buttonAddCategoryProduct.Size = new System.Drawing.Size(131, 34);
            this.buttonAddCategoryProduct.TabIndex = 3;
            this.buttonAddCategoryProduct.Text = "Ajouter une catégorie à un produit";
            this.buttonAddCategoryProduct.UseVisualStyleBackColor = true;
            // 
            // buttonDelCategoryProduct
            // 
            this.buttonDelCategoryProduct.Location = new System.Drawing.Point(90, 274);
            this.buttonDelCategoryProduct.Name = "buttonDelCategoryProduct";
            this.buttonDelCategoryProduct.Size = new System.Drawing.Size(131, 34);
            this.buttonDelCategoryProduct.TabIndex = 5;
            this.buttonDelCategoryProduct.Text = "Modifier une catégorie à un produit";
            this.buttonDelCategoryProduct.UseVisualStyleBackColor = true;
            // 
            // FormManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelCategoryProduct);
            this.Controls.Add(this.buttonAddCategoryProduct);
            this.Controls.Add(this.buttonDelCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.buttonReturn);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormManageCategory";
            this.Text = "Gestion des Catégories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonDelCategory;
        private System.Windows.Forms.Button buttonAddCategoryProduct;
        private System.Windows.Forms.Button buttonDelCategoryProduct;
    }
}