namespace PSMS
{
    partial class frmSupplierDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierDetail));
            this.dgData = new MetroFramework.Controls.MetroGrid();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.btnNew = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDel = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnClr = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.txtSuID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.rtxtAddress = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtEn1 = new MetroFramework.Controls.MetroTextBox();
            this.txtEn2 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh2 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh1 = new MetroFramework.Controls.MetroTextBox();
            this.cbBGender = new MetroFramework.Controls.MetroComboBox();
            this.txtFax2 = new MetroFramework.Controls.MetroTextBox();
            this.txtFax = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSuCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblBalance = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgData.EnableHeadersVisualStyles = false;
            this.dgData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgData.Location = new System.Drawing.Point(32, 88);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(642, 343);
            this.dgData.TabIndex = 30;
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
            this.itemContainer3,
            this.itemContainer1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(701, 88);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(105, 250);
            this.itemPanel1.TabIndex = 34;
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
            this.btnNew.Text = "New";
            this.btnNew.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnNew.TileSize = new System.Drawing.Size(100, 60);
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
            this.btnSave.Text = "Save";
            this.btnSave.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnSave.TileSize = new System.Drawing.Size(100, 60);
            // 
            // 
            // 
            this.btnSave.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnSave.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnDel.TileSize = new System.Drawing.Size(100, 60);
            // 
            // 
            // 
            this.btnDel.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnDel.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClr});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnClr
            // 
            this.btnClr.Image = global::PSMS.Properties.Resources.sweep1;
            this.btnClr.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClr.Name = "btnClr";
            this.btnClr.SymbolColor = System.Drawing.Color.Empty;
            this.btnClr.Text = "Clear";
            this.btnClr.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnClr.TileSize = new System.Drawing.Size(100, 60);
            // 
            // 
            // 
            this.btnClr.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // txtSuID
            // 
            // 
            // 
            // 
            this.txtSuID.CustomButton.Image = null;
            this.txtSuID.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtSuID.CustomButton.Name = "";
            this.txtSuID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSuID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSuID.CustomButton.TabIndex = 1;
            this.txtSuID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuID.CustomButton.UseSelectable = true;
            this.txtSuID.CustomButton.Visible = false;
            this.txtSuID.Lines = new string[0];
            this.txtSuID.Location = new System.Drawing.Point(356, 59);
            this.txtSuID.MaxLength = 32767;
            this.txtSuID.Name = "txtSuID";
            this.txtSuID.PasswordChar = '\0';
            this.txtSuID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuID.SelectedText = "";
            this.txtSuID.SelectionLength = 0;
            this.txtSuID.SelectionStart = 0;
            this.txtSuID.ShortcutsEnabled = true;
            this.txtSuID.Size = new System.Drawing.Size(32, 23);
            this.txtSuID.TabIndex = 62;
            this.txtSuID.UseSelectable = true;
            this.txtSuID.Visible = false;
            this.txtSuID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSuID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(256, 59);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(69, 19);
            this.metroLabel13.TabIndex = 61;
            this.metroLabel13.Text = "SupplierID";
            this.metroLabel13.Visible = false;
            // 
            // rtxtAddress
            // 
            // 
            // 
            // 
            this.rtxtAddress.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtxtAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtxtAddress.Location = new System.Drawing.Point(147, 250);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n{\\colortbl ;\\red51\\green153\\blue255;}\r\n\\viewkind4\\uc1\\pard\\cf1\\f0\\" +
    "fs17\\par\r\n}\r\n";
            this.rtxtAddress.Size = new System.Drawing.Size(32, 58);
            this.rtxtAddress.TabIndex = 60;
            this.rtxtAddress.Visible = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(200, 132);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(109, 19);
            this.metroLabel12.TabIndex = 59;
            this.metroLabel12.Text = "(Name in Khmer)";
            this.metroLabel12.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(200, 189);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(111, 19);
            this.metroLabel11.TabIndex = 58;
            this.metroLabel11.Text = "(Name in English)";
            this.metroLabel11.Visible = false;
            // 
            // txtEn1
            // 
            // 
            // 
            // 
            this.txtEn1.CustomButton.Image = null;
            this.txtEn1.CustomButton.Location = new System.Drawing.Point(-12, 1);
            this.txtEn1.CustomButton.Name = "";
            this.txtEn1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn1.CustomButton.TabIndex = 1;
            this.txtEn1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn1.CustomButton.UseSelectable = true;
            this.txtEn1.CustomButton.Visible = false;
            this.txtEn1.Lines = new string[0];
            this.txtEn1.Location = new System.Drawing.Point(147, 214);
            this.txtEn1.MaxLength = 32767;
            this.txtEn1.Name = "txtEn1";
            this.txtEn1.PasswordChar = '\0';
            this.txtEn1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn1.SelectedText = "";
            this.txtEn1.SelectionLength = 0;
            this.txtEn1.SelectionStart = 0;
            this.txtEn1.ShortcutsEnabled = true;
            this.txtEn1.Size = new System.Drawing.Size(10, 23);
            this.txtEn1.TabIndex = 57;
            this.txtEn1.UseSelectable = true;
            this.txtEn1.Visible = false;
            this.txtEn1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEn2
            // 
            // 
            // 
            // 
            this.txtEn2.CustomButton.Image = null;
            this.txtEn2.CustomButton.Location = new System.Drawing.Point(-12, 1);
            this.txtEn2.CustomButton.Name = "";
            this.txtEn2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn2.CustomButton.TabIndex = 1;
            this.txtEn2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn2.CustomButton.UseSelectable = true;
            this.txtEn2.CustomButton.Visible = false;
            this.txtEn2.Lines = new string[0];
            this.txtEn2.Location = new System.Drawing.Point(257, 214);
            this.txtEn2.MaxLength = 32767;
            this.txtEn2.Name = "txtEn2";
            this.txtEn2.PasswordChar = '\0';
            this.txtEn2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn2.SelectedText = "";
            this.txtEn2.SelectionLength = 0;
            this.txtEn2.SelectionStart = 0;
            this.txtEn2.ShortcutsEnabled = true;
            this.txtEn2.Size = new System.Drawing.Size(10, 23);
            this.txtEn2.TabIndex = 56;
            this.txtEn2.UseSelectable = true;
            this.txtEn2.Visible = false;
            this.txtEn2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKh2
            // 
            // 
            // 
            // 
            this.txtKh2.CustomButton.Image = null;
            this.txtKh2.CustomButton.Location = new System.Drawing.Point(-12, 1);
            this.txtKh2.CustomButton.Name = "";
            this.txtKh2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh2.CustomButton.TabIndex = 1;
            this.txtKh2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh2.CustomButton.UseSelectable = true;
            this.txtKh2.CustomButton.Visible = false;
            this.txtKh2.Lines = new string[0];
            this.txtKh2.Location = new System.Drawing.Point(257, 163);
            this.txtKh2.MaxLength = 32767;
            this.txtKh2.Name = "txtKh2";
            this.txtKh2.PasswordChar = '\0';
            this.txtKh2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh2.SelectedText = "";
            this.txtKh2.SelectionLength = 0;
            this.txtKh2.SelectionStart = 0;
            this.txtKh2.ShortcutsEnabled = true;
            this.txtKh2.Size = new System.Drawing.Size(10, 23);
            this.txtKh2.TabIndex = 55;
            this.txtKh2.UseSelectable = true;
            this.txtKh2.Visible = false;
            this.txtKh2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKh1
            // 
            // 
            // 
            // 
            this.txtKh1.CustomButton.Image = null;
            this.txtKh1.CustomButton.Location = new System.Drawing.Point(-12, 1);
            this.txtKh1.CustomButton.Name = "";
            this.txtKh1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh1.CustomButton.TabIndex = 1;
            this.txtKh1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh1.CustomButton.UseSelectable = true;
            this.txtKh1.CustomButton.Visible = false;
            this.txtKh1.Lines = new string[0];
            this.txtKh1.Location = new System.Drawing.Point(147, 163);
            this.txtKh1.MaxLength = 32767;
            this.txtKh1.Name = "txtKh1";
            this.txtKh1.PasswordChar = '\0';
            this.txtKh1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh1.SelectedText = "";
            this.txtKh1.SelectionLength = 0;
            this.txtKh1.SelectionStart = 0;
            this.txtKh1.ShortcutsEnabled = true;
            this.txtKh1.Size = new System.Drawing.Size(10, 23);
            this.txtKh1.TabIndex = 54;
            this.txtKh1.UseSelectable = true;
            this.txtKh1.Visible = false;
            this.txtKh1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbBGender
            // 
            this.cbBGender.FormattingEnabled = true;
            this.cbBGender.ItemHeight = 23;
            this.cbBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbBGender.Location = new System.Drawing.Point(464, 101);
            this.cbBGender.Name = "cbBGender";
            this.cbBGender.Size = new System.Drawing.Size(32, 29);
            this.cbBGender.TabIndex = 53;
            this.cbBGender.UseSelectable = true;
            this.cbBGender.Visible = false;
            // 
            // txtFax2
            // 
            // 
            // 
            // 
            this.txtFax2.CustomButton.Image = null;
            this.txtFax2.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtFax2.CustomButton.Name = "";
            this.txtFax2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFax2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFax2.CustomButton.TabIndex = 1;
            this.txtFax2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFax2.CustomButton.UseSelectable = true;
            this.txtFax2.CustomButton.Visible = false;
            this.txtFax2.Lines = new string[0];
            this.txtFax2.Location = new System.Drawing.Point(464, 256);
            this.txtFax2.MaxLength = 32767;
            this.txtFax2.Name = "txtFax2";
            this.txtFax2.PasswordChar = '\0';
            this.txtFax2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFax2.SelectedText = "";
            this.txtFax2.SelectionLength = 0;
            this.txtFax2.SelectionStart = 0;
            this.txtFax2.ShortcutsEnabled = true;
            this.txtFax2.Size = new System.Drawing.Size(32, 23);
            this.txtFax2.TabIndex = 52;
            this.txtFax2.UseSelectable = true;
            this.txtFax2.Visible = false;
            this.txtFax2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFax2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFax
            // 
            // 
            // 
            // 
            this.txtFax.CustomButton.Image = null;
            this.txtFax.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtFax.CustomButton.Name = "";
            this.txtFax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFax.CustomButton.TabIndex = 1;
            this.txtFax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFax.CustomButton.UseSelectable = true;
            this.txtFax.CustomButton.Visible = false;
            this.txtFax.Lines = new string[0];
            this.txtFax.Location = new System.Drawing.Point(464, 231);
            this.txtFax.MaxLength = 32767;
            this.txtFax.Name = "txtFax";
            this.txtFax.PasswordChar = '\0';
            this.txtFax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFax.SelectedText = "";
            this.txtFax.SelectionLength = 0;
            this.txtFax.SelectionStart = 0;
            this.txtFax.ShortcutsEnabled = true;
            this.txtFax.Size = new System.Drawing.Size(32, 23);
            this.txtFax.TabIndex = 51;
            this.txtFax.UseSelectable = true;
            this.txtFax.Visible = false;
            this.txtFax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(368, 231);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(28, 19);
            this.metroLabel8.TabIndex = 50;
            this.metroLabel8.Text = "Fax";
            this.metroLabel8.Visible = false;
            // 
            // txtPhone2
            // 
            // 
            // 
            // 
            this.txtPhone2.CustomButton.Image = null;
            this.txtPhone2.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtPhone2.CustomButton.Name = "";
            this.txtPhone2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone2.CustomButton.TabIndex = 1;
            this.txtPhone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone2.CustomButton.UseSelectable = true;
            this.txtPhone2.CustomButton.Visible = false;
            this.txtPhone2.Lines = new string[0];
            this.txtPhone2.Location = new System.Drawing.Point(464, 173);
            this.txtPhone2.MaxLength = 32767;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.PasswordChar = '\0';
            this.txtPhone2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone2.SelectedText = "";
            this.txtPhone2.SelectionLength = 0;
            this.txtPhone2.SelectionStart = 0;
            this.txtPhone2.ShortcutsEnabled = true;
            this.txtPhone2.Size = new System.Drawing.Size(32, 23);
            this.txtPhone2.TabIndex = 49;
            this.txtPhone2.UseSelectable = true;
            this.txtPhone2.Visible = false;
            this.txtPhone2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(47, 250);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 44;
            this.metroLabel6.Text = "Address";
            this.metroLabel6.Visible = false;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(465, 202);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(32, 23);
            this.txtEmail.TabIndex = 48;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.Visible = false;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(369, 202);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(41, 19);
            this.metroLabel9.TabIndex = 47;
            this.metroLabel9.Text = "Email";
            this.metroLabel9.Visible = false;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(465, 145);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(32, 23);
            this.txtPhone.TabIndex = 46;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.Visible = false;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(368, 145);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 45;
            this.metroLabel5.Text = "Phone";
            this.metroLabel5.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(367, 106);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 43;
            this.metroLabel4.Text = "Gender";
            this.metroLabel4.Visible = false;
            // 
            // txtSuCode
            // 
            // 
            // 
            // 
            this.txtSuCode.CustomButton.Image = null;
            this.txtSuCode.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txtSuCode.CustomButton.Name = "";
            this.txtSuCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSuCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSuCode.CustomButton.TabIndex = 1;
            this.txtSuCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuCode.CustomButton.UseSelectable = true;
            this.txtSuCode.CustomButton.Visible = false;
            this.txtSuCode.Lines = new string[0];
            this.txtSuCode.Location = new System.Drawing.Point(147, 101);
            this.txtSuCode.MaxLength = 32767;
            this.txtSuCode.Name = "txtSuCode";
            this.txtSuCode.PasswordChar = '\0';
            this.txtSuCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuCode.SelectedText = "";
            this.txtSuCode.SelectionLength = 0;
            this.txtSuCode.SelectionStart = 0;
            this.txtSuCode.ShortcutsEnabled = true;
            this.txtSuCode.Size = new System.Drawing.Size(32, 23);
            this.txtSuCode.TabIndex = 42;
            this.txtSuCode.UseSelectable = true;
            this.txtSuCode.Visible = false;
            this.txtSuCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSuCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "SupplierCode";
            this.metroLabel3.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "SupplierName";
            this.metroLabel2.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Location = new System.Drawing.Point(294, 283);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(64, 25);
            this.lblBalance.TabIndex = 64;
            this.lblBalance.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(215, 286);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(54, 19);
            this.metroLabel7.TabIndex = 63;
            this.metroLabel7.Text = "Balance";
            this.metroLabel7.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(478, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 66;
            this.metroLabel1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 65;
            // 
            // frmSupplierDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 480);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtSuID);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtEn1);
            this.Controls.Add(this.txtEn2);
            this.Controls.Add(this.txtKh2);
            this.Controls.Add(this.txtKh1);
            this.Controls.Add(this.cbBGender);
            this.Controls.Add(this.txtFax2);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtSuCode);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.dgData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupplierDetail";
            this.Text = "SupplierDetail";
            this.Load += new System.EventHandler(this.frmSupplierDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgData;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnNew;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnSave;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnDel;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnClr;
        private MetroFramework.Controls.MetroTextBox txtSuID;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtEn1;
        private MetroFramework.Controls.MetroTextBox txtEn2;
        private MetroFramework.Controls.MetroTextBox txtKh2;
        private MetroFramework.Controls.MetroTextBox txtKh1;
        private MetroFramework.Controls.MetroComboBox cbBGender;
        private MetroFramework.Controls.MetroTextBox txtFax2;
        private MetroFramework.Controls.MetroTextBox txtFax;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPhone2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSuCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblBalance;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox textBox1;

    }
}