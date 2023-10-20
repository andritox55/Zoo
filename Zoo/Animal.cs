using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        public string AnimalName { get; set; }

        public int Age { get; set; }

        public int Speed { get; set; }

        public string Country { get; set; }

        public int Weight { get; set; }

        public Animal(string animalname, int age, int speed, string country, int weight)
        {
            AnimalName = animalname;

            Age = age;

            Speed = speed;

            Country = country;

            Weight = weight;
        }

        public void Eat()
        {
            Console.WriteLine("The animal eat");
        }

        public void Move()
        {
            Console.WriteLine("The animal moves");
        }

        public void Alive()
        {
            Console.WriteLine("The animal is alive");
        }

        public void Hunt()
        {
            Console.WriteLine("The animal hunts");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal rest");
        }
    }
}
