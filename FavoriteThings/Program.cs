using System;
using FavoriteThings.FavoriteMovies;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var getMovieInfo = new Movies();
            var getBookInfo = new MyBooks();
            var mySoda = new FavSoda("Coke", 2);
            var getCityName = new FavCity();

            getMovieInfo.PlayMovie();
            getBookInfo.OpenBook();
            mySoda.PrintSodaName();
            getCityName.GoToCity();

        }
    }
}
