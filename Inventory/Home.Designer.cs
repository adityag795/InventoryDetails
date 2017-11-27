namespace Inventory
{
    partial class HomeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wareHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.generateInvoiceToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryAToolStripMenuItem,
            this.categoryBToolStripMenuItem,
            this.categoryCToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.wareHouseToolStripMenuItem,
            this.salesPersonToolStripMenuItem,
            this.taxToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 11F);
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // categoryAToolStripMenuItem
            // 
            this.categoryAToolStripMenuItem.Name = "categoryAToolStripMenuItem";
            this.categoryAToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.categoryAToolStripMenuItem.Text = "Brand";
            this.categoryAToolStripMenuItem.Click += new System.EventHandler(this.categoryAToolStripMenuItem_Click);
            // 
            // categoryBToolStripMenuItem
            // 
            this.categoryBToolStripMenuItem.Name = "categoryBToolStripMenuItem";
            this.categoryBToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.categoryBToolStripMenuItem.Text = "Category";
            this.categoryBToolStripMenuItem.Click += new System.EventHandler(this.categoryBToolStripMenuItem_Click);
            // 
            // categoryCToolStripMenuItem
            // 
            this.categoryCToolStripMenuItem.Name = "categoryCToolStripMenuItem";
            this.categoryCToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.categoryCToolStripMenuItem.Text = "Item";
            this.categoryCToolStripMenuItem.Click += new System.EventHandler(this.categoryCToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // wareHouseToolStripMenuItem
            // 
            this.wareHouseToolStripMenuItem.Name = "wareHouseToolStripMenuItem";
            this.wareHouseToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.wareHouseToolStripMenuItem.Text = "Warehouse";
            this.wareHouseToolStripMenuItem.Click += new System.EventHandler(this.wareHouseToolStripMenuItem_Click);
            // 
            // salesPersonToolStripMenuItem
            // 
            this.salesPersonToolStripMenuItem.Name = "salesPersonToolStripMenuItem";
            this.salesPersonToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.salesPersonToolStripMenuItem.Text = "Sales Person";
            this.salesPersonToolStripMenuItem.Click += new System.EventHandler(this.salesPersonToolStripMenuItem_Click);
            // 
            // taxToolStripMenuItem
            // 
            this.taxToolStripMenuItem.Name = "taxToolStripMenuItem";
            this.taxToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.taxToolStripMenuItem.Text = "Tax";
            this.taxToolStripMenuItem.Click += new System.EventHandler(this.taxToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrdersToolStripMenuItem,
            this.orderStatusToolStripMenuItem,
            this.billsToolStripMenuItem});
            this.ordersToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 11F);
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // addOrdersToolStripMenuItem
            // 
            this.addOrdersToolStripMenuItem.Name = "addOrdersToolStripMenuItem";
            this.addOrdersToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.addOrdersToolStripMenuItem.Text = "Add Orders";
            // 
            // orderStatusToolStripMenuItem
            // 
            this.orderStatusToolStripMenuItem.Name = "orderStatusToolStripMenuItem";
            this.orderStatusToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.orderStatusToolStripMenuItem.Text = "Order Status";
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.billsToolStripMenuItem.Text = "Order Summary";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 11F);
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogueToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
            this.detailsToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 11F);
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // catalogueToolStripMenuItem
            // 
            this.catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            this.catalogueToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.catalogueToolStripMenuItem.Text = "Catalogue";
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 11F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 11F);
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.generateInvoiceToolStripMenuItem.Text = "Generate Invoice";
            this.generateInvoiceToolStripMenuItem.Click += new System.EventHandler(this.generateInvoiceToolStripMenuItem_Click);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 502);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wareHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
    }
}

