namespace PSMS
{
    partial class frmInvoice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbBCusID = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtInvoiceID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.dtDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbBEmpID = new MetroFramework.Controls.MetroComboBox();
            this.EMPbindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.txtInvoiceCode = new MetroFramework.Controls.MetroTextBox();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnPrintSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnSave = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnUpdate = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDel = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.btnFind = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.btnClr = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.btnPayment = new MetroFramework.Controls.MetroTile();
            this.lblCusName = new MetroFramework.Controls.MetroLabel();
            this.dgPro = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSMSDataSet = new PSMS.PSMSDataSet();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saleprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnDis = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.lblPayment = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblBalance = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.productTableAdapter = new PSMS.PSMSDataSetTableAdapters.ProductTableAdapter();
            
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CustomerID";
            // 
            // cbBCusID
            // 
            this.cbBCusID.FormattingEnabled = true;
            this.cbBCusID.ItemHeight = 23;
            this.cbBCusID.Location = new System.Drawing.Point(139, 23);
            this.cbBCusID.Name = "cbBCusID";
            this.cbBCusID.Size = new System.Drawing.Size(205, 29);
            this.cbBCusID.TabIndex = 1;
            this.cbBCusID.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(56, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Invoice";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.txtInvoiceID);
            this.metroPanel1.Controls.Add(this.metroLabel19);
            this.metroPanel1.Controls.Add(this.dtDate);
            this.metroPanel1.Controls.Add(this.cbBEmpID);
            this.metroPanel1.Controls.Add(this.txtInvoiceCode);
            this.metroPanel1.Controls.Add(this.itemPanel1);
            this.metroPanel1.Controls.Add(this.lblAddress);
            this.metroPanel1.Controls.Add(this.btnPayment);
            this.metroPanel1.Controls.Add(this.lblCusName);
            this.metroPanel1.Controls.Add(this.dgPro);
            this.metroPanel1.Controls.Add(this.lblPhone);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cbBCusID);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 53);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(978, 480);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtInvoiceID
            // 
            // 
            // 
            // 
            this.txtInvoiceID.CustomButton.Image = null;
            this.txtInvoiceID.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtInvoiceID.CustomButton.Name = "";
            this.txtInvoiceID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceID.CustomButton.TabIndex = 1;
            this.txtInvoiceID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceID.CustomButton.UseSelectable = true;
            this.txtInvoiceID.CustomButton.Visible = false;
            this.txtInvoiceID.Lines = new string[0];
            this.txtInvoiceID.Location = new System.Drawing.Point(638, 89);
            this.txtInvoiceID.MaxLength = 32767;
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.PasswordChar = '\0';
            this.txtInvoiceID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceID.SelectedText = "";
            this.txtInvoiceID.SelectionLength = 0;
            this.txtInvoiceID.SelectionStart = 0;
            this.txtInvoiceID.ShortcutsEnabled = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(181, 23);
            this.txtInvoiceID.TabIndex = 21;
            this.txtInvoiceID.UseSelectable = true;
            this.txtInvoiceID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(530, 89);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(61, 19);
            this.metroLabel19.TabIndex = 20;
            this.metroLabel19.Text = "InvoiceID";
            // 
            // dtDate
            // 
            // 
            // 
            // 
            this.dtDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDate.ButtonDropDown.Visible = true;
            this.dtDate.IsPopupCalendarOpen = false;
            this.dtDate.Location = new System.Drawing.Point(638, 167);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDate.MonthCalendar.TodayButtonVisible = true;
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(181, 20);
            this.dtDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDate.TabIndex = 19;
            // 
            // cbBEmpID
            // 
            this.cbBEmpID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.EMPbindingSource, "EmpID", true));
            this.cbBEmpID.DataSource = this.EMPbindingSource;
            this.cbBEmpID.DisplayMember = "EmpFNEN";
            this.cbBEmpID.FormattingEnabled = true;
            this.cbBEmpID.ItemHeight = 23;
            this.cbBEmpID.Location = new System.Drawing.Point(638, 209);
            this.cbBEmpID.Name = "cbBEmpID";
            this.cbBEmpID.Size = new System.Drawing.Size(181, 29);
            this.cbBEmpID.TabIndex = 18;
            this.cbBEmpID.UseSelectable = true;
            this.cbBEmpID.ValueMember = "EmpID";
            // 
            // EMPbindingSource
            // 
            this.EMPbindingSource.DataMember = "Employee";
            // 
            // txtInvoiceCode
            // 
            // 
            // 
            // 
            this.txtInvoiceCode.CustomButton.Image = null;
            this.txtInvoiceCode.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtInvoiceCode.CustomButton.Name = "";
            this.txtInvoiceCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceCode.CustomButton.TabIndex = 1;
            this.txtInvoiceCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceCode.CustomButton.UseSelectable = true;
            this.txtInvoiceCode.CustomButton.Visible = false;
            this.txtInvoiceCode.Lines = new string[0];
            this.txtInvoiceCode.Location = new System.Drawing.Point(638, 118);
            this.txtInvoiceCode.MaxLength = 32767;
            this.txtInvoiceCode.Name = "txtInvoiceCode";
            this.txtInvoiceCode.PasswordChar = '\0';
            this.txtInvoiceCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceCode.SelectedText = "";
            this.txtInvoiceCode.SelectionLength = 0;
            this.txtInvoiceCode.SelectionStart = 0;
            this.txtInvoiceCode.ShortcutsEnabled = true;
            this.txtInvoiceCode.Size = new System.Drawing.Size(181, 23);
            this.txtInvoiceCode.TabIndex = 16;
            this.txtInvoiceCode.UseSelectable = true;
            this.txtInvoiceCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // itemPanel1
            // 
            this.itemPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.itemContainer2,
            this.itemContainer3,
            this.itemContainer4,
            this.itemContainer5,
            this.itemContainer6});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(845, 23);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(106, 371);
            this.itemPanel1.TabIndex = 21;
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
            this.btnPrintSave});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnPrintSave
            // 
            this.btnPrintSave.Image = global::PSMS.Properties.Resources.print;
            this.btnPrintSave.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintSave.Name = "btnPrintSave";
            this.btnPrintSave.SymbolColor = System.Drawing.Color.Empty;
            this.btnPrintSave.Text = "Print n Save";
            this.btnPrintSave.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnPrintSave.TileSize = new System.Drawing.Size(100, 60);
            // 
            // 
            // 
            this.btnPrintSave.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnPrintSave.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btnUpdate});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::PSMS.Properties.Resources.refresh_button_1_;
            this.btnUpdate.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.SymbolColor = System.Drawing.Color.Empty;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnUpdate.TileSize = new System.Drawing.Size(100, 60);
            // 
            // 
            // 
            this.btnUpdate.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDel});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.btnFind});
            // 
            // 
            // 
            this.itemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PSMS.Properties.Resources.magnifying_glass_search_button;
            this.btnFind.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFind.Name = "btnFind";
            this.btnFind.SymbolColor = System.Drawing.Color.Empty;
            this.btnFind.Text = "Find";
            this.btnFind.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.btnFind.TileSize = new System.Drawing.Size(100, 60);
            // 
            // 
            // 
            this.btnFind.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClr});
            // 
            // 
            // 
            this.itemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnClr
            // 
            this.btnClr.Image = global::PSMS.Properties.Resources.sweep;
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
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.Location = new System.Drawing.Point(132, 161);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(250, 98);
            this.lblAddress.TabIndex = 15;
            // 
            // btnPayment
            // 
            this.btnPayment.ActiveControl = null;
            this.btnPayment.Location = new System.Drawing.Point(672, 372);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(73, 38);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.UseSelectable = true;
            // 
            // lblCusName
            // 
            this.lblCusName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCusName.Location = new System.Drawing.Point(132, 118);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(174, 19);
            this.lblCusName.TabIndex = 14;
            // 
            // dgPro
            // 
            this.dgPro.AllowUserToDeleteRows = false;
            this.dgPro.AllowUserToResizeRows = false;
            this.dgPro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Quantity,
            this.MID,
            this.PTypeID,
            this.TID,
            this.Saleprice});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPro.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgPro.EnableHeadersVisualStyles = false;
            this.dgPro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgPro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPro.Location = new System.Drawing.Point(23, 269);
            this.dgPro.Name = "dgPro";
            this.dgPro.ReadOnly = true;
            this.dgPro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPro.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgPro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPro.Size = new System.Drawing.Size(634, 183);
            this.dgPro.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataSource = this.ProductbindingSource;
            this.Column1.DisplayMember = "PName";
            this.Column1.HeaderText = "PName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "PID";
            // 
            // ProductbindingSource
            // 
            this.ProductbindingSource.DataMember = "Product";
            this.ProductbindingSource.DataSource = this.pSMSDataSet;
            // 
            // pSMSDataSet
            // 
            this.pSMSDataSet.DataSetName = "PSMSDataSet";
            this.pSMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PSize";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Color";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // MID
            // 
            this.MID.HeaderText = "MID";
            this.MID.Name = "MID";
            this.MID.ReadOnly = true;
            // 
            // PTypeID
            // 
            this.PTypeID.HeaderText = "PTypeID";
            this.PTypeID.Name = "PTypeID";
            this.PTypeID.ReadOnly = true;
            // 
            // TID
            // 
            this.TID.HeaderText = "TID";
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            // 
            // Saleprice
            // 
            this.Saleprice.HeaderText = "Saleprice";
            this.Saleprice.Name = "Saleprice";
            this.Saleprice.ReadOnly = true;
            // 
            // lblPhone
            // 
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Location = new System.Drawing.Point(364, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 23);
            this.lblPhone.TabIndex = 13;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(530, 209);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "EmpID";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(530, 163);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(36, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(530, 118);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "InvoiceCode";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(312, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Phone";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Customer Name";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(64, 539);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(58, 19);
            this.metroLabel12.TabIndex = 5;
            this.metroLabel12.Text = "Discount";
            this.metroLabel12.Visible = false;
            // 
            // btnDis
            // 
            this.btnDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.btnDis.CustomButton.Image = null;
            this.btnDis.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.btnDis.CustomButton.Name = "";
            this.btnDis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.btnDis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDis.CustomButton.TabIndex = 1;
            this.btnDis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDis.CustomButton.UseSelectable = true;
            this.btnDis.CustomButton.Visible = false;
            this.btnDis.Lines = new string[0];
            this.btnDis.Location = new System.Drawing.Point(123, 539);
            this.btnDis.MaxLength = 32767;
            this.btnDis.Name = "btnDis";
            this.btnDis.PasswordChar = '\0';
            this.btnDis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnDis.SelectedText = "";
            this.btnDis.SelectionLength = 0;
            this.btnDis.SelectionStart = 0;
            this.btnDis.ShortcutsEnabled = true;
            this.btnDis.Size = new System.Drawing.Size(90, 23);
            this.btnDis.TabIndex = 6;
            this.btnDis.UseSelectable = true;
            this.btnDis.Visible = false;
            this.btnDis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnDis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.Location = new System.Drawing.Point(886, 20);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(90, 30);
            this.metroLink1.TabIndex = 15;
            this.metroLink1.Text = "Back";
            this.metroLink1.UseSelectable = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(589, 546);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 19);
            this.lblTotal.TabIndex = 39;
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(541, 546);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(36, 19);
            this.metroLabel17.TabIndex = 38;
            this.metroLabel17.Text = "Total";
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Location = new System.Drawing.Point(754, 546);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(93, 19);
            this.lblPayment.TabIndex = 37;
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(848, 546);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(54, 19);
            this.metroLabel14.TabIndex = 36;
            this.metroLabel14.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Location = new System.Drawing.Point(908, 546);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(93, 19);
            this.lblBalance.TabIndex = 35;
            // 
            // metroLabel18
            // 
            this.metroLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(696, 546);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(59, 19);
            this.metroLabel18.TabIndex = 34;
            this.metroLabel18.Text = "Payment";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmInvoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPbindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbBCusID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtInvoiceCode;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblCusName;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dgPro;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox btnDis;
        private MetroFramework.Controls.MetroComboBox cbBEmpID;
        private MetroFramework.Controls.MetroTile btnPayment;
        private MetroFramework.Controls.MetroLink metroLink1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnPrintSave;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnSave;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnDel;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnFind;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDate;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel lblPayment;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel lblBalance;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnClr;
        private MetroFramework.Controls.MetroTextBox txtInvoiceID;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnUpdate;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        private System.Windows.Forms.BindingSource ProductbindingSource;
        private PSMSDataSet pSMSDataSet;
        private PSMSDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saleprice;
        private System.Windows.Forms.BindingSource EMPbindingSource;
    }
}