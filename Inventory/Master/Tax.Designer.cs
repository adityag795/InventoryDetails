namespace Inventory
{
    partial class Tax
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.btnAddTax = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvTax = new System.Windows.Forms.DataGridView();
            this.taxNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet2 = new Inventory.InventoryDataSet2();
            this.tblTaxTableAdapter = new Inventory.InventoryDataSet2TableAdapters.tblTaxTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Name";
            // 
            // txtTaxName
            // 
            this.txtTaxName.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxName.Location = new System.Drawing.Point(122, 38);
            this.txtTaxName.Name = "txtTaxName";
            this.txtTaxName.Size = new System.Drawing.Size(213, 35);
            this.txtTaxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax %";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(122, 89);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(213, 35);
            this.txtTax.TabIndex = 3;
            // 
            // btnAddTax
            // 
            this.btnAddTax.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTax.Location = new System.Drawing.Point(54, 144);
            this.btnAddTax.Name = "btnAddTax";
            this.btnAddTax.Size = new System.Drawing.Size(97, 33);
            this.btnAddTax.TabIndex = 4;
            this.btnAddTax.Text = "Add Tax";
            this.btnAddTax.UseVisualStyleBackColor = true;
            this.btnAddTax.Click += new System.EventHandler(this.btnAddTax_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(220, 144);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 34);
            this.btnView.TabIndex = 24;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvTax
            // 
            this.dgvTax.AllowUserToAddRows = false;
            this.dgvTax.AllowUserToDeleteRows = false;
            this.dgvTax.AutoGenerateColumns = false;
            this.dgvTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taxNameDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn});
            this.dgvTax.DataSource = this.tblTaxBindingSource;
            this.dgvTax.Location = new System.Drawing.Point(17, 195);
            this.dgvTax.Name = "dgvTax";
            this.dgvTax.Size = new System.Drawing.Size(318, 150);
            this.dgvTax.TabIndex = 25;
            // 
            // taxNameDataGridViewTextBoxColumn
            // 
            this.taxNameDataGridViewTextBoxColumn.DataPropertyName = "taxName";
            this.taxNameDataGridViewTextBoxColumn.HeaderText = "taxName";
            this.taxNameDataGridViewTextBoxColumn.Name = "taxNameDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // tblTaxBindingSource
            // 
            this.tblTaxBindingSource.DataMember = "tblTax";
            this.tblTaxBindingSource.DataSource = this.inventoryDataSet2;
            // 
            // inventoryDataSet2
            // 
            this.inventoryDataSet2.DataSetName = "InventoryDataSet2";
            this.inventoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTaxTableAdapter
            // 
            this.tblTaxTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(122, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 35);
            this.textBox2.TabIndex = 3;
            // 
            // Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(355, 363);
            this.Controls.Add(this.dgvTax);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddTax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaxName);
            this.Controls.Add(this.label1);
            this.Name = "Tax";
            this.Text = "Tax";
            this.Load += new System.EventHandler(this.Tax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btnAddTax;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvTax;
        private InventoryDataSet2 inventoryDataSet2;
        private System.Windows.Forms.BindingSource tblTaxBindingSource;
        private InventoryDataSet2TableAdapters.tblTaxTableAdapter tblTaxTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
    }
}