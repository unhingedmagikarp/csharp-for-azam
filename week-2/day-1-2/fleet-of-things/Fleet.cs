using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        private readonly List<Thing> _things;

        public Fleet()
        {
            _things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            _things.Add(thing);
        }

        public void Print()
        {
            foreach (var thing in _things)
            {
                if (thing.Completed)
                {
                    Console.WriteLine($"[x] {thing.Name}");
                }
                else
                {
                    Console.WriteLine($"[ ] {thing.Name}");
                }

            }
        }
    }
}