using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Configuration;
namespace PSMS
{
    class frmProductFunction : Function
    {
        public frmProductFunction() 
        {
            base.conStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }
        public DataTable GetCusData()
        {
            return base.GetData("SELECT * from Product");
        }
        public void FillDataGridView(ref MetroFramework.Controls.MetroGrid dataGridView) 
        {
            dataGridView.DataSource = base.GetData("SELECT * from Product");
        }
        public void FillDataGridView2(ref MetroFramework.Controls.MetroGrid dataGridView)
        {
            dataGridView.DataSource = base.GetData("SELECT PName from Product");
        }
        public void FillComboBox(ref DataGridViewComboBoxColumn cbo, string displayMember, string valueMember)
        {
            cbo.DataSource = base.GetData("SELECT * FROM Product");
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }
        public SqlParameter[] GetParameter(frmPro Pro)
        {
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("PID", Pro.pro_id);
            param[1] = new SqlParameter("PCode", Pro.pro_code);
            param[2] = new SqlParameter("PName", Pro.pro_name);
            param[3] = new SqlParameter("PSize", Pro.pro_size);
            param[4] = new SqlParameter("color", Pro.color);
            param[5] = new SqlParameter("quantity", Pro.quantity);
            param[6] = new SqlParameter("mid", Pro.model);
            param[7] = new SqlParameter("PTypeID", Pro.ph_type);
            param[8] = new SqlParameter("TID", Pro.type);
            param[9] = new SqlParameter("Saleprice", Pro.saleprice);
            param[10] = new SqlParameter("Unitprice", Pro.unitprice);
            return param;
        }
        public int Insert(frmPro Pro)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Product(PName, PSize, Color, Quantity, MID, PTypeID,TID,Saleprice,Unitprice) " +
                "VALUES(@pname, @Psize, @Color, @Quantity, @MID, @PTypeID, @TID, @Saleprice, @Unitprice)",
                GetParameter(Pro));
        }

        public object InsertScalar(frmPro Pro)
        {
            return base.ExecScalar("INSERT INTO " +
               "Product(PName, PSize, Color, Quantity, MID, PTypeID,TID,Saleprice,Unitprice) " +
                "OUTPUT INSERTED.PID VALUES(@pname, @Psize, @Color, @Quantity, @MID, @PTypeID, @TID, @Saleprice, @Unitprice)",
                GetParameter(Pro));
        }

        public int Update(frmPro Pro)
        {
            return base.ExecNonQuery("UPDATE Product " +
                "SET PName=@PName, PSize=@PSize, Color=@Color, Quantity=@Quantity, MID=@MID, PTypeID=@PTypeID, TID=@TID, Saleprice=@Saleprice, Unitprice=@Unitprice WHERE PID=@PID", GetParameter(Pro));
                
        }

        public int Delete(int pro_id)
        {
            return base.ExecNonQuery("DELETE FROM Product WHERE PID=" + pro_id);
        }
    }
}
