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

            crystalReportViewer1.ReportSource = invoiceReportDoc;
        }

        public reportViewer(List<Class.reportEmployee> reportEmployee)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            employeeReportDoc.SetDataSource(reportEmployee);
            crystalReportViewer1.ReportSource = employeeReportDoc;
        }

        public reportViewer(List<Class.reportCustomer> reportCustomer)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            customerReportDoc.SetDataSource(reportCustomer);
            crystalReportViewer1.ReportSource = customerReportDoc;
        }

        public reportViewer(List<Class.reportProduct> reportProduct)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            productReportDoc.SetDataSource(reportProduct);
            crystalReportViewer1.ReportSource = productReportDoc;
        }

        public reportViewer(List<Class.reportPurchase> reportPurchase)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            productReportDoc.SetDataSource(reportPurchase);
            crystalReportViewer1.ReportSource = productReportDoc;
        }

        public reportViewer(List<Class.reportSupplierRenew> reportSupplier)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            supplierReportDoc.SetDataSource(reportSupplier);
            crystalReportViewer1.ReportSource = supplierReportDoc;
        }
       
        private void reportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
