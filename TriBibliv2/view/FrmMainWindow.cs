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
        /// </summary>
        public FrmMainWindow()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur
        /// Création du dossier de sauvegarde s'il n'existe pas
        /// Remplissage de la GridView avec la liste des livres
        /// </summary>
        private void Init()
        {
            controller = new FrmMainWindowController();
            controller.CreateSaveFolder();
            RemplirListeLivres();
        }

        /// <summary>
        /// Customisations de la GridView :
        /// Modification de l'odre des colonnes
        /// Masquage de la colonne PrenomAuteur
        /// Modification du titre de la colonne "NomAuteur"
        /// Ajuster la taille de la colonne titre au contenu
        /// Tri de la liste des livres par nom d'auteur
        /// </summary>
        private void GridViewCustomize()
        {
            // Set column display order
            GridVBookList.Columns["NomAuteur"].DisplayIndex = 0;
            GridVBookList.Columns[1].HeaderText = "Auteur";
            GridVBookList.Columns["Titre"].DisplayIndex = 1;
            GridVBookList.Columns["Genre"].DisplayIndex = 2;
            GridVBookList.Columns["Statut"].DisplayIndex = 3;
            GridVBookList.Columns["PrenomAuteur"].DisplayIndex = 4;
            GridVBookList.Columns["PrenomAuteur"].Visible = false;
            GridVBookList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
    }
}
