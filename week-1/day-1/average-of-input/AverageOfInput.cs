using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int[] numbers = new int[5];

            int a = 0;

            Console.WriteLine("Enter 5 numbers:");

            while (a < 5)
            {
                if (int.TryParse(Console.ReadLine(), out numbers[a]))
                    a++;
            }

            var average = numbers.Average();
            var sum = numbers.Sum();

            //Console.WriteLine($"Sum: {sum}, Average: {average}");
            Console.WriteLine("Sum: " + sum + " Average: " + average);
        }
    }
}
