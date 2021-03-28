using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number and the user has to figure it out
            // The user can input guesses
            // After each guess the program would tell one of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
            Random r = new Random();

            int val = r.Next(1, 100);
            bool correct = false;

            Console.WriteLine("I'm thinking of a random number...");

            while (!correct)
            {
                Console.Write("Guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < val)
                {
                    Console.WriteLine("The stored number is higher");
                }
                else if (guess > val)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You found the number: " + val);
                }
            }
        }
    }
}
