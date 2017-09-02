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
    public partial class frmType : MetroForm
    {
        frmTypeFunction tFun;
        public frmType()
        {
            InitializeComponent();
            tFun = new frmTypeFunction();
        }

        private void frmType_Load(object sender, EventArgs e)
        {
            tFun.FillDataGridView(ref dgT);
        }
        private frmT GetT()
        {
            frmT T = new frmT();
            T.TID = Convert.ToInt32(txtTID.Text);
            T.TCode = txtTCode.Text;
            T.Description = txtDe.Text;
            return T;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)tFun.Insert(GetT());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tFun.FillDataGridView(ref dgT);
                txtTID.Text = result.ToString();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)tFun.Delete(Convert.ToInt32(txtTID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tFun.FillDataGridView(ref dgT);
                    txtTCode.Text = "";
                    txtDe.Text = "";

                }
            }
            else if (dia == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int result = (int)tFun.Update(GetT());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tFun.FillDataGridView(ref dgT);

            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtTCode.Text = "";
            txtDe.Text = "";
        }

        private void dgT_Click(object sender, EventArgs e)
        {
            int tid = 0;
            foreach (DataGridViewRow row in dgT.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value != null)
                {
                    tid = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = tFun.GetData("SELECT * FROM Type WHERE TID = " + tid);

            foreach (DataRow row in dt.Rows)
            {
                txtTID.Text = row["TID"].ToString();
                txtTCode.Text = row["TCode"].ToString();
                txtDe.Text = row["Description"].ToString();

            }
        }
    }
}
