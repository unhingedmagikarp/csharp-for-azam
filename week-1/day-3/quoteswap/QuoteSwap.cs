using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            QuoteSwap(list);
            // Expected output: "What I cannot create I do not understand." 
            private static void QuoteSwap(List<string> input)
            {
                input.Remove("cannot");
                input.Insert(2, "cannot");
                input.Remove("create,");
                input.Insert(3, "create");
                input.Remove("do");
                input.Insert(5, "do");
                foreach (var item in input)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
