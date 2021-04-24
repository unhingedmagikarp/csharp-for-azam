using System;

namespace week2.day12
{
    class Program
    {
        public static void Main()
        {

            Sharpie s1 = new Sharpie("blue", 5);

            s1.Use();

            Console.WriteLine(s1._inkAmount);

        }
    }
}