using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_OOP_Arv
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string FavoriteFood { get; set; }
        public int Age { get; set; }

        public Animal(string name, string color, string size, string favoriteFood, int age) 
        { 
            Name = name;
            Color = color;
            Size = size;
            FavoriteFood = favoriteFood;
            Age = age;
        }
        public abstract void MakeSound();
        public bool IsBaby(int age) 
        { 
            if(Age < 1) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public string EatHabit(string favoriteFood) 
        {
            return $"The animal likes to eat {FavoriteFood}";

        }
    }
}
