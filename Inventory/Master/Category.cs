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
    public partial class AddCategory : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "")
            {
                using (con = new SqlConnection(Cstring))
                {
                    // CategoryId is an identity column and primary key.
                    string query = "INSERT INTO tblCategory (CategoryName) VALUES ('" + txtCategory.Text + "')";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    int rowsAdded = cmd.ExecuteNonQuery();
                    MessageBox.Show(Convert.ToString(rowsAdded) + " row added.");
                }
            }
            else
            {
                MessageBox.Show("Write a Category Name first.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblCategory";
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgvCategory.DataSource = dt;
        }
    }
}
