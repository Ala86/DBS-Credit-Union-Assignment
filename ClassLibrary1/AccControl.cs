using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class AccControl : UserControl
    {
        public string AccountType { get; set; }
        public bool EditOnly { get; set; }

        public AccControl()
        {
            InitializeComponent();
        }

        private void radioCurrent_CheckedChanged(object sender, EventArgs e)
        {
            AccountType = "Current";
        }

        private void radioSavings_CheckedChanged(object sender, EventArgs e)
        {
            AccountType = "Savings";
        }

        private void AccControl_Load(object sender, EventArgs e)
        {
            if (EditOnly)
            {
                txtBalance.Enabled = false;
                radioSavings.Enabled = false;
                radioCurrent.Enabled = false;
                txtSortCode.Enabled = false;
            }
        }
    }
}
