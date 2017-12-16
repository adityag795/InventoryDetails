namespace Inventory
{
    partial class FindInvoice
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
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoice
            // 
            this.txtInvoice.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.Location = new System.Drawing.Point(32, 40);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(1165, 39);
            this.txtInvoice.TabIndex = 28;
            this.txtInvoice.TextChanged += new System.EventHandler(this.txtInvoice_TextChanged);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvInvoice.Location = new System.Drawing.Point(32, 131);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1165, 363);
            this.dgvInvoice.TabIndex = 27;
            // 
            // FindInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1234, 534);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.dgvInvoice);
            this.Name = "FindInvoice";
            this.Text = "FindInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.DataGridView dgvInvoice;
    }
}