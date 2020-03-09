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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelCategory = new System.Windows.Forms.Button();
            this.textBoxDelCategory = new System.Windows.Forms.TextBox();
            this.labelDelCategory = new System.Windows.Forms.Label();
            this.listBoxDelCategory = new System.Windows.Forms.ListBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagerDataSetCategory = new StockManager.WF.StockManagerDataSetCategory();
            this.productCategoryTableAdapter = new StockManager.WF.StockManagerDataSetCategoryTableAdapters.ProductCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagerDataSetCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(418, 244);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Retour";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelCategory
            // 
            this.buttonDelCategory.Location = new System.Drawing.Point(11, 91);
            this.buttonDelCategory.Name = "buttonDelCategory";
            this.buttonDelCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonDelCategory.TabIndex = 2;
            this.buttonDelCategory.Text = "Supprimer";
            this.buttonDelCategory.UseVisualStyleBackColor = true;
            this.buttonDelCategory.Click += new System.EventHandler(this.buttonDelCategory_Click);
            // 
            // textBoxDelCategory
            // 
            this.textBoxDelCategory.Location = new System.Drawing.Point(11, 65);
            this.textBoxDelCategory.Name = "textBoxDelCategory";
            this.textBoxDelCategory.Size = new System.Drawing.Size(156, 20);
            this.textBoxDelCategory.TabIndex = 3;
            // 
            // labelDelCategory
            // 
            this.labelDelCategory.AutoSize = true;
            this.labelDelCategory.Location = new System.Drawing.Point(8, 49);
            this.labelDelCategory.Name = "labelDelCategory";
            this.labelDelCategory.Size = new System.Drawing.Size(159, 13);
            this.labelDelCategory.TabIndex = 4;
            this.labelDelCategory.Text = "Nom de la catégorie à supprimer";
            // 
            // listBoxDelCategory
            // 
            this.listBoxDelCategory.DataSource = this.productCategoryBindingSource;
            this.listBoxDelCategory.DisplayMember = "Label";
            this.listBoxDelCategory.FormattingEnabled = true;
            this.listBoxDelCategory.Location = new System.Drawing.Point(229, 12);
            this.listBoxDelCategory.Name = "listBoxDelCategory";
            this.listBoxDelCategory.Size = new System.Drawing.Size(172, 251);
            this.listBoxDelCategory.TabIndex = 5;
            this.listBoxDelCategory.ValueMember = "Identifier";
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.stockManagerDataSetCategory;
            // 
            // stockManagerDataSetCategory
            // 
            this.stockManagerDataSetCategory.DataSetName = "StockManagerDataSetCategory";
            this.stockManagerDataSetCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormDelCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 279);
            this.Controls.Add(this.listBoxDelCategory);
            this.Controls.Add(this.labelDelCategory);
            this.Controls.Add(this.textBoxDelCategory);
            this.Controls.Add(this.buttonDelCategory);
            this.Controls.Add(this.buttonClose);
            this.MaximumSize = new System.Drawing.Size(521, 318);
            this.MinimumSize = new System.Drawing.Size(521, 318);
            this.Name = "FormDelCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDelCategory";
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagerDataSetCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelCategory;
        private System.Windows.Forms.TextBox textBoxDelCategory;
        private System.Windows.Forms.Label labelDelCategory;
        private System.Windows.Forms.ListBox listBoxDelCategory;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private StockManagerDataSetCategory stockManagerDataSetCategory;
        private StockManagerDataSetCategoryTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
    }
}