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
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgLivres = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMainWindowController controller;


        /// <summary>
        /// Initialisation de la fenêtre de gestion des livres
        /// </summary>
        public FrmMainWindow()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMainWindowController();
            controller.CreateSaveFolder();
            RemplirListeLivres();
        }

        /// <summary>
        /// Affiche la liste des livres
        /// </summary>
        private void RemplirListeLivres()
        {
            listLivres = controller.GetBooks();
            bdgLivres.DataSource = listLivres;
            GridVBookList.DataSource = bdgLivres;
            GridVBookList.Columns[1].HeaderText = "Auteur";
            GridVBookList.Columns["PrenomAuteur"].Visible = false;
        }

        /// <summary>
        /// Ouvre la fenêtre d'ajout d'un livre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form addBookForm = new FrmAddWindow();
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
