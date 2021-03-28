using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            // n = rows and m = columns
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int columns = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    if (i == 1 || i == num ||
                        j == 1 || j == columns)
                        Console.Write("%");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


            //something close to this, i cant make it work
            for (x = 0; x < n; r += (y % n * x < 1) | (y == x) | (y == n - x++) ? "*" : " ") ;
        }
    }
}
