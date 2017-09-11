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
    public partial class reportViewer : MetroForm
    {
        List<Class.reportInvoice> reportInvoice { get; set; }
        float discount = 0;

        public reportViewer()
        {
            InitializeComponent();
            invoiceReportDoc.SetDataSource(reportInvoice);
            invoiceReportDoc.SetParameterValue(0, 0);
        }

        public reportViewer(List<Class.reportInvoice> reportInvoice,float discount)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);
            this.reportInvoice = reportInvoice;
            this.discount = discount;
            loadReport();
        }

        private void loadReport()
        {
            invoiceReportDoc.SetDataSource(reportInvoice);
            invoiceReportDoc.SetParameterValue(0, discount);
        }

        ~reportViewer()
        {
            reportInvoice = null;
        }

        private void reportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportInvoice = null;
        }
    }
}
