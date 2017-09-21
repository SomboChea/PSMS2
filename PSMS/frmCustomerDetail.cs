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
    public partial class frmCustomerDetail : MetroForm
    {
        frmCustomerFunction cusFun;
        frmEmployeeFunction empFun;
        public frmCustomerDetail()
        {
            InitializeComponent();
            cusFun = new frmCustomerFunction();
            empFun = new frmEmployeeFunction();
           
            btnClr.Visible = false;
            itemPanel1.Items.Remove(itemContainer1);
            itemPanel1.Items.Remove(itemContainer4);
        }

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            //customersTableAdapter.Adapter = new SqlDataAdapter("Select * from Customers where balance=0", customersTableAdapter.Connection);
            // TODO: This line of code loads data into the 'pSMS2DataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.pSMS2DataSet2.Customers);
            comboBox1.SelectedIndex = 0;
            //cusFun.FillDataGridView(ref dgData);
            //empFun.FillComboBox(ref cbBEmp, "EmpName", "EmpID");
            //PSMS2DataSet2TableAdapters.CustomersTableAdapter adapt = new PSMS2DataSet2TableAdapters.CustomersTableAdapter();
            //dapt.Adapter.SelectCommand = new SqlCommand("Select * from Customers where Balance=0;", customersTableAdapter.Connection);
        }
        private frmCus GetCus()
        {
            try
            {
                frmCus cus = new frmCus();
                cus.cus_id = Convert.ToInt32(txtCusID.Text);
                cus.cus_code = txtCusCode.Text;
                cus.cus_lnkh = txtKh1.Text;
                cus.cus_fnkh = txtKh2.Text;
                cus.cus_lnen = txtEn1.Text;
                cus.cus_fnen = txtEn2.Text;
                cus.gender = cbBGender.SelectedItem.ToString();
                cus.address = rtxtAddress.Text;
                cus.phone = txtphone.Text;
                cus.phone2 = txtPhone2.Text;
                cus.email = txtEmail.Text;
                cus.status = cbBStatus.SelectedItem.ToString();

                cus.acc_opendate = Opendate.Text;
                return cus;
            }
            catch(Exception)
            {
                return null;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            //int result = (int)cusFun.Insert(GetCus());
            //if (result > 0)
            //{
            //    MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cusFun.FillDataGridView(ref dgData);
            //    txtCusID.Text = result.ToString();
            //}
            customersBindingNavigator.AddNewItem.PerformClick();
        }

        private void dgData_Click(object sender, EventArgs e)
        {
            int cus_id = 0;
            foreach (DataGridViewRow row in dgData.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value != null)
                {
                    cus_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = cusFun.GetData("SELECT * FROM Customers WHERE CusID = " + cus_id);

            foreach (DataRow row in dt.Rows)
            {
                txtCusID.Text = row["CusID"].ToString();
                txtCusCode.Text = row["CusCode"].ToString();
                txtKh1.Text = row["CusLNKH"].ToString();
                txtKh2.Text = row["CusFNKH"].ToString();
                txtEn1.Text = row["CusLNEN"].ToString();
                txtEn2.Text = row["CusFNEN"].ToString();
                cbBGender.SelectedItem = row["Gender"].ToString();
                rtxtAddress.Text = row["Address"].ToString();
                txtphone.Text = row["Phone"].ToString();
                txtPhone2.Text = row["Phone2"].ToString();
                txtEmail.Text = row["Email"].ToString();
                lblBalance.Text = row["Balance"].ToString();
                cbBStatus.SelectedItem = row["Status"].ToString();
                //cbbEmp2.SelectedValue = Convert.ToInt32(row["Emp_ID"].ToString());
                Opendate.Text = row["Acc_Opendate"].ToString();
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int result = (int)cusFun.Update(GetCus());
            //if (result > 0)
            //{
            //    MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cusFun.FillDataGridView(ref dgData);

            //}
            customersBindingNavigatorSaveItem_Click(this, null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //int result = (int)cusFun.Delete(Convert.ToInt32(txtCusID.Text));
            //DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dia == DialogResult.Yes)
            //{
            //    if (result > 0)
            //    {
            //        MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        cusFun.FillDataGridView(ref dgData);
            //        txtCusCode.Text = "";
            //        txtKh1.Text = "";
            //        txtKh2.Text = "";
            //        txtEn1.Text = "";
            //        txtEn2.Text = "";
            //        cbBGender.SelectedItem = "";
            //        rtxtAddress.Text = "";
            //        txtphone.Text = "";
            //        txtPhone2.Text = "";
            //        txtEmail.Text = "";
            //        lblBalance.Text = "";
            //        cbBStatus.SelectedItem = "";
            //        txtEmpID.Text = "";
            //        Opendate.Text = "";
            //    }
            //}
            //else if (dia == DialogResult.No)
            //{
            //    MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            customersBindingNavigator.DeleteItem.PerformClick();
        }

        private void dgData_Click_1(object sender, EventArgs e)
        {
            int cus_id = 0;
            foreach (DataGridViewRow row in dgData.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value != null)
                {
                    cus_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = cusFun.GetData("SELECT * FROM Customers WHERE CusID = " + cus_id);

            foreach (DataRow row in dt.Rows)
            {
                txtCusID.Text = row["CusID"].ToString();
                txtCusCode.Text = row["CusCode"].ToString();
                txtKh1.Text = row["CusLNKH"].ToString();
                txtKh2.Text = row["CusFNKH"].ToString();
                txtEn1.Text = row["CusLNEN"].ToString();
                txtEn2.Text = row["CusFNEN"].ToString();
                cbBGender.SelectedItem = row["Gender"].ToString();
                rtxtAddress.Text = row["Address"].ToString();
                txtphone.Text = row["Phone"].ToString();
                txtPhone2.Text = row["Phone2"].ToString();
                txtEmail.Text = row["Email"].ToString();
                lblBalance.Text = row["Balance"].ToString();
                cbBStatus.SelectedItem = row["Status"].ToString();
                txtEmpID.Text = row["Emp_ID"].ToString();
                Opendate.Text = row["Acc_Opendate"].ToString();
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtCusCode.Text = "";
            txtKh1.Text = "";
            txtKh2.Text = "";
            txtEn1.Text = "";
            txtEn2.Text = "";
            cbBGender.SelectedItem = "";
            rtxtAddress.Text = "";
            txtphone.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            lblBalance.Text = "";
            cbBStatus.SelectedItem = "";
            txtEmpID.Text = "";
            Opendate.Text = "";
        }

        private void frmCustomerDetail_FormClosing(object sender, FormClosingEventArgs e)
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

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pSMS2DataSet2);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtfilter_Click(object sender, EventArgs e)
        {

        }

        private void txtfilter_ButtonClick(object sender, EventArgs e)
        {
            string sql = "Select * from Customers ";
            sql += txtfilter.Text.Trim() == "" ? "" : "Where " + comboBox1.Text + " like N'%" + txtfilter.Text.Trim() + "%' COLLATE Latin1_General_100_BIN2";
            customersTableAdapter.Adapter.SelectCommand.CommandText = sql;
            customersTableAdapter.Fill(this.pSMS2DataSet2.Customers);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtfilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtfilter_ButtonClick(this, null);
            }
        }
    }
}
