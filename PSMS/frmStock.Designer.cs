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
            this.btnupdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCost = new MetroFramework.Controls.MetroTextBox();
            this.txtSalePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtfilter = new System.Windows.Forms.TextBox();
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
            this.listStock.Location = new System.Drawing.Point(23, 78);
            this.listStock.MultiSelect = false;
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(1079, 590);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            this.listStock.View = System.Windows.Forms.View.Details;
            this.listStock.SelectedIndexChanged += new System.EventHandler(this.listStock_SelectedIndexChanged);
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
            this.comboBox1.Location = new System.Drawing.Point(1123, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(1123, 123);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 32);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnupdate.Enabled = false;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnupdate.Location = new System.Drawing.Point(1123, 171);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 32);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1123, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1132, 495);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Total Quantity";
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(1115, 517);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(136, 23);
            this.txtQty.TabIndex = 7;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(1132, 560);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Total Cost";
            // 
            // txtCost
            // 
            // 
            // 
            // 
            this.txtCost.CustomButton.Image = null;
            this.txtCost.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtCost.CustomButton.Name = "";
            this.txtCost.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCost.CustomButton.TabIndex = 1;
            this.txtCost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCost.CustomButton.UseSelectable = true;
            this.txtCost.CustomButton.Visible = false;
            this.txtCost.Lines = new string[0];
            this.txtCost.Location = new System.Drawing.Point(1115, 582);
            this.txtCost.MaxLength = 32767;
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCost.SelectedText = "";
            this.txtCost.SelectionLength = 0;
            this.txtCost.SelectionStart = 0;
            this.txtCost.ShortcutsEnabled = true;
            this.txtCost.Size = new System.Drawing.Size(136, 23);
            this.txtCost.TabIndex = 8;
            this.txtCost.UseSelectable = true;
            this.txtCost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSalePrice
            // 
            // 
            // 
            // 
            this.txtSalePrice.CustomButton.Image = null;
            this.txtSalePrice.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtSalePrice.CustomButton.Name = "";
            this.txtSalePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalePrice.CustomButton.TabIndex = 1;
            this.txtSalePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalePrice.CustomButton.UseSelectable = true;
            this.txtSalePrice.CustomButton.Visible = false;
            this.txtSalePrice.Lines = new string[0];
            this.txtSalePrice.Location = new System.Drawing.Point(1115, 645);
            this.txtSalePrice.MaxLength = 32767;
            this.txtSalePrice.Multiline = true;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.SelectionLength = 0;
            this.txtSalePrice.SelectionStart = 0;
            this.txtSalePrice.ShortcutsEnabled = true;
            this.txtSalePrice.Size = new System.Drawing.Size(136, 23);
            this.txtSalePrice.TabIndex = 10;
            this.txtSalePrice.UseSelectable = true;
            this.txtSalePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(1132, 623);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Total Sale Price";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "PCode",
            "PName",
            "PSize",
            "Color",
            "Quantity",
            "Brand",
            "PhoneType",
            "Type",
            "SalePrice",
            "UnitPrice",
            "Image"});
            this.comboBox2.Location = new System.Drawing.Point(868, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 21);
            this.comboBox2.TabIndex = 38;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(794, 42);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Search by";
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(961, 41);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(141, 20);
            this.txtfilter.TabIndex = 36;
            this.txtfilter.TextChanged += new System.EventHandler(this.txtfilter_TextChanged);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 691);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtfilter);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listStock);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCost;
        private MetroFramework.Controls.MetroTextBox txtSalePrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txtfilter;
    }
}