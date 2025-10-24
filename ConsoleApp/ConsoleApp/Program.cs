//void Cemleme(int a, int b)
//{
//    int sum = a+b;
//    Console.WriteLine(sum);

//}Cemleme(3, 4);

//int Topla(int a, int b)
//{
//    return a + b;
//}
//int result = Topla(5, 6);
//Console.WriteLine(result);


//void CutYoxsaTekdir(int a)
//{
//    if (a % 2 == 0 )
//    {
//        Console.WriteLine("Cut ededdir");
//    }

//    else
//    {
//        Console.WriteLine("Tek");
//    }
//}CutYoxsaTekdir(6);

//string cutYoxsaTek(int a)
//{
//    if (a % 2 == 0)
//    {
//        return "Cut ededdir";
//    }
//    else
//    {
//        return "Tek";
//    }
//}Console.WriteLine(cutYoxsaTek(7));


//string compareTo(int a, int b, int c)
//{
//    if (a > b && a > c)
//    {
//        return "Big number b";
//    }
//    else if (b > a && b > c)
//    {
//        return "Big number b";
//    }
//    else
//    {
//        return "Big number c";
//    }
//}
//Console.WriteLine(compareTo(3, 5, 8));

using ConsoleApp;

Account account = new Account();
account.Login("cavid123", "Cavid1234");

Calculator calculator = new Calculator();


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
string operation = Console.ReadLine();
calculator.Calculation(a, b, operation);



var student = new Student()
{
    name = "Emrah",
    surnmename = "Akhmedzade",
    age = 20,
    grade = 85.5m,
    email = "emrah123@gmail.com",
    attendance = 60,
    phones = "+9940507694070"
};

student.StudentInfo();
student.IsSuccessful();
student.IsFailed();