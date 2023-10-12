using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
    internal class Wolf : Animal
    {
        public string CountryOfOrigin { get; set; }
        public Wolf(string name, string color, string size, string favoriteFood, int age, string countryOfOrigin) : base(name, color, size, favoriteFood, age)
        {
            CountryOfOrigin = countryOfOrigin;
            if(countryOfOrigin is null)
            {
                countryOfOrigin = "N/A";
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine($"This wolf {Name} is original from {CountryOfOrigin} , it sounds like 'wooooooooof'.");
        }
        public string Hunting () 
        {
            return "The wolf likes hunting rabbits.";
        }
    }
}
