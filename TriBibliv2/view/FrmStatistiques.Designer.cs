namespace TriBibliv2.view
{
    partial class FrmStatistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistiques));
            label1 = new Label();
            labelNbBooks = new Label();
            label3 = new Label();
            ComboBoxStatsEtiquette = new ComboBox();
            dataGridViewStats = new DataGridView();
            BtnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre total de livres :";
            // 
            // labelNbBooks
            // 
            labelNbBooks.AutoSize = true;
            labelNbBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNbBooks.ForeColor = Color.Blue;
            labelNbBooks.Location = new Point(190, 19);
            labelNbBooks.Name = "labelNbBooks";
            labelNbBooks.Size = new Size(37, 21);
            labelNbBooks.TabIndex = 1;
            labelNbBooks.Text = "150";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(235, 21);
            label3.TabIndex = 2;
            label3.Text = "Statistiques par type d'étiquette :";
            // 
            // ComboBoxStatsEtiquette
            // 
            ComboBoxStatsEtiquette.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxStatsEtiquette.FormattingEnabled = true;
            ComboBoxStatsEtiquette.Items.AddRange(new object[] { "Genre", "Note", "Statut" });
            ComboBoxStatsEtiquette.Location = new Point(253, 57);
            ComboBoxStatsEtiquette.Name = "ComboBoxStatsEtiquette";
            ComboBoxStatsEtiquette.Size = new Size(273, 29);
            ComboBoxStatsEtiquette.Sorted = true;
            ComboBoxStatsEtiquette.TabIndex = 3;
            ComboBoxStatsEtiquette.SelectedIndexChanged += ComboBoxStatsEtiquette_SelectedIndexChanged;
            // 
            // dataGridViewStats
            // 
            dataGridViewStats.AllowUserToAddRows = false;
            dataGridViewStats.AllowUserToDeleteRows = false;
            dataGridViewStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStats.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewStats.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats.Cursor = Cursors.Hand;
            dataGridViewStats.EnableHeadersVisualStyles = false;
            dataGridViewStats.Location = new Point(12, 108);
            dataGridViewStats.MultiSelect = false;
            dataGridViewStats.Name = "dataGridViewStats";
            dataGridViewStats.ReadOnly = true;
            dataGridViewStats.RowHeadersVisible = false;
            dataGridViewStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStats.Size = new Size(514, 257);
            dataGridViewStats.TabIndex = 4;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(212, 382);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(96, 32);
            BtnClose.TabIndex = 5;
            BtnClose.Text = "Fermer";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // FrmStatistiques
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 425);
            Controls.Add(BtnClose);
            Controls.Add(dataGridViewStats);
            Controls.Add(ComboBoxStatsEtiquette);
            Controls.Add(label3);
            Controls.Add(labelNbBooks);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(554, 465);
            MinimumSize = new Size(554, 465);
            Name = "FrmStatistiques";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Statistiques de votre bibliothèque";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNbBooks;
        private Label label3;
        private ComboBox ComboBoxStatsEtiquette;
        private DataGridView dataGridViewStats;
        private Button BtnClose;
    }
}