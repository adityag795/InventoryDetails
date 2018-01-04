using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory
{
    public partial class InvoiceGenerator : Form
    {
        public string mNo = "";
        public String dgIndex = "";
        SqlCommand cmd;
        SqlConnection con,con2;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        int x = 1;
        double Grandtotal = 0;
        public InvoiceGenerator()
        {
            InitializeComponent();
        }

        bool ValidateInput()
        {
            if (ddlSalesperson.Text == "----Select Salesperson----")
            {
                MessageBox.Show("Please choose a Sales Person.");
                return false;
            }
            if (ddlCustomer.Text == "----Select Customer----")
            {
                MessageBox.Show("Please choose a Customer.");
                return false;
            }
            if (ddlWarehouse.Text == "----Select Warehouse----")
            {
                MessageBox.Show("Please choose a Warehouse.");
                return false;
            }
            if (txtMobileNo.Text == "")
            {
                MessageBox.Show("Please enter Mobile Number.");
                return false;
            }
            if (!(dgvInvoice.RowCount > 1))
            {
                MessageBox.Show("Please select any items to buy.");
                return false;
            }
            return true;
        }

        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }

        //double randomNum()
        //{
        //    Random r = new Random();
        //    int rInt = r.Next(0, 100); //for ints
        //    int range = 100;
        //    double rDouble = r.NextDouble() * range;
        //    return rDouble;
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Cstring))
            {
                if (ddlBrand.Text != "----Select Brand----" && ddlCategory.Text != "----Select Category----")
                {
                    string query = "SELECT ItemId, ItemName, Price AS 'Unit Price', Description FROM tblItem WHERE Brand = '"
                        + ddlBrand.Text + "' AND Category = '" + ddlCategory.Text + "'";
                    //cmd = new SqlCommand(query, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    con.Open();
                    // Create a command builder to generate SQL update, insert, and
                    // delete commands based on selectCommand. These are used to
                    // update the database.
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    dgvItems.DataSource = table;
                }
                if (ddlBrand.Text != "----Select Brand----" && ddlCategory.Text == "----Select Category----")
                {
                    string query = "SELECT ItemId, ItemName, Price AS 'Unit Price', Description FROM tblItem WHERE Brand = '"
                        + ddlBrand.Text + "'";
                    //cmd = new SqlCommand(query, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    con.Open();
                    // Create a command builder to generate SQL update, insert, and
                    // delete commands based on selectCommand. These are used to
                    // update the database.
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    dgvItems.DataSource = table;
                }
                if (ddlBrand.Text == "----Select Brand----" && ddlCategory.Text != "----Select Category----")
                {
                    string query = "SELECT ItemId, ItemName, Price AS 'Unit Price', Description FROM tblItem WHERE Category = '"
                        + ddlCategory.Text + "'";
                    //cmd = new SqlCommand(query, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    con.Open();
                    // Create a command builder to generate SQL update, insert, and
                    // delete commands based on selectCommand. These are used to
                    // update the database.
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    dgvItems.DataSource = table;
                }
                if (ddlBrand.Text == "----Select Brand----" && ddlCategory.Text == "----Select Category----")
                {
                    string query = "SELECT ItemId, ItemName, Price AS 'Unit Price', Description FROM tblItem";
                    //cmd = new SqlCommand(query, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    con.Open();
                    // Create a command builder to generate SQL update, insert, and
                    // delete commands based on selectCommand. These are used to
                    // update the database.
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    // Populate a new data table and bind it to the BindingSource.
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    dgvItems.DataSource = table;
                }
            }
        }

        private void InvoiceGenerator_Load(object sender, EventArgs e)
        {
            InvoiceGenerator gh = new InvoiceGenerator();
            gh.Dispose();
            txtMobileNo.Text = dgIndex;
            txtInvoiceNo.Text = "IF" + Convert.ToString(RandomNumber());
            // TODO: This line of code loads data into the 'inventoryDataSet9.tblItem' table. You can move, or remove it, as needed.
            this.tblItemTableAdapter1.Fill(this.inventoryDataSet9.tblItem);
            // TODO: This line of code loads data into the 'inventoryDataSet8.tblWarehouse' table. You can move, or remove it, as needed.
            this.tblWarehouseTableAdapter.Fill(this.inventoryDataSet8.tblWarehouse);
            // TODO: This line of code loads data into the 'inventoryDataSet7.tblSalesPerson' table. You can move, or remove it, as needed.
            this.tblSalesPersonTableAdapter.Fill(this.inventoryDataSet7.tblSalesPerson);
            // TODO: This line of code loads data into the 'inventoryDataSet6.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.inventoryDataSet6.tblCustomer);
            // TODO: This line of code loads data into the 'inventoryDataSet5.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.inventoryDataSet5.tblCategory);
            // TODO: This line of code loads data into the 'inventoryDataSet4.tblBrand' table. You can move, or remove it, as needed.
            this.tblBrandTableAdapter.Fill(this.inventoryDataSet4.tblBrand);
            // TODO: This line of code loads data into the 'inventoryDataSet3.tblItem' table. You can move, or remove it, as needed.
            this.tblItemTableAdapter.Fill(this.inventoryDataSet3.tblItem);
            ddlBrand.Text = "----Select Brand----";
            ddlCategory.Text = "----Select Category----";
            ddlCustomer.Text = "----Select Customer----";
            ddlSalesperson.Text = "----Select Salesperson----";
            ddlWarehouse.Text = "----Select Warehouse----";
        }

        private void dgvItems_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SerialNo");
            dt.Columns.Add("ItemCode");
            dt.Columns.Add("Description");
            dt.Columns.Add("UnitPrice");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");

            DataRow row = dt.NewRow();
            row["SerialNo"] = "001";
            row["ItemCode"] = dgvItems.SelectedRows[0].Cells[0].Value.ToString();
            row["Description"] = dgvItems.SelectedRows[0].Cells[3].Value.ToString();
            row["UnitPrice"] = dgvItems.SelectedRows[0].Cells[2].Value.ToString();
            row["Quantity"] = "1";
            row["Total"] = (Convert.ToDouble(row["UnitPrice"]) * Convert.ToDouble(row["Quantity"])).ToString();
            dt.Rows.Add(row);

            foreach (DataRow Drow in dt.Rows)
            {
                int num = dgvInvoice.Rows.Add();
                dgvInvoice.Rows[num].Cells[0].Value = (x++).ToString();
                dgvInvoice.Rows[num].Cells[1].Value = Drow["ItemCode"].ToString();
                dgvInvoice.Rows[num].Cells[2].Value = Drow["Description"].ToString();
                dgvInvoice.Rows[num].Cells[3].Value = Drow["UnitPrice"].ToString();
                dgvInvoice.Rows[num].Cells[4].Value = Drow["Quantity"].ToString();
                dgvInvoice.Rows[num].Cells[5].Value = Drow["Total"].ToString();
                Grandtotal += Convert.ToDouble(dgvInvoice.Rows[num].Cells[5].Value);
                txtTotal.Text = Convert.ToString(Grandtotal);

                string query = "SELECT Warehouse FROM tblItem WHERE ItemId = '" + (string)dgvInvoice.Rows[num].Cells[1].Value + "'";
                using (con = new SqlConnection(Cstring))
                {
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    string warehouse = Convert.ToString(cmd.ExecuteScalar());
                    if (!(ddlWarehouse.Items.Contains(warehouse)))
                        ddlWarehouse.Items.Add(warehouse);
                }
            }
        }

        private void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT MobileNo FROM tblCustomer WHERE CustomerName = '" + (string)ddlCustomer.SelectedValue + "'";
            using (con = new SqlConnection(Cstring))
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                //string xyz = Convert.ToString(cmd.ExecuteReader());
                txtMobileNo.Text = Convert.ToString(cmd.ExecuteScalar());
            }
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            FindCustomer fc = new FindCustomer();
            fc.ShowDialog();
            int Cid = fc.CustomerId;
            string query = "SELECT CustomerName FROM tblCustomer WHERE CustomId = " + Cid;
            using (con = new SqlConnection(Cstring))
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                string name = Convert.ToString(cmd.ExecuteScalar());
                if (ddlCustomer.Items.Contains(name))
                {
                    int index = ddlCustomer.FindString(name);
                    ddlCustomer.SelectedItem = ddlCustomer.Items[index];
                }
                else
                    MessageBox.Show("Dropdown list does not contain the selected name.");
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                using (con2 = new SqlConnection(Cstring))
                {
                    SqlTransaction tran1;
                    SqlTransaction tran2;
                    using (con = new SqlConnection(Cstring))
                    {
                        string query = "INSERT INTO HInvoice (InvoiceNo, Salesperson, CustomerName, MobileNo, Warehouse, Time) VALUES ('"
                            + txtInvoiceNo.Text + "','" + ddlSalesperson.SelectedValue + "','" + ddlCustomer.SelectedValue
                            + "'," + Convert.ToDouble(txtMobileNo.Text) + ",'" + ddlWarehouse.Text + "',GETDATE())";

                        con.Open();
                        tran1 = con.BeginTransaction();
                        con2.Open();
                        tran2 = con2.BeginTransaction();
                        //cmd = new SqlCommand(query, con, tran);
                        try
                        {
                            SqlCommand cmx = new SqlCommand(query, con, tran1);
                            int headerRow = cmx.ExecuteNonQuery();
                            tran1.Commit();
                            //con.Close();
                            
                            int i;
                            for (i = 0; i < dgvInvoice.Rows.Count - 1; i++)
                            {
                                string StrQuery = @"INSERT INTO RInvoice (SerialNo,InvoiceNo,ItemCode,Description,UnitPrice,Quantity,Total,Time) VALUES ("
                                + dgvInvoice.Rows[i].Cells["SerialNo"].Value + ", '"
                                + txtInvoiceNo.Text + "', "
                                + dgvInvoice.Rows[i].Cells["ItemCode"].Value + ", '"
                                + dgvInvoice.Rows[i].Cells["Description"].Value + "', "
                                + Convert.ToDouble(dgvInvoice.Rows[i].Cells["UnitPrice"].Value) + ", "
                                + Convert.ToInt32(dgvInvoice.Rows[i].Cells["Quantity"].Value) + ", "
                                + Convert.ToDouble(dgvInvoice.Rows[i].Cells["Total"].Value) + ", "
                                + "GETDATE() );";

                                SqlCommand cmd4 = new SqlCommand(StrQuery, con2, tran2);
                                //cmd4.CommandText = StrQuery;
                                cmd4.ExecuteNonQuery();
                                

                                string getStock = "SELECT Stock FROM tblItem WHERE ItemId = " + dgvInvoice.Rows[i].Cells["ItemCode"].Value;
                                SqlCommand cmd2 = new SqlCommand(getStock, con);
                                int stock = Convert.ToInt32(cmd2.ExecuteScalar());
                                stock -= Convert.ToInt32(dgvInvoice.Rows[i].Cells["Quantity"].Value);

                                if (stock <= 0)
                                    throw new StockOutException("Not enough stock in warehouse.");
                                string update = "UPDATE tblItem SET Stock = " + stock + " WHERE ItemId = " + dgvInvoice.Rows[i].Cells["ItemCode"].Value;
                                SqlCommand cmd3 = new SqlCommand(update, con);
                                cmd3.ExecuteNonQuery();
                            }
                            tran2.Commit();
                            MessageBox.Show(headerRow + " Invoice Header and " + ((int)i) + " Invoice Rows added.");
                        }
                        catch (StockOutException se)
                        {
                            MessageBox.Show(se.Message);
                            try
                            {
                                tran1.Rollback();
                                tran2.Rollback();
                            }
                            catch (Exception exRollback)
                            {
                                Console.WriteLine(exRollback.Message);
                            }
                            //throw;
                        }
                    }
                }
            }
        }

        private void btnFindInvoice_Click(object sender, EventArgs e)
        {
            dgvInvoice.Rows.Clear();
            FindInvoice lob = new FindInvoice();

            lob.MdiParent = this.MdiParent;
            //this.Enabled = false;
            lob.ShowDialog();
            string InvoiceNum = lob.InvoiceNum;

            this.Enabled = true;

            if (InvoiceNum != "")
            {
                using (con = new SqlConnection(Cstring))
                {
                    string query = "SELECT InvoiceNo,Salesperson,MobileNo,CustomerName,Warehouse FROM HInvoice WHERE InvoiceNo = '"
                                  + InvoiceNum + "'";
                    string query2 = "SELECT SerialNo,ItemCode,Description,UnitPrice,Quantity,Total FROM RInvoice WHERE "
                                  + "InvoiceNo = '" + InvoiceNum + "'";
                    string query3 = "SELECT count(*) FROM RInvoice where InvoiceNo = '" + InvoiceNum + "'";

                    SqlDataReader dr = null;
                    con.Open();
                    try
                    {
                        cmd = new SqlCommand(query, con);

                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txtInvoiceNo.Text = dr["InvoiceNo"].ToString();
                            ddlSalesperson.Text = dr["Salesperson"].ToString();
                            ddlCustomer.Text = dr["CustomerName"].ToString();
                            txtMobileNo.Text = dr["MobileNo"].ToString();
                            ddlWarehouse.Text = dr["Warehouse"].ToString();
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        if (dr != null)
                            dr.Close();
                        if (con != null)
                            con.Close();
                    }
                    try
                    {
                        SqlConnection con2 = new SqlConnection(Cstring);
                        cmd = new SqlCommand(query2, con2);
                        con2.Open();
                        dr = cmd.ExecuteReader();
                        // Count no. of items in this list.
                        int rowcount;
                        using (SqlConnection con3 = new SqlConnection(Cstring))
                        {
                            SqlCommand cmd4 = new SqlCommand(query3, con3);
                            con3.Open();
                            rowcount = Convert.ToInt32(cmd4.ExecuteScalar());
                        }

                        DataTable dt = new DataTable();
                        
                        dt.Columns.Add("SerialNo");
                        dt.Columns.Add("ItemCode");
                        dt.Columns.Add("Description");
                        dt.Columns.Add("UnitPrice");
                        dt.Columns.Add("Quantity");
                        dt.Columns.Add("Total");
                        
                        while (dr.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["SerialNo"] = dr["SerialNo"].ToString();
                            row["ItemCode"] = dr["ItemCode"].ToString();
                            row["Description"] = dr["Description"].ToString();
                            row["UnitPrice"] = dr["UnitPrice"].ToString();
                            row["Quantity"] = dr["Quantity"].ToString();
                            row["Total"] = dr["Total"].ToString();
                            dt.Rows.Add(row);
                        }

                        for (int num = 0; num < rowcount; num++)
                        {
                            dgvInvoice.Rows.Add();
                            dgvInvoice.Rows[num].Cells[0].Value = dt.Rows[num]["SerialNo"].ToString();
                            dgvInvoice.Rows[num].Cells[1].Value = dt.Rows[num]["ItemCode"].ToString();
                            dgvInvoice.Rows[num].Cells[2].Value = dt.Rows[num]["Description"].ToString();
                            dgvInvoice.Rows[num].Cells[3].Value = dt.Rows[num]["UnitPrice"].ToString();
                            dgvInvoice.Rows[num].Cells[4].Value = dt.Rows[num]["Quantity"].ToString();
                            dgvInvoice.Rows[num].Cells[5].Value = dt.Rows[num]["Total"].ToString();
                        }
                        //dgvInvoice.DataSource = dt;
                        //dgvInvoice.Rows[0].Cells[0].Value = 

                        con2.Close();
                        //dt.Close();
                    }
                    catch (Exception ex)
                    {
                        if (dr != null)
                            dr.Close();
                        if (con != null)
                            con.Close();
                    }
                }
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtInvoiceNo.Text = "IF" + Convert.ToString(RandomNumber());
            txtMobileNo.Text = "";
            ddlBrand.Text = "----Select Brand----";
            ddlCategory.Text = "----Select Category----";
            ddlCustomer.Text = "----Select Customer----";
            ddlSalesperson.Text = "----Select Salesperson----";
            ddlWarehouse.Text = "----Select Warehouse----";

            dgvItems.DataSource = null;
            dgvItems.Refresh();

            dgvInvoice.Rows.Clear();
            dgvInvoice.Refresh();
            
            /*
            AddCustomer ac = new AddCustomer();
            ac.MdiParent = this.MdiParent;
            ac.ShowDialog();
            //string name = ac.name;
            //ddlCustomer.Items.Add(name);
            ddlCustomer.DataSource = tblCustomerBindingSource;
           //  ddlCustomer.Refresh();
           // ddlCustomer.DataBindings.R
           // ddlCustomer.ResetText();
             */
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // int a = Convert.ToInt32( dgvInvoice.Rows[1].Cells[4].Value);
            // dgvInvoice r1 = SelectedRows.ce;
            int selectedRowIndex = dgvInvoice.SelectedCells[0].RowIndex;
            // DataGridViewRow selectedRow = dgvInvoice.Rows[selectedRowIndex];
            int qty = Convert.ToInt32(dgvInvoice.Rows[selectedRowIndex].Cells[4].Value);
        }

        private void dgvInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvInvoice.SelectedCells[0].RowIndex;
            int qty = Convert.ToInt32(dgvInvoice.Rows[selectedRowIndex].Cells[4].Value);
            double ex = Convert.ToDouble(dgvInvoice.Rows[selectedRowIndex].Cells[5].Value);
            dgvInvoice.Rows[selectedRowIndex].Cells[5].Value = Convert.ToDouble(dgvInvoice.Rows[selectedRowIndex].Cells[3].Value) * Convert.ToDouble(qty);
            Grandtotal = Grandtotal - ex + Convert.ToDouble(dgvInvoice.Rows[selectedRowIndex].Cells[5].Value);
            txtTotal.Text = Convert.ToString(Grandtotal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.CurrentCell != null)
            {
                int selectedRowIndex = dgvInvoice.CurrentCell.RowIndex;
                double ex = Convert.ToDouble(dgvInvoice.Rows[selectedRowIndex].Cells[5].Value);
                Grandtotal = Grandtotal - ex;
                txtTotal.Text = Convert.ToString(Grandtotal);
                dgvInvoice.Rows.RemoveAt(selectedRowIndex);
                x--;
            }
        }

        //private void dgvInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    dgvInvoice.Rows[e.RowIndex].Cells[CC.5].Value = (Convert.ToDouble(dgvInvoice.Rows[e.RowIndex].Cells[CC.3].Value) * Convert.ToDouble(dgvInvoice.Rows[e.RowIndex].Cells[CC.4].Value)).ToString();
        //}
    }
    public class StockOutException : Exception
    {
        public StockOutException() : base() { }
        public StockOutException(string message)
            : base(message)
        {
        }
    }
}
