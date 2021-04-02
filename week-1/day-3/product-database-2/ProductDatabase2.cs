using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductDatabase2
{
    class Program
    {
        private static Dictionary<string, int> products = new();
        public static void Main()
        {
            products.Add("Eggs", 200);
            products.Add("Milk", 200);
            products.Add("Fish", 400);
            products.Add("Apples", 150);
            products.Add("Bread", 50);
            products.Add("Chicken", 550);
            ProductsLessThan201();
            ProductsMoreThan150();
        }
        private static void ProductsLessThan201()
        {
            foreach (var filtered in products.Where(item => item.Value < 201).ToList())
            {
                Console.WriteLine(filtered.Key);
            }
        }
        private static void ProductsMoreThan150()
        {
            foreach (var filtered in products.Where(item => item.Value > 150).ToList())
            {
                Console.WriteLine($"{filtered.Key} {filtered.Value}");
            }
        }
        private static void FishPrice()
        {
            if (products.TryGetValue("Fish", out int price))
            {
                Console.WriteLine($"Fish is priced at {price}");
            }
        }
    }
}
