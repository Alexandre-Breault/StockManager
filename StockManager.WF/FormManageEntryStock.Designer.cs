namespace StockManager.WF
{
    partial class FormManageEntryStock
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
            this.buttonCloseManageEntryStock = new System.Windows.Forms.Button();
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.dateTimePickerProduct = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEmployeeCode = new System.Windows.Forms.Label();
            this.textBoxCodeEmployee = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCloseManageEntryStock
            // 
            this.buttonCloseManageEntryStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseManageEntryStock.Location = new System.Drawing.Point(140, 181);
            this.buttonCloseManageEntryStock.Name = "buttonCloseManageEntryStock";
            this.buttonCloseManageEntryStock.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseManageEntryStock.TabIndex = 0;
            this.buttonCloseManageEntryStock.Text = "Retour";
            this.buttonCloseManageEntryStock.UseVisualStyleBackColor = true;
            this.buttonCloseManageEntryStock.Click += new System.EventHandler(this.buttonCloseManageEntryStock_Click);
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.AutoSize = true;
            this.labelNameProduct.Location = new System.Drawing.Point(12, 9);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(80, 13);
            this.labelNameProduct.TabIndex = 1;
            this.labelNameProduct.Text = "Nom du Produit";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(15, 25);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProduct.TabIndex = 2;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 49);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(47, 13);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantité";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(15, 65);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(200, 20);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // dateTimePickerProduct
            // 
            this.dateTimePickerProduct.Location = new System.Drawing.Point(15, 104);
            this.dateTimePickerProduct.Name = "dateTimePickerProduct";
            this.dateTimePickerProduct.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerProduct.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 88);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(130, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Date d\'ajout dans le stock";
            // 
            // labelEmployeeCode
            // 
            this.labelEmployeeCode.AutoSize = true;
            this.labelEmployeeCode.Location = new System.Drawing.Point(12, 127);
            this.labelEmployeeCode.Name = "labelEmployeeCode";
            this.labelEmployeeCode.Size = new System.Drawing.Size(93, 13);
            this.labelEmployeeCode.TabIndex = 8;
            this.labelEmployeeCode.Text = "Code de l\'employe";
            // 
            // textBoxCodeEmployee
            // 
            this.textBoxCodeEmployee.Location = new System.Drawing.Point(15, 143);
            this.textBoxCodeEmployee.Name = "textBoxCodeEmployee";
            this.textBoxCodeEmployee.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodeEmployee.TabIndex = 9;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(15, 181);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 10;
            this.buttonModify.Text = "Envoyer";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // FormManageEntryStock
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(243, 255);
            this.MinimumSize = new System.Drawing.Size(243, 255);
            this.Name = "FormManageEntryStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion entrées stocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseManageEntryStock;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePickerProduct;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEmployeeCode;
        private System.Windows.Forms.TextBox textBoxCodeEmployee;
        private System.Windows.Forms.Button buttonModify;
    }
}