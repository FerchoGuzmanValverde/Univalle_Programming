using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
                Console.Write("Ingrese el numero: ");
                num = Console.Read();
                if (num % 2 == 0)
                    Console.Write("El numero es par");
                else
                    Console.Write("El numero es impar");
        }
    }
}
