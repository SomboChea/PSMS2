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
<<<<<<< HEAD
            ////this.Hide();
            ////frmInv = new frmInvoice2();
            ////frmInv.Show();
            frmPayment frmpay = new frmPayment();
            frmpay.ShowDialog();
           

            DataGridViewCellCollection selectrow_cell= dgInv.SelectedRows[0].Cells;
            double newpay;
            try
            {
                newpay =  double.Parse(frmpay.pay);
            }
            catch (Exception) {
                newpay = 0;
            }
            double oldpay = double.Parse(dgInv.SelectedRows[0].Cells[5].Value+"");
            double balance = double.Parse(selectrow_cell[7].Value + "");
            if(newpay>=balance)
            {
                Connection.ExecuteScalar("Update Invoice set PaymentVerify=1, Balance=0,Payment=TotalPrice where InvoiceCode='" + selectrow_cell[0].Value + "'");
                if(newpay>balance){
                   MessageBox.Show("U must Change Back : "+Environment.NewLine+(newpay-balance)+" $");
=======
            try
            {
                ////this.Hide();
                ////frmInv = new frmInvoice2();
                ////frmInv.Show();
                frmPayment frmpay = new frmPayment();
                frmpay.ShowDialog();


                DataGridViewCellCollection selectrow_cell = dgInv.SelectedRows[0].Cells;
                double newpay = frmpay.pay.Trim() == "" ? 0 : double.Parse(frmpay.pay);
                double oldpay = double.Parse(dgInv.SelectedRows[0].Cells[5].Value + "");
                double balance = double.Parse(selectrow_cell[7].Value + "");
                if (newpay >= balance)
                {
                    Connection.ExecuteScalar("Update Invoice set PaymentVerify=1, Balance=0,Payment=TotalPrice where InvoiceCode='" + selectrow_cell[0] + "'");
                    if (newpay > balance)
                    {
                        MessageBox.Show("U must Change Back : " + Environment.NewLine + (newpay - balance) + " $");
                    }
                }
                else
                {
                    double newpayment, newbalance;
                    newbalance = balance - newpay;
                    newpayment = newpay + oldpay;
                    Connection.ExecuteScalar("Update Invoice set Balance='" + newbalance + "',Payment='" + newpayment + "' where InvoiceCode='" + selectrow_cell[0] + "'");
>>>>>>> 494a14cd4b87bd6d1a70a71de9af5fce0dae2da8
                }

                frmInvoiceDetail_Load(this, null);
            }
<<<<<<< HEAD
            else{
                double newpayment, newbalance;
                newbalance = balance-newpay;
                newpayment = newpay + oldpay;
                Connection.ExecuteScalar("Update Invoice set Balance='"+newbalance+"',Payment='"+newpayment+"' where InvoiceCode='" + selectrow_cell[0].Value + "'");
=======
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
>>>>>>> 494a14cd4b87bd6d1a70a71de9af5fce0dae2da8
            }
        }

        private void dgInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgInv_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = dgInv.SelectedRows.Count > 0 ? true : false;
        }
    }
}
