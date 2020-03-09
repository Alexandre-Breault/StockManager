namespace StockManager.WF
{
    partial class FormDelProduct
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
            this.stockManagerDataSet = new StockManager.WF.StockManagerDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new StockManager.WF.StockManagerDataSetTableAdapters.ProductTableAdapter();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonDel = new System.Windows.Forms.Button();
            this.nomDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifierProductCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // stockManagerDataSet
            // 
            this.stockManagerDataSet.DataSetName = "StockManagerDataSet";
            this.stockManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.stockManagerDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(577, 246);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Quitter";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBox,
            this.referenceDataGridViewTextBoxRef,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.identifierProductCategoryDataGridViewTextBoxColumn,
            this.storedQuantityDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.productBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.Size = new System.Drawing.Size(643, 229);
            this.dataGridViewProduct.TabIndex = 5;
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.Location = new System.Drawing.Point(12, 246);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Supprimer";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // nomDataGridViewTextBox
            // 
            this.nomDataGridViewTextBox.DataPropertyName = "Nom";
            this.nomDataGridViewTextBox.HeaderText = "Nom";
            this.nomDataGridViewTextBox.Name = "nomDataGridViewTextBox";
            this.nomDataGridViewTextBox.ReadOnly = true;
            // 
            // referenceDataGridViewTextBoxRef
            // 
            this.referenceDataGridViewTextBoxRef.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxRef.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxRef.Name = "referenceDataGridViewTextBoxRef";
            this.referenceDataGridViewTextBoxRef.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identifierProductCategoryDataGridViewTextBoxColumn
            // 
            this.identifierProductCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdentifierProductCategory";
            this.identifierProductCategoryDataGridViewTextBoxColumn.HeaderText = "IdentifierProductCategory";
            this.identifierProductCategoryDataGridViewTextBoxColumn.Name = "identifierProductCategoryDataGridViewTextBoxColumn";
            this.identifierProductCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storedQuantityDataGridViewTextBoxColumn
            // 
            this.storedQuantityDataGridViewTextBoxColumn.DataPropertyName = "StoredQuantity";
            this.storedQuantityDataGridViewTextBoxColumn.HeaderText = "StoredQuantity";
            this.storedQuantityDataGridViewTextBoxColumn.Name = "storedQuantityDataGridViewTextBoxColumn";
            this.storedQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormDelProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 281);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.buttonClose);
            this.MaximumSize = new System.Drawing.Size(680, 320);
            this.MinimumSize = new System.Drawing.Size(680, 320);
            this.Name = "FormDelProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDelProduct";
            this.Load += new System.EventHandler(this.FormDelProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StockManagerDataSet stockManagerDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private StockManagerDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierProductCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storedQuantityDataGridViewTextBoxColumn;
    }
}