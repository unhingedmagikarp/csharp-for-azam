using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;

            double heightInCM = heightInM * 100;

            double bmi = (massInKg / heightInCM / heightInCM) * 10000;

            Console.WriteLine("BMI is " + bmi.ToString("n2"));
        }
    }
}
