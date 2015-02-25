namespace AssignmentWeek1
{
    partial class Lodgement
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
            this.cntlLodgement = new ClassLibrary1.AccountManagementControl();
            this.btnLodge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntlLodgement
            // 
            this.cntlLodgement.AccountDisplay = null;
            this.cntlLodgement.Deposit = true;
            this.cntlLodgement.Location = new System.Drawing.Point(12, 12);
            this.cntlLodgement.Name = "cntlLodgement";
            this.cntlLodgement.Size = new System.Drawing.Size(362, 261);
            this.cntlLodgement.TabIndex = 0;
            this.cntlLodgement.Withdrawal = false;
            this.cntlLodgement.Load += new System.EventHandler(this.cntlLodgement_Load);
            // 
            // btnLodge
            // 
            this.btnLodge.Location = new System.Drawing.Point(153, 279);
            this.btnLodge.Name = "btnLodge";
            this.btnLodge.Size = new System.Drawing.Size(75, 23);
            this.btnLodge.TabIndex = 1;
            this.btnLodge.Text = "Lodge";
            this.btnLodge.UseVisualStyleBackColor = true;
            this.btnLodge.Click += new System.EventHandler(this.btnLodge_Click);
            // 
            // Lodgement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 334);
            this.Controls.Add(this.btnLodge);
            this.Controls.Add(this.cntlLodgement);
            this.Name = "Lodgement";
            this.Text = "Lodgement";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.AccountManagementControl cntlLodgement;
        private System.Windows.Forms.Button btnLodge;
    }
}