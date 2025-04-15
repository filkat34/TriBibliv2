namespace TriBibliv2.view
{
    partial class FrmModifyWIndow
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
            CBoxNote = new ComboBox();
            BtnSave = new Button();
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
            SuspendLayout();
            // 
            // CBoxNote
            // 
            CBoxNote.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxNote.FormattingEnabled = true;
            CBoxNote.Items.AddRange(new object[] { "*", "**", "***", "****" });
            CBoxNote.Location = new Point(109, 238);
            CBoxNote.Name = "CBoxNote";
            CBoxNote.Size = new Size(168, 29);
            CBoxNote.TabIndex = 39;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(200, 293);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(130, 37);
            BtnSave.TabIndex = 38;
            BtnSave.Text = "Enregistrer";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // CBoxStatut
            // 
            CBoxStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxStatut.FormattingEnabled = true;
            CBoxStatut.Items.AddRange(new object[] { "Conserver", "Donner", "Recycler", "Vendre" });
            CBoxStatut.Location = new Point(109, 198);
            CBoxStatut.Name = "CBoxStatut";
            CBoxStatut.Size = new Size(271, 29);
            CBoxStatut.TabIndex = 37;
            // 
            // CBoxGenre
            // 
            CBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxGenre.FormattingEnabled = true;
            CBoxGenre.Items.AddRange(new object[] { "Arts et loisirs", "BD", "Cuisine", "Essai", "Manuel", "Poésie", "Récit", "Théâtre", "Autre" });
            CBoxGenre.Location = new Point(109, 155);
            CBoxGenre.Name = "CBoxGenre";
            CBoxGenre.Size = new Size(271, 29);
            CBoxGenre.TabIndex = 36;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(109, 108);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(372, 29);
            txtBoxTitle.TabIndex = 35;
            // 
            // txtBoxAuthorSurname
            // 
            txtBoxAuthorSurname.Location = new Point(109, 60);
            txtBoxAuthorSurname.Name = "txtBoxAuthorSurname";
            txtBoxAuthorSurname.Size = new Size(372, 29);
            txtBoxAuthorSurname.TabIndex = 34;
            // 
            // txtBAuthorName
            // 
            txtBAuthorName.Location = new Point(109, 16);
            txtBAuthorName.Name = "txtBAuthorName";
            txtBAuthorName.Size = new Size(372, 29);
            txtBAuthorName.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 246);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 32;
            label6.Text = "Note";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 206);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 31;
            label5.Text = "Statut";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 163);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 30;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 116);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 29;
            label3.Text = "Titre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 28;
            label2.Text = "Prenom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 27;
            label1.Text = "Nom";
            // 
            // FrmModifyWIndow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 348);
            Controls.Add(CBoxNote);
            Controls.Add(BtnSave);
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
            MaximumSize = new Size(514, 388);
            MinimumSize = new Size(514, 388);
            Name = "FrmModifyWIndow";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Modifier un livre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBoxNote;
        private Button BtnSave;
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
    }
}