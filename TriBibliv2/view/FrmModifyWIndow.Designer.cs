namespace TriBibliv2.view
{
    partial class FrmModifyWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyWindow));
            CBoxNote = new ComboBox();
            BtnSaveModification = new Button();
            CBoxStatut = new ComboBox();
            CBoxGenre = new ComboBox();
            txtBoxTitle = new TextBox();
            txtBoxAuthorSurname = new TextBox();
            txtBAuthorName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnModGenreTag = new Button();
            BtnModStatutTag = new Button();
            BtnModTagNote = new Button();
            label7 = new Label();
            TxtBoxObservations = new RichTextBox();
            SuspendLayout();
            // 
            // CBoxNote
            // 
            CBoxNote.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxNote.FormattingEnabled = true;
            CBoxNote.Items.AddRange(new object[] { "*", "**", "***", "****" });
            CBoxNote.Location = new Point(94, 238);
            CBoxNote.Name = "CBoxNote";
            CBoxNote.Size = new Size(168, 29);
            CBoxNote.Sorted = true;
            CBoxNote.TabIndex = 39;
            // 
            // BtnSaveModification
            // 
            BtnSaveModification.Location = new Point(182, 483);
            BtnSaveModification.Name = "BtnSaveModification";
            BtnSaveModification.Size = new Size(130, 37);
            BtnSaveModification.TabIndex = 38;
            BtnSaveModification.Text = "Enregistrer";
            BtnSaveModification.UseVisualStyleBackColor = true;
            BtnSaveModification.Click += BtnSaveModification_Click;
            // 
            // CBoxStatut
            // 
            CBoxStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxStatut.FormattingEnabled = true;
            CBoxStatut.Items.AddRange(new object[] { "Conserver", "Donner", "Recycler", "Vendre" });
            CBoxStatut.Location = new Point(94, 198);
            CBoxStatut.Name = "CBoxStatut";
            CBoxStatut.Size = new Size(271, 29);
            CBoxStatut.Sorted = true;
            CBoxStatut.TabIndex = 37;
            // 
            // CBoxGenre
            // 
            CBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxGenre.FormattingEnabled = true;
            CBoxGenre.Items.AddRange(new object[] { "Arts et loisirs", "Autre", "BD", "Cuisine", "Essai", "Manuel", "Poésie", "Récit", "Théâtre" });
            CBoxGenre.Location = new Point(94, 155);
            CBoxGenre.Name = "CBoxGenre";
            CBoxGenre.Size = new Size(271, 29);
            CBoxGenre.Sorted = true;
            CBoxGenre.TabIndex = 36;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(94, 108);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(372, 29);
            txtBoxTitle.TabIndex = 35;
            // 
            // txtBoxAuthorSurname
            // 
            txtBoxAuthorSurname.Location = new Point(94, 60);
            txtBoxAuthorSurname.Name = "txtBoxAuthorSurname";
            txtBoxAuthorSurname.Size = new Size(372, 29);
            txtBoxAuthorSurname.TabIndex = 34;
            // 
            // txtBAuthorName
            // 
            txtBAuthorName.Location = new Point(94, 16);
            txtBAuthorName.Name = "txtBAuthorName";
            txtBAuthorName.Size = new Size(372, 29);
            txtBAuthorName.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 246);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 32;
            label6.Text = "Note";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 206);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 31;
            label5.Text = "Statut";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 163);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 30;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 116);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 29;
            label3.Text = "Titre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 28;
            label2.Text = "Prenom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 27;
            label1.Text = "Nom";
            // 
            // BtnModGenreTag
            // 
            BtnModGenreTag.BackgroundImage = (Image)resources.GetObject("BtnModGenreTag.BackgroundImage");
            BtnModGenreTag.BackgroundImageLayout = ImageLayout.Stretch;
            BtnModGenreTag.Location = new Point(371, 155);
            BtnModGenreTag.Name = "BtnModGenreTag";
            BtnModGenreTag.Size = new Size(29, 29);
            BtnModGenreTag.TabIndex = 40;
            BtnModGenreTag.UseVisualStyleBackColor = true;
            BtnModGenreTag.Click += BtnModGenreTag_Click;
            // 
            // BtnModStatutTag
            // 
            BtnModStatutTag.BackgroundImage = (Image)resources.GetObject("BtnModStatutTag.BackgroundImage");
            BtnModStatutTag.BackgroundImageLayout = ImageLayout.Stretch;
            BtnModStatutTag.Location = new Point(371, 198);
            BtnModStatutTag.Name = "BtnModStatutTag";
            BtnModStatutTag.Size = new Size(29, 29);
            BtnModStatutTag.TabIndex = 41;
            BtnModStatutTag.UseVisualStyleBackColor = true;
            BtnModStatutTag.Click += BtnModStatutTag_Click;
            // 
            // BtnModTagNote
            // 
            BtnModTagNote.BackgroundImage = (Image)resources.GetObject("BtnModTagNote.BackgroundImage");
            BtnModTagNote.BackgroundImageLayout = ImageLayout.Stretch;
            BtnModTagNote.Location = new Point(268, 238);
            BtnModTagNote.Name = "BtnModTagNote";
            BtnModTagNote.Size = new Size(29, 29);
            BtnModTagNote.TabIndex = 42;
            BtnModTagNote.UseVisualStyleBackColor = true;
            BtnModTagNote.Click += BtnModTagNote_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 286);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 44;
            label7.Text = "Observations";
            // 
            // TxtBoxObservations
            // 
            TxtBoxObservations.Location = new Point(21, 320);
            TxtBoxObservations.Name = "TxtBoxObservations";
            TxtBoxObservations.Size = new Size(460, 152);
            TxtBoxObservations.TabIndex = 43;
            TxtBoxObservations.Text = "";
            // 
            // FrmModifyWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 532);
            Controls.Add(label7);
            Controls.Add(TxtBoxObservations);
            Controls.Add(BtnModTagNote);
            Controls.Add(BtnModStatutTag);
            Controls.Add(BtnModGenreTag);
            Controls.Add(CBoxNote);
            Controls.Add(BtnSaveModification);
            Controls.Add(CBoxStatut);
            Controls.Add(CBoxGenre);
            Controls.Add(txtBoxTitle);
            Controls.Add(txtBoxAuthorSurname);
            Controls.Add(txtBAuthorName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(520, 572);
            MinimumSize = new Size(520, 572);
            Name = "FrmModifyWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modifier un livre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBoxNote;
        private Button BtnSaveModification;
        private ComboBox CBoxStatut;
        private ComboBox CBoxGenre;
        private TextBox txtBoxTitle;
        private TextBox txtBoxAuthorSurname;
        private TextBox txtBAuthorName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnModGenreTag;
        private Button BtnModStatutTag;
        private Button BtnModTagNote;
        private Label label7;
        private RichTextBox TxtBoxObservations;
    }
}