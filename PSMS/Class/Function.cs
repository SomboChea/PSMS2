﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS
{
    public class Function
    {

        public string conStr { set; get; }

        public DataTable GetData(string cmdText)
        {
            SqlConnection cnn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = cmdText;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                cnn.Open();
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

                cnn.Close();
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
            SqlConnection cnn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = cmdText;
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
    }
}