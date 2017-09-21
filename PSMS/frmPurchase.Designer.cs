namespace PSMS
{
    partial class frmPurchase
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label cusIDLabel;
            System.Windows.Forms.Label invoiceCodeLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.BalanceLabel = new MetroFramework.Controls.MetroLabel();
            this.paymentLabel1 = new System.Windows.Forms.Label();
            this.totalPriceLabel1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDataSet = new PSMS.SupplierDataSet();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.suIDComboBox = new System.Windows.Forms.ComboBox();
            this.dtGvBuy = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDetail = new PSMS.PurchaseDetail();
            this.empIDComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new PSMS.EmpDataSet();
            this.btnPurchase = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.btnManage = new MetroFramework.Controls.MetroTile();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.PurchaseDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnPayment = new MetroFramework.Controls.MetroTile();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceCodeTextBox = new System.Windows.Forms.TextBox();
            this.supplierTableAdapter = new PSMS.SupplierDataSetTableAdapters.SupplierTableAdapter();
            this.tableAdapterManager = new PSMS.SupplierDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new PSMS.EmpDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager1 = new PSMS.EmpDataSetTableAdapters.TableAdapterManager();
            this.purchaseDetailTableAdapter = new PSMS.PurchaseDetailTableAdapters.PurchaseDetailTableAdapter();
            this.tableAdapterManager2 = new PSMS.PurchaseDetailTableAdapters.TableAdapterManager();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            empIDLabel = new System.Windows.Forms.Label();
            cusIDLabel = new System.Windows.Forms.Label();
            invoiceCodeLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(167, 449);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 20);
            label2.TabIndex = 29;
            label2.Text = "Qty:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(121, 166);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 20);
            label1.TabIndex = 25;
            label1.Text = "Brand:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(30, 70);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 20);
            phoneLabel.TabIndex = 22;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(20, 114);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(65, 20);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "Address:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(660, 70);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(44, 20);
            dateLabel.TabIndex = 12;
            dateLabel.Text = "Date:";
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empIDLabel.Location = new System.Drawing.Point(660, 117);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(61, 20);
            empIDLabel.TabIndex = 10;
            empIDLabel.Text = "Emp ID:";
            // 
            // cusIDLabel
            // 
            cusIDLabel.AutoSize = true;
            cusIDLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cusIDLabel.Location = new System.Drawing.Point(12, 26);
            cusIDLabel.Name = "cusIDLabel";
            cusIDLabel.Size = new System.Drawing.Size(71, 20);
            cusIDLabel.TabIndex = 4;
            cusIDLabel.Text = "Supplier :";
            // 
            // invoiceCodeLabel
            // 
            invoiceCodeLabel.AutoSize = true;
            invoiceCodeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoiceCodeLabel.Location = new System.Drawing.Point(660, 25);
            invoiceCodeLabel.Name = "invoiceCodeLabel";
            invoiceCodeLabel.Size = new System.Drawing.Size(109, 20);
            invoiceCodeLabel.TabIndex = 2;
            invoiceCodeLabel.Text = "Purchase Code:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paymentLabel.Location = new System.Drawing.Point(594, 553);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(72, 20);
            paymentLabel.TabIndex = 32;
            paymentLabel.Text = " Payment:";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalPriceLabel.Location = new System.Drawing.Point(364, 555);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(81, 20);
            totalPriceLabel.TabIndex = 35;
            totalPriceLabel.Text = "Total Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(812, 553);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 20);
            label3.TabIndex = 36;
            label3.Text = "Balance:";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Image = global::PSMS.Properties.Resources.add_documents_1_;
            this.metroTileItem1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.Text = "Add New";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.metroTileItem1.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Image = global::PSMS.Properties.Resources.save;
            this.metroTileItem3.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.Text = "Save";
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.metroTileItem3.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem3.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Image = global::PSMS.Properties.Resources.rubbish_bin;
            this.metroTileItem2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.Text = "Delete";
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.metroTileItem2.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem2.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Image = global::PSMS.Properties.Resources.magnifying_glass_search_button;
            this.metroTileItem4.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.Text = "Find";
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.metroTileItem4.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.Image = global::PSMS.Properties.Resources.sweep;
            this.metroTileItem5.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.Text = "Clear";
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.metroTileItem5.TileSize = new System.Drawing.Size(100, 70);
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BalanceLabel.ForeColor = System.Drawing.Color.Red;
            this.BalanceLabel.Location = new System.Drawing.Point(888, 553);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(114, 19);
            this.BalanceLabel.TabIndex = 28;
            this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // paymentLabel1
            // 
            this.paymentLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paymentLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel1.Location = new System.Drawing.Point(670, 553);
            this.paymentLabel1.Name = "paymentLabel1";
            this.paymentLabel1.Size = new System.Drawing.Size(122, 23);
            this.paymentLabel1.TabIndex = 34;
            // 
            // totalPriceLabel1
            // 
            this.totalPriceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel1.Location = new System.Drawing.Point(455, 552);
            this.totalPriceLabel1.Name = "totalPriceLabel1";
            this.totalPriceLabel1.Size = new System.Drawing.Size(120, 23);
            this.totalPriceLabel1.TabIndex = 33;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.phoneTextBox);
            this.metroPanel1.Controls.Add(this.addressTextBox);
            this.metroPanel1.Controls.Add(this.suIDComboBox);
            this.metroPanel1.Controls.Add(this.dtGvBuy);
            this.metroPanel1.Controls.Add(this.empIDComboBox);
            this.metroPanel1.Controls.Add(this.btnPurchase);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnManage);
            this.metroPanel1.Controls.Add(label2);
            this.metroPanel1.Controls.Add(this.txtQty);
            this.metroPanel1.Controls.Add(this.btnAdd);
            this.metroPanel1.Controls.Add(label1);
            this.metroPanel1.Controls.Add(this.modelComboBox);
            this.metroPanel1.Controls.Add(phoneLabel);
            this.metroPanel1.Controls.Add(addressLabel);
            this.metroPanel1.Controls.Add(this.PurchaseDetailDataGridView);
            this.metroPanel1.Controls.Add(this.btnPrint);
            this.metroPanel1.Controls.Add(this.btnPayment);
            this.metroPanel1.Controls.Add(dateLabel);
            this.metroPanel1.Controls.Add(this.dateDateTimePicker);
            this.metroPanel1.Controls.Add(empIDLabel);
            this.metroPanel1.Controls.Add(cusIDLabel);
            this.metroPanel1.Controls.Add(invoiceCodeLabel);
            this.metroPanel1.Controls.Add(this.invoiceCodeTextBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(21, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(991, 492);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(99, 70);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(196, 20);
            this.phoneTextBox.TabIndex = 40;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.supplierDataSet;
            // 
            // supplierDataSet
            // 
            this.supplierDataSet.DataSetName = "SupplierDataSet";
            this.supplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(99, 113);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(196, 20);
            this.addressTextBox.TabIndex = 39;
            // 
            // suIDComboBox
            // 
            this.suIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SuFNEN", true));
            this.suIDComboBox.DataSource = this.supplierBindingSource;
            this.suIDComboBox.DisplayMember = "SuFNEN";
            this.suIDComboBox.FormattingEnabled = true;
            this.suIDComboBox.Location = new System.Drawing.Point(99, 26);
            this.suIDComboBox.Name = "suIDComboBox";
            this.suIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.suIDComboBox.TabIndex = 38;
            this.suIDComboBox.ValueMember = "SuID";
            // 
            // dtGvBuy
            // 
            this.dtGvBuy.AllowUserToAddRows = false;
            this.dtGvBuy.AllowUserToResizeColumns = false;
            this.dtGvBuy.AutoGenerateColumns = false;
            this.dtGvBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGvBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.quantityDataGridViewTextBoxColumn1,
            this.unitpriceDataGridViewTextBoxColumn,
            this.salepriceDataGridViewTextBoxColumn1});
            this.dtGvBuy.DataSource = this.purchaseDetailBindingSource;
            this.dtGvBuy.Location = new System.Drawing.Point(526, 209);
            this.dtGvBuy.MultiSelect = false;
            this.dtGvBuy.Name = "dtGvBuy";
            this.dtGvBuy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGvBuy.Size = new System.Drawing.Size(441, 220);
            this.dtGvBuy.TabIndex = 37;
            // 
            // pIDDataGridViewTextBoxColumn1
            // 
            this.pIDDataGridViewTextBoxColumn1.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn1.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn1.Name = "pIDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PSize";
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn4.HeaderText = "Color";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "Unitprice";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "Unitprice";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            // 
            // salepriceDataGridViewTextBoxColumn1
            // 
            this.salepriceDataGridViewTextBoxColumn1.DataPropertyName = "Saleprice";
            this.salepriceDataGridViewTextBoxColumn1.HeaderText = "Saleprice";
            this.salepriceDataGridViewTextBoxColumn1.Name = "salepriceDataGridViewTextBoxColumn1";
            // 
            // purchaseDetailBindingSource
            // 
            this.purchaseDetailBindingSource.DataMember = "PurchaseDetail";
            this.purchaseDetailBindingSource.DataSource = this.purchaseDetail;
            // 
            // purchaseDetail
            // 
            this.purchaseDetail.DataSetName = "PurchaseDetail";
            this.purchaseDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empIDComboBox
            // 
            this.empIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmpID", true));
            this.empIDComboBox.DataSource = this.employeeBindingSource;
            this.empIDComboBox.DisplayMember = "EmpFNEN";
            this.empIDComboBox.FormattingEnabled = true;
            this.empIDComboBox.Location = new System.Drawing.Point(727, 117);
            this.empIDComboBox.Name = "empIDComboBox";
            this.empIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.empIDComboBox.TabIndex = 36;
            this.empIDComboBox.ValueMember = "EmpID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.empDataSet;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPurchase
            // 
            this.btnPurchase.ActiveControl = null;
            this.btnPurchase.Location = new System.Drawing.Point(865, 436);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(101, 38);
            this.btnPurchase.TabIndex = 20;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPurchase.UseSelectable = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.Location = new System.Drawing.Point(865, 117);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 38);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnManage
            // 
            this.btnManage.ActiveControl = null;
            this.btnManage.Location = new System.Drawing.Point(640, 436);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(101, 38);
            this.btnManage.TabIndex = 31;
            this.btnManage.Text = "Manage";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManage.UseSelectable = true;
            this.btnManage.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(209, 440);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(150, 34);
            this.txtQty.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(362, 440);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 33);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(177, 165);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(147, 21);
            this.modelComboBox.TabIndex = 24;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // PurchaseDetailDataGridView
            // 
            this.PurchaseDetailDataGridView.AllowUserToAddRows = false;
            this.PurchaseDetailDataGridView.AllowUserToDeleteRows = false;
            this.PurchaseDetailDataGridView.AllowUserToResizeColumns = false;
            this.PurchaseDetailDataGridView.AutoGenerateColumns = false;
            this.PurchaseDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchaseDetailDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PurchaseDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.PName,
            this.PSize,
            this.Color,
            this.quantityDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn1,
            this.salepriceDataGridViewTextBoxColumn});
            this.PurchaseDetailDataGridView.DataSource = this.purchaseDetailBindingSource;
            this.PurchaseDetailDataGridView.Location = new System.Drawing.Point(46, 209);
            this.PurchaseDetailDataGridView.MultiSelect = false;
            this.PurchaseDetailDataGridView.Name = "PurchaseDetailDataGridView";
            this.PurchaseDetailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PurchaseDetailDataGridView.Size = new System.Drawing.Size(441, 220);
            this.PurchaseDetailDataGridView.TabIndex = 21;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            // 
            // PSize
            // 
            this.PSize.DataPropertyName = "PSize";
            this.PSize.HeaderText = "Size";
            this.PSize.Name = "PSize";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn1
            // 
            this.unitpriceDataGridViewTextBoxColumn1.DataPropertyName = "Unitprice";
            this.unitpriceDataGridViewTextBoxColumn1.HeaderText = "Unitprice";
            this.unitpriceDataGridViewTextBoxColumn1.Name = "unitpriceDataGridViewTextBoxColumn1";
            // 
            // salepriceDataGridViewTextBoxColumn
            // 
            this.salepriceDataGridViewTextBoxColumn.DataPropertyName = "Saleprice";
            this.salepriceDataGridViewTextBoxColumn.HeaderText = "Saleprice";
            this.salepriceDataGridViewTextBoxColumn.Name = "salepriceDataGridViewTextBoxColumn";
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(525, 435);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 38);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.ActiveControl = null;
            this.btnPayment.Location = new System.Drawing.Point(752, 436);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(101, 38);
            this.btnPayment.TabIndex = 20;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayment.UseSelectable = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Enabled = false;
            this.dateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(713, 65);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(254, 27);
            this.dateDateTimePicker.TabIndex = 13;
            // 
            // invoiceCodeTextBox
            // 
            this.invoiceCodeTextBox.Enabled = false;
            this.invoiceCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCodeTextBox.Location = new System.Drawing.Point(784, 22);
            this.invoiceCodeTextBox.Name = "invoiceCodeTextBox";
            this.invoiceCodeTextBox.ReadOnly = true;
            this.invoiceCodeTextBox.Size = new System.Drawing.Size(100, 27);
            this.invoiceCodeTextBox.TabIndex = 3;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = PSMS.SupplierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager1.UpdateOrder = PSMS.EmpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchaseDetailTableAdapter
            // 
            this.purchaseDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.PurchaseDetailTableAdapter = this.purchaseDetailTableAdapter;
            this.tableAdapterManager2.UpdateOrder = PSMS.PurchaseDetailTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 586);
            this.Controls.Add(label3);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentLabel1);
            this.Controls.Add(this.totalPriceLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.BalanceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPurchase";
            this.Text = "Purchase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPurchase_FormClosing);
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private MetroFramework.Controls.MetroLabel BalanceLabel;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        public System.Windows.Forms.Label paymentLabel1;
        private System.Windows.Forms.Label totalPriceLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnPurchase;
        private MetroFramework.Controls.MetroTile btnClear;
        private MetroFramework.Controls.MetroTile btnManage;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.DataGridView PurchaseDetailDataGridView;
        private MetroFramework.Controls.MetroTile btnPrint;
        private MetroFramework.Controls.MetroTile btnPayment;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox invoiceCodeTextBox;
        private SupplierDataSet supplierDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private SupplierDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private SupplierDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmpDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private EmpDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox empIDComboBox;
        private PurchaseDetail purchaseDetail;
        private System.Windows.Forms.BindingSource purchaseDetailBindingSource;
        private PurchaseDetailTableAdapters.PurchaseDetailTableAdapter purchaseDetailTableAdapter;
        private PurchaseDetailTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView dtGvBuy;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox suIDComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceDataGridViewTextBoxColumn;
    }
}