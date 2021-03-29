using System;

namespace PracticeTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreatePalindrome("123");
            CreatePalindrome("PracticeTask");

        }

        private static void CreatePalindrome(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversedString = new string(charArray);
            Console.WriteLine(input + reversedString);
        }
    }
}