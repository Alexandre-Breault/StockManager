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
            this.buttonCloseManageExitStock = new System.Windows.Forms.Button();
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
            this.buttonCloseManageExitStock.Click += new System.EventHandler(this.buttonCloseManageExitStock_Click);
            // 
            // FormManageExitStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseManageExitStock);
            this.Name = "FormManageExitStock";
            this.Text = "Gestion sorties stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseManageExitStock;
    }
}