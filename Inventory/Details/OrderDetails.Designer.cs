namespace Inventory.Details
{
    partial class OrderDetails
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
            this.lblHeadOrDet = new System.Windows.Forms.Label();
            this.listODetails = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblHeadOrDet
            // 
            this.lblHeadOrDet.AutoSize = true;
            this.lblHeadOrDet.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadOrDet.Location = new System.Drawing.Point(213, 9);
            this.lblHeadOrDet.Name = "lblHeadOrDet";
            this.lblHeadOrDet.Size = new System.Drawing.Size(152, 40);
            this.lblHeadOrDet.TabIndex = 0;
            this.lblHeadOrDet.Text = "Order Details";
            // 
            // listODetails
            // 
            this.listODetails.Location = new System.Drawing.Point(12, 52);
            this.listODetails.Name = "listODetails";
            this.listODetails.Size = new System.Drawing.Size(588, 403);
            this.listODetails.TabIndex = 1;
            this.listODetails.UseCompatibleStateImageBehavior = false;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(612, 500);
            this.Controls.Add(this.listODetails);
            this.Controls.Add(this.lblHeadOrDet);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadOrDet;
        private System.Windows.Forms.ListView listODetails;
    }
}