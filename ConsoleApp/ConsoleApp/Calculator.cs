using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Calculator
    {
        public void Calculation(int a, int b, string operation)
        {
            switch (operation)
            {
                case "toplama":
                    Console.WriteLine(a + b);
                    break;
                case "cixma":
                    Console.WriteLine(a - b);
                    break;
                case "vurma":
                    Console.WriteLine(a * b);
                    break;
                case "bolme":
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Duzgun emeliyyat secin");
                    break;
            }
        }
    }
}

