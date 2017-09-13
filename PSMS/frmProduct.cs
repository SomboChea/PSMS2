using MetroFramework;
using MetroFramework.Forms;
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
    public partial class frmProduct : MetroForm
    {
        frmProductFunction proFun;
        frmModelFunction moFun;
        frmTypeFunction tFun;
        frmPTypeCodeFunction ptFun;

        public bool updated = false;
        public bool closed = false;
        public frmProduct()
        {
            this.ControlBox = false;
            InitializeComponent();
            proFun = new frmProductFunction();
            moFun = new frmModelFunction();
            ptFun = new frmPTypeCodeFunction();
            tFun = new frmTypeFunction();
        }

        public int phonetype = 0,model=0,type=0;

        private void frmProduct_Load(object sender, EventArgs e)
        {
           
            proFun.FillDataGridView(ref dgProduct);
            moFun.FillComboBox(ref cbBMo, "Description", "MID");
            ptFun.FillComboBox(ref cbBPT, "Description", "PTypeID");
            tFun.FillComboBox(ref cbbType, "Description", "TID");

            cbBMo.SelectedValue = 2;
            if (closed)
            {
                cbBMo.SelectedValue = model;
                cbBPT.SelectedValue = phonetype;
                cbbType.SelectedValue = type;
            }
        }
        private frmPro GetPro()
        {
            frmPro pro = new frmPro();
            try
            {
                pro.pro_id = Convert.ToInt32(txtPID.Text);
                pro.pro_code = txtPCode.Text;
                pro.pro_name = txtPName.Text;
                pro.pro_size = txtPSize.Text;
                pro.color = txtColor.Text;
                pro.quantity = Convert.ToInt32(txtQuantity.Text);
                pro.model = Convert.ToInt32(cbBMo.SelectedValue);
                pro.ph_type = Convert.ToInt32(cbBPT.SelectedValue);
                pro.type = Convert.ToInt32(cbbType.SelectedValue);
                pro.saleprice = (float.Parse)(txtSalePrice.Text);
                pro.unitprice = float.Parse(txtUnitprice.Text);
                MemoryStream mem=new MemoryStream();
                pro_img.Image.Save(mem,System.Drawing.Imaging.ImageFormat.Jpeg);
                pro.img = mem.ToArray();
                return pro;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void dgProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int pro_id = 1;
                foreach (DataGridViewRow row in dgProduct.SelectedRows)
                {
                    if (row.Cells != null && row.Cells[0].Value != null)
                    {
                        //pro_id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    }
                }

                DataTable dt = proFun.GetData("SELECT * FROM Product WHERE PID = " + pro_id);

                foreach (DataRow row in dt.Rows)
                {
                    txtPID.Text = row["PID"].ToString();
                    txtPCode.Text = row["PCode"].ToString();
                    txtPName.Text = row["PName"].ToString();
                    txtPSize.Text = row["PSize"].ToString();
                    txtColor.Text = row["Color"].ToString();
                    txtQuantity.Text = row["Quantity"].ToString();
                    cbBMo.SelectedValue = Convert.ToInt32(row["MID"].ToString());
                    cbBPT.SelectedValue = Convert.ToInt32(row["PTypeID"].ToString());
                    cbbType.SelectedValue = Convert.ToInt32(row["TID"].ToString());
                    txtSalePrice.Text = row["Saleprice"].ToString();
                    txtUnitprice.Text = row["Unitprice"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)proFun.Insert(GetPro());
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "New Record Insert", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    proFun.FillDataGridView(ref dgProduct);
                    txtPID.Text = result.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)proFun.Update(GetPro());
                if (result > 0)
                {
                    MetroMessageBox.Show(this, "Record Update", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    proFun.FillDataGridView(ref dgProduct);
                    updated = true;
                }
                if (closed)
                {
                    this.Dispose();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int result = (int)proFun.Delete(Convert.ToInt32(txtPID.Text));
                DialogResult dia = MetroMessageBox.Show(this, "Are you sure you want permanently delete this record?", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    if (result > 0)
                    {
                        MetroMessageBox.Show(this, "Record Deleted", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        proFun.FillDataGridView(ref dgProduct);
                        if (closed)
                            this.Dispose();
                    }
                }
                else if (dia == DialogResult.No)
                {
                    MetroMessageBox.Show(this, "Deleted record has been cancel", "MetroMessagebox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtPCode.Text = "";
            txtPName.Text = "";
            txtPSize.Text = "";
            txtColor.Text = "";
            txtQuantity.Text = "";
           
            txtSalePrice.Text = "";
            txtUnitprice.Text = "";
        }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain frmM = new frmMain();
            //frmM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBrand brand = new frmBrand();
            brand.ShowDialog();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog pd = new OpenFileDialog();
            pd.Filter = "Image JPG (*.jpg)|*.jpg";
            if (pd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(pd.FileName);

                pro_img.Image = Class.Helper.Base64ToImage(Class.Helper.ImageToBase64(img));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
