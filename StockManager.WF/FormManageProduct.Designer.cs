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
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 81);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(135, 45);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Ajouter un produit";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDelProduct
            // 
            this.buttonDelProduct.Location = new System.Drawing.Point(153, 81);
            this.buttonDelProduct.Name = "buttonDelProduct";
            this.buttonDelProduct.Size = new System.Drawing.Size(135, 45);
            this.buttonDelProduct.TabIndex = 1;
            this.buttonDelProduct.Text = "Supprimer un produit";
            this.buttonDelProduct.UseVisualStyleBackColor = true;
            this.buttonDelProduct.Click += new System.EventHandler(this.buttonDelProduct_Click);
            // 
            // buttonCloseManageProduct
            // 
            this.buttonCloseManageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseManageProduct.Location = new System.Drawing.Point(207, 155);
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
            this.ClientSize = new System.Drawing.Size(300, 196);
            this.Controls.Add(this.buttonCloseManageProduct);
            this.Controls.Add(this.buttonDelProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 235);
            this.Name = "FormManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des produits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDelProduct;
        private System.Windows.Forms.Button buttonCloseManageProduct;
    }
}