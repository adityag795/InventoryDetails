using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class HomeMenu : Form
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void categoryAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBrand ct = new AddBrand();
            ct.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoryBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory ct = new AddCategory();
            ct.ShowDialog();
        }

        private void categoryCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem ct = new AddItem();
            ct.ShowDialog();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderSummary ct = new OrderSummary();
            ct.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.ShowDialog();
        }

        private void wareHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWarehouse aw = new AddWarehouse();
            aw.ShowDialog();
        }

        private void salesPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesPerson sp = new SalesPerson();
            sp.ShowDialog();
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tax tx = new Tax();
            tx.ShowDialog();
        }
    }
}
