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
        public reportViewer()
        {
            InitializeComponent();

            invoiceReportDoc.SetDataSource(reportInvoice);
            invoiceReportDoc.SetParameterValue(0, 10);
        }
    }
}
