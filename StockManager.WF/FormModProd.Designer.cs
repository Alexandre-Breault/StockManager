namespace StockManager.WF
{
    partial class FormModProd
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
            this.buttonCloseProduct = new System.Windows.Forms.Button();
            this.comboBoxCatProd = new System.Windows.Forms.ComboBox();
            this.textBoxQuantityStored = new System.Windows.Forms.TextBox();
            this.textBoxPriceProd = new System.Windows.Forms.TextBox();
            this.textBoxNameProd = new System.Windows.Forms.TextBox();
            this.labelQuantityStored = new System.Windows.Forms.Label();
            this.labelCatProd = new System.Windows.Forms.Label();
            this.labelPriceProd = new System.Windows.Forms.Label();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCloseProduct
            // 
            this.buttonCloseProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCloseProduct.Location = new System.Drawing.Point(270, 228);
            this.buttonCloseProduct.Name = "buttonCloseProduct";
            this.buttonCloseProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseProduct.TabIndex = 31;
            this.buttonCloseProduct.Text = "Quitter";
            this.buttonCloseProduct.UseVisualStyleBackColor = true;
            this.buttonCloseProduct.Click += new System.EventHandler(this.buttonCloseProduct_Click);
            // 
            // comboBoxCatProd
            // 
            this.comboBoxCatProd.DisplayMember = "Identifier";
            this.comboBoxCatProd.FormattingEnabled = true;
            this.comboBoxCatProd.Location = new System.Drawing.Point(89, 116);
            this.comboBoxCatProd.Name = "comboBoxCatProd";
            this.comboBoxCatProd.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCatProd.TabIndex = 30;
            this.comboBoxCatProd.Tag = "Test";
            this.comboBoxCatProd.ValueMember = "Identifier";
            // 
            // textBoxQuantityStored
            // 
            this.textBoxQuantityStored.Location = new System.Drawing.Point(89, 142);
            this.textBoxQuantityStored.Name = "textBoxQuantityStored";
            this.textBoxQuantityStored.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantityStored.TabIndex = 29;
            // 
            // textBoxPriceProd
            // 
            this.textBoxPriceProd.Location = new System.Drawing.Point(89, 90);
            this.textBoxPriceProd.Name = "textBoxPriceProd";
            this.textBoxPriceProd.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceProd.TabIndex = 27;
            // 
            // textBoxNameProd
            // 
            this.textBoxNameProd.Location = new System.Drawing.Point(89, 64);
            this.textBoxNameProd.Name = "textBoxNameProd";
            this.textBoxNameProd.Size = new System.Drawing.Size(121, 20);
            this.textBoxNameProd.TabIndex = 25;
            // 
            // labelQuantityStored
            // 
            this.labelQuantityStored.AutoSize = true;
            this.labelQuantityStored.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelQuantityStored.Location = new System.Drawing.Point(4, 142);
            this.labelQuantityStored.Name = "labelQuantityStored";
            this.labelQuantityStored.Size = new System.Drawing.Size(88, 13);
            this.labelQuantityStored.TabIndex = 24;
            this.labelQuantityStored.Text = "Quantité stockée";
            // 
            // labelCatProd
            // 
            this.labelCatProd.AutoSize = true;
            this.labelCatProd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCatProd.Location = new System.Drawing.Point(4, 116);
            this.labelCatProd.Name = "labelCatProd";
            this.labelCatProd.Size = new System.Drawing.Size(52, 13);
            this.labelCatProd.TabIndex = 23;
            this.labelCatProd.Text = "Catégorie";
            // 
            // labelPriceProd
            // 
            this.labelPriceProd.AutoSize = true;
            this.labelPriceProd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPriceProd.Location = new System.Drawing.Point(4, 90);
            this.labelPriceProd.Name = "labelPriceProd";
            this.labelPriceProd.Size = new System.Drawing.Size(24, 13);
            this.labelPriceProd.TabIndex = 21;
            this.labelPriceProd.Text = "Prix";
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNameProduct.Location = new System.Drawing.Point(4, 67);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(79, 13);
            this.labelNameProduct.TabIndex = 19;
            this.labelNameProduct.Text = "Nom du produit";
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAddProd.Location = new System.Drawing.Point(114, 168);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProd.TabIndex = 18;
            this.buttonAddProd.Text = "Ajouter";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(216, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 212);
            this.listBox1.TabIndex = 32;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormModProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 263);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCloseProduct);
            this.Controls.Add(this.comboBoxCatProd);
            this.Controls.Add(this.textBoxQuantityStored);
            this.Controls.Add(this.textBoxPriceProd);
            this.Controls.Add(this.textBoxNameProd);
            this.Controls.Add(this.labelQuantityStored);
            this.Controls.Add(this.labelCatProd);
            this.Controls.Add(this.labelPriceProd);
            this.Controls.Add(this.labelNameProduct);
            this.Controls.Add(this.buttonAddProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(373, 302);
            this.MinimumSize = new System.Drawing.Size(373, 302);
            this.Name = "FormModProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier un produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseProduct;
        private System.Windows.Forms.ComboBox comboBoxCatProd;
        private System.Windows.Forms.TextBox textBoxQuantityStored;
        private System.Windows.Forms.TextBox textBoxPriceProd;
        private System.Windows.Forms.TextBox textBoxNameProd;
        private System.Windows.Forms.Label labelQuantityStored;
        private System.Windows.Forms.Label labelCatProd;
        private System.Windows.Forms.Label labelPriceProd;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.ListBox listBox1;
    }
}