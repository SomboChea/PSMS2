using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using MetroFramework.Forms;
using PSMS.Class;
using PSMS.Reports;
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
        Function func;
        public reportViewer(List<reportPurchaseWeekly> list)
        {
            InitializeComponent();

            PurchaseWeeklyReport report = new PurchaseWeeklyReport();
            report.SetDataSource(list);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }
        reportIncomeWeekly reportIncomeWeekly = new reportIncomeWeekly();

        public reportViewer(ReportDocument report)
        {
            InitializeComponent();
            
            crystalReportViewer1.ReportSource = report;
            //crystalReportViewer1.ParameterFieldInfo[0].DefaultValues.Add("title");
            crystalReportViewer1.RefreshReport();

        }

        public reportViewer(List<Class.reportRevenueWeekly> listRevenueWeekly)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            //reportInvoiceRevenue.DataSourceConnections.Clear();
            //reportInvoiceRevenue.Load(@"E:\C# Project PSMS\PSMS new\PSMS2\PSMS\Reports\partRevenueWeeklyReport.rpt");
            reportIncomeWeekly.Subreports[0].SetDataSource(listRevenueWeekly);
            crystalReportViewer1.ReportSource = reportIncomeWeekly;
        }
        public reportViewer(List<Class.reportInvoice> reportInvoice)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            invoiceReportDoc.SetDataSource(reportInvoice);

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

        public reportViewer(List<Class.reportPurchaseRenew> reportPurchase)
        {
            InitializeComponent();
            Class.FullMode.Fullscreen(this);

            purchaseReportD.SetDataSource(reportPurchase);
            crystalReportViewer1.ReportSource = purchaseReportD;
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
