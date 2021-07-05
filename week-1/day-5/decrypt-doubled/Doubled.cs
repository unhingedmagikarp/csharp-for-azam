using System;
using System.IO;
using System.Linq;

namespace Doubled
{
    class Doubled
    {
        public static void Main()
        {
            // Create a method that decrypts the duplicated-chars.txt 
            // Decryption is the process reversing an encryption, i.e. the process
            // which converts encrypted data into its original form.

            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\assets\duplicated-chars.txt";
            DecryptsDuplicatedChars(fileLocation);

        }
        private static void DecryptsDuplicatedChars(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            var line = myReader.ReadToEnd();
            myReader.Close();
            var arrayOfWords = line.Split("  ");
            using (var writer = new StreamWriter(fileLocation))
            {
                for (int i = 0; i < arrayOfWords.Length; i++)
                {
                    string output = new String(arrayOfWords[i].ToCharArray().Distinct().ToArray());
                    output += " ";
                    Console.Write(output);
                    writer.Write(output);

                }
            }
        }
    }
}