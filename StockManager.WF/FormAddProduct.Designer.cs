namespace StockManager.WF
{
    partial class FormAddProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.labelRefProd = new System.Windows.Forms.Label();
            this.labelPriceProd = new System.Windows.Forms.Label();
            this.labelDescriptProd = new System.Windows.Forms.Label();
            this.labelQuantityStored = new System.Windows.Forms.Label();
            this.labelCatProd = new System.Windows.Forms.Label();
            this.textBoxNameProd = new System.Windows.Forms.TextBox();
            this.textBoxRefProd = new System.Windows.Forms.TextBox();
            this.textBoxPriceProd = new System.Windows.Forms.TextBox();
            this.textBoxDescProd = new System.Windows.Forms.TextBox();
            this.textBoxQuantityStored = new System.Windows.Forms.TextBox();
            this.comboBoxCatProd = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProd
            // 
            resources.ApplyResources(this.buttonAddProd, "buttonAddProd");
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // labelNameProduct
            // 
            resources.ApplyResources(this.labelNameProduct, "labelNameProduct");
            this.labelNameProduct.Name = "labelNameProduct";
            // 
            // labelRefProd
            // 
            resources.ApplyResources(this.labelRefProd, "labelRefProd");
            this.labelRefProd.Name = "labelRefProd";
            // 
            // labelPriceProd
            // 
            resources.ApplyResources(this.labelPriceProd, "labelPriceProd");
            this.labelPriceProd.Name = "labelPriceProd";
            // 
            // labelDescriptProd
            // 
            resources.ApplyResources(this.labelDescriptProd, "labelDescriptProd");
            this.labelDescriptProd.Name = "labelDescriptProd";
            // 
            // labelQuantityStored
            // 
            resources.ApplyResources(this.labelQuantityStored, "labelQuantityStored");
            this.labelQuantityStored.Name = "labelQuantityStored";
            // 
            // labelCatProd
            // 
            resources.ApplyResources(this.labelCatProd, "labelCatProd");
            this.labelCatProd.Name = "labelCatProd";
            // 
            // textBoxNameProd
            // 
            resources.ApplyResources(this.textBoxNameProd, "textBoxNameProd");
            this.textBoxNameProd.Name = "textBoxNameProd";
            // 
            // textBoxRefProd
            // 
            resources.ApplyResources(this.textBoxRefProd, "textBoxRefProd");
            this.textBoxRefProd.Name = "textBoxRefProd";
            // 
            // textBoxPriceProd
            // 
            resources.ApplyResources(this.textBoxPriceProd, "textBoxPriceProd");
            this.textBoxPriceProd.Name = "textBoxPriceProd";
            // 
            // textBoxDescProd
            // 
            resources.ApplyResources(this.textBoxDescProd, "textBoxDescProd");
            this.textBoxDescProd.Name = "textBoxDescProd";
            // 
            // textBoxQuantityStored
            // 
            resources.ApplyResources(this.textBoxQuantityStored, "textBoxQuantityStored");
            this.textBoxQuantityStored.Name = "textBoxQuantityStored";
            // 
            // comboBoxCatProd
            // 
            this.comboBoxCatProd.DataSource = this.productCategoryBindingSource;
            this.comboBoxCatProd.DisplayMember = "Label";
            this.comboBoxCatProd.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCatProd, "comboBoxCatProd");
            this.comboBoxCatProd.Name = "comboBoxCatProd";
            this.comboBoxCatProd.Tag = "Test";
            this.comboBoxCatProd.ValueMember = "Identifier";
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // FormAddProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxCatProd);
            this.Controls.Add(this.textBoxQuantityStored);
            this.Controls.Add(this.textBoxDescProd);
            this.Controls.Add(this.textBoxPriceProd);
            this.Controls.Add(this.textBoxRefProd);
            this.Controls.Add(this.textBoxNameProd);
            this.Controls.Add(this.labelQuantityStored);
            this.Controls.Add(this.labelCatProd);
            this.Controls.Add(this.labelDescriptProd);
            this.Controls.Add(this.labelPriceProd);
            this.Controls.Add(this.labelRefProd);
            this.Controls.Add(this.labelNameProduct);
            this.Controls.Add(this.buttonAddProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormAddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.Label labelRefProd;
        private System.Windows.Forms.Label labelPriceProd;
        private System.Windows.Forms.Label labelDescriptProd;
        private System.Windows.Forms.Label labelQuantityStored;
        private System.Windows.Forms.Label labelCatProd;
        private System.Windows.Forms.TextBox textBoxNameProd;
        private System.Windows.Forms.TextBox textBoxRefProd;
        private System.Windows.Forms.TextBox textBoxPriceProd;
        private System.Windows.Forms.TextBox textBoxDescProd;
        private System.Windows.Forms.TextBox textBoxQuantityStored;
        private System.Windows.Forms.ComboBox comboBoxCatProd;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private System.Windows.Forms.Button buttonClose;
    }
}