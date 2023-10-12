namespace Lab6_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Steven", "black", "small", "meat", 2, 10);
            dog.MakeSound();
            dog.Run();
            Console.WriteLine();

            Wolf wolf = new Wolf("SnowWhite", "white", "big", "rabbit", 3, "Sweden");
            wolf.MakeSound();
            wolf.Hunting();
            Console.WriteLine();

            Cat cat1 = new Cat("King", "yellow", "big", "fish", 2, "blue");
            cat1.MakeSound();
            cat1.Climbing();
            Console.WriteLine();

            ScottishCat cat2 = new ScottishCat("Queen", "white", "small", "blueberry", 1, "green", true);
            cat2.MakeSound();
            cat2.Climbing();
            Console.WriteLine();

            SphynxCat cat3 = new SphynxCat("ET", "mixed yellow", "small", "cat snack bar", 5, "yellow", false);
            cat3.MakeSound();
            cat3.Climbing();
            Console.WriteLine();
        }
    }
}