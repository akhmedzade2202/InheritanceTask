//using System;

//namespace Properties
//{
//    internal class Student
//    {
//        public string Name { get; set; }
//        public string Surname { get; set; }
//        public byte Age { get; set; }
//        public string Email { get; set; }
//        public string Address { get; set; }

//        public void PrintAll( params Student[] students)
//        {
//            Console.WriteLine("\nButun telebeler: ");
//            foreach (var s in students)
//            {
//                Console.WriteLine($"{s.Name} {s.Surname} - {s.Age} yaş, {s.Address}, {s.Email}");
//            }
//        }

//        public void PrintAbove25( params Student[] students)
//        {
//            Console.WriteLine("\n25 yasdan yuxrilar");
//            foreach (var s in students)
//            {
//                if (s.Age > 25)
//                    Console.WriteLine($"{s.Name} {s.Surname} - {s.Age} yas");
//            }
//        }

//        public void PrintByAddress(string address,  params Student[] students)
//        {
//            Console.WriteLine($"\nAdresi {address} olan telebeler:");
//            foreach (var s in students)
//            {
//                if (s.Address == address)
//                    Console.WriteLine($"{s.Name} {s.Surname} - {s.Address}");
//            }
//        }

//        public void PrintAverageAge(params Student[] students)
//        {
//            double total = 0;
//            foreach (var s in students)
//            {
//                total += s.Age;
//            }

//            double average = total / students.Length;
//            Console.WriteLine($"\nYas ortalamasi: {average}");
//        }  

//        public void DeleteStudent(params Student[] students)
//        {
//            Console.WriteLine("\nTelebeleri sil:");
//            foreach (var s in students)
//            {
//                if (s.Age < 20)
//                {
//                    var yeniArray = new Student[students.Length - 1];
//                    yen1

//                    Console.WriteLine($"{s.Name} {s.Surname} - {s.Age} yas telebe silindi.");
//                }
                

//                return yeniArray;
//            }
//        }
//    }
//} 
