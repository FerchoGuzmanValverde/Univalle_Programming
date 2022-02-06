using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char ope;
            float res = 0;
            Console.WriteLine("Ingresa primer valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa segundo valor: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese operacion a realizar");
            ope = Convert.ToChar(Console.ReadLine());
            if (ope == '+')
            {
                res = x + y;
            }
            if (ope == '-')
            {
                res = x - y;
            }
            if (ope == '*')
            {
                res = x * y;
            }
            if (ope == '/')
            {
                res = x / y;
            }
            Console.WriteLine(res);
        }
    }
}
