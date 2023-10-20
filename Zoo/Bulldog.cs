using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Bulldog : Dog
    {
        public int Pattime { get; set; }

        public Bulldog(string animalname, int age, int speed, string country, int weight, string breed, int pattime)
            : base(animalname, age, speed, country, weight, breed)
        {
            Pattime = pattime;
        }

        public void Lazy()
        {
            Console.WriteLine("Bulldogs are lazy");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bulldog doesnt bark alot");
        }
    }
}
