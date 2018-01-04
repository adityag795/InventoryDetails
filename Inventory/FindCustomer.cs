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
    public partial class FindCustomer : Form
    {
        public static string mobileNo = "";
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        public int CustomerId;
        public FindCustomer()
        {
            InitializeComponent();
            txtCustomer.Text = "-----Enter Customer's Name or Mobile Number-----";
        }

        private void FindCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet12.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter1.Fill(this.inventoryDataSet12.tblCustomer);
            // TODO: This line of code loads data into the 'inventoryDataSet10.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.inventoryDataSet10.tblCustomer);
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtCustomer.Text)) && txtCustomer.Text != "-----Enter Customer's Name or Mobile Number-----")
            {
                using (con = new SqlConnection(Cstring))
                {
                    long n;
                    bool isNumeric = long.TryParse(txtCustomer.Text, out n);

                    if (isNumeric)
                    {
                        string query = "SELECT * FROM tblCustomer WHERE MobileNo = " + n;
                        con = new SqlConnection(Cstring);
                        cmd = new SqlCommand(query, con);
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(query, con);
                        da.Fill(dt);
                        dgvCustomer.DataSource = dt;
                    }
                    else
                    {
                        string query = "SELECT * FROM tblCustomer WHERE CustomerName LIKE '%" + txtCustomer.Text 
                            + "%'";
                        con = new SqlConnection(Cstring);
                        cmd = new SqlCommand(query, con);
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(query, con);
                        da.Fill(dt);
                        dgvCustomer.DataSource = dt;
                    }
                }
            }
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            g1 = new InvoiceGenerator();
            selectedRowIndex = dgvCustomer.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCustomer.Rows[selectedRowIndex];
           // int a1 = Convert.ToInt32(dgvCustomer.Rows[selectedRowIndex].Cells[4].Value);
            mobileNo = dgvCustomer.Rows[selectedRowIndex].Cells[2].Value.ToString();
            g1.mNo = mobileNo;
            g1.dgIndex = Convert.ToString(selectedRowIndex);
            g1.Dispose();
            */
            CustomerId = Convert.ToInt32(dgvCustomer.SelectedCells[0].Value);
            this.Close();
        }

        private void txtCustomer_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = "";
        }

        private void txtCustomer_Leave(object sender, EventArgs e)
        {
            if (txtCustomer.Text == "")
                txtCustomer.Text = "-----Enter Customer's Name or Mobile Number-----";
        }

    }
}
