using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Logs
{
    class Logs
    {
        public static void Main()
        {
            // Read all data from 'log.txt'
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses
            // Write a function that returns the GET / POST request ratio

            string fileLocation = @"C:\code\InterviewPractice\InterviewPractice\src\Values.txt";
            UniqueIpAddresses(fileLocation);
            GetPostRequestRatio(fileLocation);
        }

        private static void GetPostRequestRatio(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            string line = "";
            List<string> getPostList = new List<string>();

            while ((line = myReader.ReadLine()) != null)
            {
                var result = line.Substring(41, 4);
                string[] stringArray = { result };
                getPostList.Add(String.Join("", stringArray));
            }
            myReader.Close();
            List<string> PostList = new List<string>();
            List<string> GetList = new List<string>();

            foreach (var value in getPostList)
            {
                if (value == "POST")
                {
                    PostList.Add(value);
                }
                else
                {
                    GetList.Add(value);
                }
            }
            Console.WriteLine($"{PostList.Count} unique POST requests");
            Console.WriteLine($"{GetList.Count} unique GET requests");
        }

        private static void UniqueIpAddresses(string fileLocation)
        {
            StreamReader myReader = new StreamReader(fileLocation);
            string line = "";
            List<string> ipAddresses = new List<string>();

            while ((line = myReader.ReadLine()) != null)
            {
                var result = line.Substring(27, 11);
                string[] stringArray = { result };
                ipAddresses.Add(String.Join("", stringArray));
            }
            myReader.Close();

            var uniqueItems = ipAddresses.Distinct().ToList();
            foreach (var ipAddress in uniqueItems)
            {
                Console.WriteLine(ipAddress);
            }
        }
    }
}