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
    public partial class AddWarehouse : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public AddWarehouse()
        {
            InitializeComponent();
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            if (txtWarehouse.Text != "")
            {
                using (con = new SqlConnection(Cstring))
                {
                    // BrandId is an identity column and primary key.
                    string query = "INSERT INTO tblWarehouse (WarehouseName) VALUES ('" + txtWarehouse.Text + "')";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    int rowsAdded = cmd.ExecuteNonQuery();
                    MessageBox.Show(Convert.ToString(rowsAdded) + " row added.");
                }
            }
            else
            {
                MessageBox.Show("Please enter any Warehouse Name.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblWarehouse";
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgvWarehouse.DataSource = dt;
        }
    }
}
