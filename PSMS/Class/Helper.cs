using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PSMS.Class
{
    class Helper
    {
        public static string ImageToBase64(Image image)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, image.RawFormat);
            byte[] imageBytes = ms.ToArray();

            return Convert.ToBase64String(imageBytes); ;
        }

        public static Image Base64ToImage(string base64)
        {
            byte[] imageByte = Convert.FromBase64String(base64);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageByte);

            return Image.FromStream(ms);
        }
        
        public static List<ListViewItem> getListStock(ref ImageList imglist,string addSql)
        {
            try
            {
                List<ListViewItem> items = new List<ListViewItem>();
                string sql = "SELECT * FROM viewStock " + addSql;
                SqlCommand cmd = new SqlCommand(sql, Connection.con);
                SqlDataReader reader = cmd.ExecuteReader();
                string[] item = new string[10];

                while (reader.Read())
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        item[i] = reader.GetValue(i) + "";
                    }
                    items.Add(new ListViewItem(item));
                    try
                    {
                        imglist.Images.Add(Image.FromStream(new System.IO.MemoryStream((Byte[])reader.GetValue(10))));
                    }
                    catch (Exception)
                    {
                        imglist.Images.Add(Properties.Resources.Product);
                    }

                    imglist.ImageSize = new Size(100, 100);
                }

                reader.Close();
                cmd.Dispose();

                return items;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataSet getDataSet(string cmdText)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, Connection.con);
                adapter.Fill(ds);

                return ds;
            }
            catch (Exception) { return null; }
        }

        public static void Defaultform( MetroFramework.Forms.MetroForm frm)
        {
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Resizable = false;
            frm.Movable = false;
        }

        public static void BindGridView(string cmdText,BindingSource bindinSource, DataGridView gridView)
        {
            try
                {
                DataTable dt = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, Connection.con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(dt);
                bindinSource.DataSource = dt;

                // Resize the DataGridView columns to fit the newly loaded content.
                gridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Can't connect to database!"+Environment.NewLine + ex.Message);
            }

        }

        public static void AutoFitColumns(DataGridView dg)
        {
            try
            {
                dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch(Exception) { }
        }

        public static bool ifnull(object value)
        {
            if (value.Equals(null) || value.Equals(""))
                return true;
            else
                return false;
        }

        public static bool ifnull(object value, bool checkSpace)
        {
            if (value.Equals(" "))
                return ifnull(value);
            else
                return ifnull(value);
        }

        public static bool canParse(object value)
        {
            try
            {
                double.Parse(value.ToString());

                return true;
            }
            catch (Exception) { return false; }
        }

        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }

        public static int GetLastId(string table_name)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Connection.con;
            /*
                mark one error , just select ident_current('Table Name') no from Table , it error , try with empty table u will see  ,   i not sure
                ============*/
            sqlcmd.CommandText = "SELECT IDENT_CURRENT('" + table_name + "')";
            
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

        public static string GetLastIdCode(string table_name, string col_id,string col_code)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Connection.con;
            sqlcmd.CommandText = "SELECT " + col_code + " FROM " + table_name + " WHERE " + col_id + " = IDENT_CURRENT('" + table_name + "');";

            try
            {
                object rex = sqlcmd.ExecuteScalar();

                return  Convert.ToString(rex);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int checkStock(string Pcode)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT Quantity FROM Product WHERE PCode = '" + Pcode + "' AND Quantity > 0; ", Connection.con);
                int qty = Convert.ToInt32(sqlcmd.ExecuteScalar());

                sqlcmd.Dispose();

                if (qty > 0)
                    return qty;
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
    }
    
}
