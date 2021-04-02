using System;

namespace guessMyNumber
{
    internal class Program
    {
        public static void Main()
        { 
            var random = new Random();
            var randomNum = random.Next(1, 100);
            var userLives = 5;
            bool correct = false;

            Console.WriteLine("I've the number between 1-100. You have 5 lives.");

            while (!correct && userLives > 0)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                var userGuess = 0;
                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (userGuess < randomNum)
                {
                    userLives -= 1;
                    Console.WriteLine($"Too high. You have {userLives} lives left.");
                }
                else if (userGuess > randomNum)
                {
                    userLives -= 1;
                    Console.WriteLine($"Too low. You have {userLives} lives left.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("Congratulations. You won!");
                }
            }
        }
    }
}