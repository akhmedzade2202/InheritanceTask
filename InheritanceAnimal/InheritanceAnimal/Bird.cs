using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    internal class Bird : Animal
    {
        public double WingLength { get; set; }
        public Bird(string name, int age, string sound, double wingLength) : base(name, age, sound) 
        {
            WingLength = wingLength;
        }
        public void printBirdInfo() 
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Winglength: {WingLength}");
        }
    }
}
