using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PSMS
{
    class frmCustomerFunction : Function
    {
        
    
        public frmCustomerFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Customers");
        }
        public void FillDataGridView(ref DataGridView dataGridView) 
        {
            dataGridView.DataSource = base.GetData("SELECT * from Customers");
        }
        public void FillDataGridView2(ref MetroFramework.Controls.MetroGrid dataGridView)
        {
            dataGridView.DataSource = base.GetData("SELECT cuscode,cuslnkh,cusfnkh,cuslnen,cusfnen,gender,address,phone,phone2,email,balance,status,emp_id,acc_opendate from Customers");
        }
        public SqlParameter[] GetParameter(frmCus cus)
        {
            SqlParameter[] param = new SqlParameter[15];
            param[0] = new SqlParameter("cusid", cus.cus_id);
            param[1] = new SqlParameter("cuscode", cus.cus_code);
            param[2] = new SqlParameter("cuslnkh", cus.cus_lnkh);
            param[3] = new SqlParameter("cusfnkh", cus.cus_fnkh);
            param[4] = new SqlParameter("cuslnen", cus.cus_lnen);
            param[5] = new SqlParameter("cusfnen", cus.cus_fnen);
            param[6] = new SqlParameter("gender", cus.gender);
            param[7] = new SqlParameter("address", cus.address);
            param[8] = new SqlParameter("phone", cus.phone);
            param[9] = new SqlParameter("phone2", cus.phone2);
            param[10] = new SqlParameter("email", cus.email);
            param[11] = new SqlParameter("balance", cus.balance);
            param[12] = new SqlParameter("status", cus.status);
            param[13] = new SqlParameter("emp_id", cus.emp_id);
            param[14] = new SqlParameter("acc_opendate", cus.acc_opendate);
            return param;
        }
        public int Insert(frmCus cus)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Customers(cuslnkh, cusfnkh, cuslnen, cusfnen, gender, address,phone,phone2,email,balance,status,emp_id,acc_opendate) " +
                "VALUES(@cuslnkh, @cusfnkh, @cuslnen, @cusfnen, @gender, @address, @phone, @phone2, @email, @balance, @status, @emp_id, @acc_opendate)",
                GetParameter(cus));
        }

        public object InsertScalar(frmCus cus)
        {
            return base.ExecScalar("INSERT INTO " +
               "Customers(cuslnkh, cusfnkh, cuslnen, cusfnen, gender, address,phone,phone2,email,balance,status,emp_id,acc_opendate) " +
                "OUTPUT INSERTED.cus_id VALUES(@cuslnkh, @cusfnkh, @cuslnen, @cusfnen, @gender, @address, @phone, @phone2, @email, @balance, @status, @emp_id @acc_opendate)",
                GetParameter(cus));
        }

        public int Update(frmCus cus)
        {
            return base.ExecNonQuery("UPDATE Customers " +
                "SET cuslnkh=@cuslnkh, cusfnkh=@cusfnkh, cuslnen=@cuslnen,cusfnen=@cusfnen, gender=@gender, address=@address, phone=@phone, phone2=@phone2, email=@email, balance=@balance, status=@status, acc_opendate=@acc_opendate WHERE cusid=@cusid", GetParameter(cus));
        }

        public int Delete(int cus_id)
        {
            return base.ExecNonQuery("DELETE FROM Customers WHERE cusid=" + cus_id);
        }
    
    }
}
