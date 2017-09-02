﻿using MetroFramework;
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
    public partial class frmCustomer : MetroForm
    {
        frmCustomerFunction cusFun;
        frmEmployeeFunction empFun;
        public frmCustomer()
        {
            InitializeComponent();
            cusFun = new frmCustomerFunction();
            empFun = new frmEmployeeFunction();

        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cusFun.FillDataGridView(ref dataGridView1);
            empFun.FillComboBox(ref cbbEmp2, "EmpFNEN", "EmpID");
        }
        private frmCus GetCus() 
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
            cus.emp_id = Convert.ToInt32(cbbEmp2.SelectedValue);
            cus.acc_opendate = Opendate.Text;
            return cus;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)cusFun.Insert(GetCus());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cusFun.FillDataGridView(ref dataGridView1);
                txtCusID.Text = result.ToString();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int cus_id = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
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
                cbbEmp2.SelectedValue = Convert.ToInt32(row["Emp_ID"].ToString());
                Opendate.Text = row["Acc_Opendate"].ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = (int)cusFun.Update(GetCus());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cusFun.FillDataGridView(ref dataGridView1);

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
            
            Opendate.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)cusFun.Delete(Convert.ToInt32(txtCusID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cusFun.FillDataGridView(ref dataGridView1);
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
                    
                    Opendate.Text = "";
                }
            }
            else if (dia == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmCustomerDetail cusDet = new frmCustomerDetail();
            cusDet.ShowDialog();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain frmM = new frmMain();
            //frmM.Show();
        }

    

    }
}