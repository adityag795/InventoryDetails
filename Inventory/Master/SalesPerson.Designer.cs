namespace Inventory
{
    partial class SalesPerson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSalesPerson = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddSalesPerson = new System.Windows.Forms.Button();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.lblSalesPersonName = new System.Windows.Forms.Label();
            this.lblSalesPerson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesPerson
            // 
            this.dgvSalesPerson.AllowUserToAddRows = false;
            this.dgvSalesPerson.AllowUserToDeleteRows = false;
            this.dgvSalesPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesPerson.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvSalesPerson.Location = new System.Drawing.Point(52, 233);
            this.dgvSalesPerson.Name = "dgvSalesPerson";
            this.dgvSalesPerson.Size = new System.Drawing.Size(378, 174);
            this.dgvSalesPerson.TabIndex = 36;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(355, 172);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 34);
            this.btnView.TabIndex = 35;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAddSalesPerson
            // 
            this.btnAddSalesPerson.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalesPerson.Location = new System.Drawing.Point(52, 172);
            this.btnAddSalesPerson.Name = "btnAddSalesPerson";
            this.btnAddSalesPerson.Size = new System.Drawing.Size(156, 34);
            this.btnAddSalesPerson.TabIndex = 34;
            this.btnAddSalesPerson.Text = "Add SalesPerson";
            this.btnAddSalesPerson.UseVisualStyleBackColor = true;
            this.btnAddSalesPerson.Click += new System.EventHandler(this.btnAddSalesPerson_Click);
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(209, 119);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(221, 20);
            this.txtSalesPerson.TabIndex = 33;
            // 
            // lblSalesPersonName
            // 
            this.lblSalesPersonName.AutoSize = true;
            this.lblSalesPersonName.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPersonName.Location = new System.Drawing.Point(46, 112);
            this.lblSalesPersonName.Name = "lblSalesPersonName";
            this.lblSalesPersonName.Size = new System.Drawing.Size(162, 32);
            this.lblSalesPersonName.TabIndex = 32;
            this.lblSalesPersonName.Text = "SalesPerson Name";
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.AutoSize = true;
            this.lblSalesPerson.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPerson.Location = new System.Drawing.Point(144, 47);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(187, 40);
            this.lblSalesPerson.TabIndex = 31;
            this.lblSalesPerson.Text = "Add SalesPerson";
            // 
            // SalesPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(477, 454);
            this.Controls.Add(this.dgvSalesPerson);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddSalesPerson);
            this.Controls.Add(this.txtSalesPerson);
            this.Controls.Add(this.lblSalesPersonName);
            this.Controls.Add(this.lblSalesPerson);
            this.Name = "SalesPerson";
            this.Text = "Add SalesPerson";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesPerson;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAddSalesPerson;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.Label lblSalesPersonName;
        private System.Windows.Forms.Label lblSalesPerson;
    }
}