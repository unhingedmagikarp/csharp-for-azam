using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `baseNumber` and assign the value `123` to it
            // - Create a function called `DoubleNumber()` that doubles it's input parameter
            //   and returns the doubled value
            // - Print the result of `DoubleNumber(baseNumber)`
            int baseNumber = 6;
            DoubleNumber(baseNumber);
        }
        static void DoubleNumber(int input)
        {
            Console.WriteLine(input * 2);
        }
    }
}
