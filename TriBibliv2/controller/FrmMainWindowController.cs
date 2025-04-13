using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriBibliv2.model;
using System.Windows.Forms;
using static TriBibliv2.dal.Serialize;
using static TriBibliv2.view.FrmMainWindow;

namespace TriBibliv2.controller
{
    internal class FrmMainWindowController
    { 
        /// <summary>
        /// Objet pour gérer la liste des livres
        /// </summary>
        List<Book> listLivres = new List<Book>();

        /// <summary>
        /// Récupère et retourne les infos sur les livres
        /// </summary>
        /// <returns>liste des livres</returns>
        public List<Book> GetLesLivres(string nomFichier)
        {
            string nomFic = nomFichier;
            // récupérer la sauvegarde des livres, si elle existe
            Object recupLivres = Serialise.Recup(nomFic);
            if (recupLivres != null)
            {
                listLivres = (List<Book>)recupLivres;
            }
            return listLivres;
        }

        public void SaveBook(List<Book> listeaenregistrer, string nomfichier)
        {
            // sauvegarde de la liste des livres
            Serialise.Sauve(nomfichier, listeaenregistrer);
        }   
    }

}
