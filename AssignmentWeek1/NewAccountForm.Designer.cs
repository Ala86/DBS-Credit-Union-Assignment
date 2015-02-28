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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtInputCustId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lblHasAccount = new System.Windows.Forms.Label();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.cntlAccount = new ClassLibrary1.AccControl();
            this.cntlPerson = new ClassLibrary1.PersonControl();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Enabled = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(147, 457);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(99, 32);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtInputCustId
            // 
            this.txtInputCustId.Enabled = false;
            this.txtInputCustId.Location = new System.Drawing.Point(452, 92);
            this.txtInputCustId.Name = "txtInputCustId";
            this.txtInputCustId.Size = new System.Drawing.Size(100, 20);
            this.txtInputCustId.TabIndex = 4;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(353, 95);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(93, 13);
            this.lblCustomerId.TabIndex = 5;
            this.lblCustomerId.Text = "Input Customer Id:";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(508, 308);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(124, 29);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lblHasAccount
            // 
            this.lblHasAccount.AutoSize = true;
            this.lblHasAccount.Location = new System.Drawing.Point(30, 19);
            this.lblHasAccount.Name = "lblHasAccount";
            this.lblHasAccount.Size = new System.Drawing.Size(313, 13);
            this.lblHasAccount.TabIndex = 7;
            this.lblHasAccount.Text = "Does the person already have an account with the Credit Union?";
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Location = new System.Drawing.Point(258, 51);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(43, 17);
            this.rdoYes.TabIndex = 8;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            this.rdoYes.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Location = new System.Drawing.Point(307, 51);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(39, 17);
            this.rdoNo.TabIndex = 9;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            this.rdoNo.CheckedChanged += new System.EventHandler(this.rdoNo_CheckedChanged);
            // 
            // cntlAccount
            // 
            this.cntlAccount.AccountType = null;
            this.cntlAccount.Enabled = false;
            this.cntlAccount.Location = new System.Drawing.Point(352, 137);
            this.cntlAccount.Name = "cntlAccount";
            this.cntlAccount.Size = new System.Drawing.Size(327, 165);
            this.cntlAccount.TabIndex = 1;
            // 
            // cntlPerson
            // 
            this.cntlPerson.Enabled = false;
            this.cntlPerson.Location = new System.Drawing.Point(33, 137);
            this.cntlPerson.Name = "cntlPerson";
            this.cntlPerson.Size = new System.Drawing.Size(250, 324);
            this.cntlPerson.TabIndex = 0;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Enabled = false;
            this.btnFindCustomer.Location = new System.Drawing.Point(558, 89);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(121, 23);
            this.btnFindCustomer.TabIndex = 10;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 562);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.rdoNo);
            this.Controls.Add(this.rdoYes);
            this.Controls.Add(this.lblHasAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtInputCustId);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cntlAccount);
            this.Controls.Add(this.cntlPerson);
            this.Name = "NewAccountForm";
            this.Text = "NewAccount";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary1.PersonControl cntlPerson;
        private ClassLibrary1.AccControl cntlAccount;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtInputCustId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lblHasAccount;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.Button btnFindCustomer;
    }
}