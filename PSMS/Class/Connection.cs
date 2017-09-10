using System;
using System.Data;
using System.Data.SqlClient;

namespace PSMS.Class
{
    class Connection
    {
        public static SqlConnection con { get; set; }
        public static bool Open(string host,string user,string password,string db)
        {
            string conString = "Server = " + host + ";Database = " + db + ";User Id = " + user + ";Password = " + password + ";";
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public static bool Open(string host,string db)
        {
            string constring = "Server = " + host + ";Database = " + db + ";Trusted_Connection = true";
            try
            {
                con = new SqlConnection(constring);
                con.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Close(SqlConnection connection)
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }

        public static object ExecuteScalar(string sql)
        {
            object value;
            SqlCommand cmd = new SqlCommand(sql, con);
          
            value = cmd.ExecuteScalar();
            cmd.Dispose();
            return value;
        }

        public DataTable GetData(SqlConnection con, string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = cmdText;
            SqlDataReader reader = null;
            try
            {
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
                
            }
            return reader;
        }
        public int ExecNonQuery(string cmdText)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = cmdText;
            int result = 0;
            try
            {
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
            }
            return result;
        }

        public int ExecNonQuery(string cmdText, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
            int result = 0;
            try
            {
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
                
            }
            return result;
        }

        public object ExecScalar(string cmdText)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
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

    }
}
