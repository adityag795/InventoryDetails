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

        public FindInvoice()
        {
            InitializeComponent();
        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
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
}
