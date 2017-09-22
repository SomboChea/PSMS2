using MetroFramework.Forms;
using PSMS.Class;
using System;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmInvoiceDetail : MetroForm
    {
        frmInvoiceFunction Invfun;
        public frmInvoiceDetail()
        {
            
            InitializeComponent();
            Invfun = new frmInvoiceFunction();
            btnNew.Text = "Pay";
        }

        private void frmInvoiceDetail_Load(object sender, EventArgs e)
        {
            Invfun.FillDataGridView(ref dgInv);
            btnDel.Visible = false;
            btnSave.Visible = false;
            btnNew.Visible = true;
        }
        private frmIn GetInv() 
        {
            frmIn Inv = new frmIn();
            Inv.inid = Convert.ToInt32(txtInvID.Text);
            Inv.incode = txtInvCode.Text;
            Inv.date = dateTimePicker1.Text;
            Inv.totalprice = float.Parse( txtTotal.Text);
            Inv.payment = float.Parse(txtPayment.Text);
            Inv.paymentverify = int.Parse(txtPaymentVerify.Text);
            Inv.balance = float.Parse(txtBalance.Text);
            return Inv;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ////this.Hide();
            ////frmInv = new frmInvoice2();
            ////frmInv.Show();
            //


            // Action of Button Pay

            frmPayment frmpay = new frmPayment();
            frmpay.ShowDialog();


            DataGridViewCellCollection selectrow_cell = dgInv.SelectedRows[0].Cells;
            double newpay;

            try
            {
                newpay = double.Parse(frmpay.pay);
            }
            catch (Exception)
            {
                newpay = 0;
            }

            double oldpay = double.Parse(dgInv.SelectedRows[0].Cells[5].Value + "");
            double balance = double.Parse(selectrow_cell[7].Value + "");
            if (newpay >= balance)
            {
                Connection.ExecuteScalar("Update Invoice set PaymentVerify=1, Balance=0,Payment=TotalPrice where InvoiceCode='" + selectrow_cell[0].Value + "'");
                if (newpay > balance)
                {
                    MessageBox.Show("U must Change Back : " + Environment.NewLine + (newpay - balance) + " $");
                }
                else
                {
                    double newpayment, newbalance;
                    newbalance = balance - newpay;
                    newpayment = newpay + oldpay;
                    Connection.ExecuteScalar("Update Invoice set Balance='" + newbalance + "',Payment='" + newpayment + "' where InvoiceCode='" + selectrow_cell[0].Value + "'");
                    frmInvoiceDetail_Load(this, null);
                }
            }
            else
            {
                double newpayment, newbalance;
                newbalance = balance - newpay;
                newpayment = newpay + oldpay;
                Connection.ExecuteScalar("Update Invoice set Balance='" + newbalance + "',Payment='" + newpayment + "' where InvoiceCode='" + selectrow_cell[0].Value + "'");

                frmInvoiceDetail_Load(this, null);
            }
        }

        private void dgInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgInv_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = dgInv.SelectedRows.Count > 0 ? true : false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string sql = "Select * from viewInvoice2 ";
                sql += txtfilter.Text.Trim() == "" ? "" : "Where " + comboBox1.Text + " like N'%" + txtfilter.Text.Trim() + "%' COLLATE Latin1_General_100_BIN2";
                dgInv.DataSource = Invfun.GetData(sql);
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
