using MetroFramework;
using MetroFramework.Forms;
using PSMS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
         
            
            btnnext.Enabled = false;


            
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            empFun.FillDataGridView(ref dgData);
            posFun.FillComboBox(ref cbBPos, "PosName", "PosID");
            cbBPos.SelectedIndex = 0;
            cbBGender.SelectedIndex = 0;
            Join_date.Value = DateTime.Now;
            index = dgData.Rows.Count-2;
            btnpre.Enabled = dgData.Rows.Count < 2 ? false : true;
           

            object empid = Connection.ExecuteScalar("Select ident_current('Employee')");
            int Eid = empid == null ? 1 : int.Parse(empid + "") + 1;
            txtEmpID.Text = Eid + "";
            txtEmpCode.Text = "EMP" + ("00000" + Eid).Substring(("00000" + Eid).Length - 5);
            //txtKh1.Text = "សំ";
            //txtKh2.Text = "បូរ";
            //txtEn1.Text = "sun";
            //txtEn2.Text = "l";
            //txtIDCard.Text = "111111";
            //rtxtAddress.Text = "PP";
            //txtPhone.Text = "0123456789";
            //txtEmail.Text = "0987654321";
            //cbBGender.SelectedIndex = 0;
            //cbBPos.SelectedIndex = 0;
            //txtSalary.Text = "999999";
            
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

            MemoryStream mem=new MemoryStream();
            if (extensionImg == "jpg")
                pictureBox1.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
            else
                pictureBox1.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Png);

            emp.img = mem.ToArray();
            return emp;
        }

        private void dgData_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            int emp_id = 0;
            foreach (DataGridViewRow row in dgData.SelectedRows)
            {
                if (row.Cells != null && row.Cells[0].Value+"" != "")
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


                // pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])row["Image"]));
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEmpID.Text) == int.Parse(Connection.ExecuteScalar("Select Ident_current('Employee')") + "") + 1)
            {
                txtSalary.Text = txtSalary.Text.Trim() == "" ? "0" : txtSalary.Text;
                int result = (int)empFun.Insert(GetEmp());
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empFun.FillDataGridView(ref dgData);
                    txtEmpID.Text = result.ToString();

                }
                btnClr_Click(this, null);
            }
            else
            {
                if (MetroMessageBox.Show(this, "ID is exist Do you want to Update", "MetroMessage", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btnSave_Click(this, null);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtSalary.Text = txtSalary.Text.Trim() == "" ? "0" : txtSalary.Text;
            int result = (int)empFun.Update(GetEmp());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empFun.FillDataGridView(ref dgData);

            }
            btnClr_Click(this, null);
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
                    Join_date.Value=DateTime.Now;
                    frmEmployees_Load(this, null);

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
            pictureBox1.Image = Properties.Resources.employee;

            object empid = Connection.ExecuteScalar("Select ident_current('Employee') from Employee");
            int Eid = empid == null ? 1 : int.Parse(empid + "") + 1;
            txtEmpID.Text = Eid + "";
            txtEmpCode.Text = "EMP" + ("00000" + Eid).Substring(("00000" + Eid).Length - 5);
            
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
        string extensionImg="png";
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Open Image ... ";
            opf.Filter = "Image File (*.jpg) | *.jpg| PNG file (*.png) | *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                extensionImg = opf.FileName.Substring(opf.FileName.Length - 3);
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }


        int index;
        private void btnnext_Click(object sender, EventArgs e)
        {
            btnpre.Enabled = true;
            int emp_id=int.Parse(dgData.Rows[index].Cells[0].Value+"");
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
                try
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])row["Image"]));
                }
                catch(Exception)
                {
                    pictureBox1.Image = Properties.Resources.employee;
                }
            }
            index++;
            if (index >= dgData.Rows.Count-1)
            {
                btnClr_Click(this, null);
                frmEmployees_Load(this, null);
                btnnext.Enabled = false;
            }
            
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            btnnext.Enabled = true;
            int emp_id = int.Parse(dgData.Rows[index].Cells[0].Value + "");
            DataTable dt = empFun.GetData("SELECT * FROM Employee WHERE EmpID = " + emp_id);
            metroLabel1.Text = index + "";
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
                try
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])row["Image"]));
                }
                catch (Exception)
                {
                    pictureBox1.Image = Properties.Resources.employee;
                }
            }
            index--;
            if (index < 0)
            {
                index = 0;
                btnpre.Enabled = false;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
