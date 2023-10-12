using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
    internal class Dog : Animal
    {
        public int Speed { get; set; }
        public Dog(string name, string color, string size, string favoriteFood, int age, int speed ) : base(name, color, size, favoriteFood, age)
        {
            Speed = speed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"This dog {Name} is {Age} year old, it sounds like 'woowoowoo'. ");
        }

        public void Run() 
        {
            Console.WriteLine($"The dog can run at the speed of {Speed} km/h.");
        }

    }
}
