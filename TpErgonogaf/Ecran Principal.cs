using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpErgonogaf
{
    public partial class AbiRh : Form
    {
        public AbiRh()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            menuPrincipal.Enabled = true;
            menuPrincipal.Visible = true;

        }

        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            menuPrincipal.Enabled = false;
            menuPrincipal.Visible = false;
        }
    }
}
