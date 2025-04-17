using static TriBibliv2.controller.Serialize;
using TriBibliv2.model;

namespace TriBibliv2.controller
{
    public class FrmModifyController
    {
        /// <summary>
        /// Enregistrement de la modification du livre selectionné
        /// </summary>
        /// <param name="livreamodifier"></param>
        /// <param name="livremodifie"></param>
        /// <param name="uneliste"></param>
        /// <param name="unfichier"></param>
        public void ModifyBook(Book livreamodifier, Book livremodifie, List<Book> uneliste, string unfichier)
        {
            // On cherche le livre à modifier dans la liste
            int index = uneliste.FindIndex(livre => livre.Titre == livreamodifier.Titre && livre.NomAuteur == livreamodifier.NomAuteur);
            if (index != -1)
            {
                // On remplace le livre trouvé par le livre modifié
                uneliste[index] = livremodifie;
                // On sauvegarde la liste modifiée dans le fichier JSON
                Serialise.Sauve(unfichier, uneliste);
            }
        }
    }
}
