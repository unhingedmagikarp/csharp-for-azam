using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var animals = new List<string> {"bo", "anacond", "koal", "pand", "zebr"};
            // Create a method called AppendA() that adds "a" to every string in the animals list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(animals));
            // Expected output: "boa", "anaconda", "koala", "panda", "zebra"
        }
    }
}
