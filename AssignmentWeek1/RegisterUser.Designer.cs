namespace AssignmentWeek1
{
    partial class RegisterUser
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEntPwdAgain = new System.Windows.Forms.TextBox();
            this.txtEntPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblEnterPwdAgain = new System.Windows.Forms.Label();
            this.lblEnterPwd = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(155, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(155, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(38, 60);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 13);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "Enter First Name:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(180, 213);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(88, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEntPwdAgain
            // 
            this.txtEntPwdAgain.Location = new System.Drawing.Point(155, 174);
            this.txtEntPwdAgain.Name = "txtEntPwdAgain";
            this.txtEntPwdAgain.Size = new System.Drawing.Size(100, 20);
            this.txtEntPwdAgain.TabIndex = 17;
            // 
            // txtEntPwd
            // 
            this.txtEntPwd.Location = new System.Drawing.Point(155, 150);
            this.txtEntPwd.Name = "txtEntPwd";
            this.txtEntPwd.Size = new System.Drawing.Size(100, 20);
            this.txtEntPwd.TabIndex = 16;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(155, 126);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 15;
            // 
            // lblEnterPwdAgain
            // 
            this.lblEnterPwdAgain.AutoSize = true;
            this.lblEnterPwdAgain.Location = new System.Drawing.Point(38, 177);
            this.lblEnterPwdAgain.Name = "lblEnterPwdAgain";
            this.lblEnterPwdAgain.Size = new System.Drawing.Size(114, 13);
            this.lblEnterPwdAgain.TabIndex = 14;
            this.lblEnterPwdAgain.Text = "Enter Password Again:";
            // 
            // lblEnterPwd
            // 
            this.lblEnterPwd.AutoSize = true;
            this.lblEnterPwd.Location = new System.Drawing.Point(38, 153);
            this.lblEnterPwd.Name = "lblEnterPwd";
            this.lblEnterPwd.Size = new System.Drawing.Size(84, 13);
            this.lblEnterPwd.TabIndex = 12;
            this.lblEnterPwd.Text = "Enter Password:";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Location = new System.Drawing.Point(38, 129);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(111, 13);
            this.lblNewUser.TabIndex = 10;
            this.lblNewUser.Text = "Enter New Username:";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 256);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEntPwdAgain);
            this.Controls.Add(this.txtEntPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblEnterPwdAgain);
            this.Controls.Add(this.lblEnterPwd);
            this.Controls.Add(this.lblNewUser);
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEntPwdAgain;
        private System.Windows.Forms.TextBox txtEntPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblEnterPwdAgain;
        private System.Windows.Forms.Label lblEnterPwd;
        private System.Windows.Forms.Label lblNewUser;
    }
}