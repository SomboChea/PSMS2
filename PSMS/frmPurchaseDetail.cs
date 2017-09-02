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
    public partial class frmPurchaseDetail : MetroForm
    {
        frmPurchaseFunction purFun;
        public frmPurchaseDetail()
        {
            InitializeComponent();
            purFun = new frmPurchaseFunction();
        }

        private void frmPurchaseDetail_Load(object sender, EventArgs e)
        {
            purFun.FillDataGridView(ref dgData);
        }
    }
}
