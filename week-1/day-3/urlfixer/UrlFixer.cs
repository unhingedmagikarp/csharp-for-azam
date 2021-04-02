using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string theRightUrl = "https://www.reddit.com/r/wallstreetbets/";
            string url = "https//www.reddit.com/r/wallstreetapes";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "bets" and not "apes"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Replace("wallstreetapes", "wallstreetbets");
            url = url.Insert(5, ":");
            url += "/";


            Console.WriteLine(url);
            Console.WriteLine(theRightUrl);
        }
    }
}
