using System;
using System.IO;

namespace PrintEachLine
{
    class PrintEachLine
    {
        public static void Main()
        {
            /*!
                // Write a program that opens a file called "my-file.txt" and prints
               // each line from the file.
               // If the program is unable to read the file (for example it does not exist),
               // it should print the following error message: "Unable to read file: my-file.txt"
            */
            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\print-each-line\my-file.txt";
            PrintEachFile(fileLocation);

        }
        private static void PrintEachFile(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
                else
                {
                    Console.WriteLine("Unable to read file: my-file.txt");
                }
            }
            myReader.Close();
            Console.ReadLine();
        }
    }
}