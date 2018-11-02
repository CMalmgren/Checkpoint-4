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

            movies
                .OrderBy(m => m.Name);

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
