using System;
using System.Collections.Generic;
using System.Linq;

namespace ListIntroduction
{
    class ListIntroduction
    {
        public static void Main()
        {
            List<String> names = new List<string>();
            names.Add("William");
            bool isEmpty = !names.Any();
            Console.WriteLine(isEmpty ? "Empty" : "List is not empty");
            names.Add("John");
            names.Add("Amanda");
            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);
            foreach (object n in names)
            {
                Console.WriteLine(n);
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine((i) + 1 + "." + names[i]);
            }
            names.RemoveAt(1);
            for (int i = names.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            names.Clear();
        }
    }
}
