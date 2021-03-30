using System;
using System.Linq;
using static System.String;

namespace PracticeTask
{
    class Program
    {
        public static void Main(string[] args)
        {

            IsAnagram("dog", "god");
            IsAnagram("sds", "god");
        }

        public static void IsAnagram(string input1, string input2)
        {
            string temp1 = Concat(input1.OrderBy(c => c));
            string temp2 = Concat(input2.OrderBy(c => c));

            if (temp1 == temp2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }



    }
}
