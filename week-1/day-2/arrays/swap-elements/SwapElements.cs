using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`
            string[] orders = { "first", "second", "third" };
            var temp = "";
            temp = orders[2];
            orders[2] = orders[0];
            orders[0] = temp;

            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
