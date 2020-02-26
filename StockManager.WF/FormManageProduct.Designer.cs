namespace StockManager.WF
{
    partial class FormManageProduct
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
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDelProduct = new System.Windows.Forms.Button();
            this.buttonCloseManageProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(124, 176);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(249, 100);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Ajouter un produit";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonDelProduct
            // 
            this.buttonDelProduct.Location = new System.Drawing.Point(401, 176);
            this.buttonDelProduct.Name = "buttonDelProduct";
            this.buttonDelProduct.Size = new System.Drawing.Size(243, 100);
            this.buttonDelProduct.TabIndex = 1;
            this.buttonDelProduct.Text = "Supprimer un produit";
            this.buttonDelProduct.UseVisualStyleBackColor = true;
            // 
            // buttonCloseManageProduct
            // 
            this.buttonCloseManageProduct.Location = new System.Drawing.Point(711, 413);
            this.buttonCloseManageProduct.Name = "buttonCloseManageProduct";
            this.buttonCloseManageProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseManageProduct.TabIndex = 2;
            this.buttonCloseManageProduct.Text = "Retour";
            this.buttonCloseManageProduct.UseVisualStyleBackColor = true;
            this.buttonCloseManageProduct.Click += new System.EventHandler(this.buttonCloseManageProduct_Click_1);
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseManageProduct);
            this.Controls.Add(this.buttonDelProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormManageProduct";
            this.Text = "Gestion des produits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDelProduct;
        private System.Windows.Forms.Button buttonCloseManageProduct;
    }
}