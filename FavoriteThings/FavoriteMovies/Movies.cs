using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteMovies
{
    class Movies
    {
        public string MovieName { get; set; } = "Holes";
        public string ActorName { get; set; } = "Shia Labeouf";

        public void PlayMovie ()
        {
            Console.WriteLine($"Playing {MovieName}, and the actor is {ActorName}");
        }

        public void giveMovieRate()
        {
            Console.WriteLine("Please rate this movie");
            var userEnteredRating = Console.ReadLine();
            Console.WriteLine(userEnteredRating);
        }
    }
}
