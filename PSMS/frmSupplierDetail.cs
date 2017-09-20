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
    public partial class frmSupplierDetail : MetroForm
    {
        frmSupplierFunction suFun;
        public frmSupplierDetail()
        {
            InitializeComponent();
            suFun = new frmSupplierFunction();

            btnClr.Visible = false;

            itemPanel1.Items.Remove(itemContainer1);
            itemPanel1.Items.Remove(itemContainer4);
        }

        private void frmSupplierDetail_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'pSMS2DataSet2.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.pSMS2DataSet2.Supplier);
            //suFun.FillDataGridView(ref dgData);
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
            //int result = (int)suFun.Insert(GetSu());
            //if (result > 0)
            //{
            //    MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    suFun.FillDataGridView(ref dgData);
            //    txtSuID.Text = result.ToString();
            //}
            supplierBindingNavigator.AddNewItem.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int result = (int)suFun.Update(GetSu());
            //if (result > 0)
            //{
            //    MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    suFun.FillDataGridView(ref dgData);

            //}
            supplierBindingNavigatorSaveItem_Click(this, null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            supplierBindingNavigator.DeleteItem.PerformClick();
            //int result = (int)suFun.Delete(Convert.ToInt32(txtSuID.Text));
            //DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dia == DialogResult.Yes)
            //{
            //    if (result > 0)
            //    {
            //        MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        suFun.FillDataGridView(ref dgData);
            //        txtSuCode.Text = "";
            //        txtKh1.Text = "";
            //        txtKh2.Text = "";
            //        txtEn1.Text = "";
            //        txtEn2.Text = "";
            //        rtxtAddress.Text = "";
            //        txtPhone.Text = "";
            //        txtPhone2.Text = "";
            //        txtEmail.Text = "";
            //        txtFax.Text = "";
            //        txtFax2.Text = "";
            //        lblBalance.Text = "";
            //    }
            //}
            //else if (dia == DialogResult.No)
            //{
            //    MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
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
            lblBalance.Text = "";
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pSMS2DataSet2);

        }

        private void frmSupplierDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diag = MetroMessageBox.Show(this, "Do you Want to Save Change ? ", "MetroMessage", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes)
            {
                try
                {
                    btnSave_Click(this, null);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message);
                    e.Cancel = true;
                }
            }
        }

        private void txtfilter_ButtonClick(object sender, EventArgs e)
        {
            string sql = "Select * from Supplier ";
            sql += txtfilter.Text.Trim() == "" ? "" : "Where " + comboBox1.Text + " like '%" + txtfilter.Text.Trim() + "%'";
            supplierTableAdapter.Adapter.SelectCommand.CommandText = sql;
            supplierTableAdapter.Fill(this.pSMS2DataSet2.Supplier);
        
        }
    }
}
