using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTasks
{
    internal class Admin : User
    {
        public bool IsSuperAdmin { get; set; }
        public string Section { get; set; }

        public Admin(string username, string password, bool isSuperAdmin, string section)
            : base(username, password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }

        public Admin(string username, string password, string email, bool isSuperAdmin, string section)
            : base(username, password, email)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }

        public void ShowAdminInfo()
        {
            Console.WriteLine("****Admin Məlumatları****");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}");
            Console.WriteLine($"Section: {Section}");
        }
    }
}
