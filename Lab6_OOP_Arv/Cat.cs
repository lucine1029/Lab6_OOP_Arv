using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
    internal class Cat : Animal
    {
        public string ColorOfEyes { get; set; }
        public Cat(string name, string color, string size, string favoriteFood, int age, string colorOfEyes) : base(name, color, size, favoriteFood, age)
        {
            ColorOfEyes = colorOfEyes;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"This cat {Name} has a pair of beautiful {ColorOfEyes} eyes, it sounds like 'miaomiaomiao'.");
        }
        public virtual void Climbing () 
        {
            Console.WriteLine("Cat likes climbing!");
        }
    }
}
