using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens do you have?");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pigs do you have?");
            int pigs = Convert.ToInt32(Console.ReadLine());

            int legs = chickens * 4 + pigs * 4;

            Console.WriteLine($"That's {legs} legs");
        }
    }
}
