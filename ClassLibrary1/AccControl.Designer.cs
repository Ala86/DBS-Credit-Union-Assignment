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
            this.radioSavings = new System.Windows.Forms.RadioButton();
            this.radioCurrent = new System.Windows.Forms.RadioButton();
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
            // radioSavings
            // 
            this.radioSavings.AutoSize = true;
            this.radioSavings.Location = new System.Drawing.Point(216, 9);
            this.radioSavings.Name = "radioSavings";
            this.radioSavings.Size = new System.Drawing.Size(106, 17);
            this.radioSavings.TabIndex = 61;
            this.radioSavings.TabStop = true;
            this.radioSavings.Text = "Savings Account";
            this.radioSavings.UseVisualStyleBackColor = true;
            this.radioSavings.CheckedChanged += new System.EventHandler(this.radioSavings_CheckedChanged);
            // 
            // radioCurrent
            // 
            this.radioCurrent.AutoSize = true;
            this.radioCurrent.Location = new System.Drawing.Point(108, 9);
            this.radioCurrent.Name = "radioCurrent";
            this.radioCurrent.Size = new System.Drawing.Size(102, 17);
            this.radioCurrent.TabIndex = 60;
            this.radioCurrent.TabStop = true;
            this.radioCurrent.Text = "Current Account";
            this.radioCurrent.UseVisualStyleBackColor = true;
            this.radioCurrent.CheckedChanged += new System.EventHandler(this.radioCurrent_CheckedChanged);
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
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOverdraft);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.radioSavings);
            this.Controls.Add(this.radioCurrent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "AddAccount";
            this.Size = new System.Drawing.Size(327, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtOverdraft;
        public System.Windows.Forms.TextBox txtBalance;
        public System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.RadioButton radioSavings;
        private System.Windows.Forms.RadioButton radioCurrent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
