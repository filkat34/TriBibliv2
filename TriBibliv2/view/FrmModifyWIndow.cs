using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriBibliv2.controller;
using TriBibliv2.model;

namespace TriBibliv2.view
{
    public partial class FrmModifyWindow : Form
    {

        /// <summary>
        /// Ccontrôleur de la fenêtre de modification
        /// </summary>
        private readonly FrmModifyController controller;

        /// <summary>
        /// Livre en cours de modification
        /// </summary>
        Book livreamodifier = new Book();

        /// <summary>
        /// Objet pour gérer la liste des livres
        /// </summary>
        List<Book> listLivres = new List<Book>();

        /// <summary>
        /// chemin du fichier de sauvegarde
        /// </summary>
        string nomFic = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"TriBibli\sauvLivres.json");

        /// <summary>
        /// Initialisation de la fenêtre de modification
        /// </summary>
        /// <param name="unlivre"></param>
        /// <param name="uneliste"></param>
        public FrmModifyWindow(Book unlivre, List<Book> uneliste)
        {
            InitializeComponent();
            controller = new FrmModifyController();
            listLivres = uneliste;
            livreamodifier = unlivre;
            FillInBookInfo(livreamodifier);
        }

        /// <summary>
        /// Remplissage des champs de la fenêtre de modification avec les données du livre selectionné
        /// </summary>
        /// <param name="unlivre"></param>
        public void FillInBookInfo(Book unlivre)
        {
            txtBoxTitle.Text = unlivre.Titre;
            txtBAuthorName.Text = unlivre.NomAuteur;
            txtBoxAuthorSurname.Text = unlivre.PrenomAuteur;
            CBoxGenre.SelectedIndex = CBoxGenre.FindStringExact(unlivre.Genre);
            CBoxStatut.SelectedIndex = CBoxStatut.FindStringExact(unlivre.Statut);
            CBoxNote.SelectedIndex = CBoxNote.FindStringExact(unlivre.Note);
            TxtBoxObservations.Text = unlivre.Observation;
        }

        /// <summary>
        /// Demande d'enregistrement des modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveModification_Click(object sender, EventArgs e)
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

                if (TxtBoxObservations.Text.Equals(""))
                {
                    TxtBoxObservations.Text = " ";
                }

                    Book modifiedbook = new Book(
                    txtBoxTitle.Text,
                    txtBAuthorName.Text,
                    txtBoxAuthorSurname.Text,
                    CBoxGenre.SelectedItem.ToString(),
                    CBoxStatut.SelectedItem.ToString(),
                    CBoxNote.Text.ToString(),
                    TxtBoxObservations.Text);

                if (MessageBox.Show("Voulez-vous apporter des modifications au livre suivant : " + livreamodifier.Titre.ToUpper() + " de " + livreamodifier.NomAuteur + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.ModifyBook(livreamodifier, modifiedbook, listLivres, nomFic);
                    DialogResult = DialogResult.Yes;
                }
            }
        }
    }
}
