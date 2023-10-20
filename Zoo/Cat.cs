using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cat : Animal
    {
        private bool Scrach { get; set; }

        public Cat(string animalname, int age, int speed, string country, int weight, bool scrach)
            : base(animalname, age, speed, country, weight)
        {
            Scrach = scrach;
        }

        public void Humans()
        {
            Console.WriteLine("The cat like humans");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The cat meows");
        }
    }
}
