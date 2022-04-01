using System;
using System.Linq;
using System.Collections.Generic;

namespace Task09_Game_in_town_
{
    class Program
    {
        static void Main(string[] args)
        {
            var countriesAndCapitals = new Dictionary<string, string>
            {
                {"Russia", "Moscow"},
                {"Hungary", "Budapest"},
                {"USA", "Washington"},
                {"Great Britain", "London"}
            };           
            
            while (true)
            {
                Random random = new();
                int index = random.Next(4);

                KeyValuePair<string, string> kvp = countriesAndCapitals.ElementAtOrDefault(index);
                string countrie = kvp.Key;
                string capital = kvp.Value;
                Console.WriteLine($"Please see the capital of this country: {countrie}");
                string capitalUser = Console.ReadLine();

                if (capitalUser == capital)
                {
                    Console.WriteLine("Your doing great"); 
                }
                else
                {
                    Console.WriteLine("You made a mistake");
                    break;
                }
            }            
        }
    }
}
