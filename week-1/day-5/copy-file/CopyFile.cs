using System;
using System.IO;

namespace CopyFile
{
    class CopyFile
    {
        public static void Main()
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take two filenames as parameters
            // It should return a boolean that shows if the copy was successful

            //Todo ------------------------------------------------------------------------------------ EXAMPLE
            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\copy-file\my-file.txt";
            string newFileName = "beem"
            CopyFile(fileLocation, newFileName);

        }
        private static void CopyFile(string sourceFileName, string destFileName)
        {
            try
            {
                File.Copy(copyFrom, copyTo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine(true);
            }
        }
    }
}