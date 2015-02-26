namespace AssignmentWeek1
{
    partial class TransferForm
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
            this.cntlSender = new ClassLibrary1.AccountManagementControl();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.cntlReceiver = new ClassLibrary1.AccountManagementControl();
            this.grpSender = new System.Windows.Forms.GroupBox();
            this.grpReceiver = new System.Windows.Forms.GroupBox();
            this.grpSender.SuspendLayout();
            this.grpReceiver.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntlSender
            // 
            this.cntlSender.AccountDisplay = null;
            this.cntlSender.Deposit = false;
            this.cntlSender.Location = new System.Drawing.Point(6, 19);
            this.cntlSender.Name = "cntlSender";
            this.cntlSender.Size = new System.Drawing.Size(343, 261);
            this.cntlSender.TabIndex = 0;
            this.cntlSender.Withdrawal = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(344, 360);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // cntlReceiver
            // 
            this.cntlReceiver.AccountDisplay = null;
            this.cntlReceiver.Deposit = false;
            this.cntlReceiver.Location = new System.Drawing.Point(6, 19);
            this.cntlReceiver.Name = "cntlReceiver";
            this.cntlReceiver.Size = new System.Drawing.Size(333, 261);
            this.cntlReceiver.TabIndex = 12;
            this.cntlReceiver.Withdrawal = false;
            // 
            // grpSender
            // 
            this.grpSender.Controls.Add(this.cntlSender);
            this.grpSender.Location = new System.Drawing.Point(12, 19);
            this.grpSender.Name = "grpSender";
            this.grpSender.Size = new System.Drawing.Size(359, 294);
            this.grpSender.TabIndex = 13;
            this.grpSender.TabStop = false;
            this.grpSender.Text = "Sender";
            // 
            // grpReceiver
            // 
            this.grpReceiver.Controls.Add(this.cntlReceiver);
            this.grpReceiver.Location = new System.Drawing.Point(406, 19);
            this.grpReceiver.Name = "grpReceiver";
            this.grpReceiver.Size = new System.Drawing.Size(362, 294);
            this.grpReceiver.TabIndex = 14;
            this.grpReceiver.TabStop = false;
            this.grpReceiver.Text = "Receiver";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 408);
            this.Controls.Add(this.grpReceiver);
            this.Controls.Add(this.grpSender);
            this.Controls.Add(this.btnTransfer);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.grpSender.ResumeLayout(false);
            this.grpReceiver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.AccountManagementControl cntlSender;
        private System.Windows.Forms.Button btnTransfer;
        private ClassLibrary1.AccountManagementControl cntlReceiver;
        private System.Windows.Forms.GroupBox grpSender;
        private System.Windows.Forms.GroupBox grpReceiver;
    }
}