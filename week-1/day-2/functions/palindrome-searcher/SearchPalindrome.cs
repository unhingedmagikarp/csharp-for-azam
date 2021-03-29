using System;

namespace PracticeTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            SearchPalindrome("dog goat dad duck doodle never");

        }

        private static void SearchPalindrome(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    if (j - i > 1 && input[j - 1] == input[i])
                    {
                        string currentSubset = input.Substring(i, j - i);
                        Console.WriteLine(currentSubset);
                    }
                }
            }
        }
    }
}