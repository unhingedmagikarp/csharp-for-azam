namespace week2.day12
{
    class Animal
    {
        /*
         - Create an `Animal` class
           - Every animal has a `hunger` value, which is a whole number
           - Every animal has a `thirst` value, which is a whole number
           - When creating a new animal instance these values must be set to the
           default `50` value
           - Every animal can `eat()` which decreases its hunger by one
           - Every animal can `drink()` which decreases its thirst by one
           - Every animal can `play()` which increases both its hunger and thirst by one
         */

        public int Hunger = 50;
        public int Thirst = 50;

        public Animal(int hunger, int thirst)
        {
            Hunger = hunger;
            Thirst = thirst;
        }

        public void Eat()
        {
            Hunger -= 1;
        }

        public void Drink()
        {
            Thirst -= 1;
        }

        public void Play()
        {
            Hunger += Hunger;
            Thirst += Thirst;
        }
    }
}
    