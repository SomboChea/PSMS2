namespace PSMS
{
    partial class frmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
            this.btnFind = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnNew = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnDel = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnClr = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Salary = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtIDCard = new MetroFramework.Controls.MetroTextBox();
            this.joindate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.Join_date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtKh1 = new MetroFramework.Controls.MetroTextBox();
            this.txtKh2 = new MetroFramework.Controls.MetroTextBox();
            this.txtEn2 = new MetroFramework.Controls.MetroTextBox();
            this.txtEn1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpID = new MetroFramework.Controls.MetroTextBox();
            this.cbBGender = new MetroFramework.Controls.MetroComboBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.cbBPos = new System.Windows.Forms.ComboBox();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rtxtAddress = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Join_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.metroPanel1.SuspendLayout();
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
            this.btnNew.Text = "New";
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
            this.btnSave.Text = "Save";
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(36, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "Employee Code";
            // 
            // txtEmpCode
            // 
            // 
            // 
            // 
            this.txtEmpCode.CustomButton.Image = null;
            this.txtEmpCode.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txtEmpCode.CustomButton.Name = "";
            this.txtEmpCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpCode.CustomButton.TabIndex = 1;
            this.txtEmpCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpCode.CustomButton.UseSelectable = true;
            this.txtEmpCode.CustomButton.Visible = false;
            this.txtEmpCode.Enabled = false;
            this.txtEmpCode.Lines = new string[0];
            this.txtEmpCode.Location = new System.Drawing.Point(141, 88);
            this.txtEmpCode.MaxLength = 32767;
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.PasswordChar = '\0';
            this.txtEmpCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpCode.SelectedText = "";
            this.txtEmpCode.SelectionLength = 0;
            this.txtEmpCode.SelectionStart = 0;
            this.txtEmpCode.ShortcutsEnabled = true;
            this.txtEmpCode.Size = new System.Drawing.Size(284, 23);
            this.txtEmpCode.TabIndex = 52;
            this.txtEmpCode.UseSelectable = true;
            this.txtEmpCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(477, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Email";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(36, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "Employee Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(477, 205);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "Postion ID";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel6.Location = new System.Drawing.Point(34, 236);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 57;
            this.metroLabel6.Text = "Gender";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salary.Location = new System.Drawing.Point(480, 244);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(45, 19);
            this.Salary.TabIndex = 59;
            this.Salary.Text = "Salary";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(477, 92);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 60;
            this.metroLabel8.Text = "IDCard";
            // 
            // txtIDCard
            // 
            // 
            // 
            // 
            this.txtIDCard.CustomButton.Image = null;
            this.txtIDCard.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txtIDCard.CustomButton.Name = "";
            this.txtIDCard.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCard.CustomButton.TabIndex = 1;
            this.txtIDCard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCard.CustomButton.UseSelectable = true;
            this.txtIDCard.CustomButton.Visible = false;
            this.txtIDCard.Lines = new string[0];
            this.txtIDCard.Location = new System.Drawing.Point(563, 92);
            this.txtIDCard.MaxLength = 32767;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.PasswordChar = '\0';
            this.txtIDCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCard.SelectedText = "";
            this.txtIDCard.SelectionLength = 0;
            this.txtIDCard.SelectionStart = 0;
            this.txtIDCard.ShortcutsEnabled = true;
            this.txtIDCard.Size = new System.Drawing.Size(284, 23);
            this.txtIDCard.TabIndex = 61;
            this.txtIDCard.UseSelectable = true;
            this.txtIDCard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDCard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // joindate
            // 
            this.joindate.AutoSize = true;
            this.joindate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.joindate.Location = new System.Drawing.Point(478, 283);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(63, 19);
            this.joindate.TabIndex = 62;
            this.joindate.Text = "Join Date";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel10.Location = new System.Drawing.Point(34, 278);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(56, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "Address";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(563, 158);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(284, 23);
            this.txtEmail.TabIndex = 66;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(563, 240);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(284, 23);
            this.txtSalary.TabIndex = 68;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Join_date.Location = new System.Drawing.Point(563, 282);
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
            this.Join_date.Size = new System.Drawing.Size(284, 20);
            this.Join_date.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Join_date.TabIndex = 69;
            // 
            // txtKh1
            // 
            // 
            // 
            // 
            this.txtKh1.CustomButton.Image = null;
            this.txtKh1.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtKh1.CustomButton.Name = "";
            this.txtKh1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh1.CustomButton.TabIndex = 1;
            this.txtKh1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh1.CustomButton.UseSelectable = true;
            this.txtKh1.CustomButton.Visible = false;
            this.txtKh1.Lines = new string[0];
            this.txtKh1.Location = new System.Drawing.Point(141, 151);
            this.txtKh1.MaxLength = 32767;
            this.txtKh1.Name = "txtKh1";
            this.txtKh1.PasswordChar = '\0';
            this.txtKh1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh1.SelectedText = "";
            this.txtKh1.SelectionLength = 0;
            this.txtKh1.SelectionStart = 0;
            this.txtKh1.ShortcutsEnabled = true;
            this.txtKh1.Size = new System.Drawing.Size(134, 23);
            this.txtKh1.TabIndex = 71;
            this.txtKh1.UseSelectable = true;
            this.txtKh1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKh2
            // 
            // 
            // 
            // 
            this.txtKh2.CustomButton.Image = null;
            this.txtKh2.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtKh2.CustomButton.Name = "";
            this.txtKh2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKh2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKh2.CustomButton.TabIndex = 1;
            this.txtKh2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKh2.CustomButton.UseSelectable = true;
            this.txtKh2.CustomButton.Visible = false;
            this.txtKh2.Lines = new string[0];
            this.txtKh2.Location = new System.Drawing.Point(299, 151);
            this.txtKh2.MaxLength = 32767;
            this.txtKh2.Name = "txtKh2";
            this.txtKh2.PasswordChar = '\0';
            this.txtKh2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKh2.SelectedText = "";
            this.txtKh2.SelectionLength = 0;
            this.txtKh2.SelectionStart = 0;
            this.txtKh2.ShortcutsEnabled = true;
            this.txtKh2.Size = new System.Drawing.Size(126, 23);
            this.txtKh2.TabIndex = 72;
            this.txtKh2.UseSelectable = true;
            this.txtKh2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKh2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEn2
            // 
            // 
            // 
            // 
            this.txtEn2.CustomButton.Image = null;
            this.txtEn2.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtEn2.CustomButton.Name = "";
            this.txtEn2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn2.CustomButton.TabIndex = 1;
            this.txtEn2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn2.CustomButton.UseSelectable = true;
            this.txtEn2.CustomButton.Visible = false;
            this.txtEn2.Lines = new string[0];
            this.txtEn2.Location = new System.Drawing.Point(299, 199);
            this.txtEn2.MaxLength = 32767;
            this.txtEn2.Name = "txtEn2";
            this.txtEn2.PasswordChar = '\0';
            this.txtEn2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn2.SelectedText = "";
            this.txtEn2.SelectionLength = 0;
            this.txtEn2.SelectionStart = 0;
            this.txtEn2.ShortcutsEnabled = true;
            this.txtEn2.Size = new System.Drawing.Size(126, 23);
            this.txtEn2.TabIndex = 73;
            this.txtEn2.UseSelectable = true;
            this.txtEn2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEn1
            // 
            // 
            // 
            // 
            this.txtEn1.CustomButton.Image = null;
            this.txtEn1.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtEn1.CustomButton.Name = "";
            this.txtEn1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEn1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEn1.CustomButton.TabIndex = 1;
            this.txtEn1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEn1.CustomButton.UseSelectable = true;
            this.txtEn1.CustomButton.Visible = false;
            this.txtEn1.Lines = new string[0];
            this.txtEn1.Location = new System.Drawing.Point(141, 202);
            this.txtEn1.MaxLength = 32767;
            this.txtEn1.Name = "txtEn1";
            this.txtEn1.PasswordChar = '\0';
            this.txtEn1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEn1.SelectedText = "";
            this.txtEn1.SelectionLength = 0;
            this.txtEn1.SelectionStart = 0;
            this.txtEn1.ShortcutsEnabled = true;
            this.txtEn1.Size = new System.Drawing.Size(134, 23);
            this.txtEn1.TabIndex = 74;
            this.txtEn1.UseSelectable = true;
            this.txtEn1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEn1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(226, 177);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(111, 19);
            this.metroLabel9.TabIndex = 75;
            this.metroLabel9.Text = "(Name in English)";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(226, 128);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(109, 19);
            this.metroLabel12.TabIndex = 76;
            this.metroLabel12.Text = "(Name in Khmer)";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel13.Location = new System.Drawing.Point(477, 124);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(46, 19);
            this.metroLabel13.TabIndex = 78;
            this.metroLabel13.Text = "Phone";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(563, 124);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(284, 23);
            this.txtPhone.TabIndex = 79;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel14.Location = new System.Drawing.Point(175, 42);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(83, 19);
            this.metroLabel14.TabIndex = 80;
            this.metroLabel14.Text = "Employee ID";
            this.metroLabel14.Visible = false;
            // 
            // txtEmpID
            // 
            // 
            // 
            // 
            this.txtEmpID.CustomButton.Image = null;
            this.txtEmpID.CustomButton.Location = new System.Drawing.Point(262, 1);
            this.txtEmpID.CustomButton.Name = "";
            this.txtEmpID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpID.CustomButton.TabIndex = 1;
            this.txtEmpID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpID.CustomButton.UseSelectable = true;
            this.txtEmpID.CustomButton.Visible = false;
            this.txtEmpID.Lines = new string[] {
        "1"};
            this.txtEmpID.Location = new System.Drawing.Point(280, 42);
            this.txtEmpID.MaxLength = 32767;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.PasswordChar = '\0';
            this.txtEmpID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpID.SelectedText = "";
            this.txtEmpID.SelectionLength = 0;
            this.txtEmpID.SelectionStart = 0;
            this.txtEmpID.ShortcutsEnabled = true;
            this.txtEmpID.Size = new System.Drawing.Size(284, 23);
            this.txtEmpID.TabIndex = 81;
            this.txtEmpID.Text = "1";
            this.txtEmpID.UseSelectable = true;
            this.txtEmpID.Visible = false;
            this.txtEmpID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbBGender
            // 
            this.cbBGender.FormattingEnabled = true;
            this.cbBGender.ItemHeight = 23;
            this.cbBGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbBGender.Location = new System.Drawing.Point(141, 236);
            this.cbBGender.Name = "cbBGender";
            this.cbBGender.Size = new System.Drawing.Size(284, 29);
            this.cbBGender.TabIndex = 82;
            this.cbBGender.UseSelectable = true;
            // 
            // dgData
            // 
            this.dgData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(480, 358);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(330, 95);
            this.dgData.TabIndex = 72;
            this.dgData.Click += new System.EventHandler(this.dgData_Click);
            // 
            // cbBPos
            // 
            this.cbBPos.FormattingEnabled = true;
            this.cbBPos.Location = new System.Drawing.Point(563, 205);
            this.cbBPos.Name = "cbBPos";
            this.cbBPos.Size = new System.Drawing.Size(138, 21);
            this.cbBPos.TabIndex = 83;
            this.cbBPos.Text = "1";
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
            this.itemPanel1.Location = new System.Drawing.Point(871, 42);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(105, 358);
            this.itemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.itemPanel1.TabIndex = 71;
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(480, 323);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 84;
            this.metroLabel5.Text = "Load data";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(707, 194);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(140, 40);
            this.metroTile1.TabIndex = 85;
            this.metroTile1.Text = "Manage Postion";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.textBox1);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.itemPanel1);
            this.metroPanel1.Controls.Add(this.cbBPos);
            this.metroPanel1.Controls.Add(this.dgData);
            this.metroPanel1.Controls.Add(this.cbBGender);
            this.metroPanel1.Controls.Add(this.txtEmpID);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.txtPhone);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.txtEn1);
            this.metroPanel1.Controls.Add(this.txtEn2);
            this.metroPanel1.Controls.Add(this.txtKh2);
            this.metroPanel1.Controls.Add(this.txtKh1);
            this.metroPanel1.Controls.Add(this.Join_date);
            this.metroPanel1.Controls.Add(this.txtSalary);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.joindate);
            this.metroPanel1.Controls.Add(this.txtIDCard);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.Salary);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtEmpCode);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(154, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1007, 482);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rtxtAddress
            // 
            // 
            // 
            // 
            this.rtxtAddress.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtxtAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtxtAddress.Location = new System.Drawing.Point(141, 283);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.rtxtAddress.Size = new System.Drawing.Size(284, 98);
            this.rtxtAddress.TabIndex = 77;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 121);
            this.textBox1.TabIndex = 86;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 585);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "frmEmployees";
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployees_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Join_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTileItem btnFind;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnNew;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnSave;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnDel;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnClr;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEmpCode;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel Salary;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtIDCard;
        private MetroFramework.Controls.MetroLabel joindate;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Join_date;
        private MetroFramework.Controls.MetroTextBox txtKh1;
        private MetroFramework.Controls.MetroTextBox txtKh2;
        private MetroFramework.Controls.MetroTextBox txtEn2;
        private MetroFramework.Controls.MetroTextBox txtEn1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtEmpID;
        private MetroFramework.Controls.MetroComboBox cbBGender;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ComboBox cbBPos;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtxtAddress;
        private System.Windows.Forms.TextBox textBox1;
    }
}