using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            Console.WriteLine("Enter your distance in miles");
            double distanceInMiles = Convert.ToDouble(Console.ReadLine());
            double calcDistanceInKm = distanceInMiles * 1.609;
            Console.WriteLine("Distance in Kilometers is " + calcDistanceInKm);
        }
    }
}
