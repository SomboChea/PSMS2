namespace PSMS
{
    partial class frmType
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
            this.dgT = new MetroFramework.Controls.MetroGrid();
            this.btnClr = new MetroFramework.Controls.MetroTile();
            this.btnDel = new MetroFramework.Controls.MetroTile();
            this.btnUp = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.txtDe = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtTCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgT
            // 
            this.dgT.AllowUserToResizeRows = false;
            this.dgT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgT.EnableHeadersVisualStyles = false;
            this.dgT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgT.Location = new System.Drawing.Point(324, 24);
            this.dgT.Name = "dgT";
            this.dgT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgT.Size = new System.Drawing.Size(236, 193);
            this.dgT.TabIndex = 116;
            this.dgT.Click += new System.EventHandler(this.dgT_Click);
            // 
            // btnClr
            // 
            this.btnClr.ActiveControl = null;
            this.btnClr.Location = new System.Drawing.Point(240, 179);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(63, 38);
            this.btnClr.TabIndex = 115;
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
            this.btnDel.TabIndex = 114;
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
            this.btnUp.TabIndex = 113;
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
            this.btnNew.TabIndex = 112;
            this.btnNew.Text = "Save";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDe
            // 
            // 
            // 
            // 
            this.txtDe.CustomButton.Image = null;
            this.txtDe.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtDe.CustomButton.Name = "";
            this.txtDe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDe.CustomButton.TabIndex = 1;
            this.txtDe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDe.CustomButton.UseSelectable = true;
            this.txtDe.CustomButton.Visible = false;
            this.txtDe.Lines = new string[0];
            this.txtDe.Location = new System.Drawing.Point(124, 121);
            this.txtDe.MaxLength = 32767;
            this.txtDe.Name = "txtDe";
            this.txtDe.PasswordChar = '\0';
            this.txtDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDe.SelectedText = "";
            this.txtDe.SelectionLength = 0;
            this.txtDe.SelectionStart = 0;
            this.txtDe.ShortcutsEnabled = true;
            this.txtDe.Size = new System.Drawing.Size(111, 23);
            this.txtDe.TabIndex = 111;
            this.txtDe.UseSelectable = true;
            this.txtDe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel9.Location = new System.Drawing.Point(27, 125);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 110;
            this.metroLabel9.Text = "Description";
            // 
            // txtTCode
            // 
            // 
            // 
            // 
            this.txtTCode.CustomButton.Image = null;
            this.txtTCode.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtTCode.CustomButton.Name = "";
            this.txtTCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTCode.CustomButton.TabIndex = 1;
            this.txtTCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTCode.CustomButton.UseSelectable = true;
            this.txtTCode.CustomButton.Visible = false;
            this.txtTCode.Lines = new string[0];
            this.txtTCode.Location = new System.Drawing.Point(125, 79);
            this.txtTCode.MaxLength = 32767;
            this.txtTCode.Name = "txtTCode";
            this.txtTCode.PasswordChar = '\0';
            this.txtTCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTCode.SelectedText = "";
            this.txtTCode.SelectionLength = 0;
            this.txtTCode.SelectionStart = 0;
            this.txtTCode.ShortcutsEnabled = true;
            this.txtTCode.Size = new System.Drawing.Size(111, 23);
            this.txtTCode.TabIndex = 109;
            this.txtTCode.UseSelectable = true;
            this.txtTCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(25, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 108;
            this.metroLabel2.Text = "TypeCode";
            // 
            // txtTID
            // 
            // 
            // 
            // 
            this.txtTID.CustomButton.Image = null;
            this.txtTID.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtTID.CustomButton.Name = "";
            this.txtTID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTID.CustomButton.TabIndex = 1;
            this.txtTID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTID.CustomButton.UseSelectable = true;
            this.txtTID.CustomButton.Visible = false;
            this.txtTID.Enabled = false;
            this.txtTID.Lines = new string[0];
            this.txtTID.Location = new System.Drawing.Point(207, 53);
            this.txtTID.MaxLength = 32767;
            this.txtTID.Name = "txtTID";
            this.txtTID.PasswordChar = '\0';
            this.txtTID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTID.SelectedText = "";
            this.txtTID.SelectionLength = 0;
            this.txtTID.SelectionStart = 0;
            this.txtTID.ShortcutsEnabled = true;
            this.txtTID.Size = new System.Drawing.Size(111, 23);
            this.txtTID.TabIndex = 107;
            this.txtTID.UseSelectable = true;
            this.txtTID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(107, 53);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 106;
            this.metroLabel3.Text = "TypeID";
            // 
            // frmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 240);
            this.Controls.Add(this.dgT);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtTCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.metroLabel3);
            this.Name = "frmType";
            this.Text = "Type";
            this.Load += new System.EventHandler(this.frmType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgT;
        private MetroFramework.Controls.MetroTile btnClr;
        private MetroFramework.Controls.MetroTile btnDel;
        private MetroFramework.Controls.MetroTile btnUp;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTextBox txtDe;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtTCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}