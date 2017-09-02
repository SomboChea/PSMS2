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
    class frmModelFunction : Function
    {
        public frmModelFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Model");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView)
        {
            dataGridView.DataSource = base.GetData("SELECT MCode,Description from Model");
        }
        public void FillComboBox(ref ComboBox cbo, string displayMember, string valueMember)
        {
            cbo.DataSource = base.GetData("SELECT * FROM Model");
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }
        public SqlParameter[] GetParameter(frmM Mo)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("MID", Mo.MID);
            param[1] = new SqlParameter("MCode", Mo.MCode);
            param[2] = new SqlParameter("Description", Mo.Description);
            return param;
        }
        public int Insert(frmM Mo)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Model(Description) VALUES(@Description)", GetParameter(Mo));
        }

        public object InsertScalar(frmM Mo)
        {
            return base.ExecScalar("INSERT INTO " +
               "Model(Description)OUTPUT INSERTED.MID VALUES(@Description)", GetParameter(Mo));
        }

        public int Update(frmM Mo)
        {
            return base.ExecNonQuery("UPDATE Model SET Description=@Description WHERE MID=@MID", GetParameter(Mo));

        }

        public int Delete(int mid)
        {
            return base.ExecNonQuery("DELETE FROM Model WHERE MID=" + mid);
        }
    }
}
