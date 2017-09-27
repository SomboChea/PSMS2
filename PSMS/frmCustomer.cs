using MetroFramework;
using MetroFramework.Forms;
using PSMS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmCustomer : MetroForm
    {
        frmCustomerFunction cusFun;
        frmEmployeeFunction empFun;

        Control[] requirement;
        public frmCustomer()
        {
            InitializeComponent();
            cusFun = new frmCustomerFunction();
            empFun = new frmEmployeeFunction();
            dataGridView1.MultiSelect = false;

            Control[] tempRequire = { txtEn1, txtEn2, txtEmail, txtphone,txtPhone2, txtKh1, txtKh2 };
            requirement = tempRequire;
            txtphone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPhone2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            loadPlaceHolder();
        }

        void requirementnull(Control ctr, ref bool end)
        {
            Label redline = new Label();
            redline.Tag = "remove";
            redline.Location = new Point(ctr.Location.X - 2, ctr.Location.Y - 2);
            redline.Size = new Size(ctr.Size.Width + 4, ctr.Size.Height + 4);
            if (ctr.Text.Trim() == "")
            {
                redline.BackColor = Color.Red;
                end = true;
            }
            else
            {
                if (ctr.Tag == "email")
                {
                    try
                    {
                        MailAddress test = new MailAddress(ctr.Text);
                        redline.BackColor = Color.White;
                    }
                    catch (Exception)
                    {
                        redline.BackColor = Color.Red;
                        end = true;
                    }
                }
            }


            metroPanel1.Controls.Add(redline);
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cusFun.FillDataGridView(ref dataGridView1);
            empFun.FillComboBox(ref cbbEmp2, "EmpFNEN", "EmpID");
            btnpre.Enabled = dataGridView1.Rows.Count < 1 ? false : true;

            try
            {
                cbbEmp2.SelectedIndex = 0;
                cbBGender.SelectedIndex = 0;
                cbBStatus.SelectedIndex = 0;
            }
            catch (Exception) { }

            Opendate.Value = DateTime.Now;

            btnNew.Enabled = true;
            string tempId = Helper.GetLastId("Customers") + "";
            int id = int.Parse(tempId) + 1;
            txtCusID.Text = id + "";
            txtCusCode.Text = "CUS" + ("00000" + id).Substring(("00000" + id).Length - 5);


            index = dataGridView1.Rows.Count;
          

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
            
            metroLabel1.Text = txtphone.Text;
            foreach (Label temp in metroPanel1.Controls.OfType<Label>())
                if (temp.Tag == "remove")
                    temp.Visible = false;
            bool end = false;
            foreach (Control temp in requirement)
            {
                requirementnull(temp, ref end);
            }
            if (end)
                return;
            int result = (int)cusFun.Insert(GetCus());
            if (result > 0)
            {
                MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cusFun.FillDataGridView(ref dataGridView1);
                txtCusID.Text = result.ToString();
                frmCustomer_Load(this, null);
            }
        }
        int index;
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

            foreach (Label temp in metroPanel1.Controls.OfType<Label>())
                if (temp.Tag == "remove")
                    temp.Visible = false;
            bool end = false;
            foreach (Control temp in requirement)
            {
                requirementnull(temp, ref end);
            }
            if (end)
                return;
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
            cbBGender.SelectedIndex = 0;
            rtxtAddress.Text = "";
            txtphone.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            lblBalance.Text = "";
            cbBStatus.SelectedIndex = 0;
            cbbEmp2.SelectedIndex = 0;

            Opendate.Value = DateTime.Now;

            foreach (Label temp in metroPanel1.Controls.OfType<Label>())
                if (temp.Tag == "remove")
                    temp.Visible = false;
            frmCustomer_Load(this, null);
            index = dataGridView1.Rows.Count;
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
                    btnClr_Click(this, null);
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int cus_id =0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            foreach (Label temp in metroPanel1.Controls.OfType<Label>())
                if (temp.Tag == "remove")
                    temp.Visible = false;
            btnpre.Enabled = true;
            index++;
            if(index==dataGridView1.Rows.Count)
            {       
                btnClr_Click(this, null);
                frmCustomer_Load(this, null);
                btnne.Enabled = false;
                index = dataGridView1.Rows.Count ;
                return;

            }
            dataGridView1.Rows[index].Selected = true;

        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            foreach (Label temp in metroPanel1.Controls.OfType<Label>())
                if (temp.Tag == "remove")
                    temp.Visible = false;
            btnne.Enabled = true;
            index--;
            if (index == 0)
            {
                
                index = 0;
                btnpre.Enabled = false;       
            } 
            dataGridView1.Rows[index].Selected = true;

        }

        string ph_kh1 = "សូមបញ្ចូល ត្រកូលរបស់អ្នក...";
        string ph_kh2 = "សូមបញ្ចូល ឈ្មោះរបស់អ្នក...";
        string ph_en1 = "Enter lastname...";
        string ph_en2 = "Enter firstname...";
        string ph_em = "someone@example.com...";
        string ph_add = "Enter address...";

        private void loadPlaceHolder()
        {
            txtKh1.UseCustomForeColor = true;
            txtKh2.UseCustomForeColor = true;
            txtEn1.UseCustomForeColor = true;
            txtEn2.UseCustomForeColor = true;
            txtEmail.UseCustomForeColor = true;

            txtKh1.ForeColor = Color.Gray;
            txtKh2.ForeColor = Color.Gray;
            txtEn1.ForeColor = Color.Gray;
            txtEn2.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            rtxtAddress.ForeColor = Color.Gray;

            txtKh1.Text = ph_kh1;
            txtKh2.Text = ph_kh2;
            txtEn1.Text = ph_en1;
            txtEn2.Text = ph_en2;
            txtEmail.Text = ph_em;
            rtxtAddress.Text = ph_add;
        }

        private void txtKh1_Enter(object sender, EventArgs e)
        {
            if (txtKh1.Text == ph_kh1)
            {
                txtKh1.Text = "";
                txtKh1.UseCustomForeColor = false;
            }
        }

        private void txtKh1_Leave(object sender, EventArgs e)
        {
            if (txtKh1.Text == "")
            {
                txtKh1.UseCustomForeColor = true;
                txtKh1.ForeColor = Color.Gray;
                txtKh1.Text = ph_kh1;
            }
        }

        private void txtKh2_Enter(object sender, EventArgs e)
        {
            if (txtKh2.Text == ph_kh2)
            {
                txtKh2.Text = "";
                txtKh2.UseCustomForeColor = false;
            }
        }

        private void txtKh2_Leave(object sender, EventArgs e)
        {
            if (txtKh2.Text == "")
            {
                txtKh2.UseCustomForeColor = true;
                txtKh2.ForeColor = Color.Gray;
                txtKh2.Text = ph_kh2;
            }
        }

        private void txtEn1_Enter(object sender, EventArgs e)
        {
            if (txtEn1.Text == ph_en1)
            {
                txtEn1.Text = "";
                txtEn1.UseCustomForeColor = false;
            }
        }

        private void txtEn1_Leave(object sender, EventArgs e)
        {
            if (txtEn1.Text == "")
            {
                txtEn1.UseCustomForeColor = true;
                txtEn1.ForeColor = Color.Gray;
                txtEn1.Text = ph_en1;
            }
        }

        private void txtEn2_Enter(object sender, EventArgs e)
        {
            if (txtEn2.Text == ph_en2)
            {
                txtEn2.Text = "";
                txtEn2.UseCustomForeColor = false;
            }
        }

        private void txtEn2_Leave(object sender, EventArgs e)
        {
            if (txtEn2.Text == "")
            {
                txtEn2.UseCustomForeColor = true;
                txtEn2.ForeColor = Color.Gray;
                txtEn2.Text = ph_en2;
            }
        }

        private void rtxtAddress_Enter(object sender, EventArgs e)
        {
            if (rtxtAddress.Text == ph_add)
            {
                rtxtAddress.Text = "";
                rtxtAddress.ForeColor = Color.Black;
            }
        }

        private void rtxtAddress_Leave(object sender, EventArgs e)
        {
            if (rtxtAddress.Text == "")
            {
                rtxtAddress.ForeColor = Color.Gray;
                rtxtAddress.Text = ph_add;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == ph_em)
            {
                txtEmail.Text = "";
                txtEmail.UseCustomForeColor = false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.UseCustomForeColor = true;
                txtEmail.ForeColor = Color.Gray;
                txtEmail.Text = ph_em;
            }
        }
    }
}
