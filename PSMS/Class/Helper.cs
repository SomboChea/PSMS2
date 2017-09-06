using System;
using System.Collections.Generic;
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
        public static List<ListViewItem> getListStock()
        {
            List<ListViewItem> items = new List<ListViewItem>();

            Connection.Open("localhost", "PSMS2");
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
            }
            
            return items;
        }
            
    }
    
}
