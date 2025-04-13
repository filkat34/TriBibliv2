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
    public partial class FrmMainWindow : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        private BindingSource bdgLivres = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMainWindowController controller;

        /// <summary>
        /// Liste de sauvegarde des livres
        /// </summary>
        List<Book> lesLivres = new List<Book>();

        // nom du fichier de sérialisation
        string nomFic = "sauvLivres";

        // dossier de sauvegarde
        string dossierSauvegarde = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TriBibli");


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

            // création du dossier de sauvegarde s'il n'existe pas
            Directory.CreateDirectory(dossierSauvegarde);

            // chemin d'accès au fichier de sauvegarde
            nomFic = Path.Combine(dossierSauvegarde, "sauvLivres.json");
            RemplirListeLivres();
        }

        /// <summary>
        /// Affiche la liste des personnels
        /// </summary>
        private void RemplirListeLivres()
        {
            lesLivres = controller.GetLesLivres(nomFic);
            bdgLivres.DataSource = lesLivres;
            GridVBookList.DataSource = bdgLivres;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form addBookForm = new FrmAddBook();
            addBookForm.ShowDialog();
        }
    }
}
