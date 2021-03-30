using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `calculateFactorial()`
            //   that returns the factorial of its input
            int num = 5;
            CalculateFactorial(num);
        }
        static void CalculateFactorial(int input)
        {
            int f = input;
            for (int i = f - 1; i > 0; i--)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }
    }
}
