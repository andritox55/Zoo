using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cow : Animal
    {
        public int TimeSleept { get; set; }

        public Cow(string animalname, int age, int speed, string country, int weight, int timesleept)
            : base(animalname, age, speed, country, weight)
        {
            TimeSleept = timesleept;
        }

        public void Milk()
        {
            Console.WriteLine("The cow produce milk");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The cow makes the moo sound");
        }
    }
}
