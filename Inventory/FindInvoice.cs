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
    public partial class FindInvoice : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        public string InvoiceNum = "";
        public FindInvoice()
        {
            InitializeComponent();
            txtInvoice.Text = "-----Enter Invoice Number-----";
        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtInvoice.Text)) && txtInvoice.Text != "-----Enter Invoice Number-----")
            {
                string query = "SELECT * FROM HInvoice WHERE InvoiceNo LIKE '%" + txtInvoice.Text + "%'";
                con = new SqlConnection(Cstring);
                cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                dgvInvoice.DataSource = dt;
            }
        }

        private void txtInvoice_Click(object sender, EventArgs e)
        {
            txtInvoice.Text = "";
        }

        private void txtInvoice_Leave(object sender, EventArgs e)
        {
            if (txtInvoice.Text == "")
                txtInvoice.Text = "-----Enter Invoice Number-----";
        }

        private void FindInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet13.HInvoice' table. You can move, or remove it, as needed.
            this.hInvoiceTableAdapter.Fill(this.inventoryDataSet13.HInvoice);
        }

        private void dgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedRowIndex = dgvInvoice.SelectedCells[0].RowIndex;
            InvoiceNum = Convert.ToString(dgvInvoice.SelectedCells[1].Value);
            this.Close();
        }
    }
}
