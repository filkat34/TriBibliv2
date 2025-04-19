using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriBibliv2.view
{
    /// <summary>
    /// CLasse de la fenêtre a propos
    /// </summary>
    public partial class FrmAbout : Form
    {
        /// <summary>
        /// Initialisation de la fenêtre a propos
        /// </summary>
        public FrmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ouverture du lien vers la page github du projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkGithub.LinkVisited = true;
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/filkat34/TriBibliv2",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        /// <summary>
        /// Fermetures de la fenêtre a propos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
