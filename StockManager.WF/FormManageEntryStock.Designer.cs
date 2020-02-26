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
            this.SuspendLayout();
            // 
            // buttonCloseManageEntryStock
            // 
            this.buttonCloseManageEntryStock.Location = new System.Drawing.Point(713, 415);
            this.buttonCloseManageEntryStock.Name = "buttonCloseManageEntryStock";
            this.buttonCloseManageEntryStock.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseManageEntryStock.TabIndex = 0;
            this.buttonCloseManageEntryStock.Text = "Retour";
            this.buttonCloseManageEntryStock.UseVisualStyleBackColor = true;
            this.buttonCloseManageEntryStock.Click += new System.EventHandler(this.buttonCloseManageEntryStock_Click);
            // 
            // FormManageEntryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseManageEntryStock);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormManageEntryStock";
            this.Text = "Gestion entrées stocks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseManageEntryStock;
    }
}