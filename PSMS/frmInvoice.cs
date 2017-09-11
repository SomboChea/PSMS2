using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmInvoice : MetroForm
    {
       frmInvoiceFunction invFun;
       frmProductFunction proFun;
        public frmInvoice()
        {
            InitializeComponent();
            invFun = new frmInvoiceFunction();
            proFun = new frmProductFunction();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in dataGridView1.Rows)
    {
        string constring = @"Data Source=.\SQL2008R2;Initial Catalog=AjaxSamples;Integrated Security=true";
        using (SqlConnection con = new SqlConnection(constring))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Customers VALUES(@CustomerId, @Name, @Country)", con))
            {
                cmd.Parameters.AddWithValue("@CustomerId", row.Cells["Id"].Value);
                cmd.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
                cmd.Parameters.AddWithValue("@Country", row.Cells["Country"].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }*/
        }
     
         

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
