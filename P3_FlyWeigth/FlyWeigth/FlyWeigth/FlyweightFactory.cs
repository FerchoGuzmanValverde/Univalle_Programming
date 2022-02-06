using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlyWeigth
{
    /// <summary>
    /// Clase que almacenara nuestros objetos
    /// </summary>
    public class FlyweightFactory
    {
        //Creamos una lista que servira de nuestro flyweigth
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        //Constructors que recibe como parametro un array de autos
        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                //Agregamos los elementos del array a nuestro flyweigth
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.getKey(elem)));
            }
        }

        // Returns a Flyweight's string hash for a given state.
        public string getKey(Car key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // Returns an existing Flyweight with a given state or creates a new
        // one.
        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = this.getKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                MessageBox.Show("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                MessageBox.Show("FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void listFlyweights()
        {
            var count = flyweights.Count;
            MessageBox.Show("\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                MessageBox.Show(flyweight.Item2);
            }
        }
    }
}
