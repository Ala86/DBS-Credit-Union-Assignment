namespace AssignmentWeek1
{
    partial class NewCustomerForm
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
            this.cntlPerson = new ClassLibrary1.PersonControl();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntlPerson
            // 
            this.cntlPerson.Location = new System.Drawing.Point(12, 12);
            this.cntlPerson.Name = "cntlPerson";
            this.cntlPerson.Size = new System.Drawing.Size(250, 324);
            this.cntlPerson.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(132, 342);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 23);
            this.btnNext.TabIndex = 84;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 401);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cntlPerson);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.PersonControl cntlPerson;
        private System.Windows.Forms.Button btnNext;
    }
}