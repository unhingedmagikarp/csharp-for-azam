using System;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        public static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            example.replace("dishwasher", "galaxy");

            // I would like to replace "dishwasher" with "galaxy" in this example variable, but it has a problem
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            Console.WriteLine(example);
        }
    }
}