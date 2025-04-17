namespace TriBibliv2.view
{
    public partial class FrmGestionTags : Form
    {
        /// <summary>
        /// Liste pour gérer les étiquettes
        /// </summary>
        private List<string> taglist = new List<string>();

        /// <summary>
        /// BindingSource pour gérer la liste des étiquettes
        /// </summary>
        private BindingSource bdglistBoxTags = new BindingSource();

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
            bdglistBoxTags.DataSource = taglist;
            listBoxTags.DataSource = bdglistBoxTags;
        }

        /// <summary>
        /// Demande d'ajout d'une nouvelle étiquette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddEtiquette_Click(object sender, EventArgs e)
        {
            taglist.Add(TxtBoxNewTag.Text);
            bdglistBoxTags.ResetBindings(false);
            TxtBoxNewTag.Clear();
        }

        /// <summary>
        /// Fonction qui communique la nouvelle liste d'étiquettes à la fenêtre appelante
        /// </summary>
        /// <returns></returns>
        public List<string> SendData()
        {
            return taglist;
        }

        /// <summary>
        /// Demande d'enregistrement des changements concernants les étiquettes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveTag_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
