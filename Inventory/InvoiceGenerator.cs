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
        public string mNo="";
        public String dgIndex = "";
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        int x = 1;
        double Grandtotal = 0;
        public InvoiceGenerator()
        {
            InitializeComponent();
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
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Cstring))
            {
                string query = "INSERT INTO HInvoice (InvoiceNo, Salesperson, CustomerName, MobileNo, Warehouse, Time) VALUES ('" 
                    + txtInvoiceNo.Text + "','" + ddlSalesperson.SelectedValue + "','" + ddlCustomer.SelectedValue 
                    + "'," + Convert.ToDouble(txtMobileNo.Text) + ",'" + ddlWarehouse.Text + "',GETDATE())";

                cmd = new SqlCommand(query, con);
                con.Open();
                int headerRow = cmd.ExecuteNonQuery();
                MessageBox.Show(headerRow + " row added.");
                con.Close();
                con.Open();
                int i;
                for(i = 0; i < dgvInvoice.Rows.Count-1; i++)
                {
                    string StrQuery = @"INSERT INTO RInvoice (SerialNo,ItemCode,Description,UnitPrice,Quantity,Total,Time) VALUES ("
                        + dgvInvoice.Rows[i].Cells["SerialNo"].Value + ", "
                        + dgvInvoice.Rows[i].Cells["ItemCode"].Value + ", '"
                        + dgvInvoice.Rows[i].Cells["Description"].Value + "', "
                        + Convert.ToDouble(dgvInvoice.Rows[i].Cells["UnitPrice"].Value) + ", "
                        + Convert.ToInt32(dgvInvoice.Rows[i].Cells["Quantity"].Value) + ", "
                        + Convert.ToDouble(dgvInvoice.Rows[i].Cells["Total"].Value) + ", "
                        + "GETDATE() );";

                    SqlCommand cmd4 = new SqlCommand(StrQuery, con);
                    //cmd4.CommandText = StrQuery;
                    cmd4.ExecuteNonQuery();

                    string getStock = "SELECT Stock FROM tblItem WHERE ItemId = " + dgvInvoice.Rows[i].Cells["ItemCode"].Value;
                    SqlCommand cmd2 = new SqlCommand(getStock, con);
                    int stock = Convert.ToInt32(cmd2.ExecuteScalar());
                    stock -= Convert.ToInt32(dgvInvoice.Rows[i].Cells["Quantity"].Value);
                    
                    string update = "UPDATE tblItem SET Stock = " + stock + " WHERE ItemId = " + dgvInvoice.Rows[i].Cells["ItemCode"].Value;
                    SqlCommand cmd3 = new SqlCommand(update, con);
                    cmd3.ExecuteNonQuery();
                }
            }
        }

        private void btnFindInvoice_Click(object sender, EventArgs e)
        {
            FindInvoice fi = new FindInvoice();
            fi.ShowDialog();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {

        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // int a = Convert.ToInt32( dgvInvoice.Rows[1].Cells[4].Value);
            // dgvInvoice r1 = SelectedRows.ce;
            int selectedRowIndex = dgvInvoice.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvInvoice.Rows[selectedRowIndex];
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

        // Update Grand Total when rows are deleted
        private void dgvInvoice_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            /*
            int selectedRowIndex = dgvInvoice.SelectedCells[0].RowIndex;
            double ex = Convert.ToDouble(dgvInvoice.Rows[selectedRowIndex].Cells[5].Value);
            Grandtotal = Grandtotal - ex;
            txtTotal.Text = Convert.ToString(Grandtotal);
            */
        }
        
        //private void dgvInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    dgvInvoice.Rows[e.RowIndex].Cells[CC.5].Value = (Convert.ToDouble(dgvInvoice.Rows[e.RowIndex].Cells[CC.3].Value) * Convert.ToDouble(dgvInvoice.Rows[e.RowIndex].Cells[CC.4].Value)).ToString();
        //}


    }
}
