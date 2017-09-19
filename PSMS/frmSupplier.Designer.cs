namespace PSMS
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnFind = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.btnNew = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDel = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.btnClr = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSuCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtFax = new MetroFramework.Controls.MetroTextBox();
            this.txtFax2 = new MetroFramework.Controls.MetroTextBox();
            this.cbBGender = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnNexts = new System.Windows.Forms.Button();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnPrevious = new DevComponents.DotNetBar.ButtonX();
            this.dgSu = new MetroFramework.Controls.MetroGrid();
            this.txtSuID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.rtxtAddress = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtEn1 = new MetroFramework.Controls.MetroTextBox();
            this.txtEn2 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh2 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh1 = new MetroFramework.Controls.MetroTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSu)).BeginInit();
            this.SuspendLayout();
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
            this.itemContainer1,
            this.itemContainer4,
            this.itemContainer2,
            this.itemContainer3,
            this.itemContainer5});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(826, 27);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(105, 358);
            this.itemPanel1.TabIndex = 28;
            this.itemPanel1.Text = "itemPanel1";
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
            this.btnFind});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PSMS.Properties.Resources.magnifying_glass_search_button;
            this.btnFind.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFind.Name = "btnFind";
            this.btnFind.SymbolColor = System.Drawing.Color.Empty;
            this.btnFind.Text = "Find";
            this.btnFind.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnFind.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.btnFind.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnFind.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.btnDel.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.btnDel.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnDel.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClr});
            // 
            // 
            // 
            this.itemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnClr
            // 
            this.btnClr.Image = global::PSMS.Properties.Resources.sweep;
            this.btnClr.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClr.Name = "btnClr";
            this.btnClr.SymbolColor = System.Drawing.Color.Empty;
            this.btnClr.Text = "Clear";
            this.btnClr.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnClr.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.btnClr.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnClr.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(40, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Supplier Info";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(35, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "SupplierName";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(37, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "SupplierCode";
            // 
            // txtSuCode
            // 
            // 
            // 
            // 
            this.txtSuCode.CustomButton.Image = null;
            this.txtSuCode.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtSuCode.CustomButton.Name = "";
            this.txtSuCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSuCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSuCode.CustomButton.TabIndex = 1;
            this.txtSuCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuCode.CustomButton.UseSelectable = true;
            this.txtSuCode.CustomButton.Visible = false;
            this.txtSuCode.Lines = new string[0];
            this.txtSuCode.Location = new System.Drawing.Point(172, 69);
            this.txtSuCode.MaxLength = 32767;
            this.txtSuCode.Name = "txtSuCode";
            this.txtSuCode.PasswordChar = '\0';
            this.txtSuCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuCode.SelectedText = "";
            this.txtSuCode.SelectionLength = 0;
            this.txtSuCode.SelectionStart = 0;
            this.txtSuCode.ShortcutsEnabled = true;
            this.txtSuCode.Size = new System.Drawing.Size(264, 23);
            this.txtSuCode.TabIndex = 7;
            this.txtSuCode.UseSelectable = true;
            this.txtSuCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSuCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(473, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Gender";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(474, 108);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Phone";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(475, 165);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(41, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Email";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(549, 170);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(243, 23);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Tag = "email";
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(37, 218);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Address";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(474, 194);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(29, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Fax";
            // 
            // txtFax
            // 
            // 
            // 
            // 
            this.txtFax.CustomButton.Image = null;
            this.txtFax.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtFax.CustomButton.Name = "";
            this.txtFax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFax.CustomButton.TabIndex = 1;
            this.txtFax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFax.CustomButton.UseSelectable = true;
            this.txtFax.CustomButton.Visible = false;
            this.txtFax.Lines = new string[0];
            this.txtFax.Location = new System.Drawing.Point(548, 199);
            this.txtFax.MaxLength = 32767;
            this.txtFax.Name = "txtFax";
            this.txtFax.PasswordChar = '\0';
            this.txtFax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFax.SelectedText = "";
            this.txtFax.SelectionLength = 0;
            this.txtFax.SelectionStart = 0;
            this.txtFax.ShortcutsEnabled = true;
            this.txtFax.Size = new System.Drawing.Size(243, 23);
            this.txtFax.TabIndex = 21;
            this.txtFax.UseSelectable = true;
            this.txtFax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFax2
            // 
            // 
            // 
            // 
            this.txtFax2.CustomButton.Image = null;
            this.txtFax2.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtFax2.CustomButton.Name = "";
            this.txtFax2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFax2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFax2.CustomButton.TabIndex = 1;
            this.txtFax2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFax2.CustomButton.UseSelectable = true;
            this.txtFax2.CustomButton.Visible = false;
            this.txtFax2.Lines = new string[0];
            this.txtFax2.Location = new System.Drawing.Point(548, 228);
            this.txtFax2.MaxLength = 32767;
            this.txtFax2.Name = "txtFax2";
            this.txtFax2.PasswordChar = '\0';
            this.txtFax2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFax2.SelectedText = "";
            this.txtFax2.SelectionLength = 0;
            this.txtFax2.SelectionStart = 0;
            this.txtFax2.ShortcutsEnabled = true;
            this.txtFax2.Size = new System.Drawing.Size(243, 23);
            this.txtFax2.TabIndex = 22;
            this.txtFax2.UseSelectable = true;
            this.txtFax2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFax2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbBGender
            // 
            this.cbBGender.FormattingEnabled = true;
            this.cbBGender.ItemHeight = 23;
            this.cbBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbBGender.Location = new System.Drawing.Point(548, 69);
            this.cbBGender.Name = "cbBGender";
            this.cbBGender.Size = new System.Drawing.Size(243, 29);
            this.cbBGender.TabIndex = 23;
            this.cbBGender.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.txtPhone);
            this.metroPanel1.Controls.Add(this.txtPhone2);
            this.metroPanel1.Controls.Add(this.btnpre);
            this.metroPanel1.Controls.Add(this.btnNexts);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.btnNext);
            this.metroPanel1.Controls.Add(this.btnPrevious);
            this.metroPanel1.Controls.Add(this.itemPanel1);
            this.metroPanel1.Controls.Add(this.dgSu);
            this.metroPanel1.Controls.Add(this.txtSuID);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.rtxtAddress);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.txtEn1);
            this.metroPanel1.Controls.Add(this.txtEn2);
            this.metroPanel1.Controls.Add(this.txtKh2);
            this.metroPanel1.Controls.Add(this.txtKh1);
            this.metroPanel1.Controls.Add(this.cbBGender);
            this.metroPanel1.Controls.Add(this.txtFax2);
            this.metroPanel1.Controls.Add(this.txtFax);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtSuCode);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(35, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(951, 453);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnpre
            // 
            this.btnpre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpre.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpre.Location = new System.Drawing.Point(635, 27);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(75, 23);
            this.btnpre.TabIndex = 89;
            this.btnpre.Text = "Previous";
            this.btnpre.UseVisualStyleBackColor = false;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnNexts
            // 
            this.btnNexts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNexts.Enabled = false;
            this.btnNexts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNexts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNexts.Location = new System.Drawing.Point(716, 27);
            this.btnNexts.Name = "btnNexts";
            this.btnNexts.Size = new System.Drawing.Size(75, 23);
            this.btnNexts.TabIndex = 88;
            this.btnNexts.Text = "Next";
            this.btnNexts.UseVisualStyleBackColor = false;
            this.btnNexts.Click += new System.EventHandler(this.btnNexts_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(486, 302);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(70, 19);
            this.metroLabel10.TabIndex = 40;
            this.metroLabel10.Text = "Load data";
            this.metroLabel10.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Location = new System.Drawing.Point(674, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 24);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 42;
            this.btnNext.Text = "Next";
            this.btnNext.Visible = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrevious.Location = new System.Drawing.Point(575, 27);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrevious.TabIndex = 41;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Visible = false;
            // 
            // dgSu
            // 
            this.dgSu.AllowUserToAddRows = false;
            this.dgSu.AllowUserToDeleteRows = false;
            this.dgSu.AllowUserToResizeRows = false;
            this.dgSu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgSu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgSu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSu.EnableHeadersVisualStyles = false;
            this.dgSu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgSu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgSu.Location = new System.Drawing.Point(500, 334);
            this.dgSu.MultiSelect = false;
            this.dgSu.Name = "dgSu";
            this.dgSu.ReadOnly = true;
            this.dgSu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSu.Size = new System.Drawing.Size(35, 21);
            this.dgSu.TabIndex = 30;
            this.dgSu.Visible = false;
            this.dgSu.SelectionChanged += new System.EventHandler(this.dgSu_SelectionChanged);
            this.dgSu.Click += new System.EventHandler(this.dgSu_Click);
            // 
            // txtSuID
            // 
            // 
            // 
            // 
            this.txtSuID.CustomButton.Image = null;
            this.txtSuID.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtSuID.CustomButton.Name = "";
            this.txtSuID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSuID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSuID.CustomButton.TabIndex = 1;
            this.txtSuID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuID.CustomButton.UseSelectable = true;
            this.txtSuID.CustomButton.Visible = false;
            this.txtSuID.Lines = new string[] {
        "1"};
            this.txtSuID.Location = new System.Drawing.Point(346, 27);
            this.txtSuID.MaxLength = 32767;
            this.txtSuID.Name = "txtSuID";
            this.txtSuID.PasswordChar = '\0';
            this.txtSuID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuID.SelectedText = "";
            this.txtSuID.SelectionLength = 0;
            this.txtSuID.SelectionStart = 0;
            this.txtSuID.ShortcutsEnabled = true;
            this.txtSuID.Size = new System.Drawing.Size(210, 23);
            this.txtSuID.TabIndex = 39;
            this.txtSuID.Text = "1";
            this.txtSuID.UseSelectable = true;
            this.txtSuID.Visible = false;
            this.txtSuID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSuID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(246, 27);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(72, 19);
            this.metroLabel13.TabIndex = 38;
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
            this.rtxtAddress.Location = new System.Drawing.Point(172, 227);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n{\\colortbl ;\\red51\\green153\\blue255;}\r\n\\viewkind4\\uc1\\pard\\cf1\\f0\\" +
    "fs17\\par\r\n}\r\n";
            this.rtxtAddress.Size = new System.Drawing.Size(264, 158);
            this.rtxtAddress.TabIndex = 37;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(246, 108);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(109, 19);
            this.metroLabel12.TabIndex = 36;
            this.metroLabel12.Text = "(Name in Khmer)";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(244, 160);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(111, 19);
            this.metroLabel11.TabIndex = 35;
            this.metroLabel11.Text = "(Name in English)";
            // 
            // txtEn1
            // 
            // 
            // 
            // 
            this.txtEn1.CustomButton.Image = null;
            this.txtEn1.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEn1.CustomButton.Name = "";
            this.txtEn1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn1.CustomButton.TabIndex = 1;
            this.txtEn1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn1.CustomButton.UseSelectable = true;
            this.txtEn1.CustomButton.Visible = false;
            this.txtEn1.Lines = new string[0];
            this.txtEn1.Location = new System.Drawing.Point(172, 182);
            this.txtEn1.MaxLength = 32767;
            this.txtEn1.Name = "txtEn1";
            this.txtEn1.PasswordChar = '\0';
            this.txtEn1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn1.SelectedText = "";
            this.txtEn1.SelectionLength = 0;
            this.txtEn1.SelectionStart = 0;
            this.txtEn1.ShortcutsEnabled = true;
            this.txtEn1.Size = new System.Drawing.Size(127, 23);
            this.txtEn1.TabIndex = 34;
            this.txtEn1.UseSelectable = true;
            this.txtEn1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEn2
            // 
            // 
            // 
            // 
            this.txtEn2.CustomButton.Image = null;
            this.txtEn2.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtEn2.CustomButton.Name = "";
            this.txtEn2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn2.CustomButton.TabIndex = 1;
            this.txtEn2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn2.CustomButton.UseSelectable = true;
            this.txtEn2.CustomButton.Visible = false;
            this.txtEn2.Lines = new string[0];
            this.txtEn2.Location = new System.Drawing.Point(309, 182);
            this.txtEn2.MaxLength = 32767;
            this.txtEn2.Name = "txtEn2";
            this.txtEn2.PasswordChar = '\0';
            this.txtEn2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn2.SelectedText = "";
            this.txtEn2.SelectionLength = 0;
            this.txtEn2.SelectionStart = 0;
            this.txtEn2.ShortcutsEnabled = true;
            this.txtEn2.Size = new System.Drawing.Size(127, 23);
            this.txtEn2.TabIndex = 33;
            this.txtEn2.UseSelectable = true;
            this.txtEn2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKh2
            // 
            // 
            // 
            // 
            this.txtKh2.CustomButton.Image = null;
            this.txtKh2.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtKh2.CustomButton.Name = "";
            this.txtKh2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh2.CustomButton.TabIndex = 1;
            this.txtKh2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh2.CustomButton.UseSelectable = true;
            this.txtKh2.CustomButton.Visible = false;
            this.txtKh2.Lines = new string[0];
            this.txtKh2.Location = new System.Drawing.Point(309, 131);
            this.txtKh2.MaxLength = 32767;
            this.txtKh2.Name = "txtKh2";
            this.txtKh2.PasswordChar = '\0';
            this.txtKh2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh2.SelectedText = "";
            this.txtKh2.SelectionLength = 0;
            this.txtKh2.SelectionStart = 0;
            this.txtKh2.ShortcutsEnabled = true;
            this.txtKh2.Size = new System.Drawing.Size(127, 23);
            this.txtKh2.TabIndex = 32;
            this.txtKh2.UseSelectable = true;
            this.txtKh2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKh1
            // 
            // 
            // 
            // 
            this.txtKh1.CustomButton.Image = null;
            this.txtKh1.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtKh1.CustomButton.Name = "";
            this.txtKh1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh1.CustomButton.TabIndex = 1;
            this.txtKh1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh1.CustomButton.UseSelectable = true;
            this.txtKh1.CustomButton.Visible = false;
            this.txtKh1.Lines = new string[0];
            this.txtKh1.Location = new System.Drawing.Point(172, 131);
            this.txtKh1.MaxLength = 32767;
            this.txtKh1.Name = "txtKh1";
            this.txtKh1.PasswordChar = '\0';
            this.txtKh1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh1.SelectedText = "";
            this.txtKh1.SelectionLength = 0;
            this.txtKh1.SelectionStart = 0;
            this.txtKh1.ShortcutsEnabled = true;
            this.txtKh1.Size = new System.Drawing.Size(131, 23);
            this.txtKh1.TabIndex = 31;
            this.txtKh1.UseSelectable = true;
            this.txtKh1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(265, 22);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(548, 134);
            this.txtPhone2.Mask = "(999) 000-0000";
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(243, 20);
            this.txtPhone2.TabIndex = 90;
            this.txtPhone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(548, 108);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 20);
            this.txtPhone.TabIndex = 90;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSupplier_FormClosing);
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmSupplier_Paint);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnFind;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnNew;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnSave;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnDel;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnClr;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSuCode;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtFax;
        private MetroFramework.Controls.MetroTextBox txtFax2;
        private MetroFramework.Controls.MetroComboBox cbBGender;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtEn1;
        private MetroFramework.Controls.MetroTextBox txtEn2;
        private MetroFramework.Controls.MetroTextBox txtKh2;
        private MetroFramework.Controls.MetroTextBox txtKh1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtAddress;
        private MetroFramework.Controls.MetroTextBox txtSuID;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroGrid dgSu;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnPrevious;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnNexts;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtPhone2;
    }
}