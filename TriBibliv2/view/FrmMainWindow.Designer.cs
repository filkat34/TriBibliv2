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
            GridVBookList = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            CBoxFilterNote = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            CBoxFilterStatut = new ComboBox();
            CBoxFilterGenre = new ComboBox();
            groupBox2 = new GroupBox();
            BtnErase = new Button();
            TxtBxSearch = new TextBox();
            BtnAdd = new Button();
            BtnModify = new Button();
            BtnDelete = new Button();
            BtnStats = new Button();
            ((System.ComponentModel.ISupportInitialize)GridVBookList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GridVBookList
            // 
            GridVBookList.AllowUserToAddRows = false;
            GridVBookList.AllowUserToDeleteRows = false;
            GridVBookList.AllowUserToOrderColumns = true;
            GridVBookList.AllowUserToResizeRows = false;
            GridVBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridVBookList.BackgroundColor = SystemColors.ControlLightLight;
            GridVBookList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            GridVBookList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridVBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridVBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVBookList.Cursor = Cursors.Hand;
            GridVBookList.EnableHeadersVisualStyles = false;
            GridVBookList.Location = new Point(12, 12);
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
            GridVBookList.Size = new Size(751, 594);
            GridVBookList.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CBoxFilterNote);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CBoxFilterStatut);
            groupBox1.Controls.Add(CBoxFilterGenre);
            groupBox1.Location = new Point(14, 614);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 91);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtres rapides";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 25);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 5;
            label3.Text = "Note :";
            // 
            // CBoxFilterNote
            // 
            CBoxFilterNote.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxFilterNote.FormattingEnabled = true;
            CBoxFilterNote.Items.AddRange(new object[] { " ", "*", "**", "***", "****" });
            CBoxFilterNote.Location = new Point(247, 56);
            CBoxFilterNote.Name = "CBoxFilterNote";
            CBoxFilterNote.Size = new Size(166, 29);
            CBoxFilterNote.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 25);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 3;
            label2.Text = "Statut :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 2;
            label1.Text = "Genre :";
            // 
            // CBoxFilterStatut
            // 
            CBoxFilterStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxFilterStatut.FormattingEnabled = true;
            CBoxFilterStatut.Items.AddRange(new object[] { " ", "Conserver", "Donner", "Recycler", "Vendre" });
            CBoxFilterStatut.Location = new Point(434, 56);
            CBoxFilterStatut.Name = "CBoxFilterStatut";
            CBoxFilterStatut.Size = new Size(166, 29);
            CBoxFilterStatut.TabIndex = 1;
            // 
            // CBoxFilterGenre
            // 
            CBoxFilterGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxFilterGenre.FormattingEnabled = true;
            CBoxFilterGenre.Items.AddRange(new object[] { " ", "Arts et loisirs", "BD", "Cuisine", "Essai", "Manuel", "Poésie", "Récit", "Théâtre", "Autre" });
            CBoxFilterGenre.Location = new Point(6, 56);
            CBoxFilterGenre.Name = "CBoxFilterGenre";
            CBoxFilterGenre.Size = new Size(221, 29);
            CBoxFilterGenre.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnErase);
            groupBox2.Controls.Add(TxtBxSearch);
            groupBox2.Location = new Point(14, 711);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(612, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recherche";
            // 
            // BtnErase
            // 
            BtnErase.Location = new Point(518, 28);
            BtnErase.Name = "BtnErase";
            BtnErase.Size = new Size(88, 29);
            BtnErase.TabIndex = 1;
            BtnErase.Text = "Effacer";
            BtnErase.UseVisualStyleBackColor = true;
            // 
            // TxtBxSearch
            // 
            TxtBxSearch.Location = new Point(6, 28);
            TxtBxSearch.Name = "TxtBxSearch";
            TxtBxSearch.Size = new Size(506, 29);
            TxtBxSearch.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(647, 626);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(116, 34);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "Ajouter";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(647, 666);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(116, 34);
            BtnModify.TabIndex = 4;
            BtnModify.Text = "Modifier";
            BtnModify.UseVisualStyleBackColor = true;
            BtnModify.Click += BtnModify_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(647, 706);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 32);
            BtnDelete.TabIndex = 5;
            BtnDelete.Text = "Supprimer";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnStats
            // 
            BtnStats.Location = new Point(647, 744);
            BtnStats.Name = "BtnStats";
            BtnStats.Size = new Size(116, 32);
            BtnStats.TabIndex = 6;
            BtnStats.Text = "Statistiques";
            BtnStats.UseVisualStyleBackColor = true;
            // 
            // FrmMainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 789);
            Controls.Add(BtnStats);
            Controls.Add(groupBox1);
            Controls.Add(BtnDelete);
            Controls.Add(BtnModify);
            Controls.Add(BtnAdd);
            Controls.Add(groupBox2);
            Controls.Add(GridVBookList);
            MaximizeBox = false;
            MaximumSize = new Size(791, 829);
            MinimumSize = new Size(791, 829);
            Name = "FrmMainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionnaire de bibliothèque";
            ((System.ComponentModel.ISupportInitialize)GridVBookList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridVBookList;
        private GroupBox groupBox1;
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
    }
}