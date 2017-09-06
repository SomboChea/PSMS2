namespace PSMS
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.listStock = new System.Windows.Forms.ListView();
            this.cbCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbPriceOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbPriceIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listStock
            // 
            this.listStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbCode,
            this.cbName,
            this.cbSize,
            this.cbColor,
            this.cbQuantity,
            this.cbBrand,
            this.cbPT,
            this.cbType,
            this.cbPriceOut,
            this.cbPriceIn});
            this.listStock.Location = new System.Drawing.Point(23, 63);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(1202, 605);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            // 
            // cbCode
            // 
            this.cbCode.Text = "Code";
            this.cbCode.Width = 94;
            // 
            // cbName
            // 
            this.cbName.Text = "Name";
            this.cbName.Width = 179;
            // 
            // cbSize
            // 
            this.cbSize.Text = "Size";
            this.cbSize.Width = 75;
            // 
            // cbColor
            // 
            this.cbColor.Text = "Color";
            this.cbColor.Width = 77;
            // 
            // cbQuantity
            // 
            this.cbQuantity.Text = "Quantity";
            this.cbQuantity.Width = 84;
            // 
            // cbBrand
            // 
            this.cbBrand.Text = "Brand";
            this.cbBrand.Width = 121;
            // 
            // cbPT
            // 
            this.cbPT.Text = "Phone Type";
            this.cbPT.Width = 112;
            // 
            // cbType
            // 
            this.cbType.Text = "Type";
            this.cbType.Width = 95;
            // 
            // cbPriceOut
            // 
            this.cbPriceOut.Text = "Sale Price";
            this.cbPriceOut.Width = 97;
            // 
            // cbPriceIn
            // 
            this.cbPriceIn.Text = "Cost";
            this.cbPriceIn.Width = 88;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 691);
            this.Controls.Add(this.listStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listStock;
        private System.Windows.Forms.ColumnHeader cbCode;
        private System.Windows.Forms.ColumnHeader cbName;
        private System.Windows.Forms.ColumnHeader cbSize;
        private System.Windows.Forms.ColumnHeader cbColor;
        private System.Windows.Forms.ColumnHeader cbQuantity;
        private System.Windows.Forms.ColumnHeader cbBrand;
        private System.Windows.Forms.ColumnHeader cbPT;
        private System.Windows.Forms.ColumnHeader cbType;
        private System.Windows.Forms.ColumnHeader cbPriceOut;
        private System.Windows.Forms.ColumnHeader cbPriceIn;
    }
}