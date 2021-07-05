using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace DivideByZero
{
    class DivideByZero
    {
        public static void Main()
        {
            /*!
                // Create a function that divides number 10
               // by a number that's passed as a paramater and prints the result.
               // It should print "fail" if the parameter is 0
            */
            DivideByTen(50);
            DivideByTen(0);

        }

        private static void DivideByTen(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("fail");
            }
            else
            {
                int result = 10 / num;
                Console.WriteLine(result);
            }
        }
    }
}