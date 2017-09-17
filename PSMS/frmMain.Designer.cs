namespace PSMS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroTileFrame3 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.metroTileFrame5 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.metroTileFrame1 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.metroTileFrame2 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.MetroSale = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroStock = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroPro = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.MetroCus = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroSup = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroPur = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroEmps = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroUser = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroDown = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.empDataSet = new PSMS.EmpDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new PSMS.EmpDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new PSMS.EmpDataSetTableAdapters.TableAdapterManager();
            this.btnQuit = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileFrame3
            // 
            this.metroTileFrame3.Image = global::PSMS.Properties.Resources.warehouse_4_;
            this.metroTileFrame3.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFrame3.Text = "Stock";
            this.metroTileFrame3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileFrame3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileFrame3.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileFrame5
            // 
            this.metroTileFrame5.Image = global::PSMS.Properties.Resources.badge;
            this.metroTileFrame5.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFrame5.Text = "Stock";
            this.metroTileFrame5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellow;
            // 
            // 
            // 
            this.metroTileFrame5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileFrame1
            // 
            this.metroTileFrame1.Image = global::PSMS.Properties.Resources.warehouse_4_;
            this.metroTileFrame1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFrame1.Text = "Stock";
            this.metroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.metroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileFrame2
            // 
            this.metroTileFrame2.Image = global::PSMS.Properties.Resources.warehouse_4_;
            this.metroTileFrame2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFrame2.Text = "Stock";
            this.metroTileFrame2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.metroTileFrame2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // itemPanel1
            // 
            this.itemPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer3,
            this.itemContainer1});
            this.itemPanel1.KeyTipsFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(47, 80);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(935, 458);
            this.itemPanel1.TabIndex = 3;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MetroSale,
            this.MetroStock,
            this.MetroPro});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // MetroSale
            // 
            this.MetroSale.AnimationDuration = 8000;
            this.MetroSale.Image = global::PSMS.Properties.Resources.badge;
            this.MetroSale.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroSale.Name = "MetroSale";
            this.MetroSale.SymbolColor = System.Drawing.Color.Empty;
            this.MetroSale.Text = "Sale";
            this.MetroSale.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.MetroSale.TileSize = new System.Drawing.Size(365, 150);
            // 
            // 
            // 
            this.MetroSale.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroSale.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroSale.Click += new System.EventHandler(this.MetroSale_Click);
            // 
            // MetroStock
            // 
            this.MetroStock.AnimationDuration = 8000;
            this.MetroStock.Frames.Add(this.metroTileFrame3);
            this.MetroStock.Frames.Add(this.metroTileFrame5);
            this.MetroStock.Image = global::PSMS.Properties.Resources.warehouse_4_;
            this.MetroStock.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroStock.Name = "MetroStock";
            this.MetroStock.SymbolColor = System.Drawing.Color.Empty;
            this.MetroStock.Text = "Stock";
            this.MetroStock.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.MetroStock.TileSize = new System.Drawing.Size(365, 150);
            // 
            // 
            // 
            this.MetroStock.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroStock.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroStock.Click += new System.EventHandler(this.MetroStock_Click);
            // 
            // MetroPro
            // 
            this.MetroPro.AutoRotateFramesInterval = 5000;
            this.MetroPro.Image = global::PSMS.Properties.Resources.smartphone;
            this.MetroPro.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroPro.Name = "MetroPro";
            this.MetroPro.SymbolColor = System.Drawing.Color.Empty;
            this.MetroPro.Text = "Products";
            this.MetroPro.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Maroon;
            this.MetroPro.TileSize = new System.Drawing.Size(203, 150);
            // 
            // 
            // 
            this.MetroPro.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroPro.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroPro.Click += new System.EventHandler(this.MetroPro_Click);
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MetroCus,
            this.MetroSup,
            this.MetroPur,
            this.MetroEmps});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // MetroCus
            // 
            this.MetroCus.Image = global::PSMS.Properties.Resources.clerk_with_tie;
            this.MetroCus.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroCus.Name = "MetroCus";
            this.MetroCus.SymbolColor = System.Drawing.Color.Empty;
            this.MetroCus.Text = "Customers";
            this.MetroCus.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            this.MetroCus.TileSize = new System.Drawing.Size(200, 150);
            // 
            // 
            // 
            this.MetroCus.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroCus.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroCus.Click += new System.EventHandler(this.MetroCus_Click);
            // 
            // MetroSup
            // 
            this.MetroSup.Image = global::PSMS.Properties.Resources.factory_worker;
            this.MetroSup.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroSup.Name = "MetroSup";
            this.MetroSup.SymbolColor = System.Drawing.Color.Empty;
            this.MetroSup.Text = "Supplier";
            this.MetroSup.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.MetroSup.TileSize = new System.Drawing.Size(200, 150);
            // 
            // 
            // 
            this.MetroSup.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroSup.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroSup.Click += new System.EventHandler(this.MetroSup_Click);
            // 
            // MetroPur
            // 
            this.MetroPur.Image = global::PSMS.Properties.Resources.hospital_supplies;
            this.MetroPur.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroPur.Name = "MetroPur";
            this.MetroPur.SymbolColor = System.Drawing.Color.Empty;
            this.MetroPur.Text = "Purchase";
            this.MetroPur.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            this.MetroPur.TileSize = new System.Drawing.Size(380, 150);
            // 
            // 
            // 
            this.MetroPur.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroPur.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroPur.Click += new System.EventHandler(this.MetroPur_Click);
            // 
            // MetroEmps
            // 
            this.MetroEmps.Image = global::PSMS.Properties.Resources.users;
            this.MetroEmps.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroEmps.Name = "MetroEmps";
            this.MetroEmps.SymbolColor = System.Drawing.Color.Empty;
            this.MetroEmps.Text = "Employees";
            this.MetroEmps.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            this.MetroEmps.TileSize = new System.Drawing.Size(150, 150);
            // 
            // 
            // 
            this.MetroEmps.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroEmps.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroEmps.Click += new System.EventHandler(this.MetroEmps_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem7,
            this.MetroUser});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Image = global::PSMS.Properties.Resources.increasing_stocks_graphic_of_bars;
            this.metroTileItem7.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.Text = "Report";
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            this.metroTileItem7.TileSize = new System.Drawing.Size(730, 150);
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem7.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem7.Click += new System.EventHandler(this.metroTileItem7_Click);
            // 
            // MetroUser
            // 
            this.MetroUser.AutoRotateFramesInterval = 7000;
            this.MetroUser.Image = global::PSMS.Properties.Resources.avatar;
            this.MetroUser.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroUser.Name = "MetroUser";
            this.MetroUser.SymbolColor = System.Drawing.Color.Empty;
            this.MetroUser.Text = "User";
            this.MetroUser.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            this.MetroUser.TileSize = new System.Drawing.Size(203, 150);
            // 
            // 
            // 
            this.MetroUser.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroUser.TileStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetroUser.Click += new System.EventHandler(this.MetroUser_Click);
            // 
            // MetroDown
            // 
            this.MetroDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MetroDown.Location = new System.Drawing.Point(22, 608);
            this.MetroDown.Name = "MetroDown";
            this.MetroDown.Size = new System.Drawing.Size(58, 37);
            this.MetroDown.TabIndex = 4;
            this.MetroDown.Text = "Down";
            this.MetroDown.UseSelectable = true;
            this.MetroDown.Visible = false;
            this.MetroDown.Click += new System.EventHandler(this.MetroDown_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.BackColor = System.Drawing.Color.Red;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.ForeColor = System.Drawing.Color.White;
            this.metroLink1.Location = new System.Drawing.Point(843, 38);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(139, 36);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Log Out";
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // empDataSet
            // 
            this.empDataSet.DataSetName = "EmpDataSet";
            this.empDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.empDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = PSMS.EmpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuit.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(883, 544);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(99, 36);
            this.btnQuit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseCustomBackColor = true;
            this.btnQuit.UseCustomForeColor = true;
            this.btnQuit.UseSelectable = true;
            this.btnQuit.UseStyleColors = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMain
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 612);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.MetroDown);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.metroLink1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroSale;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroPro;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroCus;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroSup;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroPur;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroEmps;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem7;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroUser;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroStock;
        private MetroFramework.Controls.MetroLink MetroDown;
        private MetroFramework.Controls.MetroLink metroLink1;
        private DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame3;
        private DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame5;
        private DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame1;
        private DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame2;
        private EmpDataSet empDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmpDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private EmpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroLink btnQuit;
    }
}

