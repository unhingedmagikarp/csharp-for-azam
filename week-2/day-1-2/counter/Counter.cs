namespace week2.day12
{
    class Counter
    {
        /*
         - Create `Counter` class
           - which has a `counter` (integer) field
           - at creation it should have a default value `0` or can be specified
           by a parameter
           - we can add another whole number to this counter: `add(number)`
           - we can just increase the counter's value by one: `add()` (no parameters)
           - we can `get()` the current counter value
           - and we can `reset()` the counter to the initial value
           
         */
        private int _counter = 0;

        public Counter(int counter)
        {
            _counter = counter;
        }

        public void Add(int number)
        {
            _counter += number;
        }
        public void Add()
        {
            _counter += 1;
        }

        public int Get()
        {
            return _counter;
        }

        public int Reset()
        {
            return _counter = 0;
        }

    }
}
