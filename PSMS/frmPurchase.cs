using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmPurchase : MetroForm
    {
        frmPayment pay = new frmPayment();
        public frmPurchase()
        {
            InitializeComponent();
            initComboModel();
        }
        void initComboModel()
        {
            //string conString = @"Server=ARAFAT-JUNIOR; Initial Catalog=PSMS2; Integrated Security=true";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Model", con);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();

            this.modelComboBox.DataSource = ds.Tables[0];
            this.modelComboBox.DisplayMember = "Description";
            this.modelComboBox.ValueMember = "MID";
        }
        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          

        }
        void filterModel()
        {
            string modelValue = this.modelComboBox.SelectedValue.ToString();
            int value;
            if (int.TryParse(modelValue, out value))
            {

                //string conString = @"Server=ARAFAT-JUNIOR; Initial Catalog=PSMS2; Integrated Security=true";
                //SqlConnection con = new SqlConnection(conString);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from Product where MID=@MID", con);
                cmd.Parameters.AddWithValue("@MID", this.modelComboBox.SelectedValue.ToString());
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                this.PurchaseDetailDataGridView.DataSource = ds.Tables[0];

            }
        }
        private void binddatagridview()
        {

            int qty;
            if (int.TryParse(this.txtQty.Text, out qty))
            {
                if (this.PurchaseDetailDataGridView.SelectedCells.Count > 0)
                {

                    int selectedrowindex = PurchaseDetailDataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = PurchaseDetailDataGridView.Rows[selectedrowindex];


                    DataTable dt = new DataTable();

                    if (dt.Columns.Count == 0)
                    {
                        dt.Columns.Add("PID", typeof(string));
                        dt.Columns.Add("PName", typeof(string));
                        dt.Columns.Add("PSize", typeof(string));
                        dt.Columns.Add("Color", typeof(string));
                        dt.Columns.Add("Quantity", typeof(int));
                        dt.Columns.Add("Unitprice", typeof(string));
                        dt.Columns.Add("Saleprice", typeof(string));
                    }

                    Boolean isUpdateRow = false;
                    Double totalPrice = 0.0;
                    foreach (DataGridViewRow row in dtGvBuy.Rows)
                    {

                        DataRow NewRow1 = dt.NewRow();
                        NewRow1[0] = row.Cells[0].Value;
                        NewRow1[1] = row.Cells[1].Value;
                        NewRow1[2] = row.Cells[2].Value;
                        NewRow1[3] = row.Cells[3].Value;
                        NewRow1[4] = row.Cells[4].Value;
                        NewRow1[5] = row.Cells[5].Value;
                        NewRow1[6] = row.Cells[6].Value;



                        if (Convert.ToString(row.Cells[0].Value) == Convert.ToString(selectedRow.Cells[0].Value))
                        {
                            NewRow1[4] = Convert.ToInt32(row.Cells[4].Value) + qty;
                            isUpdateRow = true;
                        }
                        totalPrice += Convert.ToDouble(row.Cells[5].Value) * Convert.ToDouble(NewRow1[4]);

                        dt.Rows.Add(NewRow1);
                    }

                    if (!isUpdateRow)
                    {
                        DataRow NewRow = dt.NewRow();
                        NewRow[0] = Convert.ToString(selectedRow.Cells[0].Value);
                        NewRow[1] = Convert.ToString(selectedRow.Cells[1].Value);
                        NewRow[2] = Convert.ToString(selectedRow.Cells[2].Value);
                        NewRow[3] = Convert.ToString(selectedRow.Cells[3].Value);
                        NewRow[5] = Convert.ToString(selectedRow.Cells[5].Value);
                        NewRow[6] = Convert.ToString(selectedRow.Cells[6].Value);
                        NewRow[4] = qty;
                        dt.Rows.Add(NewRow);
                        totalPrice += Convert.ToDouble(selectedRow.Cells[5].Value) * Convert.ToDouble(qty);
                    }

                    this.totalPriceLabel1.Text = totalPrice.ToString();
                    dtGvBuy.DataSource = dt;


                }
                else
                {
                    MessageBox.Show("Please select product");
                }
            }
            else
            {
                MessageBox.Show("Please input number");
            }


        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchaseDetail._PurchaseDetail' table. You can move, or remove it, as needed.
            //this.purchaseDetailTableAdapter.Fill(this.purchaseDetail._PurchaseDetail);
            // TODO: This line of code loads data into the 'empDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empDataSet.Employee);
            // TODO: This line of code loads data into the 'supplierDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.supplierDataSet.Supplier);
            // TODO: This line of code loads data into the 'supplierDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.supplierDataSet.Supplier);
                      

        }

        private void supplierBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supplierDataSet);

        }

        private void supplierBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supplierDataSet);

        }

        private void frmPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain frmM = new frmMain();
            //frmM.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.binddatagridview();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterModel();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pay = new frmPayment();
            pay.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            pay.ShowDialog();
        }
        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            pay.Show();
            paymentLabel1.Text = pay.txtAmount.Text;
            // Do whatever you want here
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            int balance;
            Convert.ToInt32(paymentLabel1.Text);
            Convert.ToInt32(totalPriceLabel1.Text);
            if (dtGvBuy.Rows.Count == 0)
            {
                MessageBox.Show("Please select and buy product before you purchase");
            }
            else
            {
                //string conString = @"Server=ARAFAT-JUNIOR; Initial Catalog=PSMS2; Integrated Security=true";
                //SqlConnection con = new SqlConnection(conString);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
                SqlCommand cmd = new SqlCommand("INSERT into Purchase (Date,Payment,Balance,SuID,EmpID,Total) VALUES (@Date,@Payment,@Balance,@SuID,@EmpID,@Total)", con);
                //cmd.Parameters.AddWithValue("@InvoiceCode", "U000002");
                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateDateTimePicker.Text));
                cmd.Parameters.AddWithValue("@Payment", this.paymentLabel1.Text);
                
                cmd.Parameters.AddWithValue("@SuID", this.suIDComboBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@EmpID", this.empIDComboBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Total", this.totalPriceLabel1.Text);
                
                foreach (DataGridViewRow row in dtGvBuy.Rows)
                {

                    SqlCommand cmd3 = new SqlCommand("INSERT into PurchaseDetail ( PID, Quantity, Unitprice, Saleprice, Amount) VALUES ( @PID, @Quantity, @Unitprice, @Saleprice,@Amount)", con);
                    cmd3.Parameters.AddWithValue("@PID", row.Cells[0].Value);
                    cmd3.Parameters.AddWithValue("@Quantity", row.Cells[4].Value);
                    cmd3.Parameters.AddWithValue("@Unitprice", row.Cells[5].Value);
                    cmd3.Parameters.AddWithValue("@Saleprice", row.Cells[6].Value);
                    //Get total amount
                    
                    int total = Convert.ToInt32(row.Cells[4].Value) * Convert.ToInt32(row.Cells[5].Value);
                    cmd3.Parameters.AddWithValue("@Amount", total);
                    balance = Convert.ToInt32(totalPriceLabel1.Text) - Convert.ToInt32(paymentLabel1.Text);
                    cmd.Parameters.AddWithValue("@Balance", balance);
                    
                    con.Open();
                    cmd3.ExecuteNonQuery();
                    //Update Stock
                    SqlCommand cmd5 = new SqlCommand("UPDATE Product SET Quantity = Quantity + @Quantity Where PID=@PID ", con);
                    cmd5.Parameters.AddWithValue("@Quantity", row.Cells[4].Value);
                    cmd5.Parameters.AddWithValue("@PID", row.Cells[0].Value);
                    cmd5.ExecuteNonQuery();
                    con.Close();
                    BalanceLabel.Text = balance.ToString();
                }
                con.Open();
                cmd.ExecuteNonQuery();
                
                MetroMessageBox.Show(this, "New Purchase Save", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmPurchaseDetail frmPude = new frmPurchaseDetail();
            frmPude.ShowDialog();
        }
    }
}
