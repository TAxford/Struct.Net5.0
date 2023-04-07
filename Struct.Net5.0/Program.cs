using System;

namespace Struct.Net5._0
{
    internal class Program
    {
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;
        }


        static void Main(string[] args)
        {
            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01/07/2016";

            Console.WriteLine("Game 1's name is : {0}", game1.name);
            Console.WriteLine("Game 1's developer is : {0}", game1.developer);
            Console.WriteLine("Game 1's rating is : {0}", game1.rating);
            Console.WriteLine("Game 1's release date is : {0}", game1.releaseDate);
        }
    }
}
