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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'ouvrir ce lien.");
            }
        }

        private void VisitLink()
        {
            linkGithub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/filkat34");
        }
    }
}
