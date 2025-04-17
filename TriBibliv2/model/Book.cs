namespace TriBibliv2.model
{
    /// <summary>
    /// Classe métier Livre
    /// </summary>
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
        private string note; //note sur le livre
        private string observation; //observations sur le livre


        /// <summary>
        /// Constructeur vide utile pour la déserialization
        /// permet d'instancier l'objet avant de pouvoir définir les valeurs des champs à partir des données JSON
        /// </summary>
        public Book()
        {
            titre = string.Empty;
            nomAuteur = string.Empty;
            prenomAuteur = string.Empty;
            genre = string.Empty;
            statut = string.Empty;
            note = string.Empty;
            observation = string.Empty;
        }

        /// <summary>
        /// Constructeur de la classe Livre
        /// </summary>
        /// <param name="unTitre"></param>
        /// <param name="unNomAuteur"></param>
        /// <param name="unPrenomAuteur"></param>
        /// <param name="unGenre"></param>
        /// <param name="unStatut"></param>
        /// <param name="uneNote"></param>
        /// <<param name="uneObservation"></param>
        public Book(string unTitre, string unNomAuteur, string unPrenomAuteur, 
            string unGenre, string unStatut, string uneNote, string uneObservation)
        {
            this.titre = unTitre;
            this.nomAuteur = unNomAuteur;
            this.prenomAuteur = unPrenomAuteur;
            this.genre = unGenre;
            this.statut = unStatut;
            this.note = uneNote;
            this.observation = uneObservation;
        }

        /// <summary>
        /// Getter et setter de l'attribut titre
        /// </summary>
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        /// <summary>
        /// Getter et setter de l'attribut nomAuteur
        /// </summary>
        public string NomAuteur
        {
            get { return nomAuteur; }
            set { nomAuteur = value; }
        }

        /// <summary>
        /// Getter et setter de l'attribut prenomAuteur
        /// </summary>
        public string PrenomAuteur
        {
            get { return prenomAuteur; }
            set { prenomAuteur = value; }
        }

        /// <summary>
        /// Getter et setter de l'attribut genre
        /// </summary>
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        /// <summary>
        /// Getter et setter de l'attribut statut
        /// </summary>
        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        /// <summary>
        /// Getter et setter de l'attribut note
        /// </summary>
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        /// <summary>
        /// Getter et setter de l'attribut observation
        /// </summary>
        public string Observation
        {
            get { return observation; }
            set { observation = value; }
        }
        
    }
}

