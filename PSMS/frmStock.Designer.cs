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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
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
            this.listStock.FullRowSelect = true;
            this.listStock.GridLines = true;
            this.listStock.Location = new System.Drawing.Point(23, 63);
            this.listStock.MultiSelect = false;
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(1090, 605);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            this.listStock.View = System.Windows.Forms.View.Details;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "List Mode",
            "Image Mode"});
            this.comboBox1.Location = new System.Drawing.Point(992, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Blue;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(1119, 63);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 58);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 691);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listStock);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRemove;
    }
}