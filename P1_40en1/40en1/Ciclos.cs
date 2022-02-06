using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40en1
{
    class Ciclos
    {
        public int salario(int edad, int antiguedad)
        {
            int sal = 0;
            for (int i = 1; i <= antiguedad; i++)
            {
                sal = sal + i;
            }
            sal = 100 + edad + sal;
            return sal;
        }

        public int multiplicacion(int num1, int num2)
        {
            int result = 0;
            while(num1 >= 1)
            {
                if(num1 % 2 != 0)
                {
                    result = result + num2;
                }
                num1 = num1 / 2;
                num2 = num2 * 2;
            }
            return result;
        }

        public int[] primos()
        {
            int con, tam = 0;
            for (int i = 1; i <= 100; i++)
            {
                con = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        con++;
                    }
                }
                if(con == 2)
                {
                    tam++;
                }
            }
            int[] prim = new int[tam];
            tam = 0;
            for (int i = 1; i <= 100; i++)
            {
                con = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        con++;
                    }
                }
                if (con == 2)
                {
                    prim[tam] = i;
                    tam++;
                }
            }
            return prim;
        }

        public int min(int[] vec)
        {
            int minimo = vec[0];
            for (int i = 0; i < vec.Length; i++)
            {
                if(minimo > vec[i])
                { minimo = vec[i]; }
            }
            return minimo;
        }

        public int raiz(int num)
        {
            int x, aux = 0;
            for (int i = 1; i <= num; i++)
            {
                x = i * i;
                if (x <= num)
                {
                    aux = i;
                }
            }
            return aux;
        }
    }
}
