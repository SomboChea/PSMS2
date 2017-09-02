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
    class frmUserFunction : Function
    {
        public frmUserFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Users");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView) 
        {
            dataGridView.DataSource = base.GetData("SELECT * from Users");
        }
        
        public SqlParameter[] GetParameter(frmU U)
        {
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("UID", U.UID);
            param[1] = new SqlParameter("UCode", U.UCode);
            param[2] = new SqlParameter("UName", U.UName);
            param[3] = new SqlParameter("Password", U.Password);
            return param;
        }
        public int Insert(frmU U)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Users(UName, Password) " +
                "VALUES(@UName, @Password)",
                GetParameter(U));
        }

        public object InsertScalar(frmU U)
        {
            return base.ExecScalar("INSERT INTO " +
               "Users(UName, Password ) " +
                "OUTPUT INSERTED.UID VALUES(@UName, @Password)",
                GetParameter(U));
        }

        public int Update(frmU U)
        {
            return base.ExecNonQuery("UPDATE Users " +
                "SET UName=@UName, Password=@Password WHERE UID=@UID", GetParameter(U));
                
        }

        public int Delete(int pro_id)
        {
            return base.ExecNonQuery("DELETE FROM Users WHERE PID=" + pro_id);
        }
    }
}
