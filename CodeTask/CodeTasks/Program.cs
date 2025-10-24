using CodeTasks;
using System.Data.SqlTypes;


//Substring sub = new Substring();

//string text = "Bu bir custom substring testidir.";

//Console.WriteLine(sub.customSubstring(text, 3));
//Console.WriteLine(sub.customSubstring(text, 6, 6));

//Console.WriteLine("*****************************************");


//CustomContains contains = new CustomContains();

//string cumle = "Bu bir Custom Contains Methodudur";

//Console.WriteLine(contains.customContains(cumle, "Bu"));
//Console.WriteLine(contains.customContains(cumle, 'B'));

namespace CodeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            while (true)
            {
                Console.Write("Username daxil edin: ");
                username = Console.ReadLine();

                if (username.Length > 6)
                    break;
                else
                    Console.WriteLine("Username uzunlugu 6-dan boyuk olmalidir!");
            }

            while (true)
            {
                Console.Write("Password daxil edin: ");
                password = Console.ReadLine();

                bool hasUpper = false;
                bool hasDigit = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsDigit(c)) hasDigit = true;
                }

                if (hasUpper && hasDigit)
                    break;
                else
                    Console.WriteLine("Password da en az 1 boyuk herf və 1 reqem olmalidir!");
            }

            Console.Write("IsSuperAdmin (true/false): ");
            bool isSuperAdmin = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Section daxil edin: ");
            string section = Console.ReadLine();

            Console.Write("Email daxil etmek isteyirsiniz? (beli/xeyr): ");
            string cavab = Console.ReadLine().ToLower();

            Admin admin;

            if (cavab == "beli")
            {
                Console.Write("Email daxil edin: ");
                string email = Console.ReadLine();
                admin = new Admin(username, password, email, isSuperAdmin, section);
            }
            else
            {
                admin = new Admin(username, password, isSuperAdmin, section);
            }

            Console.WriteLine();
            admin.ShowAdminInfo();
        }
    }
}