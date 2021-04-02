using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            //Console.WriteLine(PutSaturn(planetList));
            PutSaturn(planetList);
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
        }
        private static void PutSaturn(List<string> planetList)
        {
            planetList.Insert(5, "Saturn");
            foreach (var item in planetList)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
