using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    internal class Cat : Animal
    {
        public string Color { get; set; }
        public Cat(string name, int age, string sound, string color) : base(name, age, sound)
        {
            Color = color;
        }
        public void printCatInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Color: {Color}");
        }
    }
}
