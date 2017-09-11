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
    public partial class frmInvoiceDetail : MetroForm
    {
        frmInvoiceFunction Invfun;
        public frmInvoiceDetail()
        {
            
            InitializeComponent();
            Invfun = new frmInvoiceFunction();
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
            ////this.Hide();
            ////frmInv = new frmInvoice2();
            ////frmInv.Show();
        }
    }
}
