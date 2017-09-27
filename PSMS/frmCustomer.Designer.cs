namespace PSMS
{
    partial class frmCustomer
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
            this.btnFind = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnNew = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnDel = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnne = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.btnClr = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.cbbEmp2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCusID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cbBStatus = new MetroFramework.Controls.MetroComboBox();
            this.rtxtAddress = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtEn1 = new MetroFramework.Controls.MetroTextBox();
            this.txtEn2 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh2 = new MetroFramework.Controls.MetroTextBox();
            this.Opendate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbBGender = new MetroFramework.Controls.MetroComboBox();
            this.txtPhone2xx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtphonexx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCusCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtKh1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblBalance = new MetroFramework.Controls.MetroLabel();
            this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opendate)).BeginInit();
            this.itemPanel2.SuspendLayout();
            this.SuspendLayout();
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
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = true;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.btnne);
            this.metroPanel1.Controls.Add(this.btnpre);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.cbbEmp2);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.txtCusID);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.cbBStatus);
            this.metroPanel1.Controls.Add(this.rtxtAddress);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.txtEn1);
            this.metroPanel1.Controls.Add(this.txtEn2);
            this.metroPanel1.Controls.Add(this.txtKh2);
            this.metroPanel1.Controls.Add(this.Opendate);
            this.metroPanel1.Controls.Add(this.cbBGender);
            this.metroPanel1.Controls.Add(this.txtPhone2xx);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.txtphonexx);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtCusCode);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtKh1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtPhone2);
            this.metroPanel1.Controls.Add(this.txtphone);
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(960, 452);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnne
            // 
            this.btnne.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnne.Enabled = false;
            this.btnne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnne.ForeColor = System.Drawing.SystemColors.Control;
            this.btnne.Location = new System.Drawing.Point(700, 3);
            this.btnne.Name = "btnne";
            this.btnne.Size = new System.Drawing.Size(107, 38);
            this.btnne.TabIndex = 88;
            this.btnne.Text = "Next";
            this.btnne.UseVisualStyleBackColor = false;
            this.btnne.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpre
            // 
            this.btnpre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpre.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpre.Location = new System.Drawing.Point(578, 3);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(105, 38);
            this.btnpre.TabIndex = 89;
            this.btnpre.Text = "Previous";
            this.btnpre.UseVisualStyleBackColor = false;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(526, 333);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 20);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Load Data";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.itemPanel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(813, 39);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(111, 364);
            this.metroPanel2.TabIndex = 31;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // itemPanel1
            // 
            this.itemPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.itemPanel1.Location = new System.Drawing.Point(3, 3);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(105, 361);
            this.itemPanel1.TabIndex = 20;
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
            this.btnClr.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
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
            // cbbEmp2
            // 
            this.cbbEmp2.FormattingEnabled = true;
            this.cbbEmp2.Location = new System.Drawing.Point(526, 217);
            this.cbbEmp2.Name = "cbbEmp2";
            this.cbbEmp2.Size = new System.Drawing.Size(262, 27);
            this.cbbEmp2.TabIndex = 41;
            this.cbbEmp2.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.Location = new System.Drawing.Point(546, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(29, 22);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtCusID
            // 
            // 
            // 
            // 
            this.txtCusID.CustomButton.Enabled = false;
            this.txtCusID.CustomButton.Image = null;
            this.txtCusID.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtCusID.CustomButton.Name = "";
            this.txtCusID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCusID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCusID.CustomButton.TabIndex = 1;
            this.txtCusID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCusID.CustomButton.UseSelectable = true;
            this.txtCusID.CustomButton.Visible = false;
            this.txtCusID.Enabled = false;
            this.txtCusID.Lines = new string[] {
        "1"};
            this.txtCusID.Location = new System.Drawing.Point(133, 42);
            this.txtCusID.MaxLength = 32767;
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.PasswordChar = '\0';
            this.txtCusID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCusID.SelectedText = "";
            this.txtCusID.SelectionLength = 0;
            this.txtCusID.SelectionStart = 0;
            this.txtCusID.ShortcutsEnabled = true;
            this.txtCusID.Size = new System.Drawing.Size(265, 23);
            this.txtCusID.TabIndex = 39;
            this.txtCusID.Text = "1";
            this.txtCusID.UseSelectable = true;
            this.txtCusID.Visible = false;
            this.txtCusID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCusID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel14.Location = new System.Drawing.Point(33, 42);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(82, 20);
            this.metroLabel14.TabIndex = 38;
            this.metroLabel14.Text = "CustomerID";
            this.metroLabel14.Visible = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel13.Location = new System.Drawing.Point(427, 214);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(46, 20);
            this.metroLabel13.TabIndex = 34;
            this.metroLabel13.Text = "Agent";
            // 
            // cbBStatus
            // 
            this.cbBStatus.FormattingEnabled = true;
            this.cbBStatus.ItemHeight = 24;
            this.cbBStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbBStatus.Location = new System.Drawing.Point(526, 247);
            this.cbBStatus.Name = "cbBStatus";
            this.cbBStatus.Size = new System.Drawing.Size(262, 30);
            this.cbBStatus.TabIndex = 33;
            this.cbBStatus.UseSelectable = true;
            // 
            // rtxtAddress
            // 
            // 
            // 
            // 
            this.rtxtAddress.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtxtAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtxtAddress.Location = new System.Drawing.Point(133, 247);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}" +
    "\r\n{\\colortbl ;\\red0\\green120\\blue215;}\r\n\\viewkind4\\uc1\\pard\\cf1\\f0\\fs17\\par\r\n}\r\n" +
    "";
            this.rtxtAddress.Size = new System.Drawing.Size(265, 169);
            this.rtxtAddress.TabIndex = 32;
            this.rtxtAddress.Enter += new System.EventHandler(this.rtxtAddress_Enter);
            this.rtxtAddress.Leave += new System.EventHandler(this.rtxtAddress_Leave);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(186, 125);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(115, 20);
            this.metroLabel12.TabIndex = 30;
            this.metroLabel12.Text = "(Name in Khmer)";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(186, 182);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(118, 20);
            this.metroLabel11.TabIndex = 29;
            this.metroLabel11.Text = "(Name in English)";
            // 
            // txtEn1
            // 
            // 
            // 
            // 
            this.txtEn1.CustomButton.Image = null;
            this.txtEn1.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtEn1.CustomButton.Name = "";
            this.txtEn1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn1.CustomButton.TabIndex = 1;
            this.txtEn1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn1.CustomButton.UseSelectable = true;
            this.txtEn1.CustomButton.Visible = false;
            this.txtEn1.Lines = new string[0];
            this.txtEn1.Location = new System.Drawing.Point(133, 207);
            this.txtEn1.MaxLength = 32767;
            this.txtEn1.Name = "txtEn1";
            this.txtEn1.PasswordChar = '\0';
            this.txtEn1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn1.SelectedText = "";
            this.txtEn1.SelectionLength = 0;
            this.txtEn1.SelectionStart = 0;
            this.txtEn1.ShortcutsEnabled = true;
            this.txtEn1.Size = new System.Drawing.Size(123, 23);
            this.txtEn1.TabIndex = 28;
            this.txtEn1.UseSelectable = true;
            this.txtEn1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEn1.Enter += new System.EventHandler(this.txtEn1_Enter);
            this.txtEn1.Leave += new System.EventHandler(this.txtEn1_Leave);
            // 
            // txtEn2
            // 
            // 
            // 
            // 
            this.txtEn2.CustomButton.Image = null;
            this.txtEn2.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtEn2.CustomButton.Name = "";
            this.txtEn2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn2.CustomButton.TabIndex = 1;
            this.txtEn2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn2.CustomButton.UseSelectable = true;
            this.txtEn2.CustomButton.Visible = false;
            this.txtEn2.Lines = new string[0];
            this.txtEn2.Location = new System.Drawing.Point(278, 207);
            this.txtEn2.MaxLength = 32767;
            this.txtEn2.Name = "txtEn2";
            this.txtEn2.PasswordChar = '\0';
            this.txtEn2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn2.SelectedText = "";
            this.txtEn2.SelectionLength = 0;
            this.txtEn2.SelectionStart = 0;
            this.txtEn2.ShortcutsEnabled = true;
            this.txtEn2.Size = new System.Drawing.Size(120, 23);
            this.txtEn2.TabIndex = 27;
            this.txtEn2.UseSelectable = true;
            this.txtEn2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEn2.Enter += new System.EventHandler(this.txtEn2_Enter);
            this.txtEn2.Leave += new System.EventHandler(this.txtEn2_Leave);
            // 
            // txtKh2
            // 
            // 
            // 
            // 
            this.txtKh2.CustomButton.Image = null;
            this.txtKh2.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.txtKh2.CustomButton.Name = "";
            this.txtKh2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh2.CustomButton.TabIndex = 1;
            this.txtKh2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh2.CustomButton.UseSelectable = true;
            this.txtKh2.CustomButton.Visible = false;
            this.txtKh2.Lines = new string[0];
            this.txtKh2.Location = new System.Drawing.Point(278, 156);
            this.txtKh2.MaxLength = 32767;
            this.txtKh2.Name = "txtKh2";
            this.txtKh2.PasswordChar = '\0';
            this.txtKh2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh2.SelectedText = "";
            this.txtKh2.SelectionLength = 0;
            this.txtKh2.SelectionStart = 0;
            this.txtKh2.ShortcutsEnabled = true;
            this.txtKh2.Size = new System.Drawing.Size(122, 23);
            this.txtKh2.TabIndex = 26;
            this.txtKh2.UseSelectable = true;
            this.txtKh2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKh2.Enter += new System.EventHandler(this.txtKh2_Enter);
            this.txtKh2.Leave += new System.EventHandler(this.txtKh2_Leave);
            // 
            // Opendate
            // 
            // 
            // 
            // 
            this.Opendate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Opendate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Opendate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.Opendate.ButtonDropDown.Visible = true;
            this.Opendate.IsPopupCalendarOpen = false;
            this.Opendate.Location = new System.Drawing.Point(525, 287);
            this.Opendate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.Opendate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Opendate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.Opendate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.Opendate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.Opendate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.Opendate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Opendate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Opendate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.Opendate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.Opendate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Opendate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.Opendate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Opendate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.Opendate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Opendate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Opendate.MonthCalendar.TodayButtonVisible = true;
            this.Opendate.Name = "Opendate";
            this.Opendate.Size = new System.Drawing.Size(265, 26);
            this.Opendate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Opendate.TabIndex = 25;
            // 
            // cbBGender
            // 
            this.cbBGender.FormattingEnabled = true;
            this.cbBGender.ItemHeight = 24;
            this.cbBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbBGender.Location = new System.Drawing.Point(525, 89);
            this.cbBGender.Name = "cbBGender";
            this.cbBGender.Size = new System.Drawing.Size(264, 30);
            this.cbBGender.TabIndex = 24;
            this.cbBGender.UseSelectable = true;
            // 
            // txtPhone2xx
            // 
            // 
            // 
            // 
            this.txtPhone2xx.CustomButton.Image = null;
            this.txtPhone2xx.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtPhone2xx.CustomButton.Name = "";
            this.txtPhone2xx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone2xx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone2xx.CustomButton.TabIndex = 1;
            this.txtPhone2xx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone2xx.CustomButton.UseSelectable = true;
            this.txtPhone2xx.CustomButton.Visible = false;
            this.txtPhone2xx.Lines = new string[0];
            this.txtPhone2xx.Location = new System.Drawing.Point(526, 156);
            this.txtPhone2xx.MaxLength = 32767;
            this.txtPhone2xx.Name = "txtPhone2xx";
            this.txtPhone2xx.PasswordChar = '\0';
            this.txtPhone2xx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone2xx.SelectedText = "";
            this.txtPhone2xx.SelectionLength = 0;
            this.txtPhone2xx.SelectionStart = 0;
            this.txtPhone2xx.ShortcutsEnabled = true;
            this.txtPhone2xx.Size = new System.Drawing.Size(264, 23);
            this.txtPhone2xx.TabIndex = 19;
            this.txtPhone2xx.UseSelectable = true;
            this.txtPhone2xx.Visible = false;
            this.txtPhone2xx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone2xx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel10.Location = new System.Drawing.Point(427, 287);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(100, 20);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Acc_Opendate";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.Location = new System.Drawing.Point(32, 236);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 20);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Address";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(526, 186);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(263, 23);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Tag = "email";
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel9.Location = new System.Drawing.Point(428, 185);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(42, 20);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Email";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(426, 250);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 20);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Status";
            // 
            // txtphonexx
            // 
            // 
            // 
            // 
            this.txtphonexx.CustomButton.Image = null;
            this.txtphonexx.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtphonexx.CustomButton.Name = "";
            this.txtphonexx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtphonexx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtphonexx.CustomButton.TabIndex = 1;
            this.txtphonexx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtphonexx.CustomButton.UseSelectable = true;
            this.txtphonexx.CustomButton.Visible = false;
            this.txtphonexx.Lines = new string[0];
            this.txtphonexx.Location = new System.Drawing.Point(526, 128);
            this.txtphonexx.MaxLength = 32767;
            this.txtphonexx.Name = "txtphonexx";
            this.txtphonexx.PasswordChar = '\0';
            this.txtphonexx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtphonexx.SelectedText = "";
            this.txtphonexx.SelectionLength = 0;
            this.txtphonexx.SelectionStart = 0;
            this.txtphonexx.ShortcutsEnabled = true;
            this.txtphonexx.Size = new System.Drawing.Size(264, 23);
            this.txtphonexx.TabIndex = 11;
            this.txtphonexx.UseSelectable = true;
            this.txtphonexx.Visible = false;
            this.txtphonexx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtphonexx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(429, 128);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 20);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Phone";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(429, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 20);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Gender";
            // 
            // txtCusCode
            // 
            // 
            // 
            // 
            this.txtCusCode.CustomButton.Enabled = false;
            this.txtCusCode.CustomButton.Image = null;
            this.txtCusCode.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtCusCode.CustomButton.Name = "";
            this.txtCusCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCusCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCusCode.CustomButton.TabIndex = 1;
            this.txtCusCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCusCode.CustomButton.UseSelectable = true;
            this.txtCusCode.CustomButton.Visible = false;
            this.txtCusCode.Enabled = false;
            this.txtCusCode.Lines = new string[0];
            this.txtCusCode.Location = new System.Drawing.Point(133, 90);
            this.txtCusCode.MaxLength = 32767;
            this.txtCusCode.Name = "txtCusCode";
            this.txtCusCode.PasswordChar = '\0';
            this.txtCusCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCusCode.SelectedText = "";
            this.txtCusCode.SelectionLength = 0;
            this.txtCusCode.SelectionStart = 0;
            this.txtCusCode.ShortcutsEnabled = true;
            this.txtCusCode.Size = new System.Drawing.Size(265, 23);
            this.txtCusCode.TabIndex = 7;
            this.txtCusCode.UseSelectable = true;
            this.txtCusCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCusCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(33, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "CustomerCode";
            // 
            // txtKh1
            // 
            // 
            // 
            // 
            this.txtKh1.CustomButton.Image = null;
            this.txtKh1.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtKh1.CustomButton.Name = "";
            this.txtKh1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh1.CustomButton.TabIndex = 1;
            this.txtKh1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh1.CustomButton.UseSelectable = true;
            this.txtKh1.CustomButton.Visible = false;
            this.txtKh1.Lines = new string[0];
            this.txtKh1.Location = new System.Drawing.Point(133, 156);
            this.txtKh1.MaxLength = 32767;
            this.txtKh1.Name = "txtKh1";
            this.txtKh1.PasswordChar = '\0';
            this.txtKh1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh1.SelectedText = "";
            this.txtKh1.SelectionLength = 0;
            this.txtKh1.SelectionStart = 0;
            this.txtKh1.ShortcutsEnabled = true;
            this.txtKh1.Size = new System.Drawing.Size(123, 23);
            this.txtKh1.TabIndex = 4;
            this.txtKh1.UseSelectable = true;
            this.txtKh1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKh1.Enter += new System.EventHandler(this.txtKh1_Enter);
            this.txtKh1.Leave += new System.EventHandler(this.txtKh1_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(30, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "CustomerName";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(526, 156);
            this.txtPhone2.Mask = "(999) 000-0000";
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(264, 26);
            this.txtPhone2.TabIndex = 90;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(526, 128);
            this.txtphone.Mask = "(999) 000-0000";
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(264, 26);
            this.txtphone.TabIndex = 90;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(789, 546);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(57, 20);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.ForeColor = System.Drawing.Color.Red;
            this.lblBalance.Location = new System.Drawing.Point(861, 546);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(128, 19);
            this.lblBalance.TabIndex = 28;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // itemPanel2
            // 
            // 
            // 
            // 
            this.itemPanel2.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel2.ContainerControlProcessDialogKey = true;
            this.itemPanel2.Controls.Add(this.metroPanel1);
            this.itemPanel2.DragDropSupport = true;
            this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem3});
            this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel2.Location = new System.Drawing.Point(33, 63);
            this.itemPanel2.Name = "itemPanel2";
            this.itemPanel2.Size = new System.Drawing.Size(968, 458);
            this.itemPanel2.TabIndex = 29;
            this.itemPanel2.Text = "itemPanel2";
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.Control = this.metroPanel1;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.itemPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCustomer";
            this.Resizable = false;
            this.Text = "Customer Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opendate)).EndInit();
            this.itemPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTileItem btnSave;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnFind;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnDel;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnNew;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblBalance;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnClr;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private System.Windows.Forms.ComboBox cbbEmp2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtCusID;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox cbBStatus;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtEn1;
        private MetroFramework.Controls.MetroTextBox txtEn2;
        private MetroFramework.Controls.MetroTextBox txtKh2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Opendate;
        private MetroFramework.Controls.MetroComboBox cbBGender;
        private MetroFramework.Controls.MetroTextBox txtPhone2xx;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtphonexx;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCusCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtKh1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DevComponents.DotNetBar.ItemPanel itemPanel2;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnne;
        private System.Windows.Forms.MaskedTextBox txtphone;
        private System.Windows.Forms.MaskedTextBox txtPhone2;

    }
}