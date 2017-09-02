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
    public partial class frmPayment : MetroForm
    {
        public static string passtxt;
        public frmPayment()
        {
            InitializeComponent();
        }
        
        private void btnPay_Click(object sender, EventArgs e)
        {
            passtxt = txtAmount.Text;
            Close();
        }

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
