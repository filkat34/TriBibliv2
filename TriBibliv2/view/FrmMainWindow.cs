﻿using System;
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
    public partial class FrmMainWindow : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des livres
        /// </summary>
        List<Book> listLivres = new List<Book>();

        /// <summary>
        /// Binding list pour la liste des livres
        /// </summary>
        private BindingSource bdgLivres = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre principale
        /// </summary>
        private FrmMainWindowController controller;

        /// <summary>
        /// Initialisation de la fenêtre principale
        /// Création du contrôleur
        /// Création du dossier de sauvegarde s'il n'existe pas
        /// Remplissage de la GridView avec la liste des livres
        /// </summary>
        public FrmMainWindow()
        {
            InitializeComponent();
            controller = new FrmMainWindowController();
            controller.CreateSaveFolder();
            RemplirListeLivres();
        }

        /// <summary>
        /// Customisations de l'apparence de GridView
        /// Tri alpha de la liste des livres par nom d'auteur
        /// </summary>
        private void GridViewCustomize()
        {
            GridVBookList.Columns["NomAuteur"].DisplayIndex = 0;
            GridVBookList.Columns[1].HeaderText = "Auteur";
            GridVBookList.Columns["Titre"].DisplayIndex = 1;
            GridVBookList.Columns["Genre"].DisplayIndex = 2;
            GridVBookList.Columns["Statut"].DisplayIndex = 3;
            GridVBookList.Columns["PrenomAuteur"].DisplayIndex = 4;
            GridVBookList.Columns["PrenomAuteur"].Visible = false;
            GridVBookList.Columns[1].FillWeight = 60;
            GridVBookList.Columns[3].FillWeight = 50;
            GridVBookList.Columns[4].FillWeight = 50;
            GridVBookList.Columns[5].FillWeight = 50;
            GridVBookList.Columns[0].FillWeight = 100;
            listLivres.Sort((auteur1, auteur2) => auteur1.NomAuteur.CompareTo(auteur2.NomAuteur));
        }

        /// <summary>
        /// Affiche la liste des livres
        /// </summary>
        private void RemplirListeLivres()
        {
            listLivres = controller.GetBooks();
            bdgLivres.DataSource = listLivres;
            GridVBookList.DataSource = bdgLivres;
            GridViewCustomize();
            TxtBxSearch.Clear();
        }

        /// <summary>
        /// Ouvre la fenêtre d'ajout d'un livre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form addBookForm = new FrmAddWindow(listLivres);
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                RemplirListeLivres();
            }
        }

        /// <summary>
        /// Supprime le livre sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GridVBookList.SelectedRows.Count > 0)
            {
                Book livre = (Book)bdgLivres.List[bdgLivres.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + livre.Titre.ToUpper() + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelBook(livre);
                    RemplirListeLivres();
                }
            }
        }

        /// <summary>
        /// Ouvre la fenêtre de modification du livre sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (GridVBookList.SelectedRows.Count > 0)
            {
                Book livre = (Book)bdgLivres.List[bdgLivres.Position];
                Form modifyBookForm = new FrmModifyWindow(livre, listLivres);
                if (modifyBookForm.ShowDialog() == DialogResult.Yes)
                {
                    RemplirListeLivres();
                }
            }
        }

        /// <summary>
        /// Efface la textbox de recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnErase_Click(object sender, EventArgs e)
        {
            TxtBxSearch.Clear();
        }

        /// <summary>
        /// Affiche un message si aucun livre ne correspond à la recherche
        /// </summary>
        /// <param name="uneliste"></param>
        private void AucunResultat(List <Book> uneliste)
        {
            if (uneliste.Count() == 0)
            {
                MessageBox.Show("Aucun livre ne correspond à la recherche", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Recherche un livre dans la liste de livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Book> listResultatsRecherche = new List<Book>();
            GridVBookList.DataSource = null;

            if (string.IsNullOrEmpty(TxtBxSearch.Text) == false)
            {
                foreach (Book livre in listLivres)
                {
                    if (livre.NomAuteur.ToUpper().Contains(TxtBxSearch.Text.ToUpper()) | livre.Titre.ToUpper().Contains(TxtBxSearch.Text.ToUpper()))
                    {
                        listResultatsRecherche.Add(livre);
                    }
                }
                bdgLivres.DataSource = listResultatsRecherche;
                GridVBookList.DataSource = listResultatsRecherche;
                GridViewCustomize();
                AucunResultat(listResultatsRecherche);
            }

            if (TxtBxSearch.Text == "")
            {
                RemplirListeLivres();
            }
        }

        /// <summary>
        /// Retourne les livres correspondant aux critères de filtre
        /// </summary>
        public void FilterBooks()
        {
            List<Book> listResultatsRecherche = new List<Book>();
            GridVBookList.DataSource = null;

            foreach (Book livre in listLivres)
            {
                if ((CBoxFilterGenre.SelectedIndex == -1 || livre.Genre == CBoxFilterGenre.Text) &&
                    (CBoxFilterNote.SelectedIndex == -1 || livre.Note == CBoxFilterNote.Text) &&
                    (CBoxFilterStatut.SelectedIndex == -1 || livre.Statut == CBoxFilterStatut.Text))
                {
                    listResultatsRecherche.Add(livre);
                }
            }
            bdgLivres.DataSource = listResultatsRecherche;
            GridVBookList.DataSource = listResultatsRecherche;
            GridViewCustomize();
            AucunResultat(listResultatsRecherche);
        }

        /// <summary>
        /// Filtre la liste des livres en fonction du genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBoxFilterGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxFilterGenre.SelectedIndex != -1)
            {
                FilterBooks();
            }
            
        }

        /// <summary>
        /// Filtre la liste des livres en fonction de la note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBoxFilterNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxFilterNote.SelectedIndex != -1)
            {
                FilterBooks();
            }
        }

        /// <summary>
        /// Filtre la liste des livres en fonction du statut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBoxFilterStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxFilterStatut.SelectedIndex != -1)
            {
                FilterBooks();
            }
        }

        /// <summary>
        /// Effacer tous les filtres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResetfilters_Click(object sender, EventArgs e)
        {
            CBoxFilterGenre.SelectedIndex = -1;
            CBoxFilterNote.SelectedIndex = -1;
            CBoxFilterStatut.SelectedIndex = -1;
            RemplirListeLivres();
        }
    }
}
