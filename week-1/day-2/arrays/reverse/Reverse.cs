using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements of `numbers`
            // - Print the elements of the reversed `numbers`
            int[] numbers = { 3, 4, 5, 6, 7 };

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}
