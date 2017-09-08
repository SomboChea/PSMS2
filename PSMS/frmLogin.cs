using MetroFramework;
using MetroFramework.Forms;
using PSMS.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmLogin : MetroForm
    {
        frmMain Main = new frmMain();
        public frmLogin()
        {
            InitializeComponent();

            Connection.Open("localhost", "PSMS2");

            btnlogin_Click(null,null);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           //btn_Submit Click event
            if(txtUser.Text=="" || txtPass.Text=="")
            {
                MetroMessageBox.Show(this, "Please provide Username and Password", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                return;
            }

            try
            {
                //Get SqlConnection from Connection
                
                SqlCommand cmd = new SqlCommand("Select * from Users where UName=@UName and Password=@Password",Connection.con);

                cmd.Parameters.AddWithValue("@UName",txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                
                //If count is equal to 1, than show frmMain form
                if (count > 0)
                {

                    MetroMessageBox.Show(this, "Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adapter.Dispose();
                    cmd.Dispose();
                    ds.Dispose();

                    Hide();
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
