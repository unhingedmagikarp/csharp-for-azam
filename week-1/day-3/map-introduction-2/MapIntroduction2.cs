using System;
using System.Collections.Generic;
using System.Linq;

namespace MapIntroduction2
{
    class MapIntroduction2
    {
        public static void Main()
        {
            var map = new Dictionary<string, string>();
            map.Add("978-1-60309-452-8", "A Letter to Jo");
            map.Add("978-1-60309-459-7", "Lupus");
            map.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            map.Add("978-1-60309-461-0", "The Lab");
            foreach (var pair in map)
            {
                string value = pair.Value;
                string key = pair.Key;
                Console.WriteLine($"{value} ({key})");
            }
            map.Remove("978-1-60309-444-3");
            map.Remove("978-1-60309-444-3");
            var item = map.First(pair => pair.Value == "The Lab");
            map.Remove(item.Key);
            map.Add("978-1-60309-450-4", "They Called Us Enemy");
            map.Add("978-1-60309-453-5", "Why Did We Trust Him?");
            if (map.TryGetValue("478-0-61159-424-8", out string result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(false);
            }
            if (map.TryGetValue("978-1-60309-453-5", out string associatedValue))
            {
                Console.WriteLine(associatedValue);
            }
        }
    }
}