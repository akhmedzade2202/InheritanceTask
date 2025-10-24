using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Student
    {
        public String name;
        public String surnmename;
        public int age;
        public decimal grade;
        public string email;
        public int attendance;
        public string phones;

        public void StudentInfo()
        {
            Console.WriteLine($"Name: {name}, Surname: {surnmename}, Age: {age}, Grade: {grade}, Email: {email}, Attendance: {attendance}, Phones: {phones}");
        }
        public void IsSuccessful()
        {
            if (grade >= 51 && grade <= 60)
            {
                Console.WriteLine("E");
            }
            if (grade >= 61 && grade <= 70)
            {
                Console.WriteLine("D");
            }
            if (grade >= 71 && grade <= 80)
            {
                Console.WriteLine("C");
            }
            if (grade >= 81 && grade <= 90)
            {
                Console.WriteLine("B");
            }
            if (grade >= 91 && grade <= 100)
            {
                Console.WriteLine("A");

            }
        }
               public void IsFailed()
        {
            if (attendance < 50)
            {
                Console.WriteLine($"{name} {surnmename} has failed due to low attendance.");
            }
            else
            {
                Console.WriteLine($"{name} {surnmename} has sufficient attendance.");
            }
        }
    }
}
