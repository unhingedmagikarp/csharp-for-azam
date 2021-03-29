using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= num - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
