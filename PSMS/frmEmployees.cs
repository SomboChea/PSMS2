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
    public partial class frmEmployees : MetroForm
    {
        frmEmployeeFunction empFun;
        frmPosFunction posFun;
        public frmEmployees()
        {
            InitializeComponent();
            empFun = new frmEmployeeFunction();
            posFun = new frmPosFunction();

            Connection.Open("localhost", "PSMS2");
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            empFun.FillDataGridView(ref dgData);
            posFun.FillComboBox(ref cbBPos, "PosName", "PosID");
            cbBPos.SelectedIndex = 0;
            cbBGender.SelectedIndex = 0;
            Join_date.Value = DateTime.Now;



            
            txtKh1.Text = "សំ";
            txtKh2.Text = "បូរ";
            txtEn1.Text = "sun";
            txtEn2.Text = "l";
            txtIDCard.Text = "111111";
            rtxtAddress.Text = "PP";
            txtPhone.Text = "0123456789";
            txtEmail.Text = "0987654321";
            cbBGender.SelectedIndex = 0;
            cbBPos.SelectedIndex = 0;
            txtSalary.Text = "999999";
            
        }
        private frmEmp GetEmp()
        {
            frmEmp emp = new frmEmp();
            emp.emp_id = int.Parse(txtEmpID.Text);
            emp.empcode = txtEmpCode.Text;
            emp.emp_lnkh = txtKh1.Text;
            emp.emp_fnkh = txtKh2.Text;
            emp.emp_lnen = txtEn1.Text;
            emp.emp_fnen = txtEn2.Text;
            emp.gender = cbBGender.SelectedItem.ToString();
            emp.idcard = txtIDCard.Text;
            emp.address = rtxtAddress.Text;
            emp.phone = txtPhone.Text;
            emp.email = txtEmail.Text;
            emp.pos_id = Convert.ToInt32(cbBPos.SelectedValue);
            emp.salary = Convert.ToInt32(txtSalary.Text);
            emp.join_date = Join_date.Text;
            return emp;
        }

        private void dgData_Click(object sender, EventArgs e)
        {
            int emp_id = 0;
            foreach (DataGridViewRow row in dgData.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value != null)
                {
                    emp_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }

            DataTable dt = empFun.GetData("SELECT * FROM Employee WHERE EmpID = " + emp_id);

            foreach (DataRow row in dt.Rows)
            {
                txtEmpID.Text = row["EmpID"].ToString();
                txtEmpCode.Text = row["EmpCode"].ToString();
                txtKh1.Text = row["EmpLNKH"].ToString();
                txtKh2.Text = row["EmpFNKH"].ToString();
                txtEn1.Text = row["EmpLNEN"].ToString();
                txtEn2.Text = row["EmpFNEN"].ToString();
                cbBGender.SelectedItem = row["Gender"].ToString();
                txtIDCard.Text = row["IDCard"].ToString();
                rtxtAddress.Text = row["Address"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtEmail.Text = row["email"].ToString();
                cbBPos.SelectedValue = Convert.ToInt32(row["PosID"].ToString());
                txtSalary.Text = row["Salary"].ToString();
                Join_date.Text = row["JoinDate"].ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int result = (int)empFun.Insert(GetEmp());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empFun.FillDataGridView(ref dgData);
                txtEmpID.Text = result.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = (int)empFun.Update(GetEmp());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empFun.FillDataGridView(ref dgData);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = (int)empFun.Delete(Convert.ToInt32(txtEmpID.Text));
            DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empFun.FillDataGridView(ref dgData);
                    txtEmpCode.Text = "";
                    txtKh1.Text = "";
                    txtKh2.Text = "";
                    txtEn1.Text = "";
                    txtEn2.Text = "";
                    txtIDCard.Text = "";
                    rtxtAddress.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtSalary.Text = "";
                    Join_date.Text = "";

                }
            }
            else if (dia == DialogResult.No)
            {
                MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtEmpCode.Text = "";
            txtKh1.Text = "";
            txtKh2.Text = "";
            txtEn1.Text = "";
            txtEn2.Text = "";
            txtIDCard.Text = "";
            rtxtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbBGender.SelectedIndex = 0;
            cbBPos.SelectedIndex = 0;
            txtSalary.Text = "";
            Join_date.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmEmployeeDetail empDet = new frmEmployeeDetail();
            empDet.ShowDialog();
        }

        private void frmEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain frmM = new frmMain();
            //frmM.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmPostion pos = new frmPostion();
            pos.ShowDialog();
            btnClr_Click(this,null);
            
          
            frmEmployees_Load(this,null);
        }
    }
}
