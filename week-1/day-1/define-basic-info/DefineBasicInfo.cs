using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            string name = "BeeM";
            int age = 69;
            double height = 10.10;
            bool marriageStatus = true;


            Console.WriteLine($"Name - {name}");
            Console.WriteLine($"Age - {age}");
            Console.WriteLine($"Height - {height}");
            Console.WriteLine($"Marriage status - {marriageStatus}");


            Console.ReadLine();
        }
    }
}
