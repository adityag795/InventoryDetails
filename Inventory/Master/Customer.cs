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
    public partial class AddCustomer : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "")
            {
                using (con = new SqlConnection(Cstring))
                {
                    // CategoryId is an identity column and primary key.
                    string query = "INSERT INTO tblCustomer (CustomerName) VALUES ('" + txtCustomer.Text + "')";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    int rowsAdded = cmd.ExecuteNonQuery();
                    MessageBox.Show(Convert.ToString(rowsAdded) + " row added.");
                }
            }
            else
            {
                MessageBox.Show("Write Customer Name first.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblCustomer";
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgvCustomer.DataSource = dt;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(dgvCustomer.SelectedRows[0].Index));
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
