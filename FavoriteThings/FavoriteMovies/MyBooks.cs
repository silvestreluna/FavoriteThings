using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavoriteMovies

{
    class MyBooks
    {
        public string BookTitle { get; set; } = "It";
        public string BookAuther { get; set; } = "Stephen King";

        public void OpenBook()
        {
            Console.WriteLine($"{BookTitle} is open.");
        }

        public void CloseBook()
        {
            Console.WriteLine($"{BookTitle} is closed.");
        }
    }
}