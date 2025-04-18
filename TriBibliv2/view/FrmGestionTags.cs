namespace TriBibliv2.view
{
    public partial class FrmGestionTags : Form
    {
        /// <summary>
        /// Liste pour gérer les étiquettes
        /// </summary>
        private List<string> taglist = new List<string>();

        /// <summary>
        /// Initialisation de la fenêtre de gestion des étiquettes
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="Comboboxlist"></param>
        public FrmGestionTags(String tagName, List<String> Comboboxlist)
        {
            InitializeComponent();
            tagLabel.Text = tagName;
            taglist = Comboboxlist;
        }

        /// <summary>
        /// Fonction qui communique la nouvelle liste d'étiquettes à la fenêtre appelante
        /// </summary>
        /// <returns></returns>
        public List<string> SendData()
        {
            return taglist;
        }

        public string GetNouvelleEtiquette()
        {
            return TxtBoxNewTag.Text;
        }

        /// <summary>
        /// Demande d'enregistrement des changements concernants les étiquettes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveTag_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxNewTag.Text))
            {
                MessageBox.Show("Veuillez entrer une étiquette valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            taglist.Add(TxtBoxNewTag.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
