using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  and returns an array of integers where every integer is unique (occurs only once)

            //  Example
            Console.WriteLine(FindUniqueItems(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`

            public static void FindUniqueItems(int[] inputArray)
            {
                var distinctResult = inputArray.Distinct();
                int[] array = distinctResult.ToArray();
                // Fancy solution i found on google 
                //Dictionary<int, int> hm = new Dictionary<int, int>();
                //for (int i = 0; i < inputArray.Length; i++)
                //{
                //    if (hm.ContainsKey(inputArray[i]))
                //        hm.Remove(inputArray[i]);
                //    hm.Add(inputArray[i], i);
                //}
                //var v = hm.Keys;
                //foreach (int a in v)
                //    Console.Write(a + " ");
                Console.WriteLine(array);
            }
        }
    }
}
