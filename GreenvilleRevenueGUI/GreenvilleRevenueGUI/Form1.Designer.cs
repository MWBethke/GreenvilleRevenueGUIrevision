namespace GreenvilleRevenueGUI
{
    partial class RevenueForm
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
            this.lastYearInput = new System.Windows.Forms.TextBox();
            this.thisYearInput = new System.Windows.Forms.TextBox();
            this.getRevenue = new System.Windows.Forms.Button();
            this.revenueOutput = new System.Windows.Forms.Label();
            this.greaterOutput = new System.Windows.Forms.Label();
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.GreaterLabel = new System.Windows.Forms.Label();
            this.LYALabel = new System.Windows.Forms.Label();
            this.TYALabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYearInput
            // 
            this.lastYearInput.Location = new System.Drawing.Point(12, 36);
            this.lastYearInput.Name = "lastYearInput";
            this.lastYearInput.Size = new System.Drawing.Size(100, 20);
            this.lastYearInput.TabIndex = 0;
            // 
            // thisYearInput
            // 
            this.thisYearInput.Location = new System.Drawing.Point(12, 83);
            this.thisYearInput.Name = "thisYearInput";
            this.thisYearInput.Size = new System.Drawing.Size(100, 20);
            this.thisYearInput.TabIndex = 1;
            // 
            // getRevenue
            // 
            this.getRevenue.Location = new System.Drawing.Point(88, 157);
            this.getRevenue.Name = "getRevenue";
            this.getRevenue.Size = new System.Drawing.Size(104, 23);
            this.getRevenue.TabIndex = 2;
            this.getRevenue.Text = "Get Revenue";
            this.getRevenue.UseVisualStyleBackColor = true;
            this.getRevenue.Click += new System.EventHandler(this.getRevenue_Click);
            // 
            // revenueOutput
            // 
            this.revenueOutput.AutoSize = true;
            this.revenueOutput.Location = new System.Drawing.Point(190, 43);
            this.revenueOutput.Name = "revenueOutput";
            this.revenueOutput.Size = new System.Drawing.Size(13, 13);
            this.revenueOutput.TabIndex = 3;
            this.revenueOutput.Text = "0";
            // 
            // greaterOutput
            // 
            this.greaterOutput.AutoSize = true;
            this.greaterOutput.Location = new System.Drawing.Point(27, 130);
            this.greaterOutput.Name = "greaterOutput";
            this.greaterOutput.Size = new System.Drawing.Size(0, 13);
            this.greaterOutput.TabIndex = 4;
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Location = new System.Drawing.Point(129, 43);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(63, 13);
            this.RevenueLabel.TabIndex = 5;
            this.RevenueLabel.Text = "Revenue: $";
            // 
            // GreaterLabel
            // 
            this.GreaterLabel.AutoSize = true;
            this.GreaterLabel.Location = new System.Drawing.Point(77, 106);
            this.GreaterLabel.Name = "GreaterLabel";
            this.GreaterLabel.Size = new System.Drawing.Size(115, 13);
            this.GreaterLabel.TabIndex = 6;
            this.GreaterLabel.Text = "Increased Attendance:";
            // 
            // LYALabel
            // 
            this.LYALabel.AutoSize = true;
            this.LYALabel.Location = new System.Drawing.Point(4, 20);
            this.LYALabel.Name = "LYALabel";
            this.LYALabel.Size = new System.Drawing.Size(118, 13);
            this.LYALabel.TabIndex = 7;
            this.LYALabel.Text = "Last Years Attendance:";
            // 
            // TYALabel
            // 
            this.TYALabel.AutoSize = true;
            this.TYALabel.Location = new System.Drawing.Point(4, 66);
            this.TYALabel.Name = "TYALabel";
            this.TYALabel.Size = new System.Drawing.Size(118, 13);
            this.TYALabel.TabIndex = 8;
            this.TYALabel.Text = "This Years Attendance:";
            this.TYALabel.Click += new System.EventHandler(this.TYALabel_Click);
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.TYALabel);
            this.Controls.Add(this.LYALabel);
            this.Controls.Add(this.GreaterLabel);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.greaterOutput);
            this.Controls.Add(this.revenueOutput);
            this.Controls.Add(this.getRevenue);
            this.Controls.Add(this.thisYearInput);
            this.Controls.Add(this.lastYearInput);
            this.Name = "RevenueForm";
            this.Text = "Estimate Revenue";
            this.Load += new System.EventHandler(this.RevenueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastYearInput;
        private System.Windows.Forms.TextBox thisYearInput;
        private System.Windows.Forms.Button getRevenue;
        private System.Windows.Forms.Label revenueOutput;
        private System.Windows.Forms.Label greaterOutput;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.Label GreaterLabel;
        private System.Windows.Forms.Label LYALabel;
        private System.Windows.Forms.Label TYALabel;
    }
}

