namespace AssignmentWeek1
{
    partial class Withdrawal
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.cntlWithdrawal = new ClassLibrary1.AccountManagementControl();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(171, 279);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // cntlWithdrawal
            // 
            this.cntlWithdrawal.AccountDisplay = null;
            this.cntlWithdrawal.Deposit = false;
            this.cntlWithdrawal.Location = new System.Drawing.Point(12, 12);
            this.cntlWithdrawal.Name = "cntlWithdrawal";
            this.cntlWithdrawal.Size = new System.Drawing.Size(370, 261);
            this.cntlWithdrawal.TabIndex = 0;
            this.cntlWithdrawal.Withdrawal = false;
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 330);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.cntlWithdrawal);
            this.Name = "Withdrawal";
            this.Text = "Withdrawal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private ClassLibrary1.AccountManagementControl cntlWithdrawal;
    }
}