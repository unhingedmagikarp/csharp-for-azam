using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as parameters
            //  It returns the indices of the integers of the array which contain the given number
            //  or returns an empty array (if the number is not part of any of the integers in the array)

            //  Example:
            Console.WriteLine(FindMatchingIndexes(1, new int[] {1, 11, 34, 52, 61}));
            //  should print: `[0, 1, 4]`
            Console.WriteLine(FindMatchingIndexes(9, new int[] {1, 11, 34, 52, 61}));
            //  should print: '[]'
        }
    }
}
