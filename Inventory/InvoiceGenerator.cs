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
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        int x = 1;
        public InvoiceGenerator()
        {
            InitializeComponent();
        }

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
            }
        }
        
        //private void dgvInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    dgvInvoice.Rows[e.RowIndex].Cells[CC.5].Value = (Convert.ToDouble(dgvInvoice.Rows[e.RowIndex].Cells[CC.3].Value) * Convert.ToDouble(dgvInvoice.Rows[e.RowIndex].Cells[CC.4].Value)).ToString();
        //}


    }
}
