using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `numbers`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[3]++);
        }
    }
}
