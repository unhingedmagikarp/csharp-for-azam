using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductDatabase
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
            FishPrice();
            MostExpensive();
            AveragePrice();
            ProductsBelow300();
            ProductsAt125();
            CheapestProduct();
        }
        private static void FishPrice()
        {
            if (products.TryGetValue("Fish", out int price))
            {
                Console.WriteLine($"Fish is priced at {price}");
            }
        }
        private static void MostExpensive()
        {
            int maxValue = products.Values.Max();
            string maxPriceProduct = products.FirstOrDefault(x => x.Value == maxValue).Key;
            Console.WriteLine(maxPriceProduct);
        }
        private static void AveragePrice()
        {
            double averagePriceOfProduct = products.Values.Average();
            Console.WriteLine(averagePriceOfProduct.ToString("N2"));
        }
        private static void ProductsBelow300()
        {
            foreach (var filtered in products.Where(item => item.Value < 300).ToList())
            {
                Console.WriteLine(filtered.Key);
            }
        }
        private static void ProductsAt125()
        {
            var value = 125;
            string productAt125 = products.FirstOrDefault(x => x.Value == value).Key;
            Console.WriteLine(string.IsNullOrEmpty(productAt125) ? "No Product exists at that price" : productAt125);
        }
        private static void CheapestProduct()
        {
            int minValue = products.Values.Min();
            string minPriceProduct = products.FirstOrDefault(x => x.Value == minValue).Key;
            Console.WriteLine(minPriceProduct);
        }
    }
}
