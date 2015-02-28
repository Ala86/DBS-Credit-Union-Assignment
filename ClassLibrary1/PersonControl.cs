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
    public partial class PersonControl : UserControl
    {
        public bool EditOnly { get; set; }


        public PersonControl()
        {
            InitializeComponent();
        }

        private void cmbCounty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonControl_Load(object sender, EventArgs e)
        {
            if (EditOnly)
            {
                txtFName.Enabled = false;
                txtLName.Enabled = false;
            }
        }
    }
}
