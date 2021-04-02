using System;
using System.IO;

namespace WriteSingleLine
{
    class WriteSingleLine
    {
        public static void Main()
        {
            /*!
            Write a function that is able to manipulate a file
            by writing your name into it as a single line.
            The file should be named "my-file.txt".
            In case the program is unable to write the file,
            it should print the following error message: "Unable to write file: my-file.txt".
            */
            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\write-single-line\my-file.txt";
            string text = "beem";
        }


        private static void WriteAndCheckFile(string fileLocation, string text)
        {
            if (File.Exists(fileLocation))
            {
                File.WriteAllText(fileLocation, text);
            }
            else
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
    }
}



