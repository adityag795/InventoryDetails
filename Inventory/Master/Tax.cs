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
    public partial class Tax : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public Tax()
        {
            InitializeComponent();
        }

        private void Tax_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet2.tblTax' table. You can move, or remove it, as needed.
            this.tblTaxTableAdapter.Fill(this.inventoryDataSet2.tblTax);

        }

        bool validateInput()
        {
            if (String.IsNullOrEmpty(txtTaxName.Text))
            {
                MessageBox.Show("Please enter Tax Name.");
                return false;
            }
            if (String.IsNullOrEmpty(txtTax.Text))
            {
                MessageBox.Show("Please enter Tax %.");
                return false;
            }
            return true;
        }

        private void btnAddTax_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                using (con = new SqlConnection(Cstring))
                {
                    string query = "INSERT INTO tblTax (taxName, tax) VALUES ('" + txtTaxName.Text + "', '" + txtTax.Text + "')";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    int rowsAdded = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAdded + " row added.");
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblTax";
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgvTax.DataSource = dt;
        }


    }
}
