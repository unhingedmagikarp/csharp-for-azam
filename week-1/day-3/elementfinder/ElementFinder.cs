using System;
using System.Collections.Generic;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int>{1, 2, 3, 4, 5};
            ContainsSeven(List);
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!

        }
        private static void ContainsSeven(List<int> input)
        {
            Console.WriteLine(input.Contains(7) == true ? "Hoorray" : "Noooooo");
        }
    }
}
