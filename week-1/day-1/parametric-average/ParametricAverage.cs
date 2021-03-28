using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number
            // It would ask this many times to enter an integer
            // If all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            string number;
            double total = 0;
            int numbers = 0;
            while ((number = Console.ReadLine()) != "")
            {
                var average = total / numbers;
                total += double.Parse(number);
                numbers++;

                Console.WriteLine("Sum: " + total + ", " + "Average: " + average);
            }
        }
    }
}
