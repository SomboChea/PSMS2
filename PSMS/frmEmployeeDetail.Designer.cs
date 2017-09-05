namespace PSMS
{
    partial class frmEmployeeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDetail));
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.btnNew = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDel = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnClr = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.cbBGender = new MetroFramework.Controls.MetroComboBox();
            this.txtEmpID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.rtxtAddress = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtEn1 = new MetroFramework.Controls.MetroTextBox();
            this.txtEn2 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh2 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh1 = new MetroFramework.Controls.MetroTextBox();
            this.Join_date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.txtPosID = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.joindate = new MetroFramework.Controls.MetroLabel();
            this.txtIDCard = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.Salary = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Join_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.itemContainer4,
            this.itemContainer2,
            this.itemContainer3,
            this.itemContainer1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(712, 82);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(105, 250);
            this.itemPanel1.TabIndex = 33;
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
            // cbBGender
            // 
            this.cbBGender.FormattingEnabled = true;
            this.cbBGender.ItemHeight = 23;
            this.cbBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbBGender.Location = new System.Drawing.Point(146, 243);
            this.cbBGender.Name = "cbBGender";
            this.cbBGender.Size = new System.Drawing.Size(47, 29);
            this.cbBGender.TabIndex = 109;
            this.cbBGender.UseSelectable = true;
            this.cbBGender.Visible = false;
            // 
            // txtEmpID
            // 
            // 
            // 
            // 
            this.txtEmpID.CustomButton.Image = null;
            this.txtEmpID.CustomButton.Location = new System.Drawing.Point(2, 1);
            this.txtEmpID.CustomButton.Name = "";
            this.txtEmpID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpID.CustomButton.TabIndex = 1;
            this.txtEmpID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpID.CustomButton.UseSelectable = true;
            this.txtEmpID.CustomButton.Visible = false;
            this.txtEmpID.Lines = new string[0];
            this.txtEmpID.Location = new System.Drawing.Point(308, 50);
            this.txtEmpID.MaxLength = 32767;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.PasswordChar = '\0';
            this.txtEmpID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpID.SelectedText = "";
            this.txtEmpID.SelectionLength = 0;
            this.txtEmpID.SelectionStart = 0;
            this.txtEmpID.ShortcutsEnabled = true;
            this.txtEmpID.Size = new System.Drawing.Size(24, 23);
            this.txtEmpID.TabIndex = 108;
            this.txtEmpID.UseSelectable = true;
            this.txtEmpID.Visible = false;
            this.txtEmpID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel14.Location = new System.Drawing.Point(203, 50);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(83, 19);
            this.metroLabel14.TabIndex = 107;
            this.metroLabel14.Text = "Employee ID";
            this.metroLabel14.Visible = false;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(455, 127);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(47, 23);
            this.txtPhone.TabIndex = 106;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.Visible = false;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel13.Location = new System.Drawing.Point(371, 127);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(46, 19);
            this.metroLabel13.TabIndex = 105;
            this.metroLabel13.Text = "Phone";
            this.metroLabel13.Visible = false;
            // 
            // rtxtAddress
            // 
            // 
            // 
            // 
            this.rtxtAddress.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtxtAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtxtAddress.Location = new System.Drawing.Point(146, 285);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.rtxtAddress.Size = new System.Drawing.Size(47, 35);
            this.rtxtAddress.TabIndex = 104;
            this.rtxtAddress.Visible = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(199, 127);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(109, 19);
            this.metroLabel12.TabIndex = 103;
            this.metroLabel12.Text = "(Name in Khmer)";
            this.metroLabel12.Visible = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(199, 184);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(111, 19);
            this.metroLabel9.TabIndex = 102;
            this.metroLabel9.Text = "(Name in English)";
            this.metroLabel9.Visible = false;
            // 
            // txtEn1
            // 
            // 
            // 
            // 
            this.txtEn1.CustomButton.Image = null;
            this.txtEn1.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtEn1.CustomButton.Name = "";
            this.txtEn1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn1.CustomButton.TabIndex = 1;
            this.txtEn1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn1.CustomButton.UseSelectable = true;
            this.txtEn1.CustomButton.Visible = false;
            this.txtEn1.Lines = new string[0];
            this.txtEn1.Location = new System.Drawing.Point(146, 209);
            this.txtEn1.MaxLength = 32767;
            this.txtEn1.Name = "txtEn1";
            this.txtEn1.PasswordChar = '\0';
            this.txtEn1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn1.SelectedText = "";
            this.txtEn1.SelectionLength = 0;
            this.txtEn1.SelectionStart = 0;
            this.txtEn1.ShortcutsEnabled = true;
            this.txtEn1.Size = new System.Drawing.Size(33, 23);
            this.txtEn1.TabIndex = 101;
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
            this.txtEn2.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtEn2.CustomButton.Name = "";
            this.txtEn2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn2.CustomButton.TabIndex = 1;
            this.txtEn2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn2.CustomButton.UseSelectable = true;
            this.txtEn2.CustomButton.Visible = false;
            this.txtEn2.Lines = new string[0];
            this.txtEn2.Location = new System.Drawing.Point(256, 209);
            this.txtEn2.MaxLength = 32767;
            this.txtEn2.Name = "txtEn2";
            this.txtEn2.PasswordChar = '\0';
            this.txtEn2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn2.SelectedText = "";
            this.txtEn2.SelectionLength = 0;
            this.txtEn2.SelectionStart = 0;
            this.txtEn2.ShortcutsEnabled = true;
            this.txtEn2.Size = new System.Drawing.Size(33, 23);
            this.txtEn2.TabIndex = 100;
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
            this.txtKh2.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtKh2.CustomButton.Name = "";
            this.txtKh2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh2.CustomButton.TabIndex = 1;
            this.txtKh2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh2.CustomButton.UseSelectable = true;
            this.txtKh2.CustomButton.Visible = false;
            this.txtKh2.Lines = new string[0];
            this.txtKh2.Location = new System.Drawing.Point(256, 158);
            this.txtKh2.MaxLength = 32767;
            this.txtKh2.Name = "txtKh2";
            this.txtKh2.PasswordChar = '\0';
            this.txtKh2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh2.SelectedText = "";
            this.txtKh2.SelectionLength = 0;
            this.txtKh2.SelectionStart = 0;
            this.txtKh2.ShortcutsEnabled = true;
            this.txtKh2.Size = new System.Drawing.Size(33, 23);
            this.txtKh2.TabIndex = 99;
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
            this.txtKh1.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtKh1.CustomButton.Name = "";
            this.txtKh1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh1.CustomButton.TabIndex = 1;
            this.txtKh1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh1.CustomButton.UseSelectable = true;
            this.txtKh1.CustomButton.Visible = false;
            this.txtKh1.Lines = new string[0];
            this.txtKh1.Location = new System.Drawing.Point(146, 158);
            this.txtKh1.MaxLength = 32767;
            this.txtKh1.Name = "txtKh1";
            this.txtKh1.PasswordChar = '\0';
            this.txtKh1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh1.SelectedText = "";
            this.txtKh1.SelectionLength = 0;
            this.txtKh1.SelectionStart = 0;
            this.txtKh1.ShortcutsEnabled = true;
            this.txtKh1.Size = new System.Drawing.Size(33, 23);
            this.txtKh1.TabIndex = 98;
            this.txtKh1.UseSelectable = true;
            this.txtKh1.Visible = false;
            this.txtKh1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Join_date
            // 
            // 
            // 
            // 
            this.Join_date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Join_date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Join_date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.Join_date.ButtonDropDown.Visible = true;
            this.Join_date.IsPopupCalendarOpen = false;
            this.Join_date.Location = new System.Drawing.Point(455, 285);
            this.Join_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.Join_date.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Join_date.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.Join_date.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.Join_date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.Join_date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.Join_date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Join_date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Join_date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.Join_date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.Join_date.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Join_date.MonthCalendar.DisplayMonth = new System.DateTime(2016, 8, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.Join_date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Join_date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.Join_date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Join_date.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Join_date.MonthCalendar.TodayButtonVisible = true;
            this.Join_date.Name = "Join_date";
            this.Join_date.Size = new System.Drawing.Size(47, 20);
            this.Join_date.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Join_date.TabIndex = 97;
            this.Join_date.Visible = false;
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(455, 243);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(47, 23);
            this.txtSalary.TabIndex = 96;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.Visible = false;
            this.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPosID
            // 
            // 
            // 
            // 
            this.txtPosID.CustomButton.Image = null;
            this.txtPosID.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.txtPosID.CustomButton.Name = "";
            this.txtPosID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPosID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPosID.CustomButton.TabIndex = 1;
            this.txtPosID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPosID.CustomButton.UseSelectable = true;
            this.txtPosID.CustomButton.Visible = false;
            this.txtPosID.Lines = new string[0];
            this.txtPosID.Location = new System.Drawing.Point(455, 206);
            this.txtPosID.MaxLength = 32767;
            this.txtPosID.Name = "txtPosID";
            this.txtPosID.PasswordChar = '\0';
            this.txtPosID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPosID.SelectedText = "";
            this.txtPosID.SelectionLength = 0;
            this.txtPosID.SelectionStart = 0;
            this.txtPosID.ShortcutsEnabled = true;
            this.txtPosID.Size = new System.Drawing.Size(47, 23);
            this.txtPosID.TabIndex = 95;
            this.txtPosID.UseSelectable = true;
            this.txtPosID.Visible = false;
            this.txtPosID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPosID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(455, 161);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(47, 23);
            this.txtEmail.TabIndex = 94;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.Visible = false;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel10.Location = new System.Drawing.Point(39, 285);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(56, 19);
            this.metroLabel10.TabIndex = 93;
            this.metroLabel10.Text = "Address";
            this.metroLabel10.Visible = false;
            // 
            // joindate
            // 
            this.joindate.AutoSize = true;
            this.joindate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.joindate.Location = new System.Drawing.Point(369, 283);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(63, 19);
            this.joindate.TabIndex = 92;
            this.joindate.Text = "Join Date";
            this.joindate.Visible = false;
            // 
            // txtIDCard
            // 
            // 
            // 
            // 
            this.txtIDCard.CustomButton.Image = null;
            this.txtIDCard.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.txtIDCard.CustomButton.Name = "";
            this.txtIDCard.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCard.CustomButton.TabIndex = 1;
            this.txtIDCard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCard.CustomButton.UseSelectable = true;
            this.txtIDCard.CustomButton.Visible = false;
            this.txtIDCard.Lines = new string[0];
            this.txtIDCard.Location = new System.Drawing.Point(455, 95);
            this.txtIDCard.MaxLength = 32767;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.PasswordChar = '\0';
            this.txtIDCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCard.SelectedText = "";
            this.txtIDCard.SelectionLength = 0;
            this.txtIDCard.SelectionStart = 0;
            this.txtIDCard.ShortcutsEnabled = true;
            this.txtIDCard.Size = new System.Drawing.Size(47, 23);
            this.txtIDCard.TabIndex = 91;
            this.txtIDCard.UseSelectable = true;
            this.txtIDCard.Visible = false;
            this.txtIDCard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDCard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(371, 95);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 90;
            this.metroLabel8.Text = "IDCard";
            this.metroLabel8.Visible = false;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salary.Location = new System.Drawing.Point(373, 243);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(45, 19);
            this.Salary.TabIndex = 89;
            this.Salary.Text = "Salary";
            this.Salary.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.Location = new System.Drawing.Point(39, 243);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 88;
            this.metroLabel6.Text = "Gender";
            this.metroLabel6.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(370, 210);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 87;
            this.metroLabel1.Text = "Postion ID";
            this.metroLabel1.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(41, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 86;
            this.metroLabel2.Text = "Employee Name";
            this.metroLabel2.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(371, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 85;
            this.metroLabel4.Text = "Email";
            this.metroLabel4.Visible = false;
            // 
            // txtEmpCode
            // 
            // 
            // 
            // 
            this.txtEmpCode.CustomButton.Image = null;
            this.txtEmpCode.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.txtEmpCode.CustomButton.Name = "";
            this.txtEmpCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpCode.CustomButton.TabIndex = 1;
            this.txtEmpCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpCode.CustomButton.UseSelectable = true;
            this.txtEmpCode.CustomButton.Visible = false;
            this.txtEmpCode.Enabled = false;
            this.txtEmpCode.Lines = new string[0];
            this.txtEmpCode.Location = new System.Drawing.Point(146, 95);
            this.txtEmpCode.MaxLength = 32767;
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.PasswordChar = '\0';
            this.txtEmpCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpCode.SelectedText = "";
            this.txtEmpCode.SelectionLength = 0;
            this.txtEmpCode.SelectionStart = 0;
            this.txtEmpCode.ShortcutsEnabled = true;
            this.txtEmpCode.Size = new System.Drawing.Size(47, 23);
            this.txtEmpCode.TabIndex = 84;
            this.txtEmpCode.UseSelectable = true;
            this.txtEmpCode.Visible = false;
            this.txtEmpCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(41, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Employee Code";
            this.metroLabel3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 360);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(398, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 21);
            this.comboBox1.TabIndex = 119;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(323, 50);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 118;
            this.metroLabel7.Text = "Search by";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(456, 49);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(141, 20);
            this.txtsearch.TabIndex = 117;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Aqua;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsearch.Location = new System.Drawing.Point(625, 47);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(64, 23);
            this.btnsearch.TabIndex = 120;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // frmEmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 480);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbBGender);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtEn1);
            this.Controls.Add(this.txtEn2);
            this.Controls.Add(this.txtKh2);
            this.Controls.Add(this.txtKh1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPosID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.joindate);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.Join_date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeDetail";
            this.Text = "EmployeeDetail";
            this.Load += new System.EventHandler(this.frmEmployeeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Join_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnNew;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnSave;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnDel;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnClr;
        private MetroFramework.Controls.MetroComboBox cbBGender;
        private MetroFramework.Controls.MetroTextBox txtEmpID;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtEn1;
        private MetroFramework.Controls.MetroTextBox txtEn2;
        private MetroFramework.Controls.MetroTextBox txtKh2;
        private MetroFramework.Controls.MetroTextBox txtKh1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Join_date;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private MetroFramework.Controls.MetroTextBox txtPosID;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel joindate;
        private MetroFramework.Controls.MetroTextBox txtIDCard;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel Salary;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEmpCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
    }
}