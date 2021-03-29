using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22

            // Print the result of 13 substracted from 22

            // Print the result of 22 multiplied by 13

            // Print the result of 22 divided by 13 (as a decimal fraction)

            // Print the integer part of 22 divided by 13

            // Print the remainder of 22 divided by 13

            Console.WriteLine(22 + 13);
            Console.WriteLine(22 - 13);
            Console.WriteLine(22 * 13);
            Console.WriteLine(((double)22 / 13).ToString("n2"));
            Console.WriteLine(22 / 13);

            var calc = ((double)22 / 13).ToString("n2");
            var splitCalc = calc.Split('.');
            var lastValue = int.Parse(splitCalc[1]);
            var lastInt = Math.Abs(lastValue) % 10;

            Console.WriteLine(lastInt);


            Console.ReadLine();

        }
    }
}
