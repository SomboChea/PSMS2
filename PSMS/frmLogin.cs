using MetroFramework;
using MetroFramework.Forms;
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
        frmMain Main = new frmMain();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Connection String
            string cs = @"Server=localhost; Initial Catalog=PSMS2; Integrated Security=true";
           //btn_Submit Click event
            if(txtUser.Text=="" || txtPass.Text=="")
            {
                
                MetroMessageBox.Show(this, "Please provide UserName and Password", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Users where UName=@UName and Password=@Password",con);
                cmd.Parameters.AddWithValue("@UName",txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {

                    MetroMessageBox.Show(this, "Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Main.ShowDialog();
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
    }
}
