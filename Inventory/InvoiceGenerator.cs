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

        }
    }
}
