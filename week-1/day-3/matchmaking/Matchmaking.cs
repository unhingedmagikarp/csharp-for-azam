using System;
using System.Collections.Generic;
using System.Linq;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> {"Eve", "Ashley", "Claire", "Kat", "Jane"};
            var boys = new List<string> {"Joe", "Fred", "Tom", "Todd", "Neef", "Jeff"};

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // If someone has no pair, he/she should be the element of the list too
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            MakingMatches(girls, boys);
        }
        private static void MakingMatches(List<string> girls, List<string> boys)
        {
            string[] girlsArray = girls.ToArray();
            string[] boysArray = boys.ToArray();
            var pairing = new string[girlsArray.Length + boysArray.Length];

            for (int i = 0; i < girlsArray.Length; i++)
            {
                girlsArray.CopyTo(pairing, 0);

            }
            for (int i = 0; i < girlsArray.Length; i++)
            {
                boysArray.CopyTo(pairing, i + 1);
            }

            List<string> paired = pairing.ToList();

            foreach (var item in paired)
            {
                Console.Write($"{item}, ");
            }

        }
    }
}
