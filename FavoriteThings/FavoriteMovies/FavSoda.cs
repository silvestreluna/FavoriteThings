using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteMovies
{
    class FavSoda
    {
        public string SodaName { get; set; }
        public int Price { get; set; }

        public FavSoda(string sodaName, int sodaPrice)
        {
            SodaName = sodaName;
            Price = sodaPrice;
        }

        public void PrintSodaName ()
        {
            Console.WriteLine($"The soda name is {SodaName}");
        }

        public void GetPriceOfSoda ()
        {
            Console.WriteLine("$2.00");
        }
    }
}
