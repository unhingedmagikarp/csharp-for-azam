namespace week2.day12
{
    /*
- Create a `Sharpie` class
       - We should know the followings about each sharpie:
       - `color` (which should be a string),
       - `width` (which will be a floating point number) and the
       - `inkAmount` (another floating point number)
       - We need to specify the `color` and the `width` at creation
       - Every sharpie is created with a default `inkAmount` value: `100`
       - We can `Use()` the sharpie objects: using it decreases
       `inkAmount` by `10`
     
     */
    class Sharpie
    {
        public string _color;
        public float _width;
        public float _inkAmount;

        public Sharpie(string color, float width)
        {
            _color = color;
            _width = width;
            _inkAmount = 100;
        }

        public void Use()
        {
            _inkAmount -= 10;
        }

    }
}
