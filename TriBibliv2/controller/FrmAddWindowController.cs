using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TriBibliv2.controller.Serialize;
using TriBibliv2.model;

namespace TriBibliv2.controller
{
    public class FrmAddWindowController
    {
        /// <summary>
        /// Ajoute le livre à la liste
        /// Sauvegarde la liste dans le fichier JSON
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book, List<Book> uneliste, string unfichier)
        {
            uneliste.Add(book);
            Serialise.Sauve(unfichier, uneliste);
        }

        /// <summary>
        /// Vérifie si le livre existe déjà dans la liste
        /// </summary>
        /// <param name="unlivre"></param>
        /// <returns></returns>
        public bool DoublonTrouve(Book unlivre, List<Book> listLivres)
        {
            bool doublon = false;

            foreach (Book livre in listLivres)
            {
                if (unlivre.Titre.ToUpper() == livre.Titre.ToUpper() && unlivre.NomAuteur.ToUpper() == livre.NomAuteur.ToUpper())
                {
                    doublon = true;
                    break;
                }
            }
            return doublon;
        }
    }
}
