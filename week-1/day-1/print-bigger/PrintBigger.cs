using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Enter two numbers to check which is better");
            Console.WriteLine("Enter first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int highest = Math.Max(number1, number2);
            Console.WriteLine(highest + " is the biggest");
        }
    }
}
