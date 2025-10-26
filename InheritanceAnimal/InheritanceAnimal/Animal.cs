using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Sound { get; set; }
        public Animal(string name, int age, string sound) {
            Name = name;
            Age = age;
            Sound = sound;

        }
        public void printInfo() {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}" );
        }
    }
}
