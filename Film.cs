using System;

namespace dm_cinema
{
    public class Film
    {
        // Attributs privés
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal; // Ajout de l'attribut acteurPrincipal

        // Constructeur prenant en paramètres tous les attributs privés
        public Film(int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal; // Initialisation de l'acteur principal
        }

        // Méthode getInstance qui instancie un objet Film
        public static Film getInstance(int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            return new Film(annee, genre, idFilm, resume, titre, acteurPrincipal);
        }

        // Accesseur pour acteurPrincipal
        public Acteur GetActeurPrincipal()
        {
            return acteurPrincipal;
        }

        // Les autres accesseurs restent inchangés

        // Méthode ToString pour afficher les informations du film
        public override string ToString()
        {
            return $"Titre : {titre}\nAnnée : {annee}\nGenre : {genre}\nRésumé : {resume}";
        }
    }
}
