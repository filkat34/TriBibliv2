using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriBibliv2.model;

namespace TriBibliv2.view
{
    /// <summary>
    /// Fenêtre de statistiques
    /// </summary>
    public partial class FrmStatistiques : Form
    {
        /// <summary>
        /// Listes des livres de la bibliothèque
        /// </summary>
        List<Book> listeLivres = new List<Book>();

        /// <summary>
        /// Initialisation de la fenêtre des statistiques
        /// </summary>
        /// <param name="uneliste"></param>
        public FrmStatistiques(List<Book> uneliste)
        {
            InitializeComponent();
            listeLivres = uneliste;
            labelNbBooks.Text = listeLivres.Count().ToString();
            ComboBoxStatsEtiquette.SelectedIndex = 0;
        }

        /// <summary>
        /// Demande de fermeture de la fenêtre de statistiques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Affichage des statistiques en fonction de la sélection de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxStatsEtiquette_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = ComboBoxStatsEtiquette.SelectedItem.ToString();
            List<string> listStats = new List<string>();

            if (ComboBoxStatsEtiquette.SelectedItem.ToString() == "Genre")
            {
                var genres = listeLivres.GroupBy(b => b.Genre)
                                        .Select(g => new { Genre = g.Key, Nombre = g.Count(), Pourcentage = g.Count() * 100 / listeLivres.Count() + "%" })
                                        .ToList();
                genres.Sort((stat2, stat1) => stat1.Nombre.CompareTo(stat2.Nombre));
                dataGridViewStats.DataSource = genres;
            }

            if (ComboBoxStatsEtiquette.SelectedItem.ToString() == "Statut")
            {
                var statuts = listeLivres.GroupBy(b => b.Statut)
                                        .Select(g => new { Statut = g.Key, Nombre = g.Count(), Pourcentage = g.Count() * 100 / listeLivres.Count() + "%" })
                                        .ToList();
                statuts.Sort((stat2, stat1) => stat1.Nombre.CompareTo(stat2.Nombre));
                dataGridViewStats.DataSource = statuts;
            }

            if (ComboBoxStatsEtiquette.SelectedItem.ToString() == "Note")
            {
                var notes = listeLivres.GroupBy(b => b.Note)
                                        .Select(g => new { Note = g.Key, Nombre = g.Count(), Pourcentage = g.Count() * 100 / listeLivres.Count() + "%" })
                                        .ToList();
                notes.Sort((stat2, stat1) => stat1.Nombre.CompareTo(stat2.Nombre));
                dataGridViewStats.DataSource = notes;
            }
        }
    }
}
