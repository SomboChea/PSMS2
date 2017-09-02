using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    class frmPosFunction : Function
    {
        public frmPosFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Position");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView)
        {
            dataGridView.DataSource = base.GetData("SELECT * from Position");
        }
        public void FillComboBox(ref ComboBox cbo, string displayMember, string valueMember)
        {
            cbo.DataSource = base.GetData("SELECT * FROM Position");
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }
        public SqlParameter[] GetParameter(frmPos Pos)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("PosID",Pos.PosID );
            param[1] = new SqlParameter("PosCode",Pos.PosCode );
            param[2] = new SqlParameter("PosName",Pos.PosName);
            
            return param;
        }
        public int Insert(frmPos Pos)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Position(PosName) " +
                "VALUES(@PosName)",
                GetParameter(Pos));
        }

        public object InsertScalar(frmPos Pos)
        {
            return base.ExecScalar("INSERT INTO " +
               "Position(PosName) " +
                "OUTPUT INSERTED.PosID VALUES(@PosName)",
                GetParameter(Pos));
        }

        public int Update(frmPos Pos)
        {
            return base.ExecNonQuery("UPDATE Position " +
                "SET PosName=@PosName WHERE PosID=@PosID", GetParameter(Pos));

        }

        public int Delete(int PosID)
        {
            return base.ExecNonQuery("DELETE FROM Position WHERE PosID=" + PosID);
        }
    }
}
