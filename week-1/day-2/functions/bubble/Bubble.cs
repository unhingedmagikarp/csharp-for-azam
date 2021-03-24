using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes an array of numbers as parameter
            //  and returns an array where the elements are sorted in ascending numerical order
            //  When you are done, add a second boolean parameter to the function
            //  If it is `true` sort the array descending, otherwise ascending

            //  Example:
            Console.WriteLine(Bubble(new int[] {34, 12, 24, 9, 5}));
            //  should print [5, 9, 12, 24, 34]
            Console.WriteLine(AdvancedBubble(new int[] {34, 12, 24, 9, 5}, true));
            //  should print [34, 24, 12, 9, 5]
        }
    }
}
