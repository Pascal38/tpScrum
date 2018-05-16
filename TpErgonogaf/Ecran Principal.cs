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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listeDesCollaborateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeCollabos frmL; // déclare une instance du form
            frmL = new frmListeCollabos(); // instancie le form
            frmL.MdiParent = this;
            frmL.Show(); // affiche le form dans son conteneur
        }
    }
}
