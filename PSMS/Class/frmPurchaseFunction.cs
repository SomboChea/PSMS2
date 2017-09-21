using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS
{
    class frmPurchaseFunction : Function
    {
          public frmPurchaseFunction() 
        {
            
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Purchase");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView) 
        {
            dataGridView.DataSource = base.GetData("select * from viewPurchase2 WHERE Payment < Total");
        }
    }
}
