using dm_cinema;
using System;

public class Program
{
    public static void Main()
    {
        
        Film monFilm = Film.getInstance(1982, "Science-Fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner");

    
        Console.WriteLine(monFilm.ToString());

        Acteur monActeur = Acteur.getInstance(1, "Ford", "Harrison", 1942);

        
        Console.WriteLine(monActeur.ToString());








    }




}

