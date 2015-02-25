namespace ClassLibrary1
{
    partial class AccountManagementControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnFindAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(49, 114);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(63, 13);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "CustomerId:";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(20, 41);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNo.TabIndex = 2;
            this.lblAccountNo.Text = "Account Number:";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(53, 143);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(57, 13);
            this.lblSort.TabIndex = 3;
            this.lblSort.Text = "Sort Code:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(128, 111);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 5;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(128, 38);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNo.TabIndex = 6;
            // 
            // txtSortCode
            // 
            this.txtSortCode.Location = new System.Drawing.Point(128, 140);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(100, 20);
            this.txtSortCode.TabIndex = 7;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(128, 174);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 9;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(61, 177);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Balance:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(127, 205);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 11;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(18, 208);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(92, 13);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount (in cents):";
            // 
            // btnFindAcc
            // 
            this.btnFindAcc.Location = new System.Drawing.Point(234, 33);
            this.btnFindAcc.Name = "btnFindAcc";
            this.btnFindAcc.Size = new System.Drawing.Size(97, 29);
            this.btnFindAcc.TabIndex = 12;
            this.btnFindAcc.Text = "Find Account";
            this.btnFindAcc.UseVisualStyleBackColor = true;
            this.btnFindAcc.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindAcc);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblName);
            this.Name = "AccountManagementControl";
            this.Size = new System.Drawing.Size(410, 280);
            this.Load += new System.EventHandler(this.AccountManagementControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.TextBox txtAccountNo;
        public System.Windows.Forms.Button btnFindAcc;
    }
}
