namespace Inventory
{
    partial class InvoiceGenerator
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet5 = new Inventory.InventoryDataSet5();
            this.ddlBrand = new System.Windows.Forms.ComboBox();
            this.tblBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet4 = new Inventory.InventoryDataSet4();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddlWarehouse = new System.Windows.Forms.ComboBox();
            this.tblWarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet8 = new Inventory.InventoryDataSet8();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.btnFindInvoice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlSalesperson = new System.Windows.Forms.ComboBox();
            this.tblSalesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet7 = new Inventory.InventoryDataSet7();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.ddlCustomer = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet6 = new Inventory.InventoryDataSet6();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDataSet3 = new Inventory.InventoryDataSet3();
            this.tblItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblItemTableAdapter = new Inventory.InventoryDataSet3TableAdapters.tblItemTableAdapter();
            this.tblBrandTableAdapter = new Inventory.InventoryDataSet4TableAdapters.tblBrandTableAdapter();
            this.tblCategoryTableAdapter = new Inventory.InventoryDataSet5TableAdapters.tblCategoryTableAdapter();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tblCustomerTableAdapter = new Inventory.InventoryDataSet6TableAdapters.tblCustomerTableAdapter();
            this.tblSalesPersonTableAdapter = new Inventory.InventoryDataSet7TableAdapters.tblSalesPersonTableAdapter();
            this.tblWarehouseTableAdapter = new Inventory.InventoryDataSet8TableAdapters.tblWarehouseTableAdapter();
            this.inventoryDataSet9 = new Inventory.InventoryDataSet9();
            this.tblItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblItemTableAdapter1 = new Inventory.InventoryDataSet9TableAdapters.tblItemTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblWarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.ddlCategory);
            this.panel1.Controls.Add(this.ddlBrand);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 164);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(144, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ddlCategory
            // 
            this.ddlCategory.DataSource = this.tblCategoryBindingSource;
            this.ddlCategory.DisplayMember = "CategoryName";
            this.ddlCategory.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(70, 64);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(219, 35);
            this.ddlCategory.TabIndex = 1;
            this.ddlCategory.ValueMember = "CategoryName";
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.inventoryDataSet5;
            // 
            // inventoryDataSet5
            // 
            this.inventoryDataSet5.DataSetName = "InventoryDataSet5";
            this.inventoryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ddlBrand
            // 
            this.ddlBrand.DataSource = this.tblBrandBindingSource;
            this.ddlBrand.DisplayMember = "BrandName";
            this.ddlBrand.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlBrand.FormattingEnabled = true;
            this.ddlBrand.Location = new System.Drawing.Point(70, 12);
            this.ddlBrand.Name = "ddlBrand";
            this.ddlBrand.Size = new System.Drawing.Size(219, 35);
            this.ddlBrand.TabIndex = 0;
            this.ddlBrand.ValueMember = "BrandName";
            // 
            // tblBrandBindingSource
            // 
            this.tblBrandBindingSource.DataMember = "tblBrand";
            this.tblBrandBindingSource.DataSource = this.inventoryDataSet4;
            // 
            // inventoryDataSet4
            // 
            this.inventoryDataSet4.DataSetName = "InventoryDataSet4";
            this.inventoryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvItems
            // 
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(13, 197);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(382, 248);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.Click += new System.EventHandler(this.dgvItems_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.ddlWarehouse);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Controls.Add(this.btnFindCustomer);
            this.panel2.Controls.Add(this.btnFindInvoice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMobileNo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ddlSalesperson);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnNewCustomer);
            this.panel2.Controls.Add(this.ddlCustomer);
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(414, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 164);
            this.panel2.TabIndex = 1;
            // 
            // ddlWarehouse
            // 
            this.ddlWarehouse.DataSource = this.tblWarehouseBindingSource;
            this.ddlWarehouse.DisplayMember = "WarehouseName";
            this.ddlWarehouse.Font = new System.Drawing.Font("Dubai Medium", 12F);
            this.ddlWarehouse.FormattingEnabled = true;
            this.ddlWarehouse.Location = new System.Drawing.Point(414, 106);
            this.ddlWarehouse.Name = "ddlWarehouse";
            this.ddlWarehouse.Size = new System.Drawing.Size(168, 35);
            this.ddlWarehouse.TabIndex = 13;
            this.ddlWarehouse.ValueMember = "WarehouseName";
            // 
            // tblWarehouseBindingSource
            // 
            this.tblWarehouseBindingSource.DataMember = "tblWarehouse";
            this.tblWarehouseBindingSource.DataSource = this.inventoryDataSet8;
            // 
            // inventoryDataSet8
            // 
            this.inventoryDataSet8.DataSetName = "InventoryDataSet8";
            this.inventoryDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(319, 62);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(77, 27);
            this.lblCustomer.TabIndex = 12;
            this.lblCustomer.Text = "Customer";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustomer.Location = new System.Drawing.Point(607, 55);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(141, 32);
            this.btnFindCustomer.TabIndex = 11;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // btnFindInvoice
            // 
            this.btnFindInvoice.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInvoice.Location = new System.Drawing.Point(413, 12);
            this.btnFindInvoice.Name = "btnFindInvoice";
            this.btnFindInvoice.Size = new System.Drawing.Size(169, 32);
            this.btnFindInvoice.TabIndex = 10;
            this.btnFindInvoice.Text = "Find Invoice";
            this.btnFindInvoice.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Warehouse";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Dubai Medium", 12F);
            this.txtMobileNo.Location = new System.Drawing.Point(118, 103);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(183, 35);
            this.txtMobileNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile No.:";
            // 
            // ddlSalesperson
            // 
            this.ddlSalesperson.DataSource = this.tblSalesPersonBindingSource;
            this.ddlSalesperson.DisplayMember = "SalesPersonName";
            this.ddlSalesperson.Font = new System.Drawing.Font("Dubai Medium", 12F);
            this.ddlSalesperson.FormattingEnabled = true;
            this.ddlSalesperson.Location = new System.Drawing.Point(118, 55);
            this.ddlSalesperson.Name = "ddlSalesperson";
            this.ddlSalesperson.Size = new System.Drawing.Size(183, 35);
            this.ddlSalesperson.TabIndex = 5;
            this.ddlSalesperson.ValueMember = "SalesPersonName";
            // 
            // tblSalesPersonBindingSource
            // 
            this.tblSalesPersonBindingSource.DataMember = "tblSalesPerson";
            this.tblSalesPersonBindingSource.DataSource = this.inventoryDataSet7;
            // 
            // inventoryDataSet7
            // 
            this.inventoryDataSet7.DataSetName = "InventoryDataSet7";
            this.inventoryDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salesperson";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(607, 15);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(141, 32);
            this.btnNewCustomer.TabIndex = 3;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.DataSource = this.tblCustomerBindingSource;
            this.ddlCustomer.DisplayMember = "CustomerName";
            this.ddlCustomer.Font = new System.Drawing.Font("Dubai Medium", 12F);
            this.ddlCustomer.FormattingEnabled = true;
            this.ddlCustomer.Location = new System.Drawing.Point(414, 55);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(169, 35);
            this.ddlCustomer.TabIndex = 2;
            this.ddlCustomer.ValueMember = "CustomerName";
            this.ddlCustomer.SelectedIndexChanged += new System.EventHandler(this.ddlCustomer_SelectedIndexChanged);
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.inventoryDataSet6;
            // 
            // inventoryDataSet6
            // 
            this.inventoryDataSet6.DataSetName = "InventoryDataSet6";
            this.inventoryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Dubai Medium", 12F);
            this.txtInvoiceNo.Location = new System.Drawing.Point(118, 12);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(183, 35);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No.:";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.ItemCode,
            this.Description,
            this.UnitPrice,
            this.Quantity,
            this.Total});
            this.dgvInvoice.Location = new System.Drawing.Point(414, 197);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(768, 248);
            this.dgvInvoice.TabIndex = 2;
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "SerialNo";
            this.SerialNo.Name = "SerialNo";
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // inventoryDataSet3
            // 
            this.inventoryDataSet3.DataSetName = "InventoryDataSet3";
            this.inventoryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblItemBindingSource
            // 
            this.tblItemBindingSource.DataMember = "tblItem";
            this.tblItemBindingSource.DataSource = this.inventoryDataSet3;
            // 
            // tblItemTableAdapter
            // 
            this.tblItemTableAdapter.ClearBeforeFill = true;
            // 
            // tblBrandTableAdapter
            // 
            this.tblBrandTableAdapter.ClearBeforeFill = true;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(1021, 461);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(141, 32);
            this.btnInvoice.TabIndex = 3;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(712, 461);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(109, 32);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(827, 458);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 39);
            this.textBox1.TabIndex = 5;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tblSalesPersonTableAdapter
            // 
            this.tblSalesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // tblWarehouseTableAdapter
            // 
            this.tblWarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryDataSet9
            // 
            this.inventoryDataSet9.DataSetName = "InventoryDataSet9";
            this.inventoryDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblItemBindingSource1
            // 
            this.tblItemBindingSource1.DataMember = "tblItem";
            this.tblItemBindingSource1.DataSource = this.inventoryDataSet9;
            // 
            // tblItemTableAdapter1
            // 
            this.tblItemTableAdapter1.ClearBeforeFill = true;
            // 
            // InvoiceGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1194, 513);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.panel1);
            this.Name = "InvoiceGenerator";
            this.Text = "InvoiceGenerator";
            this.Load += new System.EventHandler(this.InvoiceGenerator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblWarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.ComboBox ddlBrand;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Button btnFindInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlSalesperson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.ComboBox ddlCustomer;
        private InventoryDataSet3 inventoryDataSet3;
        private System.Windows.Forms.BindingSource tblItemBindingSource;
        private InventoryDataSet3TableAdapters.tblItemTableAdapter tblItemTableAdapter;
        private InventoryDataSet4 inventoryDataSet4;
        private System.Windows.Forms.BindingSource tblBrandBindingSource;
        private InventoryDataSet4TableAdapters.tblBrandTableAdapter tblBrandTableAdapter;
        private InventoryDataSet5 inventoryDataSet5;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private InventoryDataSet5TableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private InventoryDataSet6 inventoryDataSet6;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private InventoryDataSet6TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private InventoryDataSet7 inventoryDataSet7;
        private System.Windows.Forms.BindingSource tblSalesPersonBindingSource;
        private InventoryDataSet7TableAdapters.tblSalesPersonTableAdapter tblSalesPersonTableAdapter;
        private System.Windows.Forms.ComboBox ddlWarehouse;
        private InventoryDataSet8 inventoryDataSet8;
        private System.Windows.Forms.BindingSource tblWarehouseBindingSource;
        private InventoryDataSet8TableAdapters.tblWarehouseTableAdapter tblWarehouseTableAdapter;
        private InventoryDataSet9 inventoryDataSet9;
        private System.Windows.Forms.BindingSource tblItemBindingSource1;
        private InventoryDataSet9TableAdapters.tblItemTableAdapter tblItemTableAdapter1;
    }
}