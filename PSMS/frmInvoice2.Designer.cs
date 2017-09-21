namespace PSMS
{
    partial class frmInvoice2
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
            System.Windows.Forms.Label invoiceCodeLabel;
            System.Windows.Forms.Label cusIDLabel;
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice2));
            this.invoiceDataSet = new PSMS.InvoiceDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new PSMS.InvoiceDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new PSMS.InvoiceDataSetTableAdapters.TableAdapterManager();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnPurchase = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.btnManage = new MetroFramework.Controls.MetroTile();
            this.dtGvBuy = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailDataSet = new PSMS.InvoiceDetailDataSet();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            this.CusbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new PSMS.CustomerDataSet();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.invoiceDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnPayment = new MetroFramework.Controls.MetroTile();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empIDComboBox = new System.Windows.Forms.ComboBox();
            this.EmpbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empDataSet = new PSMS.EmpDataSet();
            this.cusIDComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceCodeTextBox = new System.Windows.Forms.TextBox();
            this.ProductbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product2DataSet = new PSMS.Product2DataSet();
            this.invoiceDetailTableAdapter = new PSMS.InvoiceDetailDataSetTableAdapters.InvoiceDetailTableAdapter();
            this.tableAdapterManager1 = new PSMS.InvoiceDetailDataSetTableAdapters.TableAdapterManager();
            this.totalPriceLabel1 = new System.Windows.Forms.Label();
            this.paymentLabel1 = new System.Windows.Forms.Label();
            this.productTableAdapter = new PSMS.Product2DataSetTableAdapters.ProductTableAdapter();
            this.employeeTableAdapter = new PSMS.EmpDataSetTableAdapters.EmployeeTableAdapter();
            this.customersTableAdapter = new PSMS.CustomerDataSetTableAdapters.CustomersTableAdapter();
            invoiceCodeLabel = new System.Windows.Forms.Label();
            cusIDLabel = new System.Windows.Forms.Label();
            empIDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceCodeLabel
            // 
            invoiceCodeLabel.AutoSize = true;
            invoiceCodeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoiceCodeLabel.Location = new System.Drawing.Point(660, 25);
            invoiceCodeLabel.Name = "invoiceCodeLabel";
            invoiceCodeLabel.Size = new System.Drawing.Size(98, 20);
            invoiceCodeLabel.TabIndex = 2;
            invoiceCodeLabel.Text = "Invoice Code:";
            // 
            // cusIDLabel
            // 
            cusIDLabel.AutoSize = true;
            cusIDLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cusIDLabel.Location = new System.Drawing.Point(29, 25);
            cusIDLabel.Name = "cusIDLabel";
            cusIDLabel.Size = new System.Drawing.Size(54, 20);
            cusIDLabel.TabIndex = 4;
            cusIDLabel.Text = "Cus ID:";
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
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalPriceLabel.Location = new System.Drawing.Point(431, 589);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(81, 20);
            totalPriceLabel.TabIndex = 3;
            totalPriceLabel.Text = "Total Price:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paymentLabel.Location = new System.Drawing.Point(731, 592);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(72, 20);
            paymentLabel.TabIndex = 4;
            paymentLabel.Text = " Payment:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(18, 114);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(65, 20);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "Address:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(138, 164);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 20);
            label1.TabIndex = 25;
            label1.Text = "Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(170, 441);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 20);
            label2.TabIndex = 29;
            label2.Text = "Qty:";
            // 
            // invoiceDataSet
            // 
            this.invoiceDataSet.DataSetName = "InvoiceDataSet";
            this.invoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.invoiceDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.UpdateOrder = PSMS.InvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.btnPurchase);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnManage);
            this.metroPanel1.Controls.Add(this.dtGvBuy);
            this.metroPanel1.Controls.Add(label2);
            this.metroPanel1.Controls.Add(this.txtQty);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(label1);
            this.metroPanel1.Controls.Add(this.modelComboBox);
            this.metroPanel1.Controls.Add(phoneLabel);
            this.metroPanel1.Controls.Add(this.phoneLabel1);
            this.metroPanel1.Controls.Add(addressLabel);
            this.metroPanel1.Controls.Add(this.addressLabel1);
            this.metroPanel1.Controls.Add(this.invoiceDetailDataGridView);
            this.metroPanel1.Controls.Add(this.btnPrint);
            this.metroPanel1.Controls.Add(this.btnPayment);
            this.metroPanel1.Controls.Add(dateLabel);
            this.metroPanel1.Controls.Add(this.dateDateTimePicker);
            this.metroPanel1.Controls.Add(empIDLabel);
            this.metroPanel1.Controls.Add(this.empIDComboBox);
            this.metroPanel1.Controls.Add(cusIDLabel);
            this.metroPanel1.Controls.Add(this.cusIDComboBox);
            this.metroPanel1.Controls.Add(invoiceCodeLabel);
            this.metroPanel1.Controls.Add(this.invoiceCodeTextBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 88);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(991, 485);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnPurchase
            // 
            this.btnPurchase.ActiveControl = null;
            this.btnPurchase.Location = new System.Drawing.Point(868, 428);
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
            this.btnManage.Location = new System.Drawing.Point(528, 427);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(101, 38);
            this.btnManage.TabIndex = 31;
            this.btnManage.Text = "Manage";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManage.UseSelectable = true;
            this.btnManage.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtGvBuy
            // 
            this.dtGvBuy.AllowUserToAddRows = false;
            this.dtGvBuy.AllowUserToDeleteRows = false;
            this.dtGvBuy.AllowUserToResizeColumns = false;
            this.dtGvBuy.AutoGenerateColumns = false;
            this.dtGvBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGvBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.quantityDataGridViewTextBoxColumn,
            this.salepriceDataGridViewTextBoxColumn});
            this.dtGvBuy.DataSource = this.invoiceDetailBindingSource;
            this.dtGvBuy.Location = new System.Drawing.Point(528, 201);
            this.dtGvBuy.MultiSelect = false;
            this.dtGvBuy.Name = "dtGvBuy";
            this.dtGvBuy.ReadOnly = true;
            this.dtGvBuy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGvBuy.Size = new System.Drawing.Size(441, 220);
            this.dtGvBuy.TabIndex = 30;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PName";
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PSize";
            this.dataGridViewTextBoxColumn12.HeaderText = "Size";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn13.HeaderText = "Color";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salepriceDataGridViewTextBoxColumn
            // 
            this.salepriceDataGridViewTextBoxColumn.DataPropertyName = "Saleprice";
            this.salepriceDataGridViewTextBoxColumn.HeaderText = "Saleprice";
            this.salepriceDataGridViewTextBoxColumn.Name = "salepriceDataGridViewTextBoxColumn";
            this.salepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "InvoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.invoiceDetailDataSet;
            // 
            // invoiceDetailDataSet
            // 
            this.invoiceDetailDataSet.DataSetName = "InvoiceDetailDataSet";
            this.invoiceDetailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(212, 432);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(150, 34);
            this.txtQty.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 432);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(215, 166);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(147, 21);
            this.modelComboBox.TabIndex = 24;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CusbindingSource, "Phone", true));
            this.phoneLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel1.Location = new System.Drawing.Point(105, 69);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(220, 23);
            this.phoneLabel1.TabIndex = 23;
            // 
            // CusbindingSource
            // 
            this.CusbindingSource.DataMember = "Customers";
            this.CusbindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressLabel1
            // 
            this.addressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CusbindingSource, "Address", true));
            this.addressLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel1.Location = new System.Drawing.Point(105, 114);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(220, 23);
            this.addressLabel1.TabIndex = 22;
            // 
            // invoiceDetailDataGridView
            // 
            this.invoiceDetailDataGridView.AllowUserToAddRows = false;
            this.invoiceDetailDataGridView.AllowUserToDeleteRows = false;
            this.invoiceDetailDataGridView.AllowUserToResizeColumns = false;
            this.invoiceDetailDataGridView.AutoGenerateColumns = false;
            this.invoiceDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDetailDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.invoiceDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.PName,
            this.PSize,
            this.Color,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.invoiceDetailDataGridView.DataSource = this.invoiceDetailBindingSource;
            this.invoiceDetailDataGridView.Location = new System.Drawing.Point(49, 201);
            this.invoiceDetailDataGridView.MultiSelect = false;
            this.invoiceDetailDataGridView.Name = "invoiceDetailDataGridView";
            this.invoiceDetailDataGridView.ReadOnly = true;
            this.invoiceDetailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.invoiceDetailDataGridView.Size = new System.Drawing.Size(441, 220);
            this.invoiceDetailDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // PSize
            // 
            this.PSize.DataPropertyName = "PSize";
            this.PSize.HeaderText = "Size";
            this.PSize.Name = "PSize";
            this.PSize.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Saleprice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Saleprice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(641, 428);
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
            this.btnPayment.Location = new System.Drawing.Point(755, 428);
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
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "Date", true));
            this.dateDateTimePicker.Enabled = false;
            this.dateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(713, 65);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(254, 27);
            this.dateDateTimePicker.TabIndex = 13;
            // 
            // empIDComboBox
            // 
            this.empIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "EmpID", true));
            this.empIDComboBox.DataSource = this.EmpbindingSource;
            this.empIDComboBox.DisplayMember = "EmpFNEN";
            this.empIDComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDComboBox.FormattingEnabled = true;
            this.empIDComboBox.Location = new System.Drawing.Point(729, 114);
            this.empIDComboBox.Name = "empIDComboBox";
            this.empIDComboBox.Size = new System.Drawing.Size(121, 28);
            this.empIDComboBox.TabIndex = 11;
            this.empIDComboBox.ValueMember = "EmpID";
            // 
            // EmpbindingSource
            // 
            this.EmpbindingSource.DataMember = "Employee";
            this.EmpbindingSource.DataSource = this.empDataSet;
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cusIDComboBox
            // 
            this.cusIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CusID", true));
            this.cusIDComboBox.DataSource = this.CusbindingSource;
            this.cusIDComboBox.DisplayMember = "CusFNEN";
            this.cusIDComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusIDComboBox.FormattingEnabled = true;
            this.cusIDComboBox.Location = new System.Drawing.Point(105, 22);
            this.cusIDComboBox.Name = "cusIDComboBox";
            this.cusIDComboBox.Size = new System.Drawing.Size(121, 28);
            this.cusIDComboBox.TabIndex = 5;
            this.cusIDComboBox.ValueMember = "CusID";
            // 
            // invoiceCodeTextBox
            // 
            this.invoiceCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceCode", true));
            this.invoiceCodeTextBox.Enabled = false;
            this.invoiceCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCodeTextBox.Location = new System.Drawing.Point(773, 22);
            this.invoiceCodeTextBox.Name = "invoiceCodeTextBox";
            this.invoiceCodeTextBox.Size = new System.Drawing.Size(100, 27);
            this.invoiceCodeTextBox.TabIndex = 3;
            // 
            // ProductbindingSource
            // 
            this.ProductbindingSource.DataMember = "Product";
            this.ProductbindingSource.DataSource = this.product2DataSet;
            // 
            // product2DataSet
            // 
            this.product2DataSet.DataSetName = "Product2DataSet";
            this.product2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceDetailTableAdapter
            // 
            this.invoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.InvoiceDetailTableAdapter = this.invoiceDetailTableAdapter;
            this.tableAdapterManager1.UpdateOrder = PSMS.InvoiceDetailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // totalPriceLabel1
            // 
            this.totalPriceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "TotalPrice", true));
            this.totalPriceLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel1.Location = new System.Drawing.Point(526, 589);
            this.totalPriceLabel1.Name = "totalPriceLabel1";
            this.totalPriceLabel1.Size = new System.Drawing.Size(120, 23);
            this.totalPriceLabel1.TabIndex = 4;
            // 
            // paymentLabel1
            // 
            this.paymentLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paymentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Payment", true));
            this.paymentLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel1.Location = new System.Drawing.Point(815, 586);
            this.paymentLabel1.Name = "paymentLabel1";
            this.paymentLabel1.Size = new System.Drawing.Size(122, 23);
            this.paymentLabel1.TabIndex = 5;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoice2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 633);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentLabel1);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(this.totalPriceLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvoice2";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InvoiceDataSet invoiceDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private InvoiceDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private InvoiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox empIDComboBox;
        private System.Windows.Forms.ComboBox cusIDComboBox;
        private System.Windows.Forms.TextBox invoiceCodeTextBox;
        private InvoiceDetailDataSet invoiceDetailDataSet;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private InvoiceDetailDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        private InvoiceDetailDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private MetroFramework.Controls.MetroTile btnPayment;
        private MetroFramework.Controls.MetroTile btnPrint;
        private System.Windows.Forms.Label totalPriceLabel1;
        private System.Windows.Forms.BindingSource ProductbindingSource;
        private Product2DataSet product2DataSet;
        private Product2DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource EmpbindingSource;
        private EmpDataSet empDataSet;
        private EmpDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource CusbindingSource;
        private CustomerDataSet customerDataSet;
        private CustomerDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        public System.Windows.Forms.Label paymentLabel1;
        private System.Windows.Forms.DataGridView invoiceDetailDataGridView;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.Label phoneLabel1;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridView dtGvBuy;
        private MetroFramework.Controls.MetroTile btnPurchase;
        private MetroFramework.Controls.MetroTile btnManage;
        private MetroFramework.Controls.MetroTile btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;




    }
}