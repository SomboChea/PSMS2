using PSMS.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public class Function
    {
        public DataTable GetData(string cmdText)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = cmdText;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                adapter.Dispose();
                adapter = null;

                cmd.Dispose();
                cmd = null;
            }
            return dt;
        }

        public SqlDataReader GetDataReader(string cmdText)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = cmdText;
            SqlDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Dispose();
                reader = null;

                cmd.Dispose();
                cmd = null;
            }
            return reader;
        }
        public int ExecNonQuery(string cmdText)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = cmdText;
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cmd.Dispose();
                cmd = null;
            }
            return result;
        }

        public int ExecNonQuery(string cmdText, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cmd.Dispose();
                cmd = null;
            }
            return result;
        }

        public object ExecScalar(string cmdText)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = cmdText;
            object result = null;
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cmd.Dispose();
                cmd = null;
                
            }
            return result;
        }

        public object ExecScalar(string cmdText, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.con;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
            object result = null;
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cmd.Dispose();
                cmd = null;
            }
            return result;
        }

        public int GetLastId(string table_name)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Connection.con;
            sqlcmd.CommandText = "SELECT IDENT_CURRENT('" + table_name + "') FROM " + table_name + ";";

            try
            {
                object rex = sqlcmd.ExecuteScalar();

                return Convert.ToInt32(rex);
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
    }
}
