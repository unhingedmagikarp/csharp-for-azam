using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinance
{
    class Program
    {
        static List<int> expenses = new();
        public static void Main()
        {
            expenses.Add(500);
            expenses.Add(1000);
            expenses.Add(1250);
            expenses.Add(175);
            expenses.Add(800);
            expenses.Add(120);
            TotalSpent();
            GreatestExpense();
            CheapestSpending();
            AverageSpendings();

        }

        private static void TotalSpent()
        {
            Console.WriteLine(expenses.Sum());
        }
        private static void GreatestExpense()
        {
            Console.WriteLine(expenses.Max());
        }
        private static void CheapestSpending()
        {
            Console.WriteLine(expenses.Min());
        }
        private static void AverageSpendings()
        {
            Console.WriteLine(expenses.Average());
        }
    }
}