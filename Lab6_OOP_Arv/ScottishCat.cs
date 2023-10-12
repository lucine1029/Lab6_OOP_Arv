using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
    internal class ScottishCat : Cat
    {
        public bool HasFoldedEar { get; set; }
        public ScottishCat(string name, string color, string size, string favoriteFood, int age, string colorOfEyes, bool hasFoldedEar) : base(name, color, size, favoriteFood, age, colorOfEyes)
        {
            HasFoldedEar = hasFoldedEar;
        }

        public override void Climbing()
        {
            base.Climbing();
            Console.WriteLine("Ohohohoh, ScottishCat likes climbing wall.");
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }


    }
}
