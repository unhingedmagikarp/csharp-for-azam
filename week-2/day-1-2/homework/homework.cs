namespace homework
{
    class Program
    {
        public static void Main()
        {
            /*
             - Create 5 trees
               - Store the data of them in variables in your program
               - for every tree the program should store its'
               - type
               - leaf color
               - age
               - sex
               - you can use just variables, or lists and/or maps
             */

            Tree tree1 = new Tree(14, "Green", "Male", "Oak");
            Tree tree2 = new Tree(15, "Black", "Female", "Willow");
            Tree tree3 = new Tree(146, "Blue", "Male", "Yew");
            Tree tree4 = new Tree(123, "White", "Male", "Ivory");
            Tree tree5 = new Tree(142, "Pink", "Male", "Normal");
        }

    }
}