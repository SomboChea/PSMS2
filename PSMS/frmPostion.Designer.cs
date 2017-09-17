namespace PSMS
{
    partial class frmPostion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostion));
            this.dgPos = new MetroFramework.Controls.MetroGrid();
            this.btnClr = new MetroFramework.Controls.MetroTile();
            this.btnDel = new MetroFramework.Controls.MetroTile();
            this.btnUp = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.txtPosName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtPosCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPosID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPos
            // 
            this.dgPos.AllowUserToResizeRows = false;
            this.dgPos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPos.EnableHeadersVisualStyles = false;
            this.dgPos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgPos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgPos.Location = new System.Drawing.Point(324, 24);
            this.dgPos.Name = "dgPos";
            this.dgPos.ReadOnly = true;
            this.dgPos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPos.Size = new System.Drawing.Size(236, 193);
            this.dgPos.TabIndex = 127;
            this.dgPos.Click += new System.EventHandler(this.dgPos_Click);
            // 
            // btnClr
            // 
            this.btnClr.ActiveControl = null;
            this.btnClr.Location = new System.Drawing.Point(240, 179);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(63, 38);
            this.btnClr.TabIndex = 126;
            this.btnClr.Text = "Clear";
            this.btnClr.UseSelectable = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnDel
            // 
            this.btnDel.ActiveControl = null;
            this.btnDel.Location = new System.Drawing.Point(169, 179);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(63, 38);
            this.btnDel.TabIndex = 125;
            this.btnDel.Text = "Delete";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.ActiveControl = null;
            this.btnUp.Location = new System.Drawing.Point(98, 179);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(63, 38);
            this.btnUp.TabIndex = 124;
            this.btnUp.Text = "Update";
            this.btnUp.UseSelectable = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.Location = new System.Drawing.Point(27, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(63, 38);
            this.btnNew.TabIndex = 123;
            this.btnNew.Text = "Save";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPosName
            // 
            // 
            // 
            // 
            this.txtPosName.CustomButton.Image = null;
            this.txtPosName.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtPosName.CustomButton.Name = "";
            this.txtPosName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPosName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPosName.CustomButton.TabIndex = 1;
            this.txtPosName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPosName.CustomButton.UseSelectable = true;
            this.txtPosName.CustomButton.Visible = false;
            this.txtPosName.Lines = new string[0];
            this.txtPosName.Location = new System.Drawing.Point(124, 121);
            this.txtPosName.MaxLength = 32767;
            this.txtPosName.Name = "txtPosName";
            this.txtPosName.PasswordChar = '\0';
            this.txtPosName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPosName.SelectedText = "";
            this.txtPosName.SelectionLength = 0;
            this.txtPosName.SelectionStart = 0;
            this.txtPosName.ShortcutsEnabled = true;
            this.txtPosName.Size = new System.Drawing.Size(111, 23);
            this.txtPosName.TabIndex = 122;
            this.txtPosName.UseSelectable = true;
            this.txtPosName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPosName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel9.Location = new System.Drawing.Point(27, 125);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(94, 19);
            this.metroLabel9.TabIndex = 121;
            this.metroLabel9.Text = "Position Name";
            // 
            // txtPosCode
            // 
            // 
            // 
            // 
            this.txtPosCode.CustomButton.Image = null;
            this.txtPosCode.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtPosCode.CustomButton.Name = "";
            this.txtPosCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPosCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPosCode.CustomButton.TabIndex = 1;
            this.txtPosCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPosCode.CustomButton.UseSelectable = true;
            this.txtPosCode.CustomButton.Visible = false;
            this.txtPosCode.Enabled = false;
            this.txtPosCode.Lines = new string[0];
            this.txtPosCode.Location = new System.Drawing.Point(125, 79);
            this.txtPosCode.MaxLength = 32767;
            this.txtPosCode.Name = "txtPosCode";
            this.txtPosCode.PasswordChar = '\0';
            this.txtPosCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPosCode.SelectedText = "";
            this.txtPosCode.SelectionLength = 0;
            this.txtPosCode.SelectionStart = 0;
            this.txtPosCode.ShortcutsEnabled = true;
            this.txtPosCode.Size = new System.Drawing.Size(111, 23);
            this.txtPosCode.TabIndex = 120;
            this.txtPosCode.UseSelectable = true;
            this.txtPosCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPosCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(25, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 119;
            this.metroLabel2.Text = "PositionCode";
            // 
            // txtPosID
            // 
            // 
            // 
            // 
            this.txtPosID.CustomButton.Image = null;
            this.txtPosID.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtPosID.CustomButton.Name = "";
            this.txtPosID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPosID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPosID.CustomButton.TabIndex = 1;
            this.txtPosID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPosID.CustomButton.UseSelectable = true;
            this.txtPosID.CustomButton.Visible = false;
            this.txtPosID.Enabled = false;
            this.txtPosID.Lines = new string[0];
            this.txtPosID.Location = new System.Drawing.Point(154, 47);
            this.txtPosID.MaxLength = 32767;
            this.txtPosID.Name = "txtPosID";
            this.txtPosID.PasswordChar = '\0';
            this.txtPosID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPosID.SelectedText = "";
            this.txtPosID.SelectionLength = 0;
            this.txtPosID.SelectionStart = 0;
            this.txtPosID.ShortcutsEnabled = true;
            this.txtPosID.Size = new System.Drawing.Size(111, 23);
            this.txtPosID.TabIndex = 118;
            this.txtPosID.UseSelectable = true;
            this.txtPosID.Visible = false;
            this.txtPosID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPosID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(107, 47);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 117;
            this.metroLabel3.Text = "PosID";
            this.metroLabel3.Visible = false;
            // 
            // frmPostion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 240);
            this.Controls.Add(this.dgPos);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtPosName);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtPosCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPosID);
            this.Controls.Add(this.metroLabel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPostion";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.frmPostion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgPos;
        private MetroFramework.Controls.MetroTile btnClr;
        private MetroFramework.Controls.MetroTile btnDel;
        private MetroFramework.Controls.MetroTile btnUp;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTextBox txtPosName;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtPosCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPosID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}