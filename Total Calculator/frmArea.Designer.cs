namespace Total_Calculator
{
    partial class frmArea
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
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtInputRadius = new System.Windows.Forms.TextBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(189, 84);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(237, 22);
            this.txtArea.TabIndex = 8;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(36, 87);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(137, 16);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Area of circle (sq Unit)";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(36, 49);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(99, 16);
            this.lblRadius.TabIndex = 5;
            this.lblRadius.Text = "Radius of circle";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(39, 122);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(387, 35);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtInputRadius
            // 
            this.txtInputRadius.Location = new System.Drawing.Point(189, 46);
            this.txtInputRadius.Name = "txtInputRadius";
            this.txtInputRadius.Size = new System.Drawing.Size(237, 22);
            this.txtInputRadius.TabIndex = 10;
            this.txtInputRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputRadius_KeyDown);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(12, 178);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(213, 16);
            this.lblCopyRight.TabIndex = 11;
            this.lblCopyRight.Text = "Made with ❤️ by yarzardhiyit © 2022";
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 203);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.txtInputRadius);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadius);
            this.MaximizeBox = false;
            this.Name = "frmArea";
            this.Text = "Calculator: Area of circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtInputRadius;
        private System.Windows.Forms.Label lblCopyRight;
    }
}