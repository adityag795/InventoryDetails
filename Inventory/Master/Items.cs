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
    public partial class AddItem : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet1.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.inventoryDataSet1.tblCategory);
            // TODO: This line of code loads data into the 'inventoryDataSet.tblBrand' table. You can move, or remove it, as needed.
            this.tblBrandTableAdapter.Fill(this.inventoryDataSet.tblBrand);
            ddlBrandName.Text = "-----Select Brand-----";
            ddlCategoryName.Text = "-----Select Category-----";
        }

        bool ValidateInput()
        {
            if (ddlBrandName.Text == "-----Select Brand-----")
            {
                MessageBox.Show("Please select any Brand.");
                return false;
            }
            if (ddlCategoryName.Text == "-----Select Category-----")
            {
                MessageBox.Show("Please select any Category.");
                return false;
            }
            if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter any Item Name.");
                return false;
            }
            return true;
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            using (con = new SqlConnection(Cstring))
            {
                cmd = new SqlCommand("spAddItems", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@brandName", ddlBrandName.SelectedValue);
                cmd.Parameters.AddWithValue("@categoryName", ddlCategoryName.SelectedValue);
                cmd.Parameters.AddWithValue("@item", txtItem.Text);
                cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(txtPrice.Text));
                con.Open();

                // Output parameter
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@id";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
                
                int rowsAdded = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAdded.ToString() + " rows added.");
                ddlBrandName.Text = "-----Select Brand-----";
                ddlCategoryName.Text = "-----Select Category-----";
                txtItem.Text = txtPrice.Text = "";
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblItem";
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgvItems.DataSource = dt;
        }
    }
}
