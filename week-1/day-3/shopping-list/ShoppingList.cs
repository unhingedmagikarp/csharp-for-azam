using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        public static void Main()
        {
            List<String> shoppingList = new List<string>();
            shoppingList.Add("Eggs");
            shoppingList.Add("milk");
            shoppingList.Add("fish");
            shoppingList.Add("apples");
            shoppingList.Add("bread");
            shoppingList.Add("chicken");
            Console.WriteLine(shoppingList.Contains("milk"));
            Console.WriteLine(shoppingList.Contains("bananas"));
        }

    }
}