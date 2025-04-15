using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TriBibliv2.controller.Serialize;
using TriBibliv2.model;
using TriBibliv2.controller;

namespace TriBibliv2.view
{
    public partial class FrmAddWindow : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des livres
        /// </summary>
        List<Book> listLivres = new List<Book>();

        /// <summary>
        /// Controleur de la fenêtre d'ajout
        /// </summary>
        private FrmAddWindowController controller;

        /// <summary>
        /// chemin du fichier de sauvegarde
        /// </summary>
        string nomFic = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"TriBibli\sauvLivres.json");

        /// <summary>
        /// Initialisation de la fenêtre
        /// Récupération de la liste de livres depuis la fenêtre principale
        /// Intitialisation du controleur
        /// </summary>
        public FrmAddWindow(List<Book> livres)
        {
            InitializeComponent();
            listLivres = livres;
            controller = new FrmAddWindowController();
        }

        /// <summary>
        /// Création du nouveau livre et ajout à la liste
        /// Enregistrement dans le fichier JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!txtBAuthorName.Text.Equals("") && !txtBoxTitle.Text.Equals("") && !(CBoxGenre.SelectedIndex == -1) && !(CBoxStatut.SelectedIndex == -1))
            {
                if (CBoxNote.Text.Equals(""))
                {
                    CBoxNote.Text = " ";
                }

                if (txtBoxAuthorSurname.Text.Equals(""))
                {
                    txtBoxAuthorSurname.Text = " ";
                }

                Book newbook = new Book(
                    txtBoxTitle.Text,
                    txtBAuthorName.Text,
                    txtBoxAuthorSurname.Text,
                    CBoxGenre.SelectedItem.ToString(),
                    CBoxStatut.SelectedItem.ToString(),
                    CBoxNote.Text.ToString());

                if (controller.DoublonTrouve(newbook, listLivres))
                {
                    if (MessageBox.Show("Un même livre semble être déjà présent dans la base. Voulez-vous vraiment ajouter : " + newbook.Titre.ToUpper() + " ?", "Confirmation d'ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controller.AddBook(newbook, listLivres, nomFic);
                        DialogResult = DialogResult.OK;  
                    }
                }
                else
                {
                    controller.AddBook(newbook, listLivres, nomFic);
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
