using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Properties
{
    internal class Person
    {
        public string FullName { get; set; }
        public byte Age { get; set; }
        public string Country { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Email { get; set; }

        public void Create(Person person)
        {
            while (true)
            {
                Console.WriteLine("Please enter FullName:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("FullName bos qoymaq olmaz!");
                    continue;
                }

                if (Regex.IsMatch(input, @"\d"))
                {
                    Console.WriteLine("Ad ve soyadda reqem ola bilmez!");
                    continue;
                }

                person.FullName = input;
                break;
            }

            while (true)
            {
                Console.WriteLine("Please enter Age:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Age bos qoymaq olmaz!");
                    continue;
                }

                if (byte.TryParse(input, out byte age))
                {
                    if (age < 18 || age > 65)
                    {
                        Console.WriteLine("Yas 18 ile 65 arasinda olmalidir!");
                        continue;
                    }

                    person.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Yas duzgun formatda deyil (reqem olmalidir)!");
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter Country:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Country bos qoymaq olmaz!");
                    continue;
                }

                person.Country = input;
                break;
            }

            while (true)
            {
                Console.WriteLine("Please enter Height:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Height bos qoymaq olmaz!");
                    continue;
                }

                person.Height = input;
                break;
            }

            while (true)
            {
                Console.WriteLine("Please enter Weight:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Weight bos qoymaq olmaz!");
                    continue;
                }

                person.Weight = input;
                break;
            }

            while (true)
            {
                Console.WriteLine("Please enter Email:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Email bos qoymaq olmaz!");
                    continue;
                }

                person.Email = input;
                break;
            }
        }
        public void PrintInfo(Person person)
        {
            Console.WriteLine($"FullName: {person.FullName}\n Age: {person.Age}\n Country: {person.Country}\n Height: {person.Height}\n Weight: {person.Weight}\n Email: {person.Email}");
        }
    } 
}
