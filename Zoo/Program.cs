namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog animal = new Dog("Dog", 10, 20, "Sweden", 20, "Golden Retriever");

            Cow cow = new Cow("Cow", 20, 5, "Spain", 200, 3);

            Bulldog bulldog = new Bulldog("Dog", 6, 25, "China", 30, "BullDog", 20);


            animal.MakeSound();

            Console.WriteLine();

            animal.Play();

            Console.WriteLine();

            cow.MakeSound();

            Console.WriteLine();

            cow.Alive();

            Console.WriteLine();

            bulldog.MakeSound();

            Console.WriteLine();

            bulldog.Lazy();
        }
    }
}