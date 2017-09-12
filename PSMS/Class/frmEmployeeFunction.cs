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
    class frmEmployeeFunction : Function
    {
        
        public frmEmployeeFunction() 
        {
            
        }
        public DataTable GetEmpData()
        {
            return base.GetData("SELECT * from Employee");
        }
        public void FillDataGridView(ref DataGridView dataGridView) 
        {
            dataGridView.DataSource = base.GetData("SELECT * from Employee");
        }
       
        public void FillComboBox(ref ComboBox cbo, string displayMember, string valueMember)
        {
            cbo.DataSource = base.GetData("SELECT * FROM Employee");
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }
        public SqlParameter[] GetParameter(frmEmp emp)
        {
            SqlParameter[] param = new SqlParameter[15];
            param[0] = new SqlParameter("empid", emp.emp_id);
            param[1] = new SqlParameter("empcode", emp.empcode);
            param[2] = new SqlParameter("emplnkh", emp.emp_lnkh);
            param[3] = new SqlParameter("empfnkh", emp.emp_fnkh);
            param[4] = new SqlParameter("emplnen", emp.emp_lnen);
            param[5] = new SqlParameter("empfnen", emp.emp_fnen);
            param[6] = new SqlParameter("gender", emp.gender);
            param[7] = new SqlParameter("idcard", emp.idcard);
            param[8] = new SqlParameter("address", emp.address);
            param[9] = new SqlParameter("phone", emp.phone);
            param[10] = new SqlParameter("email", emp.email);
            param[11] = new SqlParameter("posid", emp.pos_id);
            param[12] = new SqlParameter("salary", emp.salary);
            param[13] = new SqlParameter("joindate", emp.join_date);
            param[14] = new SqlParameter("@img", emp.img);
            return param;
        }

        public int Insert(frmEmp emp)
        {
            return base.ExecNonQuery("INSERT INTO " +
                "Employee(emplnkh, empfnkh, emplnen, empfnen, gender, idcard, address, phone, email, posid, salary, joindate,Image) " +
                "VALUES(@emplnkh, @empfnkh, @emplnen, @empfnen, @gender, @idcard, @address, @phone, @email, @posid, @salary, @joindate,convert(Varbinary(max),@img))",
                GetParameter(emp));
        }

        public object InsertScalar(frmEmp emp)
        {
            return base.ExecScalar("INSERT INTO " +
                "Employee(emplnkh, empfnkh, emplnen, empfnen, gender, idcard, address, phone, email, posid, salary, joindate) " +
                "OUTPUT INSERTED.empid VALUES(@emplnkh, @empfnkh, @emplnen, @empfnen, @gender, @idcard, @address, @phone, @email, @posid, @salary, @joindate)",
                GetParameter(emp));
        }

        public int Update(frmEmp emp)
        {
            return base.ExecNonQuery("UPDATE Employee " +
                "SET emplnkh=@emplnkh, empfnkh=@empfnkh, emplnen=@emplnen, empfnen=@empfnen, gender=@gender, idcard=@idcard, address=@address, phone=@phone, email=@email, posid=@posid, salary=@salary, joindate=@joindate,Image=Convert(varbinary(max),@img)" +
                "WHERE empid=@empid", GetParameter(emp));
        }

        public int Delete(int emp_id)
        {
            return base.ExecNonQuery("DELETE FROM Employee WHERE empid=" + emp_id);
        }
    }
}
