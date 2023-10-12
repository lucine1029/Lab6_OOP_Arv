using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
    internal class SphynxCat : Cat
    {
        public bool HasFur { get; set; }
        public SphynxCat(string name, string color, string size, string favoriteFood, int age, string colorOfEyes, bool hasFur) : base(name, color, size, favoriteFood, age, colorOfEyes)
        {
            HasFur = hasFur;
        }

        public override void Climbing()
        {
            base.Climbing();
            Console.WriteLine("My sphynx cat only like climbing my bed!");
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
