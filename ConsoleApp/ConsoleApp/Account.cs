using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Account
    {
        public void Login(string username, string password) { 
            if ( username == "cavid123" && password == "Cavid123")
            {
                Console.WriteLine("Giris ugurludur");
            }
            else
            {
                Console.WriteLine("Email ve password sehvdir");
            }
        }
    }
}
