using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PSMS.Class;

namespace PSMS
{
    class DBSetting : MetroForm
    {
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnApply;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lbUser;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel lbPass;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbAuthentication;
        private MetroFramework.Controls.MetroTextBox txtHost;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBSetting));
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnApply = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lbUser = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.lbPass = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbAuthentication = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 29);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHost
            // 
            // 
            // 
            // 
            this.txtHost.CustomButton.Image = null;
            this.txtHost.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.txtHost.CustomButton.Name = "";
            this.txtHost.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHost.CustomButton.TabIndex = 1;
            this.txtHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHost.CustomButton.UseSelectable = true;
            this.txtHost.CustomButton.Visible = false;
            this.txtHost.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(159, 122);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Multiline = true;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.ShortcutsEnabled = true;
            this.txtHost.Size = new System.Drawing.Size(281, 29);
            this.txtHost.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtHost.TabIndex = 1;
            this.txtHost.UseCustomBackColor = true;
            this.txtHost.UseCustomForeColor = true;
            this.txtHost.UseSelectable = true;
            this.txtHost.UseStyleColors = true;
            this.txtHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(56, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Hostname : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(352, 391);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(88, 29);
            this.btnApply.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseCustomBackColor = true;
            this.btnApply.UseCustomForeColor = true;
            this.btnApply.UseSelectable = true;
            this.btnApply.UseStyleColors = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 29);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbUser.Location = new System.Drawing.Point(86, 242);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(103, 25);
            this.lbUser.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "Username : ";
            this.lbUser.UseCustomBackColor = true;
            this.lbUser.UseCustomForeColor = true;
            this.lbUser.UseStyleColors = true;
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(192, 242);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(248, 29);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtUsername.TabIndex = 5;
            this.txtUsername.UseCustomBackColor = true;
            this.txtUsername.UseCustomForeColor = true;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.UseStyleColors = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPass.Location = new System.Drawing.Point(86, 298);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(101, 25);
            this.lbPass.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbPass.TabIndex = 8;
            this.lbPass.Text = "Password  : ";
            this.lbPass.UseCustomBackColor = true;
            this.lbPass.UseCustomForeColor = true;
            this.lbPass.UseStyleColors = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(192, 294);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(248, 29);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(23, 184);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(136, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Authentication : ";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.FormattingEnabled = true;
            this.cbAuthentication.ItemHeight = 23;
            this.cbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbAuthentication.Location = new System.Drawing.Point(159, 180);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(281, 29);
            this.cbAuthentication.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbAuthentication.TabIndex = 10;
            this.cbAuthentication.UseCustomBackColor = true;
            this.cbAuthentication.UseCustomForeColor = true;
            this.cbAuthentication.UseSelectable = true;
            this.cbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbAuthentication_SelectedIndexChanged);
            // 
            // DBSetting
            // 
            this.ClientSize = new System.Drawing.Size(504, 452);
            this.Controls.Add(this.cbAuthentication);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "DBSetting";
            this.Text = "Setting up a Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Properties.Settings setting = new Properties.Settings(); //Unsed
        INIParser mySetting = new INIParser("Settings.ini"); //Used

        //AuthType
        string section = "SQL Server Authentication";
        string section2 = "Windows Authentication";

        public DBSetting()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ControlBox = false;

            reloadCheck();

        }

        private void reloadCheck(byte auth=0)
        {
            byte type = auth;

            try
            {
                type = byte.Parse(mySetting.Read("AuthType"));
            }
            catch (Exception)
            {
                type = 0;
            }

            if (type == 0)
            {
                txtHost.Text = mySetting.Read("hostname", section2);
                cbAuthentication.SelectedIndex = 0;
                UserPassEnable(false);
            }
            else
            {
                setAuthSQL();
                UserPassEnable(true);
            }
        }

        private void setAuthSQL()
        {
            cbAuthentication.SelectedIndex = 1;
            txtHost.Text = mySetting.Read("hostname", section);
            txtUsername.Text = mySetting.Read("username", section);
            txtPassword.Text = mySetting.Read("password", section);
        }

        private void UserPassEnable(bool enable)
        {
            if (enable)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                lbPass.ForeColor = System.Drawing.Color.Black;
                lbUser.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                lbPass.ForeColor = System.Drawing.Color.LightGray;
                lbUser.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void cbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthentication.SelectedIndex == 0)
            {
                txtHost.Text = mySetting.Read("hostname", section2);
                UserPassEnable(false);
            }
            else
            {
                setAuthSQL();
                UserPassEnable(true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                saveSetting(Authentication);
                MessageBox.Show("Saved!", "DB Setting");
                reloadCheck();
            }
            catch(Exception)
            {
                MessageBox.Show("Saving error!", "DB Setting");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnApply_Click(sender, e);
            this.Close();
        }

        private void saveSetting(byte auth)
        {
            if (auth.Equals(1))
            {
                mySetting.Write("AuthType", 1 + "");
                mySetting.Write("hostname", txtHost.Text, section);
                mySetting.Write("dbname", "PSMS2", section);
                mySetting.Write("username", txtUsername.Text, section);
                mySetting.Write("password", txtPassword.Text, section);
            }
            else
            {
                mySetting.Write("AuthType", 0 + "");
                mySetting.Write("hostname", txtHost.Text, section2);
                mySetting.Write("dbname", "PSMS2", section2);
            }


        }

        private string Hostname
        {
            get { return Properties.Settings.Default.Hostname; }
            set { Properties.Settings.Default.Hostname = value; Properties.Settings.Default.Save(); }
        }

        private string Username
        {
            get { return Properties.Settings.Default.Username; }
            set { Properties.Settings.Default.Username = value; Properties.Settings.Default.Save(); }
        }
        private string Password
        {
            get { return Properties.Settings.Default.Password; }
            set { Properties.Settings.Default.Password = value; Properties.Settings.Default.Save(); }
        }

        private byte Authentication
        {
            get { return Properties.Settings.Default.Authentication; }
            set { Properties.Settings.Default.Authentication = value; Properties.Settings.Default.Save(); }
        }

        private string PSMS2Connection
        {
            get { return Properties.Settings.Default.PSMS2ConnectionString; }
        }

    }
}
