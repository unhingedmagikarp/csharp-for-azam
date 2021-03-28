using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum()` that returns the sum of numbers from zero to the given parameter
            int num = 5;
            // 5 + 4 + 3 + 2 + 1 + 0 = 15
            Sum(num);
        }

        static void Sum(int input)
        {
            int sum = 0;
            for (int i = 0; i <= input; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
