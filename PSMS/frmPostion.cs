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
    public partial class frmPostion : MetroForm
    {
        frmPosFunction PosFun;
        public frmPostion()
        {
            InitializeComponent();
            PosFun = new frmPosFunction();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)PosFun.Insert(GetPos());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Position Add", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PosFun.FillDataGridView(ref dgPos);
                txtPosID.Text = result.ToString();
            }
        }

        private frmPos GetPos() 
        {
            frmPos Pos = new frmPos();
            Pos.PosID = Convert.ToInt32(txtPosID.Text);
            Pos.PosName = txtPosName.Text;
            Pos.PosCode = txtPosCode.Text;
            return Pos;
        }
        private void frmPostion_Load(object sender, EventArgs e)
        {
            PosFun.FillDataGridView(ref dgPos);
        }

        private void dgPos_Click(object sender, EventArgs e)
        {
            int PosID = 0;
            foreach (DataGridViewRow row in dgPos.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value != null)
                {
                    PosID = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = PosFun.GetData("SELECT * FROM Position WHERE PosID = " + PosID);

            foreach (DataRow row in dt.Rows)
            {
                txtPosID.Text = row["PosID"].ToString();
                txtPosCode.Text = row["PosCode"].ToString();
                txtPosName.Text = row["PosName"].ToString();
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int result = (int)PosFun.Update(GetPos());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PosFun.FillDataGridView(ref dgPos);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)PosFun.Delete(Convert.ToInt32(txtPosID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PosFun.FillDataGridView(ref dgPos);
                    txtPosCode.Text = "";
                    txtPosName.Text = "";
                    
                }
            }
            else if (dia == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtPosCode.Text = "";
            txtPosName.Text = "";
        }
    }
}
