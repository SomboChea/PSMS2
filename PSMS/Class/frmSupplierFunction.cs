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
    class frmSupplierFunction : Function
    {
         public frmSupplierFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Supplier");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView) 
        {
            dataGridView.DataSource = base.GetData("SELECT * from Supplier");
        }
        public SqlParameter[] GetParameter(frmSu Su)
        {
            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("SuID", Su.su_id);
            param[1] = new SqlParameter("SuLNKH", Su.su_lnkh);
            param[2] = new SqlParameter("SuFNKH", Su.su_fnkh);
            param[3] = new SqlParameter("SuLNEN", Su.su_lnen);
            param[4] = new SqlParameter("SuFNEN", Su.su_fnen);
            param[5] = new SqlParameter("Gender", Su.gender);
            param[6] = new SqlParameter("Address", Su.address);
            param[7] = new SqlParameter("Phone", Su.phone2);
            param[8] = new SqlParameter("Phone2", Su.phone2);
            param[9] = new SqlParameter("Email", Su.email);
            param[10] = new SqlParameter("Fax", Su.fax);
            param[11] = new SqlParameter("Fax2", Su.fax2);
            param[12] = new SqlParameter("Balance", Su.balance);
            return param;
        }
        public int Insert(frmSu Su)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Supplier(SuLNKH, SuFNKH, SuLNEN, SuFNEN, Gender, Address,Phone,Phone2,Fax,Fax2, Balance) " +
                "VALUES(@SuLNKH, @SuFNKH, @SuLNEN, @SuFNEN, @Gender, @Address, @Phone, @Phone2, @Fax, @Fax2, @Balance)",
                GetParameter(Su));
        }

        public object InsertScalar(frmSu Su)
        {
            return base.ExecScalar("INSERT INTO " +
               "Supplier(SuLNKH, SuFNKH, SuLNEN, SuFNEN, Gender, Address,Phone,Phone2,Fax,Fax2, Balance)" +
                "OUTPUT INSERTED.SuID Supplier(SuLNKH, SuFNKH, SuLNEN, SuFNEN, Gender, Address,Phone,Phone2,Fax,Fax2, Balance)"+
                GetParameter(Su));
        }

        public int Update(frmSu Su)
        {
            return base.ExecNonQuery("UPDATE Supplier " +
                "SET SuLNKH=@SuLNKH, SuFNKH=@SuFNKH, SuLNEN=@SuLNEN, SuFNEN=@SuFNEN, Gender=@Gender, Address=@Address, Phone=@Phone2, Fax=@Fax, Fax2=@Fax2 WHERE SuID=@SuID", GetParameter(Su));
        }

        public int Delete(int suid)
        {
            return base.ExecNonQuery("DELETE FROM Supplier WHERE SuID=" + suid);
        }
    }
}
