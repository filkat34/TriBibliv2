using System;
using System.IO;
using System.Text.Json;
using TriBibliv2.model;

namespace TriBibliv2.controller
{
    internal class Serialize
    {
        /// <summary>  
        /// Classe Sérialise  
        /// Permet de sauvegarder en JSON et récupérer des objets  
        /// </summary>  
        public abstract class Serialise
        {
            /// <summary>  
            /// Sérialisation  
            /// </summary>  
            /// <param name="fichier">nom du fichier de sauvegarde</param>  
            /// <param name="objet">objet à sérialiser</param>  
            public static void Sauve(string fichier, object objet)
            {
                // si le fichier existe, il faut le supprimer  
                if (File.Exists(fichier))
                {
                    File.Delete(fichier);
                }
                // sérialisation de l'objet en JSON  
                string json = JsonSerializer.Serialize(objet);
                File.WriteAllText(fichier, json);
            }

            /// <summary>  
            /// Désérialisation  
            /// </summary>  
            /// <param name="fichier">nom du fichier de sauvegarde</param>  
            /// <returns>objet désérialisé</returns>  
            public static List<Book>? Recup(string fichier)
            {
                // Contrôle de l'existence du fichier  
                if (File.Exists(fichier))
                {
                    try
                    {
                        // lecture du contenu du fichier  
                        string json = File.ReadAllText(fichier);
                        // désérialisation de l'objet à partir du JSON  
                        return JsonSerializer.Deserialize<List<Book>>(json);
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}