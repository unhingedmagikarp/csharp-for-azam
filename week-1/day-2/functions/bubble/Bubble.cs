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
            Bubble(new[] { 34, 12, 24, 9, 5 });
            //  should print [5, 9, 12, 24, 34]
            AdvancedBubble(new[] { 34, 12, 24, 9, 5 }, true);
            //  should print [34, 24, 12, 9, 5]
        }

        private static void Bubble(int[] numbers)
        {
            Array.Sort(numbers);
            Console.WriteLine("{0}", string.Join(", ", numbers));
        }


        private static void AdvancedBubble(int[] numbers, bool whichSort)
        {
            if (whichSort == true)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
                Console.WriteLine("{0}", string.Join(", ", numbers));
            }
            else
            {
                Array.Sort(numbers);
                Console.WriteLine("{0}", string.Join(", ", numbers));
            }
        }
    }
}
