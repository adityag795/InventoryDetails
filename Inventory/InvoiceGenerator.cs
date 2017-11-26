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
                    string query = "SELECT ItemName, Price AS 'Unit Price', Description FROM tblItem WHERE Brand = '" 
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
                    string query = "SELECT ItemName, Price AS 'Unit Price', Description FROM tblItem WHERE Brand = '"
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
                    string query = "SELECT ItemName, Price AS 'Unit Price', Description FROM tblItem WHERE Category = '"
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
                    string query = "SELECT ItemName, Price AS 'Unit Price', Description FROM tblItem";
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
            // TODO: This line of code loads data into the 'inventoryDataSet5.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.inventoryDataSet5.tblCategory);
            // TODO: This line of code loads data into the 'inventoryDataSet4.tblBrand' table. You can move, or remove it, as needed.
            this.tblBrandTableAdapter.Fill(this.inventoryDataSet4.tblBrand);
            // TODO: This line of code loads data into the 'inventoryDataSet3.tblItem' table. You can move, or remove it, as needed.
            this.tblItemTableAdapter.Fill(this.inventoryDataSet3.tblItem);
            ddlBrand.Text = "----Select Brand----";
            ddlCategory.Text = "----Select Category----";
        }
    }
}
