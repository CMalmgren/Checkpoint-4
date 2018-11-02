using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Best movies ever!");
            Console.WriteLine("Copyright Caroline Malmgren, 2018 :D");

            List<Movie> movies = new List<Movie>();
            //previous implementation, no longer in use
            //Console.WriteLine("V for Vendetta");
            //Console.WriteLine("Star Wars Episode V");
            movies.Add(new Movie("V For Vendetta"));
            movies.Add(new Movie("Star Wars Episode V"));


            var bestMovies = movies
                .OrderBy(m => m.Name)
                .Select(m => m.Name);

            foreach (var movie in bestMovies)
            {
                Console.WriteLine(movie);
            }


        }
    }
}
