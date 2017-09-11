using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSMS
{
    public partial class reportViewer : MetroForm
    {
        public reportViewer()
        {
            InitializeComponent();
        }
        
        public reportViewer(List<Class.reportInvoice> reportInvoice,float discount)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            invoiceReportDoc.SetDataSource(reportInvoice);
            invoiceReportDoc.SetParameterValue(0, discount);
        }

        public reportViewer(List<Class.reportCustomer> reportCustomer)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            invoiceReportDoc.SetDataSource(reportCustomer);
        }

        private void loadReport()
        {
            //invoiceReportDoc.SetDataSource(reportCustomer);
        }

        private void reportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
