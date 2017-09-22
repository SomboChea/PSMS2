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
    public partial class frmPurchaseDetail : MetroForm
    {
        frmPurchaseFunction purFun;
        public frmPurchaseDetail()
        {
            InitializeComponent();
            btnNew.Visible = false;
            btnDel.Visible = false;
            btnSave.Visible = false;
            itemPanel1.Visible = false;

            purFun = new frmPurchaseFunction();
        }

        private void frmPurchaseDetail_Load(object sender, EventArgs e)
        {
            purFun.FillDataGridView(ref dgData);
            comboBox1.SelectedIndex = 0;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPayment frmpay = new frmPayment();
                frmpay.ShowDialog();

                DataGridViewCellCollection selectrow_cell = dgData.SelectedRows[0].Cells;
                double newpay;

                try
                {
                    newpay = double.Parse(frmpay.pay);
                }
                catch (Exception)
                {
                    newpay = 0;
                }

                double oldpay = double.Parse(dgData.SelectedRows[0].Cells[3].Value + "");
                double balance = double.Parse(selectrow_cell[3].Value + "");
                if (newpay >= balance)
                {
                    Connection.ExecuteScalar("Update Purchase set Balance=0,Payment=Total where PurCode='" + selectrow_cell[0].Value + "'");
                    if (newpay > balance)
                    {
                        MessageBox.Show("U must Change Back : " + Environment.NewLine + (newpay - balance) + " $");
                    }
                    else
                    {
                        double newpayment, newbalance;
                        newbalance = balance - newpay;
                        newpayment = newpay + oldpay;
                        Connection.ExecuteScalar("Update Purchase set Balance='" + newbalance + "',Payment='" + newpayment + "' where PurCode='" + selectrow_cell[0].Value + "'");

                        frmPurchaseDetail_Load(this, null);
                    }
                }
                else
                {
                    double stackPay = balance - newpay;
                    Connection.ExecuteScalar("Update Purchase set Balance="+stackPay+",Payment=" + newpay + " where PurCode='" + selectrow_cell[0].Value + "'");
                    frmPurchaseDetail_Load(this, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * from viewPurchase2 ";
                sql += txtfilter.Text.Trim() == "" ? "" : "Where " + comboBox1.Text + " like N'%" + txtfilter.Text.Trim() + "%' COLLATE Latin1_General_100_BIN2";
                dgData.DataSource = purFun.GetData(sql);
            }
            catch(Exception) { }
            
        }

        private void txtfilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                textBox1_TextChanged(this, null);
         
        }
    }
}
