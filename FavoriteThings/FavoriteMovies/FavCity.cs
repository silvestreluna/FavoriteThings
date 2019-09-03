using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteMovies
{
    class FavCity
    {
        public string CityName { get; set; } = "Nashville";
        public string StateName { get; set; } = "TN";

        public void GoToCity()
        {
            Console.WriteLine($"You are going to {CityName}, {StateName}");
        }
    }
}
