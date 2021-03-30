using System;
using System.Collections.Generic;
using System.Linq;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int>{2, 4, 6, 8, 10, 12, 14, 16};

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            //var result = input.Where(num =>
            //    input.Any(num => num.Equals(4) || num.Equals(8) || num.Equals(12) || num.Equals(16)));
            CheckNums(list);
        }
        private static void CheckNums(List<int> input)
        {
            int[] array = input.ToArray();
            Console.WriteLine(array.Any(x => x == 4 || x == 8 || x == 12 || x == 16));
        }
    }
}
