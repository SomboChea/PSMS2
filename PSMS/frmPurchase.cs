using MetroFramework;
using MetroFramework.Forms;
using PSMS.Class;
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
            try
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
            catch (Exception) { }
        }


        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();

        }
        void filterModel()
        {
            try
            {
                string modelValue = this.modelComboBox.SelectedValue.ToString();
                int value;
                if (int.TryParse(modelValue, out value))
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE MID=@MID;", Connection.con);
                    cmd.Parameters.AddWithValue("@MID", this.modelComboBox.SelectedValue.ToString());
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);

                    PurchaseDetailDataGridView.DataSource = ds.Tables[0];

                    adapt.Dispose();
                    cmd.Dispose();
                }
            }
            catch (Exception) { }
        }
        private void binddatagridview()
        {
            try
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
                        MessageBox.Show("Please select product!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input number!");
                }
            }
            catch (Exception) { }

        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchaseDetail._PurchaseDetail' table. You can move, or remove it, as needed.
            //this.purchaseDetailTableAdapter.Fill(this.purchaseDetail._PurchaseDetail);
            // TODO: This line of code loads data into the 'empDataSet.Employee' table. You can move, or remove it, as needed.
            employeeTableAdapter.Fill(empDataSet.Employee);

            // TODO: This line of code loads data into the 'supplierDataSet.Supplier' table. You can move, or remove it, as needed.
            supplierTableAdapter.Fill(supplierDataSet.Supplier);

            // TODO: This line of code loads data into the 'supplierDataSet.Supplier' table. You can move, or remove it, as needed.
            supplierTableAdapter.Fill(supplierDataSet.Supplier);
                      

        }

        private void supplierBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            supplierBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(supplierDataSet);

        }

        private void supplierBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            Validate();
            supplierBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(supplierDataSet);

        }

        private void frmPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //frmMain frmM = new frmMain();
            //frmM.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            binddatagridview();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterModel();
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
            try
            {
                float balance = 0;

                float payment = Helper.ifnull(paymentLabel1.Text) ? 0 :float.Parse(paymentLabel1.Text);
                float totalPirce = Helper.ifnull(totalPriceLabel1.Text) ? 0 : float.Parse(totalPriceLabel1.Text);

                if (dtGvBuy.Rows.Count == 0)
                {
                    MessageBox.Show("Please select and buy product before you purchase!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Purchase (Date,Payment,Balance,SuID,EmpID,Total) VALUES (@Date,@Payment,@Balance,@SuID,@EmpID,@Total);", Connection.con);

                    //cmd.Parameters.AddWithValue("@InvoiceCode", "U000002");
                    cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateDateTimePicker.Text));
                    cmd.Parameters.AddWithValue("@Payment", paymentLabel1.Text);

                    cmd.Parameters.AddWithValue("@SuID", suIDComboBox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EmpID", empIDComboBox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Total", totalPriceLabel1.Text);

                    List<StructPurchaseDetail> purchaseDetail = new List<StructPurchaseDetail>(); 

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO PurchaseDetail ( PID, Quantity, Unitprice, Saleprice, Amount) VALUES ( @PID, @Quantity, @Unitprice, @Saleprice,@Amount)", Connection.con);

                    foreach (DataGridViewRow row in dtGvBuy.Rows)
                    {
                        StructPurchaseDetail data = new StructPurchaseDetail();
                        cmd3.Parameters.AddWithValue("@PID", row.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@Quantity", row.Cells[4].Value);
                        cmd3.Parameters.AddWithValue("@Unitprice", row.Cells[5].Value);
                        cmd3.Parameters.AddWithValue("@Saleprice", row.Cells[6].Value);

                        //Get total amount
                        float total = Convert.ToInt32(row.Cells[4].Value) * Convert.ToInt32(row.Cells[5].Value);
                        cmd3.Parameters.AddWithValue("@Amount", total);
                        balance = totalPirce - payment;
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        
                        cmd3.ExecuteNonQuery();

                        //Update Stock
                        SqlCommand cmd5 = new SqlCommand("UPDATE Product SET Quantity = Quantity + @Quantity Where PID=@PID ", Connection.con);
                        cmd5.Parameters.AddWithValue("@Quantity", row.Cells[4].Value);
                        cmd5.Parameters.AddWithValue("@PID", row.Cells[0].Value);
                        cmd5.ExecuteNonQuery();

                        BalanceLabel.Text = balance.ToString();
                    }

                    cmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, "New Purchase Save", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            catch(Exception) { }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmPurchaseDetail frmPude = new frmPurchaseDetail();
            frmPude.ShowDialog();
        }
    }
}
