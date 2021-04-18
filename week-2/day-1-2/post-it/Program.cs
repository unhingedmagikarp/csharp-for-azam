namespace week2.day12
{
    class Program
    {
        public static void Main()
        {
            /*
            - Create a `PostIt` a struct that has
               - a `BackgroundColor`
               - a `Text` on it
               - a `TextColor`
               - Create a few example post-it objects:
               - an orange with blue text: "Idea 1"
               - a pink with black text: "Awesome"
               - a yellow with green text: "Superb!"

             */

            PostIt example1 = new PostIt("orange", "Idea 1", "blue");
            PostIt example2 = new PostIt("pink", "Awesome", "black");
            PostIt example3 = new PostIt("yellow", "Superb!", "green");

        }
    }
}
