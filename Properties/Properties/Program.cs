//using Properties;

//Student student = new Student();

//var s1 = new Student
//{
//    Name = "Emrah",
//    Surname = "Akhmedzade",
//    Email = "akhmedzadeamrah@gmail.com",
//    Age = 20,
//    Address = "Neftciler"
//};

//var s2 = new Student
//{
//    Name = "Seid",
//    Surname = "Ehmedova",
//    Email = "sd@gmail.com",
//    Age = 19,
//    Address = "Yasamal"
//};

//var s3 = new Student
//{
//    Name = "Ruslan",
//    Surname = "Memmedov",
//    Email = "rusik@gmail.com",
//    Age = 30,
//    Address = "Ehmedli"
//};

//var s4 = new Student
//{
//    Name = "Aysel",
//    Surname = "Huseynova",
//    Email = "aysel123@gmail.com",
//    Age = 28,
//    Address = "Neftciler"
//};

//student.PrintAll(s1, s2, s3, s4);
//student.PrintAbove25(s1, s2, s3, s4);
//student.PrintByAddress("Neftciler", s1, s2, s3, s4);
//student.PrintAverageAge(s1, s2, s3, s4);
//student.DeleteStudent(s1, s2, s3, s4);
//student.PrintAll(s1, s2, s3, s4);


using Properties;

Person person = new Person();
person.Create(person);
Console.WriteLine("------------------------");
person.PrintInfo(person);