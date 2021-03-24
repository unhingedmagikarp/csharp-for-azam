using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            Console.WriteLine("Calculate surface area and volume of a cuboid");
            Console.WriteLine("Enter Length: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            double w = Convert.ToDouble(Console.ReadLine());


            double volumeCuboid = (l * h * w);

            double surfaceAreaCuboid = (2 * l * w + 2 * w * h + 2 * l * h);

            Console.WriteLine("Surface Area: " + surfaceAreaCuboid);
            Console.WriteLine("Volume: " + volumeCuboid);
        }
    }
}
