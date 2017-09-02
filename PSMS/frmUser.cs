using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmUser : MetroForm
    {
        frmUserFunction uFun;
        public frmUser()
        {
            InitializeComponent();
            uFun = new frmUserFunction();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain main = new frmMain();
            //main.Show();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            uFun.FillDataGridView(ref dgUser);
        }
        private frmU GetUser()
        {
            frmU U = new frmU();
            U.UID = Convert.ToInt32(txtUID.Text);
            U.UCode = txtUCode.Text;
            U.UName = txtUName.Text;
            U.Password = txtPass.Text;
            return U;
        }

        private void dgUser_Click(object sender, EventArgs e)
        {
            int uid = 0;
            foreach (DataGridViewRow row in dgUser.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value != null)
                {
                    uid = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = uFun.GetData("SELECT * FROM Users WHERE UID = " + uid);

            foreach (DataRow row in dt.Rows)
            {
                txtUID.Text = row["UID"].ToString();
                txtUCode.Text = row["UCode"].ToString();
                txtUName.Text = row["UName"].ToString();
                txtPass.Text = row["Password"].ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)uFun.Insert(GetUser());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uFun.FillDataGridView(ref dgUser);
                txtUID.Text = result.ToString();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)uFun.Delete(Convert.ToInt32(txtUID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uFun.FillDataGridView(ref dgUser);

                }
            }
            else if (dia == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int result = (int)uFun.Update(GetUser());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uFun.FillDataGridView(ref dgUser);

            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtUID.Text = "";
            txtUCode.Text = "";
            txtUName.Text = "";
            txtPass.Text = "";
        }
    }
}
