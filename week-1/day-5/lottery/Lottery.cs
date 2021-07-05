using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterviewPractice
{
    class Program
    {
        public static void Main()
        {
            // Create a method that find the 5 most common lottery numbers in lottery.csv

            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\assets\lottery.csv";

            CommonLotteryNumbers(fileLocation);
        }

        private static void CommonLotteryNumbers(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            string line = "";
            List<string> allStringData = new List<string>();
            List<int> columnOne = new List<int>();
            List<int> columnTwo = new List<int>();
            List<int> columnThree = new List<int>();
            List<int> columnFour = new List<int>();
            List<int> columnFive = new List<int>();
            var map = new Dictionary<string, int>();

            while ((line = myReader.ReadLine()) != null)
            {
                var result = line;
                string[] stringArray = { result };
                allStringData.Add(String.Join("", stringArray));
            }

            foreach (var s in allStringData)
            {
                string splitWord = "Ft;";
                var split = s.Substring(s.IndexOf(splitWord) + splitWord.Length);
                var split2 = split.Substring(split.IndexOf(splitWord) + splitWord.Length);
                var split3 = split2.Substring(split2.IndexOf(splitWord) + splitWord.Length);
                var split4 = split3.Substring(split3.IndexOf(splitWord) + splitWord.Length);

                string[] splitString = split4.Split(';');

                columnOne.Add(int.Parse(splitString[0].Trim()));
                columnTwo.Add(int.Parse(splitString[1].Trim()));
                columnThree.Add(int.Parse(splitString[2].Trim()));
                columnFour.Add(int.Parse(splitString[3].Trim()));
                columnFive.Add(int.Parse(splitString[4].Trim()));
            }

            List<int> winningColumnOne = new List<int>();
            List<int> winningColumnTwo = new List<int>();
            List<int> winningColumnThree = new List<int>();
            List<int> winningColumnFour = new List<int>();
            List<int> winningColumnFive = new List<int>();


            var array1 = columnOne.ToArray();
            var resultCheck1 = array1.GroupBy(i => i).OrderBy(g => g.Count()).Select(g => g.Key).ToList();
            foreach (var item in resultCheck1.Skip(resultCheck1.Count - 5))
            {
                winningColumnOne.Add(item);
            }

            var array2 = columnTwo.ToArray();
            var resultCheck2 = array2.GroupBy(i => i).OrderBy(g => g.Count()).Select(g => g.Key).ToList();
            foreach (var item in resultCheck2.Skip(resultCheck2.Count - 5))
            {
                winningColumnTwo.Add(item);
            }

            var array3 = columnThree.ToArray();
            var resultCheck3 = array3.GroupBy(i => i).OrderBy(g => g.Count()).Select(g => g.Key).ToList();
            foreach (var item in resultCheck3.Skip(resultCheck3.Count - 5))
            {
                winningColumnThree.Add(item);
            }

            var array4 = columnFour.ToArray();
            var resultCheck4 = array4.GroupBy(i => i).OrderBy(g => g.Count()).Select(g => g.Key).ToList();
            foreach (var item in resultCheck4.Skip(resultCheck4.Count - 5))
            {
                winningColumnFour.Add(item);
            }

            var array5 = columnFive.ToArray();
            var resultCheck5 = array5.GroupBy(i => i).OrderBy(g => g.Count()).Select(g => g.Key).ToList();
            foreach (var item in resultCheck5.Skip(resultCheck5.Count - 5))
            {
                winningColumnFive.Add(item);
            }


            for (int i = 5 - 1; i >= 0; i--)
            {
                Console.WriteLine($"{winningColumnOne[i]};{winningColumnTwo[i]};{winningColumnThree[i]};{winningColumnFour[i]};{winningColumnFive[i]}");
            }
        }
    }
}