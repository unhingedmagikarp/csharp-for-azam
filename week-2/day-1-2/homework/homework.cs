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

            var tree1 = new Tree();

            tree1.treeType.Add("Oak");
            tree1.leafColor.Add("green");
            tree1.age = 300;
            tree1.sex = "Male";

            // repeat for 5 trees
        }

    }
}