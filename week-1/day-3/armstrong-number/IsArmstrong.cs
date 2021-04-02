using System;

namespace IsArmstrong
{
    internal class Program
    {
        public static void Main()
        {
            IsArmstrong(371);
            IsArmstrong(45);
        }
        private static void IsArmstrong(int input)
        {
            int sum = 0;
            for (int i = input; i > 0; i = i / 10)
            {
                sum = sum + (int)Math.Pow(i % 10, 3.0);
            }

            if (input == sum)
                Console.WriteLine($"The {input} is an Armstrong number.");
            else
                Console.WriteLine(false);
        }
    }
}