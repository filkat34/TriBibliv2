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
        /// Initialisation de la fenêtre
        /// Récupération de la liste de livres depuis la fenêtre principale
        /// Intitialisation du controleur
        /// </summary>
        public FrmAddWindow(List<Book> livres, List<String> statuts, List<string> notes, List<string> genres)
        {
            InitializeComponent();
            listLivres = livres;
            controller = new FrmAddWindowController();
            comboboxStatutlist = statuts;
            comboboxGenrelist = genres;
            comboboxNotelist = notes;
            MajComboBoxes();
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
            foreach (string item in comboboxGenrelist)
            {
                CBoxGenre.Items.Add(item);
            }
            foreach (string item in comboboxNotelist)
            {
                CBoxNote.Items.Add(item);
            }
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

                if (TxtBoxObservations.Text.Equals(""))
                {
                    TxtBoxObservations.Text = " ";
                }

                Book newbook = new Book(
                    txtBoxTitle.Text,
                    txtBAuthorName.Text,
                    txtBoxAuthorSurname.Text,
                    CBoxGenre.SelectedItem.ToString(),
                    CBoxStatut.SelectedItem.ToString(),
                    CBoxNote.Text.ToString(),
                    TxtBoxObservations.Text);

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
            }
        }

        /// <summary>
        /// Fonction qui ouvre la fenêtre de gestion des tags pour le genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModGenreTag_Click(object sender, EventArgs e)
        {
            MajAdminTags("Nouveau genre :", comboboxGenrelist, CBoxGenre.Items);
        }

        /// <summary>
        /// Fonction qui ouvre la fenêtre de gestion des tags pour le statut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModStatutTag_Click(object sender, EventArgs e)
        {
           MajAdminTags("Nouveau statut :", comboboxStatutlist, CBoxStatut.Items);
        }

        /// <summary>
        /// Fonction qui ouvre la fenêtre de gestion des tags pour la note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModNoteTag_Click(object sender, EventArgs e)
        {
            MajAdminTags("Nouvelle note :", comboboxNotelist, CBoxNote.Items);
        }
    }
}
