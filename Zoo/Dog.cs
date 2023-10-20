using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Dog : Animal
    {
        public string Breed { get; set; }


        public Dog(string name, int age, int speed, string country, int weight, string breed)
            : base(name, age, speed, country, weight)
        {
            Breed = breed;
        }

        public void Play()
        {
            Console.WriteLine("The dog plays");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    }
}
