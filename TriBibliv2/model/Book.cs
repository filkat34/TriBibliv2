﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriBibliv2.model
{
    /// <summary>
    /// Classe métier Livre
    /// </summary>
    [SerializableAttribute]
    public class Book
    {
        /// <summary>
        /// Attributs de la classe Livre
        /// </summary>
        private string titre;
        private string nomAuteur;
        private string prenomAuteur;
        private string genre;// roman, essai, théâtre, poésie, BD, usuels, autres, etc.
        private string statut; //conserver, donner, vendre, recycler
        private string note; //notes sur le livre

        /// <summary>
        /// Constructeur de la classe Livre
        /// </summary>
        /// <param name="unTitre"></param>
        /// <param name="unNomAuteur"></param>
        /// <param name="unPrenomAuteur"></param>
        /// <param name="unGenre"></param>
        /// <param name="unStatut"></param>
        /// <param name="uneNote"></param>
        public Book(string unTitre, string unNomAuteur, string unPrenomAuteur, string unGenre, string unStatut, string uneNote)
        {
            this.titre = unTitre;
            this.nomAuteur = unNomAuteur;
            this.prenomAuteur = unPrenomAuteur;
            this.genre = unGenre;
            this.statut = unStatut;
            this.note = uneNote;
        }

        /// <summary>
        /// Getters et setters de la classe Livre
        /// </summary>
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        public string NomAuteur
        {
            get { return nomAuteur; }
            set { nomAuteur = value; }
        }
        public string PrenomAuteur
        {
            get { return prenomAuteur; }
            set { prenomAuteur = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }
        public string Notes
        {
            get { return note; }
            set { note = value; }
        }
    }
}

