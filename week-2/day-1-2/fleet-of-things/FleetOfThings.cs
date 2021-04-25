using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            Fleet fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main()` method
            // - Download those, use those
            // - In the Main() method create a fleet

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            Thing thing1 = new Thing("Get Milk");
            Thing thing2 = new Thing("Remove the obstacles");
            Thing thing3 = new Thing("Stand up");
            Thing thing4 = new Thing("Eat lunch");
            thing3.Complete();
            thing4.Complete();

            fleet.Add(thing1);
            fleet.Add(thing2);
            fleet.Add(thing3);
            fleet.Add(thing4);

            fleet.Print();
        }
    }
}