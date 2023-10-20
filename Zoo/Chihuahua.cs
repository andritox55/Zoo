using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Chihuahua : Dog
    {
        public string Food { get; set; }

        public Chihuahua(string animalname, int age, int speed, string country, int weight, string breed, string food)
            : base(animalname, age, speed, country, weight, breed)
        {
            Food = food;
        }

        public void Angry()
        {
            Console.WriteLine("Chihuahuas are angry");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chihuahuas bark alot");
        }
    }
}
