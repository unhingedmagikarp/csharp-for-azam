namespace InterviewPractice
{
    class Program
    {
        public static void Main()
        {

            Animal dog = new Animal(50, 50);

            dog.Eat();

            Console.WriteLine(dog.Hunger);

        }
    }
}