using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40en1
{
    class Condicionales
    {
        Random num = new Random();
        public string categorizar(int peso, double estatura)
        {
            string cat = "";
            double medida = peso / (estatura * estatura);
            if(medida < 16)
            { cat = "criterio de ingreso en hospital"; }
            else if(medida == 16 || medida == 17)
            { cat = "infrapeso"; }
            else if(medida == 18)
            { cat = "bajo peso"; }
            else if(medida > 18 && medida < 26)
            { cat = "Peso normal(saludable)"; }
            else if(medida > 25 && medida < 31)
            { cat = "Sobrepeso(Obesidad grado 1)"; }
            else if(medida > 30 && medida < 36)
            { cat = "Sobrepeso cronico(Obesidad grado 2)"; }
            else if(medida > 35 && medida < 41)
            { cat = "Obesidad pre-morbida(Obesidad grado 3)"; }
            else if(medida > 40)
            { cat = "Obesidad Morbida"; }
            return cat;
        }

        public string calificar(int producidos, int defectuosos)
        {
            string cat;
            if(producidos < 10000 && defectuosos > 200)
            { cat = "grado 5"; }
            else if(producidos < 10000 && defectuosos < 200)
            { cat = "grado 6"; }
            else if(producidos > 10000 && defectuosos > 200)
            { cat = "grado 7"; }
            else
            { cat = "grado 8"; }
            return cat;
        }

        public string comprobante(int num, int random)
        {
            if(num < random)
            { return "Numero muy bajo"; }
            else if(num > random)
            { return "Numero muy alto"; }
            else
            { return "Acertaste"; }
        }

        public string operador(int cont, int num, int random)
        {
            cont++;
            string res = "mmmm...";
            if(cont <= 10)
            {
                if(num == random)
                {
                    if(cont == 1)
                    { res = "Tuviste suerte"; }
                    else if(cont == 2 || cont == 3)
                    { res = "Muy bien"; }
                    else if(cont == 4 || cont == 5)
                    { res = "Aceptable"; }
                    else if(cont > 5 && cont < 9)
                    { res = "Regular"; }
                    else if(cont == 9 || cont == 10)
                    { res = "Apenas"; }
                }
                else
                {
                    res = "No acertaste";
                }
            }
            else
            {
                res = "Perdiste";
            }
            return res;
        }

        public string sorteo()
        {
            int sort = num.Next(1, 6);
            string res;
            if(sort == 1)
            { res = "Negro"; }
            else if(sort == 2)
            { res = "Verde"; }
            else if(sort == 3)
            { res = "Amarillo"; }
            else if(sort == 4)
            { res = "Azul"; }
            else
            { res = "Rojo"; }
            return res;
        }

        public float descuento(int monto, string color)
        {
            float des;
            if(color == "Negro")
            { des = monto * 0.1f; }
            else if(color == "Verde")
            { des = monto * 0.25f; }
            else if(color == "Amarillo")
            { des = monto * 0.5f; }
            else if(color == "Azul")
            { des = monto * 0.75f; }
            else
            { des = monto * 1; }
            return des;
        }

        public string ppt(char j1, char j2, string n1, string n2)
        {
            string res;
            if(j1 == 'R' && j2 == 'R')
            { res = "R-R Roca y Roca es empate"; }
            else if(j1 == 'R' && j2 == 'P')
            { res = "R-P Papel envuelve Roca, Gana " + n1; }
            else if(j1 == 'R' && j2 == 'T')
            { res = "R-T Roca rompe Tijeras, Gana " + n2; }
            else if(j1 == 'P' && j2 == 'P')
            { res = "P-P Papel y Papel es empate"; }
            else if(j1 == 'P' && j2 == 'T')
            { res = "P-T Tijera corta papel, Gana " + n2; }
            else if(j1 == 'P' && j2 == 'R')
            { res = "P-R Papel envuelve Roca, Gana " + n1; }
            else if(j1 == 'T' && j2 == 'T')
            { res = "T-T Tijera y Tijera es empate"; }
            else if(j1 == 'T' && j2 == 'P')
            { res = "T-P Tijera corta Papel, Gana " + n1; }
            else
            { res = "T-R Roca rompe Tijera, Gana " + n2; }
            return res;
        }
    }
}
