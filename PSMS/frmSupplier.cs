using MetroFramework;
using MetroFramework.Forms;
using PSMS.Class;
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
    public partial class frmSupplier : MetroForm
    {
        frmSupplierFunction suFun;
        int index;
        public frmSupplier()
        {
            InitializeComponent();
            suFun = new frmSupplierFunction();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Resizable = false;
          
            btnNexts.Enabled = false;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            suFun.FillDataGridView(ref dgSu);
            index = dgSu.Rows.Count - 1;
            cbBGender.SelectedIndex = 0;
            btnpre.Enabled=dgSu.Rows.Count<1?false:true;

            object empid = Connection.ExecuteScalar("Select ident_current('Supplier')");
            int Eid = empid == null ? 1 : int.Parse(empid + "") + 1;
            txtSuID.Text = Eid + "";
            txtSuCode.Text = "SU" + ("00000" + Eid).Substring(("00000" + Eid).Length - 5);
            
        }
        private frmSu GetSu()
        {
           frmSu su = new frmSu();
            su.su_id = Convert.ToInt32(txtSuID.Text);
            su.sucode = txtSuCode.Text;
            su.su_lnkh = txtKh1.Text;
            su.su_fnkh = txtKh2.Text;
            su.su_lnen = txtEn1.Text;
            su.su_fnen = txtEn2.Text;
            su.gender = cbBGender.SelectedItem.ToString();
            su.address = rtxtAddress.Text;
            su.phone = txtPhone.Text;
            su.phone2 = txtPhone2.Text;
            su.email = txtEmail.Text;
            su.fax = txtFax.Text;
            su.fax2 = txtFax2.Text;
            return su;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)suFun.Insert(GetSu());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                suFun.FillDataGridView(ref dgSu);
                txtSuID.Text = result.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = (int)suFun.Update(GetSu());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                suFun.FillDataGridView(ref dgSu);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)suFun.Delete(Convert.ToInt32(txtSuID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    suFun.FillDataGridView(ref dgSu);
                    txtSuCode.Text = "";
                    txtKh1.Text = "";
                    txtKh2.Text = "";
                    txtEn1.Text = "";
                    txtEn2.Text = "";
                    rtxtAddress.Text = "";
                    txtPhone.Text = "";
                    txtPhone2.Text = "";
                    txtEmail.Text = "";
                    txtFax.Text = "";
                    txtFax2.Text = "";
                    
                }
            }
            else if (dia == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void showdata(int i)
        {
            int suid = 0;

            suid =int.Parse(dgSu.Rows[i].Cells[0].Value + "");

            DataTable dt = suFun.GetData("SELECT * FROM Supplier WHERE SuID = " + suid);

            foreach (DataRow row in dt.Rows)
            {
                txtSuID.Text = row["SuID"].ToString();
                txtSuCode.Text = row["SuCode"].ToString();
                txtKh1.Text = row["SuLNKH"].ToString();
                txtKh2.Text = row["SuFNKH"].ToString();
                txtEn1.Text = row["SuLNEN"].ToString();
                txtEn2.Text = row["SuFNEN"].ToString();
                cbBGender.SelectedItem = row["Gender"].ToString();
                rtxtAddress.Text = row["Address"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtPhone2.Text = row["Phone2"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtFax.Text = row["Fax"].ToString();
                txtFax2.Text = row["Fax2"].ToString();

            }
        }

        private void dgSu_Click(object sender, EventArgs e)
        {
            int suid = 0;
            foreach (DataGridViewRow row in dgSu.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value+"" != "")
                {
                    suid = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = suFun.GetData("SELECT * FROM Supplier WHERE SuID = " + suid);

            foreach (DataRow row in dt.Rows)
            {
                txtSuID.Text = row["SuID"].ToString();
                txtSuCode.Text = row["SuCode"].ToString();
                txtKh1.Text = row["SuLNKH"].ToString();
                txtKh2.Text = row["SuFNKH"].ToString();
                txtEn1.Text = row["SuLNEN"].ToString();
                txtEn2.Text = row["SuFNEN"].ToString();
                cbBGender.SelectedItem = row["Gender"].ToString();
                rtxtAddress.Text = row["Address"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtPhone2.Text = row["Phone2"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtFax.Text = row["Fax"].ToString();
                txtFax2.Text = row["Fax2"].ToString();
                
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtSuCode.Text = "";
            txtKh1.Text = "";
            txtKh2.Text = "";
            txtEn1.Text = "";
            txtEn2.Text = "";
            rtxtAddress.Text = "";
            txtPhone.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtFax2.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmSupplierDetail suDet = new frmSupplierDetail();
            suDet.ShowDialog();
        }

        private void frmSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnNexts_Click(object sender, EventArgs e)
        {
            btnpre.Enabled = true;
            showdata(index);
            index++;
            if (index > dgSu.Rows.Count - 1)
            {
                btnNexts.Enabled = false;
                btnClr_Click(this, null);
                frmSupplier_Load(this, null);
            }
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            btnNexts.Enabled = true;
            showdata(index);
            index--;
            if (index < 0)
            {
                index = 0;
                btnpre.Enabled = false;

            }
        }
    }
}
