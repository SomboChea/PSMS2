using MetroFramework;
using MetroFramework.Forms;
using PSMS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmLogin : MetroForm
    {
        User user = new User();

        public frmLogin()
        {
            
            InitializeComponent();
            Connection.Open("localhost", "PSMS2");

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           //btn_Submit Click event
            if(txtUser.Text=="" || txtPass.Text=="")
            {
                MetroMessageBox.Show(this, "Please provide UserName and Password", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                //Create SqlConnection
                SqlCommand cmd = new SqlCommand("Select * from Users where UName=@UName and Password=@Password",Connection.con);
                cmd.Parameters.AddWithValue("@UName",txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;

                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {

                    MetroMessageBox.Show(this, "Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.Name = txtUser.Text;
                    this.Hide();
                    new frmMain(user).Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Login Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = MetroMessageBox.Show(this, "Are you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            else if (dia == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //txtUser.Text = "admin";
            //txtPass.Text = "123";
            //btnlogin_Click(this, null);
        
        }
    }
}
