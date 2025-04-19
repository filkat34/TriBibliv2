using TriBibliv2.controller;
using TriBibliv2.model;


namespace TriBibliv2.view
{
    /// <summary>
    /// Classe de la fenêtre de modification
    /// </summary>
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
        /// Liste pour gérer les étiquettes concernant le gere
        /// </summary>
        private List<string> comboboxGenrelist = new List<string>();

        /// <summary>
        /// Liste pour gérer les étiquettes concernant le statut
        /// </summary>
        private List<string> comboboxStatutlist = new List<string>();

        /// <summary>
        /// Liste pour gérer les étiquettes concernant la note
        /// </summary>
        private List<string> comboboxNotelist = new List<string>();

        /// <summary>
        /// Variable pour gérer la nouvelle étiquette
        /// </summary>
        string nouvelleEtiquette = string.Empty;

        /// <summary>
        /// Initialisation de la fenêtre de modification
        /// </summary>
        /// <param name="unlivre"></param>
        /// <param name="uneliste"></param>
        public FrmModifyWindow(Book unlivre, List<Book> uneliste, List<String> statuts, List<string> notes, List<string> genres)
        {
            InitializeComponent();
            controller = new FrmModifyController();
            listLivres = uneliste;
            livreamodifier = unlivre;
            comboboxStatutlist = statuts;
            comboboxGenrelist = genres;
            comboboxNotelist = notes;
            MajComboBoxes();
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
        /// Fonction qui met à jour les comboboxes de la fenêtre depuis la liste de livres
        /// </summary>
        public void MajComboBoxes()
        {
            CBoxStatut.Items.Clear();
            CBoxGenre.Items.Clear();
            CBoxNote.Items.Clear();
            foreach (string item in comboboxStatutlist)
            {
                CBoxStatut.Items.Add(item);
            }
            CBoxStatut.Items.RemoveAt(0); //Supprime le premier element vide de la liste des filtres qui sert à annuler le filtre

            foreach (string item in comboboxGenrelist)
            {
                CBoxGenre.Items.Add(item);
            }
            CBoxGenre.Items.RemoveAt(0); //Supprime le premier element vide de la liste des filtres qui sert à annuler le filtre

            foreach (string item in comboboxNotelist)
            {
                CBoxNote.Items.Add(item);
            }
            CBoxNote.Items.RemoveAt(0); //Supprime le premier element vide de la liste des filtres qui sert à annuler le filtre
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
                if (CBoxNote.SelectedIndex == -1)
                {
                    CBoxNote.Items.Add("Non noté");
                    CBoxNote.SelectedItem = "Non noté"; //Choix par défaut pour note
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


                if (MessageBox.Show("Voulez-vous enregistrer les modifications apportées au livre : " + livreamodifier.Titre.ToUpper() + " de " + livreamodifier.NomAuteur + " ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.ModifyBook(livreamodifier, modifiedbook, listLivres, nomFic);
                    DialogResult = DialogResult.Yes;
                }
            }
        }

        /// <summary>
        /// Fonction qui ouvre la fenêtre de gestion des étiquettes en mettant à jour leur liste
        /// </summary>
        /// <param name="label"></param>
        /// <param name="ComboBoxlist"></param>
        /// <param name="items"></param>
        public void MajAdminTags(string label, List<string> ComboBoxlist, ComboBox.ObjectCollection items)
        {
            FrmGestionTags gestionTags = new FrmGestionTags(label, ComboBoxlist);
            if (gestionTags.ShowDialog() == DialogResult.OK)
            {
                items.Clear();
                foreach (string item in gestionTags.SendData())
                {
                    items.Add(item);
                }
                items.RemoveAt(0); //Supprime le premier element vide de la liste des filtres qui sert à annuler le filtre
                nouvelleEtiquette = gestionTags.GetNouvelleEtiquette();
            }
        }

        /// <summary>
        /// Demande d'ajout d'une nouvelle étiquette de genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModGenreTag_Click(object sender, EventArgs e)
        {
            MajAdminTags("Nouveau genre :", comboboxGenrelist, CBoxGenre.Items);
            CBoxGenre.SelectedItem = nouvelleEtiquette; //selectionne l'étiquette qui vient d'être ajoutée
        }

        /// <summary>
        /// Demande d'ajout d'une nouvelle étiquette de statut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModStatutTag_Click(object sender, EventArgs e)
        {
            MajAdminTags("Nouveau statut :", comboboxStatutlist, CBoxStatut.Items);
            CBoxStatut.SelectedItem = nouvelleEtiquette; //selectionne l'étiquette qui vient d'être ajoutée
        }

        /// <summary>
        /// Demande d'ajout d'une nouvelle étiquette de note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModTagNote_Click(object sender, EventArgs e)
        {
            MajAdminTags("Nouvelle note :", comboboxNotelist, CBoxNote.Items);
            CBoxNote.SelectedItem = nouvelleEtiquette; // selectionne l'étiquette qui vient d'être ajoutée
        }
    }
}
