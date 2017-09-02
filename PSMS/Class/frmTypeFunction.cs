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
    class frmTypeFunction : Function
    {
        public frmTypeFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Type");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView)
        {
            dataGridView.DataSource = base.GetData("SELECT * from Type");
        }
        public void FillComboBox(ref ComboBox cbo, string displayMember, string valueMember)
        {
            cbo.DataSource = base.GetData("SELECT * FROM Type");
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }
        public SqlParameter[] GetParameter(frmT T)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("TID", T.TID);
            param[1] = new SqlParameter("TCode", T.TCode);
            param[2] = new SqlParameter("Description", T.Description);
            return param;
        }
        public int Insert(frmT T)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Type(Description) VALUES(@Description)", GetParameter(T));
        }

        public object InsertScalar(frmT T)
        {
            return base.ExecScalar("INSERT INTO " +
               "Type(Description)OUTPUT INSERTED.TID VALUES(@Description)", GetParameter(T));
        }

        public int Update(frmT T)
        {
            return base.ExecNonQuery("UPDATE Type " +
                "SET Description=@Description WHERE TID=@TID", GetParameter(T));

        }

        public int Delete(int tid)
        {
            return base.ExecNonQuery("DELETE FROM Type WHERE TID=" + tid);
        }
    }
}
