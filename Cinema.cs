using dm_cinema;
using System;
using System.Collections.Generic;

public class Cinema
{
    private List<Acteur> lesActeurs;
    private List<Film> lesFilms;

    public Cinema()
    {
        this.lesActeurs = new List<Acteur>();
        this.lesFilms = new List<Film>();
    }

    public static Cinema GetInstance()
    {
        return new Cinema();
    }

    // Méthode pour ajouter un acteur à la liste d'acteurs
    public void AjouterActeur(Acteur acteur)
    {
        lesActeurs.Add(acteur);
    }

    // Méthode pour ajouter un film à la liste de films
    public void AjouterFilm(Film film)
    {
        lesFilms.Add(film);
    }

    // Méthode pour obtenir un acteur par son ID
    public Acteur GetActeur(int id)
    {
        foreach (Acteur acteur in lesActeurs)
        {
            if (acteur.Id == id)
            {
                return acteur;
            }
        }
        return null;
    }

    // Méthode pour obtenir un film par son ID
    public Film GetFilm(int id)
    {
        foreach (Film film in lesFilms)
        {
            if (film.IdFilm == id)
            {
                return film;
            }
        }
        return null;
    }

    // Méthode pour obtenir le nombre d'acteurs
    public int NbActeur()
    {
        return lesActeurs.Count;
    }

    // Méthode pour obtenir le nombre de films
    public int NbFilm()
    {
        return lesFilms.Count;
    }
}
