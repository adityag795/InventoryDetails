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
        public FindCustomer()
        {
            InitializeComponent();
        }

        private void FindCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet10.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.inventoryDataSet10.tblCustomer);

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }
               
    }
}
