namespace TriBibliv2.view
{
    partial class FrmAddBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBAuthorName = new TextBox();
            txtBoxAuthorSurname = new TextBox();
            txtBoxTitle = new TextBox();
            CBoxGenre = new ComboBox();
            CBoxStatut = new ComboBox();
            richtxtBoxNotes = new RichTextBox();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 112);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 2;
            label3.Text = "Titre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 159);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 202);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 4;
            label5.Text = "Statut";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 242);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 5;
            label6.Text = "Notes";
            // 
            // txtBAuthorName
            // 
            txtBAuthorName.Location = new Point(102, 12);
            txtBAuthorName.Name = "txtBAuthorName";
            txtBAuthorName.Size = new Size(372, 29);
            txtBAuthorName.TabIndex = 6;
            // 
            // txtBoxAuthorSurname
            // 
            txtBoxAuthorSurname.Location = new Point(102, 56);
            txtBoxAuthorSurname.Name = "txtBoxAuthorSurname";
            txtBoxAuthorSurname.Size = new Size(372, 29);
            txtBoxAuthorSurname.TabIndex = 7;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(102, 104);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(372, 29);
            txtBoxTitle.TabIndex = 8;
            // 
            // CBoxGenre
            // 
            CBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxGenre.FormattingEnabled = true;
            CBoxGenre.Items.AddRange(new object[] { "Arts et loisirs", "Autres", "BD", "Cuisine", "Essai", "Manuels", "Poésie", "Récits", "Théâtre" });
            CBoxGenre.Location = new Point(102, 151);
            CBoxGenre.Name = "CBoxGenre";
            CBoxGenre.Size = new Size(271, 29);
            CBoxGenre.TabIndex = 9;
            // 
            // CBoxStatut
            // 
            CBoxStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxStatut.FormattingEnabled = true;
            CBoxStatut.Items.AddRange(new object[] { "Conserver", "Donner", "Recycler", "Vendre" });
            CBoxStatut.Location = new Point(102, 194);
            CBoxStatut.Name = "CBoxStatut";
            CBoxStatut.Size = new Size(271, 29);
            CBoxStatut.TabIndex = 10;
            // 
            // richtxtBoxNotes
            // 
            richtxtBoxNotes.Location = new Point(14, 278);
            richtxtBoxNotes.Name = "richtxtBoxNotes";
            richtxtBoxNotes.Size = new Size(460, 191);
            richtxtBoxNotes.TabIndex = 11;
            richtxtBoxNotes.Text = "";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(173, 484);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(130, 37);
            BtnSave.TabIndex = 12;
            BtnSave.Text = "Enregistrer";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // FrmAddBook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 536);
            Controls.Add(BtnSave);
            Controls.Add(richtxtBoxNotes);
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
            MaximumSize = new Size(508, 576);
            MinimizeBox = false;
            MinimumSize = new Size(508, 576);
            Name = "FrmAddBook";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter un livre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBAuthorName;
        private TextBox txtBoxAuthorSurname;
        private TextBox txtBoxTitle;
        private ComboBox CBoxGenre;
        private ComboBox CBoxStatut;
        private RichTextBox richtxtBoxNotes;
        private Button BtnSave;
    }
}