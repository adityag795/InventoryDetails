namespace Inventory
{
    partial class Catalogue
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
            this.listCatalogue = new System.Windows.Forms.ListView();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.lblHeadCatalogue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCatalogue
            // 
            this.listCatalogue.Location = new System.Drawing.Point(12, 52);
            this.listCatalogue.Name = "listCatalogue";
            this.listCatalogue.Size = new System.Drawing.Size(512, 397);
            this.listCatalogue.TabIndex = 0;
            this.listCatalogue.UseCompatibleStateImageBehavior = false;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxC.Location = new System.Drawing.Point(407, 469);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(100, 29);
            this.checkBoxC.TabIndex = 7;
            this.checkBoxC.Text = "Category C";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxB.Location = new System.Drawing.Point(222, 467);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(100, 29);
            this.checkBoxB.TabIndex = 8;
            this.checkBoxB.Text = "Category B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxA.Location = new System.Drawing.Point(33, 469);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(101, 29);
            this.checkBoxA.TabIndex = 9;
            this.checkBoxA.Text = "Category A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // lblHeadCatalogue
            // 
            this.lblHeadCatalogue.AutoSize = true;
            this.lblHeadCatalogue.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadCatalogue.Location = new System.Drawing.Point(203, 9);
            this.lblHeadCatalogue.Name = "lblHeadCatalogue";
            this.lblHeadCatalogue.Size = new System.Drawing.Size(119, 40);
            this.lblHeadCatalogue.TabIndex = 10;
            this.lblHeadCatalogue.Text = "Catalogue";
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(536, 508);
            this.Controls.Add(this.lblHeadCatalogue);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.listCatalogue);
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCatalogue;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.CheckBox checkCatA;
        private System.Windows.Forms.CheckBox checkCatB;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.Label lblHeadCatalogue;
    }
}