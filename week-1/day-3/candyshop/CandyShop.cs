using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Sweets(list);
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }
        private static void Sweets(List<object> input)
        {
            input.Remove(false);
            input.Remove(2);
            input.Insert(1, "Croissant");
            input.Insert(3, "Ice cream");

            foreach (var item in input)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
