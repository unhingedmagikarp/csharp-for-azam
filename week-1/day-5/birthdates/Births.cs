using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace Births
{
    class Program
    {
        public static void Main()
        {
            // Create a function that
            // - takes the name of a CSV file as a parameter,
            //   - every row is in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
            // - and returns the year when the most births happened.
            //   - if there were multiple years with the same number of births then return any of them

            // You can find such a CSV file in this directory named births.csv
            // If you pass "births.csv" to your function, the result should be either 2006 or 2016.

            string fileLocation = @"S:\Work\Code\peter-keller\csharp-for-azam\week-1\day-5\assets\births.csv";
            Births(fileLocation);
        }
        private static void Births(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            string line = "";
            List<string> stringData = new List<string>();

            while ((line = myReader.ReadLine()) != null)
            {
                var singleLine = line.Split(";");
                var birthYearOnly = singleLine[1].Substring(0, 4);
                //dataArray.Append(result[1])
                string[] dataArray = { birthYearOnly };
                stringData.Add(String.Join("", dataArray));
            }
            List<int> birthYears = stringData.ConvertAll(int.Parse);

            var mostBirthsInOneYear = birthYears.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Select(grp => grp.Key).First();

            Console.WriteLine(mostBirthsInOneYear);
        }
    }
}