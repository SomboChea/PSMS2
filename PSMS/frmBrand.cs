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
    public partial class frmBrand : MetroForm
    {
        frmModelFunction moFun;
        int mId = 0;
        public frmBrand()
        {
            InitializeComponent();
            moFun = new frmModelFunction();
            
        }

        private void frmModel_Load(object sender, EventArgs e)
        {
            moFun.FillDataGridView(ref dgMo);
            reloadMId();
        }

        public void reloadMId()
        {
            mId = moFun.GetLastId("model") + 1;
            txtMCode.Text = "M" + ("00000" + mId).Substring(("00000" + mId).Length - 5);
        }

        private frmM GetMo()
        {
            frmM Mo = new frmM();
            Mo.MID = Convert.ToInt32(txtMID.Text);
            Mo.MCode = txtMCode.Text;
            Mo.Description = txtDe.Text;
            return Mo;
        }

        private void dgMo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)moFun.Insert(GetMo());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                moFun.FillDataGridView(ref dgMo);
                txtMID.Text = result.ToString();

            }
            txtDe.Clear();
            reloadMId();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int result = (int)moFun.Update(GetMo());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                moFun.FillDataGridView(ref dgMo);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)moFun.Delete(Convert.ToInt32(txtMID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    moFun.FillDataGridView(ref dgMo);
                    txtMCode.Text = "";
                    txtDe.Text = "";

                }
            }
            else if (dia == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            
            txtMCode.Text = "";
            txtDe.Text = "";
        }

        private void dgMo_SelectionChanged(object sender, EventArgs e)
        {
            int mid = 0;
            
            if(dgMo.SelectedRows.Count>0)
            {
                mid = 0;
            }

            DataTable dt = moFun.GetData("SELECT * FROM Model WHERE MID = " + mid);

            foreach (DataRow row in dt.Rows)
            {
                txtMID.Text = row["MID"].ToString();
                txtMCode.Text = row["MCode"].ToString();
                txtDe.Text = row["Description"].ToString();

            }
        }
    }
}
