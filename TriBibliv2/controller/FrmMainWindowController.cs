using TriBibliv2.model;
using static TriBibliv2.controller.Serialize;


namespace TriBibliv2.controller
{
    public class FrmMainWindowController
    { 
        /// <summary>
        /// Objet pour gérer la liste des livres
        /// </summary>
        List<Book> listLivres = new List<Book>();

        /// <summary>
        /// nom du fichier de sauvegarde
        /// </summary>
        string nomFic = "sauvLivres.json";

        /// <summary>
        /// dossier de sauvegarde
        /// </summary>
        string dossierSauvegarde = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TriBibli");


        /// <summary>
        /// Création du dossier de sauvegarde s'il n'existent pas
        /// Enregistrement du chemin d'accès au fichier de sauvegarde
        /// </summary>
        public void CreateSaveFolder() { 
            Directory.CreateDirectory(dossierSauvegarde);
            nomFic = Path.Combine(dossierSauvegarde, "sauvLivres.json");
        }

        /// <summary>
        /// Récupère et retourne les informations sur les livres
        /// </summary>
        /// <returns>liste des livres</returns>
        public List<Book> GetBooks()
        {
            List<Book> recupLivres = Serialise.Recup(nomFic);
            if (recupLivres != null)
            {
                listLivres = recupLivres;
            }
            return listLivres;
        }

        /// <summary>
        /// Supprime le livre de la liste
        /// Sauvegarde la liste dans le fichier JSON
        /// </summary>
        /// <param name="book"></param>
        public void DelBook(Book book)
        {
            listLivres.Remove(book);
            Serialise.Sauve(nomFic, listLivres);
        }
    }
}
