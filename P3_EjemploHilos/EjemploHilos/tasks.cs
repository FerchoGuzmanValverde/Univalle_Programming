using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploHilos
{
    class tasks
    {
        private String name;
        private int time;
        // estos son los atributos de la clase

        //este es el metodo constructor, debe llamarse igual que la clase

        public tasks(String name, int time)
        {
            this.name = name; // el dato que este en el parametro name se lo vamos a almacenar a el atributo
            this.time = time;
            // de esta forma quedan inicializados los artibutos

        }
        //creamos un nuevo metodo
        public void tasks1()
        {
            Console.WriteLine(name + "Este hilo solo durara" + time + "segundos"); // mensaje que saldra en consola

            Thread.Sleep(time * 1000); //aqui como dijimos en la teoria estamos calculando en base a milisegundos, asi que determinanos que tiempo tomara el hilo
            // tambien es el tiempo que se suspendera el subproceso actual hasta que se termine

            Console.WriteLine("Hilo terminado " + name); // mensaje para saber cuando termino el hilo

        }
        //aca solo copie y pegue para tener dos hilos
        public void tasks2()
        {
            Console.WriteLine(name + "Este hilo solo durara" + time + "segundos"); // mensaje que saldra en consola

            Thread.Sleep(time * 1000); //aqui como dijimos en la teoria estamos calculando en base a milisegundos, asi que determinanos que tiempo tomara el hilo
            // tambien es el tiempo que se suspendera el subproceso actual hasta que se termine

            Console.WriteLine("Hilo terminado " + name); // mensaje para saber cuando termino el hilo

        }
    }
}
