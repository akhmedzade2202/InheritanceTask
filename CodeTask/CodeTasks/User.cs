using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTasks
{
    internal class User
    {
        private string username;
        private string password;
        private string email;

        public string Username
        {
            get { return username; }
            set
            {
                if (value.Length > 6)
                    username = value;
                else
                    Console.WriteLine("Username uzunlugu 6-dan boyuk olmalidir!");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                bool hasUpper = false;
                bool hasDigit = false;

                foreach (char c in value)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsDigit(c)) hasDigit = true;
                }

                if (hasUpper && hasDigit)
                    password = value;
                else
                    Console.WriteLine("Password da en az 1 boyuk herf ve 1 reqem olmalidir!");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                {
                    if (!char.IsLetterOrDigit(value[0]) || !char.IsLetterOrDigit(value[value.Length - 1]))
                        Console.WriteLine("Email baslangic ve son hissede xususi simvol ola bilmez!");
                    else
                        email = value;
                }
                else
                {
                    Console.WriteLine("Email '@' simvolu icermekidir");
                }
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
