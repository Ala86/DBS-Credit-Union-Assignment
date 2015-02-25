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
    }
}
