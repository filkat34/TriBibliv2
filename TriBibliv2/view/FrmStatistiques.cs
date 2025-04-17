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
    public partial class FrmStatistiques : Form
    {
        /// <summary>
        /// Listes des livres de la bibliothèque
        /// </summary>
        List<Book> listeLivres = new List<Book>();

        public FrmStatistiques(List<Book> uneliste)
        {
            InitializeComponent();
            listeLivres = uneliste;
            labelNbBooks.Text = listeLivres.Count().ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxStatsEtiquette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxStatsEtiquette.SelectedItem.ToString() == "Genre")
            {
                var genres = listeLivres.GroupBy(b => b.Genre)
                                        .Select(g => new { Genre = g.Key, Nombre = g.Count()})
                                        .ToList();
                dataGridViewStats.DataSource = genres;
            }

            if (ComboBoxStatsEtiquette.SelectedItem.ToString() == "Statut")
            {
                var statuts = listeLivres.GroupBy(b => b.Statut)
                                        .Select(g => new { Statut = g.Key, Nombre = g.Count() })
                                        .ToList();
                dataGridViewStats.DataSource = statuts;
            }

            if (ComboBoxStatsEtiquette.SelectedItem.ToString() == "Note")
            {
                var notes = listeLivres.GroupBy(b => b.Note)
                                        .Select(g => new { Note = g.Key, Nombre = g.Count() })
                                        .ToList();
                dataGridViewStats.DataSource = notes;
            }
            

        }
    }
}
