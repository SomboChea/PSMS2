namespace PSMS
{
    partial class frmInvoiceDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceDetail));
            this.dgInv = new MetroFramework.Controls.MetroGrid();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.btnNew = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDel = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.Iabel1 = new System.Windows.Forms.Label();
            this.txtInvID = new System.Windows.Forms.TextBox();
            this.txtInvCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaymentVerify = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInv
            // 
            this.dgInv.AllowUserToAddRows = false;
            this.dgInv.AllowUserToDeleteRows = false;
            this.dgInv.AllowUserToResizeRows = false;
            this.dgInv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgInv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgInv.EnableHeadersVisualStyles = false;
            this.dgInv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgInv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgInv.Location = new System.Drawing.Point(14, 88);
            this.dgInv.MultiSelect = false;
            this.dgInv.Name = "dgInv";
            this.dgInv.ReadOnly = true;
            this.dgInv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgInv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInv.Size = new System.Drawing.Size(671, 338);
            this.dgInv.TabIndex = 0;
            this.dgInv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInv_CellContentClick);
            this.dgInv.Click += new System.EventHandler(this.dgInv_Click);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(23, 441);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(357, 19);
            this.metroLabel19.TabIndex = 25;
            this.metroLabel19.Text = "Payment Verify Note: 0 = Not Paid Yet, 1 = Full Paid";
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer4,
            this.itemContainer2,
            this.itemContainer3});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(712, 88);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(105, 214);
            this.itemPanel1.TabIndex = 30;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNew});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PSMS.Properties.Resources.add_documents_1_;
            this.btnNew.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Name = "btnNew";
            this.btnNew.SymbolColor = System.Drawing.Color.Empty;
            this.btnNew.Text = "Save";
            this.btnNew.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnNew.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.btnNew.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnNew.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSave});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PSMS.Properties.Resources.save;
            this.btnSave.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Name = "btnSave";
            this.btnSave.SymbolColor = System.Drawing.Color.Empty;
            this.btnSave.Text = "Update";
            this.btnSave.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnSave.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.btnSave.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnSave.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDel});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::PSMS.Properties.Resources.rubbish_bin;
            this.btnDel.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.Name = "btnDel";
            this.btnDel.SymbolColor = System.Drawing.Color.Empty;
            this.btnDel.Text = "Delete";
            this.btnDel.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnDel.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.btnDel.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnDel.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(377, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Search by";
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(555, 52);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(141, 20);
            this.txtfilter.TabIndex = 34;
            this.txtfilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtfilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfilter_KeyPress);
            // 
            // Iabel1
            // 
            this.Iabel1.AutoSize = true;
            this.Iabel1.Location = new System.Drawing.Point(217, 56);
            this.Iabel1.Name = "Iabel1";
            this.Iabel1.Size = new System.Drawing.Size(33, 13);
            this.Iabel1.TabIndex = 36;
            this.Iabel1.Text = "InvID";
            this.Iabel1.Visible = false;
            // 
            // txtInvID
            // 
            this.txtInvID.Location = new System.Drawing.Point(267, 53);
            this.txtInvID.Name = "txtInvID";
            this.txtInvID.Size = new System.Drawing.Size(100, 20);
            this.txtInvID.TabIndex = 37;
            this.txtInvID.Visible = false;
            // 
            // txtInvCode
            // 
            this.txtInvCode.Location = new System.Drawing.Point(205, 148);
            this.txtInvCode.Name = "txtInvCode";
            this.txtInvCode.Size = new System.Drawing.Size(100, 20);
            this.txtInvCode.TabIndex = 39;
            this.txtInvCode.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "InvCode";
            this.label2.Visible = false;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(205, 185);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(100, 20);
            this.txtCusID.TabIndex = 41;
            this.txtCusID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "CusID";
            this.label3.Visible = false;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(205, 211);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 43;
            this.txtEmpID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "EmpID";
            this.label4.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(436, 144);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 45;
            this.txtTotal.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Date";
            this.label5.Visible = false;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(436, 181);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 20);
            this.txtPayment.TabIndex = 47;
            this.txtPayment.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "TotalPrice";
            this.label6.Visible = false;
            // 
            // txtPaymentVerify
            // 
            this.txtPaymentVerify.Location = new System.Drawing.Point(436, 214);
            this.txtPaymentVerify.Name = "txtPaymentVerify";
            this.txtPaymentVerify.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentVerify.TabIndex = 49;
            this.txtPaymentVerify.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Payment";
            this.label7.Visible = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(436, 246);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 51;
            this.txtBalance.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "PayVerify";
            this.label8.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 52;
            this.dateTimePicker1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Balance";
            this.label9.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PurCode",
            "Date",
            "Payment",
            "Balance",
            "SuEnName",
            "EmpEnName",
            "Total",
            "SuKHName",
            "EmpKHName"});
            this.comboBox1.Location = new System.Drawing.Point(451, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 54;
            // 
            // frmInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 480);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPaymentVerify);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInvID);
            this.Controls.Add(this.Iabel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtfilter);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.dgInv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvoiceDetail";
            this.Text = "InvoiceDetail";
            this.Load += new System.EventHandler(this.frmInvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgInv;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnNew;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnSave;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnDel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Label Iabel1;
        private System.Windows.Forms.TextBox txtInvID;
        private System.Windows.Forms.TextBox txtInvCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPaymentVerify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}