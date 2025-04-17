namespace TriBibliv2.view
{
    partial class FrmGestionTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionTags));
            TxtBoxNewTag = new TextBox();
            listBoxTags = new ListBox();
            BtnAddEtiquette = new Button();
            tagLabel = new Label();
            BtnSaveTag = new Button();
            SuspendLayout();
            // 
            // TxtBoxNewTag
            // 
            TxtBoxNewTag.Location = new Point(12, 48);
            TxtBoxNewTag.Name = "TxtBoxNewTag";
            TxtBoxNewTag.Size = new Size(305, 29);
            TxtBoxNewTag.TabIndex = 0;
            // 
            // listBoxTags
            // 
            listBoxTags.FormattingEnabled = true;
            listBoxTags.ItemHeight = 21;
            listBoxTags.Location = new Point(12, 137);
            listBoxTags.Name = "listBoxTags";
            listBoxTags.Size = new Size(305, 319);
            listBoxTags.Sorted = true;
            listBoxTags.TabIndex = 1;
            // 
            // BtnAddEtiquette
            // 
            BtnAddEtiquette.Location = new Point(113, 88);
            BtnAddEtiquette.Name = "BtnAddEtiquette";
            BtnAddEtiquette.Size = new Size(99, 28);
            BtnAddEtiquette.TabIndex = 2;
            BtnAddEtiquette.Text = "Ajouter";
            BtnAddEtiquette.UseVisualStyleBackColor = true;
            BtnAddEtiquette.Click += BtnAddEtiquette_Click;
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new Point(12, 14);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(82, 21);
            tagLabel.TabIndex = 4;
            tagLabel.Text = "Nouveau...";
            // 
            // BtnSaveTag
            // 
            BtnSaveTag.Location = new Point(113, 462);
            BtnSaveTag.Name = "BtnSaveTag";
            BtnSaveTag.Size = new Size(99, 32);
            BtnSaveTag.TabIndex = 5;
            BtnSaveTag.Text = "Enregistrer";
            BtnSaveTag.UseVisualStyleBackColor = true;
            BtnSaveTag.Click += BtnSaveTag_Click;
            // 
            // FrmGestionTags
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 508);
            Controls.Add(BtnSaveTag);
            Controls.Add(tagLabel);
            Controls.Add(BtnAddEtiquette);
            Controls.Add(listBoxTags);
            Controls.Add(TxtBoxNewTag);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(352, 548);
            MinimumSize = new Size(352, 548);
            Name = "FrmGestionTags";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion des étiquettes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBoxNewTag;
        private ListBox listBoxTags;
        private Button BtnAddEtiquette;
        private Label tagLabel;
        private Button BtnSaveTag;
    }
}