namespace AssignmentWeek1
{
    partial class ViewTransactionHistoryForm
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
            this.dgvTransactionDisplay = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDisplayIntTranfers = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactionDisplay
            // 
            this.dgvTransactionDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDisplay.Location = new System.Drawing.Point(12, 12);
            this.dgvTransactionDisplay.Name = "dgvTransactionDisplay";
            this.dgvTransactionDisplay.Size = new System.Drawing.Size(661, 314);
            this.dgvTransactionDisplay.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(566, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisplayIntTranfers
            // 
            this.btnDisplayIntTranfers.Location = new System.Drawing.Point(485, 332);
            this.btnDisplayIntTranfers.Name = "btnDisplayIntTranfers";
            this.btnDisplayIntTranfers.Size = new System.Drawing.Size(75, 35);
            this.btnDisplayIntTranfers.TabIndex = 2;
            this.btnDisplayIntTranfers.Text = "Internal Transfers";
            this.btnDisplayIntTranfers.UseVisualStyleBackColor = true;
            this.btnDisplayIntTranfers.Click += new System.EventHandler(this.btnDisplayIntTranfers_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(404, 332);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(75, 35);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Transaction History";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // ViewTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 370);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnDisplayIntTranfers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTransactionDisplay);
            this.Name = "ViewTransactionHistory";
            this.Text = "ViewTransactionHistory";
            this.Load += new System.EventHandler(this.ViewTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDisplayIntTranfers;
        private System.Windows.Forms.Button btnTransactions;
    }
}