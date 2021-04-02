using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String which is passed as the parameter
            // Pass the toBeReversed variable to this method to check if it works well

            Console.WriteLine(Reverse(toBeReversed));
        }
        public static string Reverse(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
