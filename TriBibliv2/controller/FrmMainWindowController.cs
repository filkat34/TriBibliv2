﻿using System.Xml.Linq;
using TriBibliv2.model;
using static TriBibliv2.controller.Serialize;


namespace TriBibliv2.controller
{
    /// <summary>
    /// Contrôleur de la fenêtre principale
    /// </summary>
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

        /// <summary>
        /// Exporte la liste des livres dans un fichier JSON
        /// </summary>
        /// <param name="pathfolder"></param>
        public void ExportBooks(string pathfolder)
        {
            File.Copy(nomFic, Path.Combine(pathfolder, "TriBibliexport.json"), true);
        }

        /// <summary>
        /// Importe la liste des livres depuis un fichier JSON
        /// </summary>
        /// <param name="pathfolder"></param>
        public void ImportBooks(string pathfolder)
        {
            File.Copy(pathfolder, nomFic, true);
        }

        /// <summary>
        /// Demande d'ouverture du dossier de sauvegarde
        /// </summary>
        public void OpenSaveFolder ()
        {
            System.Diagnostics.Process.Start("explorer.exe", dossierSauvegarde);
        }
    }
}
