namespace ClassLibrary1
{
    partial class AccControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.rdoSavings = new System.Windows.Forms.RadioButton();
            this.rdoCurrent = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Location = new System.Drawing.Point(161, 121);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(100, 20);
            this.txtOverdraft.TabIndex = 64;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(161, 84);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 63;
            // 
            // txtSortCode
            // 
            this.txtSortCode.Location = new System.Drawing.Point(161, 50);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(100, 20);
            this.txtSortCode.TabIndex = 62;
            // 
            // rdoSavings
            // 
            this.rdoSavings.AutoSize = true;
            this.rdoSavings.Location = new System.Drawing.Point(216, 9);
            this.rdoSavings.Name = "rdoSavings";
            this.rdoSavings.Size = new System.Drawing.Size(106, 17);
            this.rdoSavings.TabIndex = 61;
            this.rdoSavings.TabStop = true;
            this.rdoSavings.Text = "Savings Account";
            this.rdoSavings.UseVisualStyleBackColor = true;
            this.rdoSavings.CheckedChanged += new System.EventHandler(this.radioSavings_CheckedChanged);
            // 
            // rdoCurrent
            // 
            this.rdoCurrent.AutoSize = true;
            this.rdoCurrent.Location = new System.Drawing.Point(108, 9);
            this.rdoCurrent.Name = "rdoCurrent";
            this.rdoCurrent.Size = new System.Drawing.Size(102, 17);
            this.rdoCurrent.TabIndex = 60;
            this.rdoCurrent.TabStop = true;
            this.rdoCurrent.Text = "Current Account";
            this.rdoCurrent.UseVisualStyleBackColor = true;
            this.rdoCurrent.CheckedChanged += new System.EventHandler(this.radioCurrent_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Overdraft Limit:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Initial Balance:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Sort Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Account Type:";
            // 
            // AccControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOverdraft);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.rdoSavings);
            this.Controls.Add(this.rdoCurrent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "AccControl";
            this.Size = new System.Drawing.Size(327, 165);
            this.Load += new System.EventHandler(this.AccControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtOverdraft;
        public System.Windows.Forms.TextBox txtBalance;
        public System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.RadioButton rdoSavings;
        public System.Windows.Forms.RadioButton rdoCurrent;
    }
}
