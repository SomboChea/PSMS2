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
    class frmPTypeCodeFunction : Function
    {
        public frmPTypeCodeFunction() 
        {
            
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Phone_Type");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView)
        {
            dataGridView.DataSource = base.GetData("SELECT * from Phone_Type");
        }
        public void FillComboBox(ref ComboBox cbo, string displayMember, string valueMember)
        {
            cbo.DataSource = base.GetData("SELECT * FROM Phone_Type");
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }
        public SqlParameter[] GetParameter(frmPT PT)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("PTID", PT.PTypeID);
            param[1] = new SqlParameter("PTypeCode", PT.PTypeCode);
            param[2] = new SqlParameter("Description", PT.Description);
            return param;
        }
        public int Insert(frmPT PT)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Phone_Type(Description) VALUES(@Description)",GetParameter(PT));
        }

        public object InsertScalar(frmPT PT)
        {
            return base.ExecScalar("INSERT INTO " +
               "Phone_Type(Description)OUTPUT INSERTED.PTypeID VALUES(@Description)",GetParameter(PT));
        }

        public int Update(frmPT PT)
        {
            return base.ExecNonQuery("UPDATE Phone_Type " +
                 "SET Description=@Description WHERE PTypeID=@PTID", GetParameter(PT));

        }

        public int Delete(int ptyid)
        {
            return base.ExecNonQuery("DELETE FROM Phone_Type WHERE PTypeID=" +ptyid);
        }
    }
}
