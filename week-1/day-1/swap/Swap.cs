using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int tempNumber = a;
            a = b;
            b = tempNumber;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
