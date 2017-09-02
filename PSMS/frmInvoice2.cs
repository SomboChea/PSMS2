﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using Dapper;
using System.Configuration;

namespace PSMS
{
    public partial class frmInvoice2 : MetroForm
    {
        frmPayment pay = new frmPayment();
        frmInvoiceFunction Invfun;
        public frmInvoice2()
        {
            InitializeComponent();

            initComboModel();
            Invfun = new frmInvoiceFunction();
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
        
        private void frmInvoice2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'customerDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customerDataSet.Customers);
            // TODO: This line of code loads data into the 'empDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empDataSet.Employee);
            // TODO: This line of code loads data into the 'product2DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.product2DataSet.Product);
            //// TODO: This line of code loads data into the 'invoiceDetailDataSet.InvoiceDetail' table. You can move, or remove it, as needed.
            //this.invoiceDetailTableAdapter.Fill(this.invoiceDetailDataSet.InvoiceDetail);
            //// TODO: This line of code loads data into the 'invoiceDataSet.Invoice' table. You can move, or remove it, as needed.
            //this.invoiceTableAdapter.Fill(this.invoiceDataSet.Invoice);
           
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.invoiceDataSet);

        }


        
        private void btnPayment_Click(object sender, EventArgs e)
        {
            pay = new frmPayment();
            pay.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            pay.ShowDialog();
            //paymentLabel1.Text = frmPayment.passtxt;
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            pay.Show();
            paymentLabel1.Text = pay.txtAmount.Text;
            // Do whatever you want here
        }
        
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.invoiceBindingSource.AddNew();
            invoiceDataSet.AcceptChanges();

        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filterModel();

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

                this.invoiceDetailDataGridView.DataSource = ds.Tables[0];

            }




        }
        private void binddatagridview() 
        {

            int qty;
            if (int.TryParse(this.txtQty.Text, out qty))
            {
                if (this.invoiceDetailDataGridView.SelectedCells.Count > 0)
                {

                    int selectedrowindex = invoiceDetailDataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = invoiceDetailDataGridView.Rows[selectedrowindex];


                    DataTable dt = new DataTable();

                    if (dt.Columns.Count == 0)
                    {
                        dt.Columns.Add("PID", typeof(string));
                        dt.Columns.Add("PName", typeof(string));
                        dt.Columns.Add("PSize", typeof(string));
                        dt.Columns.Add("Color", typeof(string));
                        dt.Columns.Add("Quantity", typeof(int));
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

        private void button1_Click(object sender, EventArgs e)
        {

            this.binddatagridview();
        }
       
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            
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
                SqlCommand cmd = new SqlCommand("INSERT into Invoice (CusID,EmpID,Date,TotalPrice,Payment,PaymentVerify,Balance) VALUES (@CusID,@EmpID,@Date,@TotalPrice,@Payment,@PaymentVerify,@Balance)", con);
               
                //cmd.Parameters.AddWithValue("@InvoiceCode", "U000002");
                cmd.Parameters.AddWithValue("@CusID", this.cusIDComboBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@EmpID", this.empIDComboBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateDateTimePicker.Text));
                cmd.Parameters.AddWithValue("@TotalPrice", this.totalPriceLabel1.Text);
                cmd.Parameters.AddWithValue("@Payment", this.paymentLabel1.Text);

                  foreach (DataGridViewRow row in dtGvBuy.Rows  )
                   {
                       SqlCommand cmd3 = new SqlCommand("INSERT into InvoiceDetail ( PID, Quantity, Saleprice, Amount) VALUES ( @PID, @Quantity, @Saleprice,@Amount)", con);
                       //cmd3.Parameters.AddWithValue("@InvoiceNo", this.invoiceCodeTextBox.Text);
                       cmd3.Parameters.AddWithValue("@PID",row.Cells[0].Value);
                       cmd3.Parameters.AddWithValue("@Quantity", row.Cells[4].Value);
                       cmd3.Parameters.AddWithValue("@Saleprice", row.Cells[5].Value);
                       int total = Convert.ToInt32( row.Cells[4].Value) * Convert.ToInt32( row.Cells[5].Value);
                       //MessageBox.Show(total.ToString());
                       cmd3.Parameters.AddWithValue("@Amount",total);
                       con.Open();
                       cmd3.ExecuteNonQuery();
                       //Update Stock
                       SqlCommand cmd5 = new SqlCommand("UPDATE Product SET Quantity = Quantity - @Quantity Where PID=@PID ", con);
                       cmd5.Parameters.AddWithValue("@Quantity", row.Cells[4].Value);
                       cmd5.Parameters.AddWithValue("@PID", row.Cells[0].Value);
                       cmd5.ExecuteNonQuery();
                       con.Close();
                            
                    }
        
                if (Convert.ToInt32(paymentLabel1.Text) >= Convert.ToInt32 (totalPriceLabel1.Text))
                {
                    cmd.Parameters.AddWithValue("@PaymentVerify", "1");
                }
                else if (Convert.ToInt32(paymentLabel1.Text) < Convert.ToInt32(totalPriceLabel1.Text))
                {
                    int balance;
                    cmd.Parameters.AddWithValue("@PaymentVerify", "0");
                    balance = Convert.ToInt32(totalPriceLabel1.Text) - Convert.ToInt32(paymentLabel1.Text);
                    cmd.Parameters.AddWithValue("@Balance",balance);
                    balance = balance + balance;
                    SqlCommand cmd2 = new SqlCommand("UPDATE Customers SET Balance=@balance Where CusID=@CusID ", con);
                    cmd2.Parameters.AddWithValue("@CusID", this.cusIDComboBox.SelectedValue.ToString());
                    
                    cmd2.Parameters.AddWithValue("@Balance", balance);
                    //MessageBox.Show(balance.ToString());
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    //MessageBox.Show("Record Update");
                    con.Close();
                }
                
                //cmd.Parameters.AddWithValue("@Profits", "10");
                con.Open();
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "New Record Save", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmInvoiceDetail InvDe = new frmInvoiceDetail();
            InvDe.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            invoiceCodeTextBox.Text = "";
        }



  
    }
}