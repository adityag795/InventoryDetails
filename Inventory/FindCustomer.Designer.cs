﻿namespace Inventory
{
    partial class FindCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet10 = new Inventory.InventoryDataSet10();
            this.tblCustomerTableAdapter = new Inventory.InventoryDataSet10TableAdapters.tblCustomerTableAdapter();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvCustomer.Location = new System.Drawing.Point(23, 119);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1165, 363);
            this.dgvCustomer.TabIndex = 25;
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.inventoryDataSet10;
            // 
            // inventoryDataSet10
            // 
            this.inventoryDataSet10.DataSetName = "InventoryDataSet10";
            this.inventoryDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(23, 28);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(1165, 39);
            this.txtCustomer.TabIndex = 26;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // FindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 507);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "FindCustomer";
            this.Text = "Find Customer";
            this.Load += new System.EventHandler(this.FindCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private InventoryDataSet10 inventoryDataSet10;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private InventoryDataSet10TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.TextBox txtCustomer;
    }
}