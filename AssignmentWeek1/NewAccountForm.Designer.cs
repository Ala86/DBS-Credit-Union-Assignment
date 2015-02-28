namespace AssignmentWeek1
{
    partial class NewAccountForm
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
            this.txtInputCustId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.cntlAccount = new ClassLibrary1.AccControl();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputCustId
            // 
            this.txtInputCustId.Location = new System.Drawing.Point(119, 19);
            this.txtInputCustId.Name = "txtInputCustId";
            this.txtInputCustId.Size = new System.Drawing.Size(100, 20);
            this.txtInputCustId.TabIndex = 4;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(20, 22);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(93, 13);
            this.lblCustomerId.TabIndex = 5;
            this.lblCustomerId.Text = "Input Customer Id:";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(192, 254);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(124, 29);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // cntlAccount
            // 
            this.cntlAccount.AccountType = null;
            this.cntlAccount.Location = new System.Drawing.Point(23, 59);
            this.cntlAccount.Name = "cntlAccount";
            this.cntlAccount.Size = new System.Drawing.Size(327, 165);
            this.cntlAccount.TabIndex = 1;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(225, 16);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(91, 23);
            this.btnFindCustomer.TabIndex = 10;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 322);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtInputCustId);
            this.Controls.Add(this.cntlAccount);
            this.Name = "NewAccountForm";
            this.Text = "NewAccount";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary1.AccControl cntlAccount;
        private System.Windows.Forms.TextBox txtInputCustId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnFindCustomer;
    }
}