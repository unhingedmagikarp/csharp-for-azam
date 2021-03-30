using System;

namespace PrintParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `PrintParams`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // PrintParams("first")
            // PrintParams("first", "second")
            // PrintParams("first", "second", "third", "fourh")
            // ...
            PrintParams("yes", "second");
        }
        static void PrintParams(string input1, string input2)
        {
            Console.WriteLine(input1, input2);
        }
    }
}
