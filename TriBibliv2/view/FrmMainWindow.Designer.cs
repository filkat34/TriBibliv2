namespace TriBibliv2.view
{
    partial class FrmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            GridVBookList = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            CBoxFilterNote = new ComboBox();
            label1 = new Label();
            CBoxFilterGenre = new ComboBox();
            BtnResetfilters = new Button();
            CBoxFilterStatut = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            TxtBxSearch = new TextBox();
            BtnErase = new Button();
            BtnAdd = new Button();
            BtnModify = new Button();
            BtnDelete = new Button();
            BtnStats = new Button();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem1 = new ToolStripMenuItem();
            ouvrirLeDossierDeSauvegardeToolStripMenuItem = new ToolStripMenuItem();
            importerToolStripMenuItem = new ToolStripMenuItem();
            importerToolStripMenuItem1 = new ToolStripMenuItem();
            exporterToolStripMenuItem = new ToolStripMenuItem();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)GridVBookList).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GridVBookList
            // 
            GridVBookList.AllowUserToAddRows = false;
            GridVBookList.AllowUserToDeleteRows = false;
            GridVBookList.AllowUserToOrderColumns = true;
            GridVBookList.AllowUserToResizeRows = false;
            GridVBookList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridVBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridVBookList.BackgroundColor = SystemColors.ControlLightLight;
            GridVBookList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridVBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridVBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVBookList.Cursor = Cursors.Hand;
            GridVBookList.EnableHeadersVisualStyles = false;
            GridVBookList.Location = new Point(12, 32);
            GridVBookList.MultiSelect = false;
            GridVBookList.Name = "GridVBookList";
            GridVBookList.ReadOnly = true;
            GridVBookList.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            GridVBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GridVBookList.RowHeadersVisible = false;
            GridVBookList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            GridVBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridVBookList.Size = new Size(751, 565);
            GridVBookList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.18724F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4595947F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.3531647F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(CBoxFilterNote, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(CBoxFilterGenre, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnResetfilters, 3, 1);
            tableLayoutPanel1.Controls.Add(CBoxFilterStatut, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Location = new Point(2, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(600, 67);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 3;
            label2.Text = "Statut";
            // 
            // CBoxFilterNote
            // 
            CBoxFilterNote.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CBoxFilterNote.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxFilterNote.FormattingEnabled = true;
            CBoxFilterNote.Items.AddRange(new object[] { " *", "**", "***", "****" });
            CBoxFilterNote.Location = new Point(394, 33);
            CBoxFilterNote.Name = "CBoxFilterNote";
            CBoxFilterNote.Size = new Size(106, 29);
            CBoxFilterNote.Sorted = true;
            CBoxFilterNote.TabIndex = 4;
            CBoxFilterNote.SelectedIndexChanged += CBoxFilterNote_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 2;
            label1.Text = "Genre";
            // 
            // CBoxFilterGenre
            // 
            CBoxFilterGenre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CBoxFilterGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxFilterGenre.FormattingEnabled = true;
            CBoxFilterGenre.Items.AddRange(new object[] { "Arts et loisirs", "Autre", "BD", "Cuisine", "Essai", "Manuel", "Poésie", "Récit", "Théâtre" });
            CBoxFilterGenre.Location = new Point(3, 33);
            CBoxFilterGenre.Name = "CBoxFilterGenre";
            CBoxFilterGenre.Size = new Size(196, 29);
            CBoxFilterGenre.Sorted = true;
            CBoxFilterGenre.TabIndex = 0;
            CBoxFilterGenre.SelectedIndexChanged += CBoxFilterGenre_SelectedIndexChanged;
            // 
            // BtnResetfilters
            // 
            BtnResetfilters.Anchor = AnchorStyles.Left;
            BtnResetfilters.Location = new Point(506, 32);
            BtnResetfilters.Name = "BtnResetfilters";
            BtnResetfilters.Size = new Size(89, 32);
            BtnResetfilters.TabIndex = 6;
            BtnResetfilters.Text = "Effacer";
            BtnResetfilters.UseVisualStyleBackColor = true;
            BtnResetfilters.Click += BtnResetfilters_Click;
            // 
            // CBoxFilterStatut
            // 
            CBoxFilterStatut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CBoxFilterStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxFilterStatut.FormattingEnabled = true;
            CBoxFilterStatut.Items.AddRange(new object[] { "Conserver", "Donner", "Recycler", "Vendre" });
            CBoxFilterStatut.Location = new Point(205, 33);
            CBoxFilterStatut.Name = "CBoxFilterStatut";
            CBoxFilterStatut.Size = new Size(183, 29);
            CBoxFilterStatut.Sorted = true;
            CBoxFilterStatut.TabIndex = 1;
            CBoxFilterStatut.SelectedIndexChanged += CBoxFilterStatut_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 5;
            label3.Text = "Note";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(14, 715);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(608, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recherche par titre ou nom d'auteur";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(TxtBxSearch, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnErase, 1, 0);
            tableLayoutPanel2.Location = new Point(8, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(597, 36);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // TxtBxSearch
            // 
            TxtBxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBxSearch.Location = new Point(3, 4);
            TxtBxSearch.Name = "TxtBxSearch";
            TxtBxSearch.Size = new Size(499, 29);
            TxtBxSearch.TabIndex = 0;
            TxtBxSearch.TextChanged += TxtBxSearch_TextChanged;
            // 
            // BtnErase
            // 
            BtnErase.Location = new Point(508, 3);
            BtnErase.Name = "BtnErase";
            BtnErase.Size = new Size(86, 30);
            BtnErase.TabIndex = 1;
            BtnErase.Text = "Effacer";
            BtnErase.UseVisualStyleBackColor = true;
            BtnErase.Click += BtnErase_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(3, 3);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(138, 35);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "Ajouter";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(3, 45);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(138, 33);
            BtnModify.TabIndex = 4;
            BtnModify.Text = "Modifier";
            BtnModify.UseVisualStyleBackColor = true;
            BtnModify.Click += BtnModify_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(3, 87);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(138, 35);
            BtnDelete.TabIndex = 5;
            BtnDelete.Text = "Supprimer";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnStats
            // 
            BtnStats.Location = new Point(3, 129);
            BtnStats.Name = "BtnStats";
            BtnStats.Size = new Size(138, 34);
            BtnStats.TabIndex = 6;
            BtnStats.Text = "Statistiques";
            BtnStats.UseVisualStyleBackColor = true;
            BtnStats.Click += BtnStats_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem1, importerToolStripMenuItem, fichierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(270, 29);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem1
            // 
            fichierToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ouvrirLeDossierDeSauvegardeToolStripMenuItem });
            fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            fichierToolStripMenuItem1.Size = new Size(68, 25);
            fichierToolStripMenuItem1.Text = "Fichier";
            // 
            // ouvrirLeDossierDeSauvegardeToolStripMenuItem
            // 
            ouvrirLeDossierDeSauvegardeToolStripMenuItem.Name = "ouvrirLeDossierDeSauvegardeToolStripMenuItem";
            ouvrirLeDossierDeSauvegardeToolStripMenuItem.Size = new Size(300, 26);
            ouvrirLeDossierDeSauvegardeToolStripMenuItem.Text = "Ouvrir le dossier de sauvegarde";
            ouvrirLeDossierDeSauvegardeToolStripMenuItem.Click += ouvrirLeDossierDeSauvegardeToolStripMenuItem_Click;
            // 
            // importerToolStripMenuItem
            // 
            importerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importerToolStripMenuItem1, exporterToolStripMenuItem });
            importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            importerToolStripMenuItem.Size = new Size(109, 25);
            importerToolStripMenuItem.Text = "Bibliothèque";
            // 
            // importerToolStripMenuItem1
            // 
            importerToolStripMenuItem1.Name = "importerToolStripMenuItem1";
            importerToolStripMenuItem1.Size = new Size(141, 26);
            importerToolStripMenuItem1.Text = "Importer";
            importerToolStripMenuItem1.Click += importerToolStripMenuItem1_Click;
            // 
            // exporterToolStripMenuItem
            // 
            exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            exporterToolStripMenuItem.Size = new Size(141, 26);
            exporterToolStripMenuItem.Text = "Exporter";
            exporterToolStripMenuItem.Click += exporterToolStripMenuItem_Click;
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(85, 25);
            fichierToolStripMenuItem.Text = "A propos";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(143, 26);
            aProposToolStripMenuItem.Text = "A propos";
            aProposToolStripMenuItem.Click += aProposToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(143, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(BtnStats, 0, 3);
            tableLayoutPanel4.Controls.Add(BtnDelete, 0, 2);
            tableLayoutPanel4.Controls.Add(BtnModify, 0, 1);
            tableLayoutPanel4.Controls.Add(BtnAdd, 0, 0);
            tableLayoutPanel4.Location = new Point(628, 612);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(144, 169);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(14, 603);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 103);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtres";
            // 
            // FrmMainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 793);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(groupBox2);
            Controls.Add(GridVBookList);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(791, 829);
            Name = "FrmMainWindow";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionnaire de bibliothèque";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)GridVBookList).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridVBookList;
        private GroupBox groupBox2;
        private Button BtnAdd;
        private Button BtnModify;
        private Button BtnDelete;
        private Button BtnErase;
        private TextBox TxtBxSearch;
        private Label label2;
        private Label label1;
        private ComboBox CBoxFilterStatut;
        private ComboBox CBoxFilterGenre;
        private Button BtnStats;
        private Label label3;
        private ComboBox CBoxFilterNote;
        private Button BtnResetfilters;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem importerToolStripMenuItem;
        private ToolStripMenuItem exporterToolStripMenuItem;
        private ToolStripMenuItem importerToolStripMenuItem1;
        private ToolStripMenuItem fichierToolStripMenuItem1;
        private ToolStripMenuItem ouvrirLeDossierDeSauvegardeToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox1;
    }
}