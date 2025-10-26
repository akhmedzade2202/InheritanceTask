using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnimal
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string sound, string breed) : base(name, age, sound)
        {
            Breed = breed;
        }
        public void printDogInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Breed: {Breed}");
        }
    }
}
