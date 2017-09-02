using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PSMS
{
    class frmInvoiceFunction : Function
    {
        public frmInvoiceFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Invoice");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView) 
        {
            dataGridView.DataSource = base.GetData("SELECT [InvoiceCode],[CusID],[EmpID],[Date],[TotalPrice],[Payment],[PaymentVerify] ,[Balance] from Invoice");
        }
        public SqlParameter[] GetParameter(frmIn Inv)
        {
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("InvoiceNo", Inv.inid);
            param[1] = new SqlParameter("InvoiceCode", Inv.incode);
            param[2] = new SqlParameter("CusID", Inv.cusid);
            param[3] = new SqlParameter("EmpID", Inv.empid);
            param[4] = new SqlParameter("Date", Inv.date);
            param[5] = new SqlParameter("Totalprice", Inv.totalprice);
            param[6] = new SqlParameter("Payment", Inv.payment);
            param[7] = new SqlParameter("PaymentVerify", Inv.paymentverify);
            param[8] = new SqlParameter("Balance", Inv.balance);
            
            return param;
        }
        public int Insert(frmIn inv)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Invoice(CusID, EmpID, Date,Totalprice,Payment, PaymentVerify, Balance) " +
                "VALUES(@CusID, @EmpID, @Date, @Totalprice, @Payment, @PaymentVerify, @Balance)",
                GetParameter(inv));
        }

        public object InsertScalar(frmIn inv)
        {
            return base.ExecScalar("INSERT INTO " +
               "Invoice(CusID, EmpID, Date,Totalprice,Payment, PaymentVerify, Balance) " +
                "OUTPUT INSERTED.InvoiceNo VALUES(@CusID, @EmpID, @Date, @Totalprice, @Payment, @PaymentVerify, @Balance)",
                GetParameter(inv));
        }

        public int Update(frmIn inv)
        {
            return base.ExecNonQuery("UPDATE Product " +
                "SET CusID=@CusID, EmpID=@EmpID, Date=@Date, Totalprice=@Totalprice, Payment=@Payment, PaymentVerify=@PaymentVerify, Balance=@Balance WHERE InvoiceNo=@InvoiceNo", GetParameter(inv));
        }

        public int Delete(int inid)
        {
            return base.ExecNonQuery("DELETE FROM Invoice WHERE InvoiceNo=" + inid);
        }
    }
}
