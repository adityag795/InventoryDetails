namespace Inventory
{
    partial class Payment
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
            this.lblHeadPayment = new System.Windows.Forms.Label();
            this.listPayment = new System.Windows.Forms.ListView();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeadPayment
            // 
            this.lblHeadPayment.AutoSize = true;
            this.lblHeadPayment.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadPayment.Location = new System.Drawing.Point(251, 9);
            this.lblHeadPayment.Name = "lblHeadPayment";
            this.lblHeadPayment.Size = new System.Drawing.Size(106, 40);
            this.lblHeadPayment.TabIndex = 3;
            this.lblHeadPayment.Text = "Payment";
            // 
            // listPayment
            // 
            this.listPayment.Location = new System.Drawing.Point(12, 55);
            this.listPayment.Name = "listPayment";
            this.listPayment.Size = new System.Drawing.Size(639, 396);
            this.listPayment.TabIndex = 4;
            this.listPayment.UseCompatibleStateImageBehavior = false;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(258, 464);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(136, 34);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(663, 510);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.listPayment);
            this.Controls.Add(this.lblHeadPayment);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadPayment;
        private System.Windows.Forms.ListView listPayment;
        private System.Windows.Forms.Button btnPay;
    }
}