using System;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it!
            // Insert the words "always takes longer than" between the words "It" and "you" using the StringBuilder class!
            // Use pieces of the quote variable (instead of just redefining the string)!

            StringBuilder sb = new StringBuilder(quote);
            //sb.Insert(20, " always takes longer than");
            //Console.WriteLine(sb);
            sb.Insert(sb.ToString().IndexOf("It") + 2, " always takes longer than");
            Console.WriteLine(sb.ToString());
        }
    }
}