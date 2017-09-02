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
    public partial class frmPhoneType : MetroForm
    {
        frmPTypeCodeFunction ptFun;
        public frmPhoneType()
        {
            InitializeComponent();
            ptFun = new frmPTypeCodeFunction();
        }
        private void frmPhoneType_Load(object sender, EventArgs e)
        {
            ptFun.FillDataGridView(ref dgPT);
        }
        private frmPT GetPT()
        {
            frmPT PT = new frmPT();
            PT.PTypeID = Convert.ToInt32(txtPTID.Text);
            PT.PTypeCode = txtPTCode.Text;
            PT.Description = txtDe.Text;
            return PT;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtPTCode.Text = "";
            txtDe.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)ptFun.Delete(Convert.ToInt32(txtPTID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ptFun.FillDataGridView(ref dgPT);
                    txtPTCode.Text = "";
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
            int result = (int)ptFun.Update(GetPT());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ptFun.FillDataGridView(ref dgPT);

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)ptFun.Insert(GetPT());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ptFun.FillDataGridView(ref dgPT);
                txtPTID.Text = result.ToString();

            }
        }

        private void dgPT_Click(object sender, EventArgs e)
        {
            int ptid = 0;
            foreach (DataGridViewRow row in dgPT.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value != null)
                {
                    ptid = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = ptFun.GetData("SELECT * FROM PhoneType WHERE PTypeID = " + ptid);

            foreach (DataRow row in dt.Rows)
            {
                txtPTID.Text = row["PTypeID"].ToString();
                txtPTCode.Text = row["PTypeCode"].ToString();
                txtDe.Text = row["Description"].ToString();

            }
        }

      
    }
}
