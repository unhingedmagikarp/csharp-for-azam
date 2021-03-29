using System;
using System.Collections.Generic;
using System.Linq;

namespace MapIntroduction
{
    class MapIntroduction
    {
        public static void Main()
        {
            var map = new Dictionary<int, char>();
            bool isEmpty = !map.Any();
            Console.WriteLine(isEmpty);
            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');
            foreach (var pair in map)
            {
                char value = pair.Value;
                Console.WriteLine(value);
            }
            foreach (var pair in map)
            {
                int key = pair.Key;
                Console.WriteLine(key);
            }
            map.Add(68, 'D');
            Console.WriteLine(map.Count);
            if (map.TryGetValue(99, out char result))
            {
                Console.WriteLine(result);
            }
            map.Remove(97);
            if (map.TryGetValue(100, out char result2))
            {
                Console.WriteLine(result2);
            }
            else
            {
                Console.WriteLine(false);
            }
            map.Clear();
        }
    }
}