﻿namespace PSMS
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.viewReport = new MetroFramework.Controls.MetroGrid();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateStart = new MetroFramework.Controls.MetroDateTime();
            this.dateEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.viewStock = new MetroFramework.Controls.MetroTile();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.viewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(23, 109);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(132, 52);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Customer";
            this.metroTile1.TileImage = global::PSMS.Properties.Resources.avatar;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.ForeColor = System.Drawing.Color.White;
            this.metroTile2.Location = new System.Drawing.Point(23, 283);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(132, 52);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Puchase";
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.ForeColor = System.Drawing.Color.White;
            this.metroTile3.Location = new System.Drawing.Point(23, 341);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(132, 52);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Invoice";
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.ForeColor = System.Drawing.Color.White;
            this.metroTile5.Location = new System.Drawing.Point(23, 167);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(132, 52);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Supplier";
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseStyleColors = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.ForeColor = System.Drawing.Color.White;
            this.metroTile4.Location = new System.Drawing.Point(23, 225);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(132, 52);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Employee";
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseStyleColors = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // viewReport
            // 
            this.viewReport.AllowUserToResizeRows = false;
            this.viewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewReport.EnableHeadersVisualStyles = false;
            this.viewReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.viewReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewReport.Location = new System.Drawing.Point(178, 109);
            this.viewReport.Name = "viewReport";
            this.viewReport.ReadOnly = true;
            this.viewReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.viewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewReport.Size = new System.Drawing.Size(723, 342);
            this.viewReport.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Green;
            this.btnPreview.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(770, 477);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(131, 36);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseCustomBackColor = true;
            this.btnPreview.UseCustomForeColor = true;
            this.btnPreview.UseSelectable = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(247, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "From date";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(344, 62);
            this.dateStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(107, 29);
            this.dateStart.TabIndex = 8;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(524, 62);
            this.dateEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(107, 29);
            this.dateEnd.TabIndex = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(459, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "to date";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(650, 62);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(74, 29);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filler";
            this.btnFilter.UseCustomBackColor = true;
            this.btnFilter.UseCustomForeColor = true;
            this.btnFilter.UseSelectable = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // viewStock
            // 
            this.viewStock.ActiveControl = null;
            this.viewStock.ForeColor = System.Drawing.Color.White;
            this.viewStock.Location = new System.Drawing.Point(24, 399);
            this.viewStock.Name = "viewStock";
            this.viewStock.Size = new System.Drawing.Size(131, 52);
            this.viewStock.Style = MetroFramework.MetroColorStyle.Blue;
            this.viewStock.TabIndex = 12;
            this.viewStock.Text = "Stock";
            this.viewStock.UseCustomForeColor = true;
            this.viewStock.UseSelectable = true;
            this.viewStock.UseStyleColors = true;
            this.viewStock.Click += new System.EventHandler(this.viewStock_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(24, 477);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 36);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(161, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.viewStock);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.viewReport);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.Text = "Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReport_FormClosing);
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroGrid viewReport;
        private MetroFramework.Controls.MetroButton btnPreview;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dateStart;
        private MetroFramework.Controls.MetroDateTime dateEnd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnFilter;
        private MetroFramework.Controls.MetroTile viewStock;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}