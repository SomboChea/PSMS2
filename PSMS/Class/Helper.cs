using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // //////////////// //
        public static List<ListViewItem> getListStock(ref ImageList imglist)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            //Connection.Open("localhost", "PSMS2");

            SqlCommand cmd = new SqlCommand("SELECT * FROM viewStock;",Connection.con);
            SqlDataReader reader = cmd.ExecuteReader();
            string[] item = new string[10];
            
            while (reader.Read())
            {
                for (int i = 0; i < item.Length; i++)
                {
                    item[i] = reader.GetValue(i)+"";
                }  
                items.Add(new ListViewItem(item));
                try
                {
                    imglist.Images.Add(Image.FromStream(new System.IO.MemoryStream((Byte[])reader.GetValue(10))));
                }
                catch (Exception)
                {
                    imglist.Images.Add(Properties.Resources.employee);
                }

                imglist.ImageSize = new Size(100, 100);
            }

            reader.Close();
            cmd.Dispose();

            return items;
        }

        public static DataSet getDataSet(string cmdText)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, Connection.con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
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
            catch(SqlException)
            {
                MessageBox.Show("Can't connect to database!");
            }

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
            if (value.Equals(null) || value.Equals("") || value.Equals(" "))
                return true;
            else
                return ifnull(value);
        }

        public static int GetLastId(string table_name)
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

        public static int checkStock(string Pcode)
        {
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Product WHERE PCode = '" + Pcode + "' AND Quantity > 0; ", Connection.con);

            return sqlcmd.ExecuteNonQuery();
        }
    }
    
}
