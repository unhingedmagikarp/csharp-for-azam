using System;
using System.Collections.Generic;
using System.Linq;

namespace TelephoneBook
{
    class Program
    {
        static Dictionary<string, string> map = new();
        public static void Main()
        {
            map.Add("William A. Lathan", "405-709-1865");
            map.Add("John K. Miller", "402-247-8568");
            map.Add("Hortensia E. Foster", "606-481-6467");
            map.Add("Amanda D. Newland", "319-243-5613");
            map.Add("Brooke P. Askew", "307-687-2982");


            if (map.TryGetValue("John K. Miller", out string associatedValue))
            {
                Console.WriteLine($"John K. Miller's phone number is {associatedValue}");
            }
            var pn = map.First(pair => pair.Value == "307-687-2982");
            Console.WriteLine($"This is {pn.Key}s phone number");
            Console.WriteLine(map.TryGetValue("Chris E. Myers", out var check));
        }

    }
}