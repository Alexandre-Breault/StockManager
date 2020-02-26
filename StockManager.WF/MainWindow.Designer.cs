namespace StockManager.WF
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonManageCategory = new System.Windows.Forms.Button();
            this.buttonManageExitStock = new System.Windows.Forms.Button();
            this.buttonManageEntryStock = new System.Windows.Forms.Button();
            this.buttonManageProduct = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageCategory
            // 
            this.buttonManageCategory.Location = new System.Drawing.Point(42, 61);
            this.buttonManageCategory.Name = "buttonManageCategory";
            this.buttonManageCategory.Size = new System.Drawing.Size(203, 23);
            this.buttonManageCategory.TabIndex = 0;
            this.buttonManageCategory.Text = "Gestion Catégories";
            this.buttonManageCategory.UseVisualStyleBackColor = true;
            this.buttonManageCategory.Click += new System.EventHandler(this.buttonManageCategory_Click);
            // 
            // buttonManageExitStock
            // 
            this.buttonManageExitStock.Location = new System.Drawing.Point(42, 184);
            this.buttonManageExitStock.Name = "buttonManageExitStock";
            this.buttonManageExitStock.Size = new System.Drawing.Size(203, 23);
            this.buttonManageExitStock.TabIndex = 1;
            this.buttonManageExitStock.Text = "Gestion sorties stock";
            this.buttonManageExitStock.UseVisualStyleBackColor = true;
            this.buttonManageExitStock.Click += new System.EventHandler(this.buttonManageExitStock_Click);
            // 
            // buttonManageEntryStock
            // 
            this.buttonManageEntryStock.Location = new System.Drawing.Point(42, 144);
            this.buttonManageEntryStock.Name = "buttonManageEntryStock";
            this.buttonManageEntryStock.Size = new System.Drawing.Size(203, 23);
            this.buttonManageEntryStock.TabIndex = 2;
            this.buttonManageEntryStock.Text = "Gestion entrées stocks";
            this.buttonManageEntryStock.UseVisualStyleBackColor = true;
            this.buttonManageEntryStock.Click += new System.EventHandler(this.buttonManageEntryStock_Click);
            // 
            // buttonManageProduct
            // 
            this.buttonManageProduct.Location = new System.Drawing.Point(42, 105);
            this.buttonManageProduct.Name = "buttonManageProduct";
            this.buttonManageProduct.Size = new System.Drawing.Size(203, 23);
            this.buttonManageProduct.TabIndex = 3;
            this.buttonManageProduct.Text = "Gestion Produits";
            this.buttonManageProduct.UseVisualStyleBackColor = true;
            this.buttonManageProduct.Click += new System.EventHandler(this.buttonManageProduct_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(713, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Quitter";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonManageProduct);
            this.Controls.Add(this.buttonManageEntryStock);
            this.Controls.Add(this.buttonManageExitStock);
            this.Controls.Add(this.buttonManageCategory);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainWindow";
            this.Text = "StockManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCategory;
        private System.Windows.Forms.Button buttonManageExitStock;
        private System.Windows.Forms.Button buttonManageEntryStock;
        private System.Windows.Forms.Button buttonManageProduct;
        private System.Windows.Forms.Button buttonClose;
    }
}

