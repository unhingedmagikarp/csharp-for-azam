using System;
using System.IO;

namespace CountLines
{
    class CountLines
    {
        public static void Main()
        {
            // Write a function that takes a filename as string as a parameter
            // and returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\count-lines\my-file.txt";
            CountLines(fileLocation);

        }
        private static void CountLines(string fileLocation)
        {
            if (File.ReadAllText(fileLocation) != "")
            {
                var lineCount = File.ReadAllLines(fileLocation).Length;
                Console.WriteLine(lineCount);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}