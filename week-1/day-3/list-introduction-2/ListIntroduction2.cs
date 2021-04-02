using System;
using System.Collections.Generic;
using System.Linq;

namespace ListIntroduction2
{
    class ListIntroduction2
    {
        public static void Main()
        {
            List<String> ListA = new List<string>();
            ListA.Add("Apple");
            ListA.Add("Avocado");
            ListA.Add("Blueberries");
            ListA.Add("Durian");
            ListA.Add("Lychee");
            List<string> ListB = new List<string>(ListA);
            Console.WriteLine(ListA.Contains("Durian"));
            ListB.Remove("Durian");
            ListA.Insert(3, "Kiwifruit");
            var allLists = new[] { ListA, ListB };
            Console.WriteLine(allLists.All(l => l.Count == allLists[0].Count));
            Console.WriteLine(ListA.IndexOf("Avocado"));
            Console.WriteLine(ListB.IndexOf("Durian"));
            //ListB.Add("Passion Fruit" + "Pomelo");
            ListB.InsertRange(ListB.Count, new[] { "Passion Fruit", "Pomelo" });
            foreach (object n in ListB)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(ListA[2]);
        }
    }
}
