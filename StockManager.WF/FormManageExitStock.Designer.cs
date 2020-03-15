namespace StockManager.WF
{
    partial class FormManageExitStock
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
            this.buttonCloseManageExitStock = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxCodeEmployee = new System.Windows.Forms.TextBox();
            this.labelEmployeeCode = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerProduct = new System.Windows.Forms.DateTimePicker();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.buttonCloseManageEntryStock = new System.Windows.Forms.Button();
            this.errorProviderQuantité = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantité)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseManageExitStock
            // 
            this.buttonCloseManageExitStock.Location = new System.Drawing.Point(713, 415);
            this.buttonCloseManageExitStock.Name = "buttonCloseManageExitStock";
            this.buttonCloseManageExitStock.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseManageExitStock.TabIndex = 0;
            this.buttonCloseManageExitStock.Text = "Retour";
            this.buttonCloseManageExitStock.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(15, 183);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 20;
            this.buttonModify.Text = "Envoyer";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click_1);
            // 
            // textBoxCodeEmployee
            // 
            this.textBoxCodeEmployee.Location = new System.Drawing.Point(15, 145);
            this.textBoxCodeEmployee.Name = "textBoxCodeEmployee";
            this.textBoxCodeEmployee.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodeEmployee.TabIndex = 19;
            // 
            // labelEmployeeCode
            // 
            this.labelEmployeeCode.AutoSize = true;
            this.labelEmployeeCode.Location = new System.Drawing.Point(12, 129);
            this.labelEmployeeCode.Name = "labelEmployeeCode";
            this.labelEmployeeCode.Size = new System.Drawing.Size(93, 13);
            this.labelEmployeeCode.TabIndex = 18;
            this.labelEmployeeCode.Text = "Code de l\'employe";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 90);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(130, 13);
            this.labelDate.TabIndex = 17;
            this.labelDate.Text = "Date d\'ajout dans le stock";
            // 
            // dateTimePickerProduct
            // 
            this.dateTimePickerProduct.Location = new System.Drawing.Point(15, 106);
            this.dateTimePickerProduct.Name = "dateTimePickerProduct";
            this.dateTimePickerProduct.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerProduct.TabIndex = 16;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(15, 67);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(200, 20);
            this.textBoxQuantity.TabIndex = 15;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 51);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(47, 13);
            this.labelQuantity.TabIndex = 14;
            this.labelQuantity.Text = "Quantité";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(15, 27);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProduct.TabIndex = 13;
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.Location = new System.Drawing.Point(12, 11);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(80, 13);
            this.labelNameProduct.TabIndex = 12;
            this.labelNameProduct.Text = "Nom du Produit";
            // 
            // buttonCloseManageEntryStock
            // 
            this.buttonCloseManageEntryStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseManageEntryStock.Location = new System.Drawing.Point(140, 183);
            this.buttonCloseManageEntryStock.Name = "buttonCloseManageEntryStock";
            this.buttonCloseManageEntryStock.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseManageEntryStock.TabIndex = 11;
            this.buttonCloseManageEntryStock.Text = "Retour";
            this.buttonCloseManageEntryStock.UseVisualStyleBackColor = true;
            this.buttonCloseManageEntryStock.Click += new System.EventHandler(this.buttonCloseManageEntryStock_Click);
            // 
            // errorProviderQuantité
            // 
            this.errorProviderQuantité.ContainerControl = this;
            // 
            // FormManageExitStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 216);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxCodeEmployee);
            this.Controls.Add(this.labelEmployeeCode);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerProduct);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelNameProduct);
            this.Controls.Add(this.buttonCloseManageEntryStock);
            this.Controls.Add(this.buttonCloseManageExitStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(243, 255);
            this.MinimumSize = new System.Drawing.Size(243, 255);
            this.Name = "FormManageExitStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion sorties stocks";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantité)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseManageExitStock;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxCodeEmployee;
        private System.Windows.Forms.Label labelEmployeeCode;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerProduct;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.Button buttonCloseManageEntryStock;
        private System.Windows.Forms.ErrorProvider errorProviderQuantité;
    }
}