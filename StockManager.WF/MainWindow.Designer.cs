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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonManageCategory = new System.Windows.Forms.Button();
            this.buttonManageExitStock = new System.Windows.Forms.Button();
            this.buttonManageEntryStock = new System.Windows.Forms.Button();
            this.buttonManageProduct = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonManageCategory
            // 
            this.buttonManageCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonManageCategory.Location = new System.Drawing.Point(241, 64);
            this.buttonManageCategory.Name = "buttonManageCategory";
            this.buttonManageCategory.Size = new System.Drawing.Size(210, 40);
            this.buttonManageCategory.TabIndex = 0;
            this.buttonManageCategory.Text = "Gestion Catégories";
            this.buttonManageCategory.UseVisualStyleBackColor = true;
            this.buttonManageCategory.Click += new System.EventHandler(this.buttonManageCategory_Click);
            this.buttonManageCategory.MouseEnter += new System.EventHandler(this.buttonManageCategory_MouseEnter);
            this.buttonManageCategory.MouseLeave += new System.EventHandler(this.buttonManageCategory_MouseLeave);
            // 
            // buttonManageExitStock
            // 
            this.buttonManageExitStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonManageExitStock.Location = new System.Drawing.Point(241, 274);
            this.buttonManageExitStock.Name = "buttonManageExitStock";
            this.buttonManageExitStock.Size = new System.Drawing.Size(210, 40);
            this.buttonManageExitStock.TabIndex = 1;
            this.buttonManageExitStock.Text = "Gestion sorties stocks";
            this.buttonManageExitStock.UseVisualStyleBackColor = true;
            this.buttonManageExitStock.Click += new System.EventHandler(this.buttonManageExitStock_Click);
            this.buttonManageExitStock.MouseEnter += new System.EventHandler(this.buttonManageExitStock_MouseEnter);
            this.buttonManageExitStock.MouseLeave += new System.EventHandler(this.buttonManageExitStock_MouseLeave);
            // 
            // buttonManageEntryStock
            // 
            this.buttonManageEntryStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonManageEntryStock.Location = new System.Drawing.Point(241, 204);
            this.buttonManageEntryStock.Name = "buttonManageEntryStock";
            this.buttonManageEntryStock.Size = new System.Drawing.Size(210, 40);
            this.buttonManageEntryStock.TabIndex = 2;
            this.buttonManageEntryStock.Text = "Gestion entrées stocks";
            this.buttonManageEntryStock.UseVisualStyleBackColor = true;
            this.buttonManageEntryStock.Click += new System.EventHandler(this.buttonManageEntryStock_Click);
            this.buttonManageEntryStock.MouseEnter += new System.EventHandler(this.buttonManageEntryStock_MouseEnter);
            this.buttonManageEntryStock.MouseLeave += new System.EventHandler(this.buttonManageEntryStock_MouseLeave);
            // 
            // buttonManageProduct
            // 
            this.buttonManageProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonManageProduct.Location = new System.Drawing.Point(241, 134);
            this.buttonManageProduct.Name = "buttonManageProduct";
            this.buttonManageProduct.Size = new System.Drawing.Size(210, 40);
            this.buttonManageProduct.TabIndex = 3;
            this.buttonManageProduct.Text = "Gestion Produits";
            this.buttonManageProduct.UseVisualStyleBackColor = true;
            this.buttonManageProduct.Click += new System.EventHandler(this.buttonManageProduct_Click);
            this.buttonManageProduct.MouseEnter += new System.EventHandler(this.buttonManageProduct_MouseEnter);
            this.buttonManageProduct.MouseLeave += new System.EventHandler(this.buttonManageProduct_MouseLeave);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(607, 306);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Quitter";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMain
            // 
            this.labelMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(49, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(602, 25);
            this.labelMain.TabIndex = 5;
            this.labelMain.Text = "Bienvenue sur le logiciel StockManager pour générer votre stockage";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(694, 341);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonManageProduct);
            this.Controls.Add(this.buttonManageEntryStock);
            this.Controls.Add(this.buttonManageExitStock);
            this.Controls.Add(this.buttonManageCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 380);
            this.MinimumSize = new System.Drawing.Size(710, 380);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCategory;
        private System.Windows.Forms.Button buttonManageExitStock;
        private System.Windows.Forms.Button buttonManageEntryStock;
        private System.Windows.Forms.Button buttonManageProduct;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMain;
    }
}

