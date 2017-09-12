using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using PSMS.Class;

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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Model", Connection.con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            modelComboBox.DataSource = ds.Tables[0];
            modelComboBox.DisplayMember = "Description";
            modelComboBox.ValueMember = "MID";

            adapt.Dispose();
            cmd.Dispose();
        }
        
        private void frmInvoice2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'customerDataSet.Customers' table. You can move, or remove it, as needed.
            customersTableAdapter.Fill(customerDataSet.Customers);

            // TODO: This line of code loads data into the 'empDataSet.Employee' table. You can move, or remove it, as needed.
            employeeTableAdapter.Fill(empDataSet.Employee);

            // TODO: This line of code loads data into the 'product2DataSet.Product' table. You can move, or remove it, as needed.

            productTableAdapter.Fill(product2DataSet.Product);
            //// TODO: This line of code loads data into the 'invoiceDetailDataSet.InvoiceDetail' table. You can move, or remove it, as needed.
            //this.invoiceDetailTableAdapter.Fill(this.invoiceDetailDataSet.InvoiceDetail);
            //// TODO: This line of code loads data into the 'invoiceDataSet.Invoice' table. You can move, or remove it, as needed.
            //this.invoiceTableAdapter.Fill(this.invoiceDataSet.Invoice);

            btnPrint.Enabled = false;
            

            try
            {
                modelComboBox.SelectedIndex = 1;
                modelComboBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
             
            }
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            invoiceBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(invoiceDataSet);

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
            invoiceBindingSource.AddNew();
            invoiceDataSet.AcceptChanges();

        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterModel();

        }

        void filterModel()
        {
            try
            {
                string modelValue = modelComboBox.SelectedValue.ToString();
                int value;
                if (int.TryParse(modelValue, out value))
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE MID=@MID AND Quantity > 0;", Connection.con);
                    cmd.Parameters.AddWithValue("@MID", modelComboBox.SelectedValue.ToString());
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);

                    invoiceDetailDataGridView.DataSource = ds.Tables[0];

                    adapt.Dispose();
                    cmd.Dispose();
                }
            }
            catch(Exception) { }
            
        }
        private void binddatagridview() 
        {

            try
            {
                int qty;
                if (int.TryParse(txtQty.Text, out qty))
                {
                    if (invoiceDetailDataGridView.SelectedCells.Count > 0)
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

                        totalPriceLabel1.Text = totalPrice.ToString();
                        dtGvBuy.DataSource = dt;
                        
                    }
                    else
                    {
                        MessageBox.Show("Please select product!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input number!");
                }
            }
            catch(Exception) { }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            binddatagridview();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {

                float payment, totalPrice = 0;
                payment = Helper.ifnull(paymentLabel1.Text) ? 0 : float.Parse(paymentLabel1.Text);
                totalPrice = float.Parse(totalPriceLabel1.Text);

                if (dtGvBuy.Rows.Count == 0)
                {
                    MessageBox.Show("Please select and buy product before you purchase");
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Invoice (CusID,EmpID,Date,TotalPrice,Payment,PaymentVerify,Balance) VALUES (@CusID,@EmpID,@Date,@TotalPrice,@Payment,@PaymentVerify,@Balance)", Connection.con);

                        //cmd.Parameters.AddWithValue("@InvoiceCode", "U000002");
                        cmd.Parameters.AddWithValue("@CusID", cusIDComboBox.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@EmpID", empIDComboBox.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateDateTimePicker.Text));
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@Payment", payment);


                        List<StructInvocieDetail> invoiceDetails = new List<StructInvocieDetail>();

                        foreach (DataGridViewRow row in dtGvBuy.Rows)
                        {
                            StructInvocieDetail data = new StructInvocieDetail(Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[4].Value), float.Parse(row.Cells[5].Value + ""));

                            invoiceDetails.Add(data);

                        }
                        float balance;
                        if (payment >= totalPrice)
                        {
                            cmd.Parameters.AddWithValue("@PaymentVerify", "1");
                        

                            if (payment > totalPrice)
                            {
                                MetroMessageBox.Show(this, "Purchase Successful Change Back " + (payment - totalPrice), "Purchase!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@PaymentVerify", "0");
                           
                        } 
                        balance = totalPrice - payment;
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        float oldbalance = float.Parse(Connection.ExecuteScalar("Select Balance from Customers where CusID=" + cusIDComboBox.SelectedValue) + "");
                        balance = balance + oldbalance;
                        SqlCommand cmd2 = new SqlCommand("UPDATE Customers SET Balance=@balance WHERE CusID=@CusID ", Connection.con);
                        cmd2.Parameters.AddWithValue("@CusID", cusIDComboBox.SelectedValue.ToString());

                        cmd2.Parameters.AddWithValue("@Balance", balance);

                        //MessageBox.Show(balance.ToString());

                        cmd2.ExecuteNonQuery();

                        //MessageBox.Show("Record Update");

                        cmd2.Dispose();


                        //cmd.Parameters.AddWithValue("@Profits", "10");

                        cmd.ExecuteNonQuery();

                        int invID = Helper.GetLastId("Invoice");

                        foreach (StructInvocieDetail temp in invoiceDetails)
                        {
                            try
                            {
                                SqlCommand cmd3 = new SqlCommand("INSERT INTO InvoiceDetail (InvoiceNo, PID, Quantity, Saleprice, Amount) VALUES ( @InvoiceNo, @PID, @Quantity, @Saleprice,@Amount)", Connection.con);

                                cmd3.Parameters.AddWithValue("@InvoiceNo", invID);
                                cmd3.Parameters.AddWithValue("@PID", temp.PID);
                                cmd3.Parameters.AddWithValue("@Quantity", temp.Qty);
                                cmd3.Parameters.AddWithValue("@Saleprice", temp.SalePrice);
                                cmd3.Parameters.AddWithValue("@Amount", temp.Amount);

                                cmd3.ExecuteNonQuery();

                                //Update Stock
                                SqlCommand cmd5 = new SqlCommand("UPDATE Product SET Quantity = Quantity - @Quantity Where PID=@PID ", Connection.con);
                                cmd5.Parameters.AddWithValue("@Quantity", temp.Qty);
                                cmd5.Parameters.AddWithValue("@PID", temp.PID);

                                cmd5.ExecuteNonQuery();
                            }
                            catch (Exception) { }
                        }

                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Something wrong!" + Environment.NewLine + ex.Message, "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }

                    btnPrint.Enabled = true;
                    MetroMessageBox.Show(this, "New Record Save", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(this, null);
                    invoiceDetailDataGridView.Refresh();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Something wrong!" + Environment.NewLine + ex.Message, "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
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
            foreach (DataGridViewRow row in dtGvBuy.Rows)
                dtGvBuy.Rows.Remove(row);
        }

        List<reportInvoice> listReport;

        private void addCurrentInvoiceToPrint(string code)
        {
            DataSet ds = Helper.getDataSet("SELECT * FROM viewInvoice WHERE InvoiceCode = '" + code + "';");
            DataTable dt = ds.Tables[0];

            listReport = new List<reportInvoice>();

            for (int i=0;i<dt.Rows.Count;i++)
            {
                reportInvoice dataList = new reportInvoice();

                dataList.InvoiceCode = dt.Rows[i]["InvoiceCode"].ToString();
                dataList.ProCode = dt.Rows[i]["ProCode"].ToString();
                dataList.ProName = dt.Rows[i]["ProName"].ToString();
                dataList.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                dataList.Price = Convert.ToDouble(dt.Rows[i]["Price"].ToString());
                dataList.Amount = Convert.ToDouble(dt.Rows[i]["Amount"].ToString());
                dataList.Sellby = dt.Rows[i]["Sellby"].ToString();
                dataList.CustomerName = dt.Rows[i]["CustomerName"].ToString();
                dataList.Phone = dt.Rows[i]["Phone"].ToString();
                dataList.Address = dt.Rows[i]["Address"].ToString();
                dataList.Date = dt.Rows[i]["Date"].ToString();

                listReport.Add(dataList);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            addCurrentInvoiceToPrint(Helper.GetLastIdCode("Invoice"));
            new reportViewer(listReport,100).ShowDialog();
            btnPrint.Enabled = false;
        }
    }
}
