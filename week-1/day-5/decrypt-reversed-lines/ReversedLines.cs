using System;
using System.IO;
using System.Linq;

namespace ReversedLines
{
    class ReversedLines
    {
        public static void Main()
        {
            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\assets\reversed-lines.txt";
            ReversedLines(fileLocation);

        }
        private static void ReversedLines(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            var line = myReader.ReadToEnd();
            myReader.Close();

            using (var writer = new StreamWriter(fileLocation))
            {
                char[] charArray = line.ToCharArray();
                Array.Reverse(charArray);
                var output = new string(charArray);
                Console.WriteLine(output);
                writer.Write(output);
            }
        }
    }
}