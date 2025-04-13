using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriBibliv2.model;
using TriBibliv2.controller;

namespace TriBibliv2.view
{
    public partial class FrmAddBook : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMainWindowController controller;

        /// <summary>
        /// Objet pour gérer la liste des livres
        /// </summary>
        private List<Book> leslivres = new List<Book>();

        string nomfichier;

        /// <summary>
        /// Initialisation de la fenêtre d'ajout de livre
        /// </summary>
        /// <param name="uneListelivres"></param>
        public FrmAddBook(List<Book> uneListelivres, string fichier)
        {
            InitializeComponent();
            controller = new FrmMainWindowController();
            leslivres = uneListelivres;
            nomfichier = fichier;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!txtBAuthorName.Text.Equals("") && !txtBoxTitle.Text.Equals("") && !(CBoxGenre.SelectedIndex == -1) && !(CBoxStatut.SelectedIndex == -1))
            {
                if (richtxtBoxNotes.Text.Equals(""))
                {
                    richtxtBoxNotes.Text = "Aucune note sur ce livre...";
                }

                Book newbook = new Book(
                txtBAuthorName.Text, 
                txtBoxAuthorSurname.Text,
                txtBoxTitle.Text,
                CBoxGenre.SelectedItem.ToString(),
                CBoxStatut.SelectedItem.ToString(),
                richtxtBoxNotes.Text);
            
                // Vérification de la présence d'un doublon
                int compteurdoublon = 0;
                foreach (Book unlivre in leslivres)
                {
                    if (unlivre.Titre.ToUpper() == newbook.Titre.ToUpper() && unlivre.NomAuteur.ToUpper() == newbook.NomAuteur.ToUpper())
                    {
                        compteurdoublon++;
                    }
                }
                if (compteurdoublon > 0)
                {
                    if (MessageBox.Show("Un même livre semble être déjà présent dans la base. Voulez-vous vraiment ajouter : " + newbook.Titre.ToUpper() + " ?", "Confirmation d'ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        leslivres.Add(newbook);
                        controller.SaveBook(leslivres, nomfichier);
                        DialogResult = DialogResult.OK;
                    }
                }
                else 
                {
                    leslivres.Add(newbook);
                    controller.SaveBook(leslivres, nomfichier);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

    }
}

