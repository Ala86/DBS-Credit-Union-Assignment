namespace AssignmentWeek1
{
    partial class EditAccount
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
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumer = new System.Windows.Forms.Label();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.cntlPerson = new ClassLibrary1.PersonControl();
            this.cntlAccount = new ClassLibrary1.AccControl();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.grpCustomer.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(302, 12);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(89, 23);
            this.btnFindCustomer.TabIndex = 22;
            this.btnFindCustomer.Text = "Find Account";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(174, 14);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 21;
            // 
            // lblAccountNumer
            // 
            this.lblAccountNumer.AutoSize = true;
            this.lblAccountNumer.Location = new System.Drawing.Point(53, 12);
            this.lblAccountNumer.Name = "lblAccountNumer";
            this.lblAccountNumer.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumer.TabIndex = 20;
            this.lblAccountNumer.Text = "Account Number:";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(174, 637);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(124, 29);
            this.btnEditAccount.TabIndex = 19;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // cntlPerson
            // 
            this.cntlPerson.EditOnly = true;
            this.cntlPerson.Location = new System.Drawing.Point(18, 19);
            this.cntlPerson.Name = "cntlPerson";
            this.cntlPerson.Size = new System.Drawing.Size(250, 324);
            this.cntlPerson.TabIndex = 23;
            // 
            // cntlAccount
            // 
            this.cntlAccount.AccountType = null;
            this.cntlAccount.EditOnly = true;
            this.cntlAccount.Location = new System.Drawing.Point(6, 19);
            this.cntlAccount.Name = "cntlAccount";
            this.cntlAccount.Size = new System.Drawing.Size(327, 165);
            this.cntlAccount.TabIndex = 24;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.cntlPerson);
            this.grpCustomer.Location = new System.Drawing.Point(30, 47);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(318, 346);
            this.grpCustomer.TabIndex = 25;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Details";
            this.grpCustomer.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.cntlAccount);
            this.grpAccount.Location = new System.Drawing.Point(24, 410);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(339, 187);
            this.grpAccount.TabIndex = 26;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Account Details";
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 698);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumer);
            this.Controls.Add(this.btnEditAccount);
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumer;
        private System.Windows.Forms.Button btnEditAccount;
        private ClassLibrary1.PersonControl cntlPerson;
        private ClassLibrary1.AccControl cntlAccount;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpAccount;
    }
}