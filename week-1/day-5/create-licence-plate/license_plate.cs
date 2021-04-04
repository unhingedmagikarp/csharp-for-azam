using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LicensePlateWords
{
    class Program
    {
        public static void Main()
        {
            /*
             # Exercise
               
               ## Find a Word Based on Licence Plate
               
               Write a program takes a word and see which word(s) contains these letters in a certain way:
               
               - if the licence plate starts with a vowel,
               the word also has to start with the same vowel
               - if it starts with a consonant, it can start with any vowel
               but after the vowel(s) this consonant should come
               - after vowels if the next letter on the licence plate is a consonant
               then this consonant should come as next,
               if the next letter on the licence plate is a vowel
               other consonants can come between them
               - after consonants if the next letter on the licence plate is a consonant
               then any vowel(s) can come between them
               but if the next character in the licence plate is a vowel
               then no other letter can come between them
               - the licence plate can contain a 2-5 letter long string and no numeric
               values, only alphabetical
               
               You can find all the words in the English language in the provided file.
               The file is a txt file and you have to parse it to
               create a list of words from it.
               You can find the source file with the words here [here](../assets/words.txt)
               
               Your task is
               
               - to ask the user for input
               - validate the input
               - parse and search through the terms in the file
               - use exception handling for both validating the input and reading the file
               - return a list of possible words or
               display some meaningful message if there is no such word
               
               Some examples for expected input and output
               
               **input:** *lmo*
               
               **expected output:**
               *{almond, almonds, lemon, lemons, lemonade, lemonades, limousine, limousines}*
               
               **input**: *rdo*
               
               **expected output:**
               *{ardor, ardors, ardour, ardours, readout, readouts,
               redo, redo, redoed, redo, redoes, redo, redoing, redo, redone, redo,
               redos, redouble, redoubled, redouble, redoubles, redouble, redoubling,
               redoubt, redoubts, redound, redounded, redound, redounding, redound,
               redounds}*
               
             */
            //Todo ------------------------------------------------------------------------------------ EXAMPLE
            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\assets\words.txt";
            //Todo ------------------------------------------------------------------------------------ TASK

            LicensePlateWords("lmo", fileLocation);
        }

        private static void LicensePlateWords(string userInput, string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            string line = "";
            List<string> stringData = new List<string>();

            while ((line = myReader.ReadLine()) != null)
            {
                //var singleLine = new String(line.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());
                var singleLine = Regex.Replace(line, @"(\d|\s|_|@|\.|,|-)", string.Empty);
                stringData.Add(String.Join("", singleLine));
            }
            Debugger.Break();
        }
    }
}