using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  and returns an array of integers where every integer is unique (occurs only once)

            //  Example
            Console.WriteLine(FindUniqueItems(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`
        }
    }
}
