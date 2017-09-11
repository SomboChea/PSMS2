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

        public string conStr { set; get; }

        public DataTable GetData(string cmdText)
        {
         

            Connection.Open("localhost", "PSMS2");

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
                throw ex;
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
            SqlConnection cnn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = cmdText;
            SqlDataReader reader = null;
            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Dispose();
                reader = null;

                cmd.Dispose();
                cmd = null;

                cnn.Close();
            }
            return reader;
        }
        public int ExecNonQuery(string cmdText)
        {
            SqlConnection cnn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = cmdText;
            int result = 0;
            try
            {
                cnn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                cmd.Dispose();
                cmd = null;

                cnn.Close();
            }
            return result;
        }

        public int ExecNonQuery(string cmdText, SqlParameter[] param)
        {
            SqlConnection cnn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
            int result = 0;
            try
            {
                cnn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                cmd.Dispose();
                cmd = null;

                cnn.Close();
            }
            return result;
        }

        public object ExecScalar(string cmdText)
        {
            Connection.Open("localhost", "PSMS2");

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
                throw ex;
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
            SqlConnection cnn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
            object result = null;
            try
            {
                cnn.Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                cmd.Dispose();
                cmd = null;

                cnn.Close();
            }
            return result;
        }

        public int GetLastId(string table_name)
        {
            Connection.Open("localhost", "PSMS2");
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
