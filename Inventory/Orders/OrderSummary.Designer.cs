namespace Inventory
{
    partial class OrderSummary
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
            this.lblHeadBills = new System.Windows.Forms.Label();
            this.listBills = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblHeadBills
            // 
            this.lblHeadBills.AutoSize = true;
            this.lblHeadBills.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadBills.Location = new System.Drawing.Point(183, 9);
            this.lblHeadBills.Name = "lblHeadBills";
            this.lblHeadBills.Size = new System.Drawing.Size(172, 40);
            this.lblHeadBills.TabIndex = 2;
            this.lblHeadBills.Text = "OrderSummary";
            // 
            // listBills
            // 
            this.listBills.Location = new System.Drawing.Point(12, 52);
            this.listBills.Name = "listBills";
            this.listBills.Size = new System.Drawing.Size(533, 429);
            this.listBills.TabIndex = 3;
            this.listBills.UseCompatibleStateImageBehavior = false;
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(557, 493);
            this.Controls.Add(this.listBills);
            this.Controls.Add(this.lblHeadBills);
            this.Name = "OrderSummary";
            this.Text = "OrderSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadBills;
        private System.Windows.Forms.ListView listBills;
    }
}