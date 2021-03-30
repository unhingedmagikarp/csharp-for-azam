using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPractice
{
    class Program
    {
        private static Dictionary<string, double> products = new();
        private static Dictionary<string, int> bobShoppingList = new();
        private static Dictionary<string, int> aliceShoppingList = new();

        public static void Main()
        {
            products.Add("Milk", 1.07);
            products.Add("Rice", 1.59);
            products.Add("Eggs", 3.14);
            products.Add("Cheese", 12.60);
            products.Add("Chicken Breasts", 9.40);
            products.Add("Apples", 2.31);
            products.Add("Tomato", 2.58);
            products.Add("Potato", 1.75);
            products.Add("Onion", 1.10);
            bobShoppingList.Add("Milk", 3);
            bobShoppingList.Add("Rice", 2);
            bobShoppingList.Add("Eggs", 2);
            bobShoppingList.Add("Cheese", 1);
            bobShoppingList.Add("Chicken Breasts", 4);
            bobShoppingList.Add("Apples", 1);
            bobShoppingList.Add("Tomato", 2);
            bobShoppingList.Add("Potato", 1);
            aliceShoppingList.Add("Rice", 1);
            aliceShoppingList.Add("Eggs", 5);
            aliceShoppingList.Add("Chicken Breasts", 2);
            aliceShoppingList.Add("Apples", 1);
            aliceShoppingList.Add("Tomato", 10);
            /*
             Im skipping this, cant work how to do the one below
                - How much does Bob pay?
                - How much does Alice pay?                  
            */

            //- Who buys more Rice?
            var bobRiceAmount = bobShoppingList.FirstOrDefault(x => x.Key == "Rice");
            var aliceRiceAmount = aliceShoppingList.FirstOrDefault(x => x.Key == "Rice");
            Console.WriteLine(bobRiceAmount.Value > aliceRiceAmount.Value
                ? "Bob has bought more rice"
                : "Alice has bought more rice");
            //- Who buys more Potato?
            var bobPotatoAmount = bobShoppingList.FirstOrDefault(x => x.Key == "Potato");
            var alicePotatoAmount = aliceShoppingList.FirstOrDefault(x => x.Key == "Potato");
            Console.WriteLine(bobPotatoAmount.Value > alicePotatoAmount.Value
                ? "Bob has bought more potato's"
                : "Alice has bought more potato's");
            //- Who buys more different products?
            Console.WriteLine(bobShoppingList.Keys.Count > aliceShoppingList.Keys.Count
                ? "Bob buys more unique products"
                : "Alice buys more unique products");
            //-Who buys more products ? (piece)
            Console.WriteLine(bobShoppingList.Skip(1).Sum(v => v.Value) > aliceShoppingList.Skip(1).Sum(v => v.Value)
                 ? "Bob buys more products"
                 : "Alice buys more products");
        }
    }
}
