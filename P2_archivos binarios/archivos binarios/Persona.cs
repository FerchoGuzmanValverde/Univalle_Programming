using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace archivos_binarios
{
    class Persona
    {
        string carnet, nombre;

        public Persona(string id, string nom)
        {
            carnet = id;
            nombre = nom;
        }

        public string CARNET
        {
            get { return carnet; }
            set { carnet = value; }
        }
        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void almacenar()
        {
            FileStream f = null;
            BinaryWriter bw = null;
            f = new FileStream("d:/test.data", FileMode.Append, FileAccess.Write);
            bw = new BinaryWriter(f);
            bw.Write(nombre);
            bw.Write(carnet);

            if (bw != null)
            {
                bw.Close();
            }
            if (f != null)
            {
                f.Close();
            }
        }

        public void recuperar()
        {
            FileStream f = null;
            BinaryReader br = null;
            f = new FileStream("d:/test.data", FileMode.Open);
            br = new BinaryReader(f);

            while (br.PeekChar() != -1)
            {
                nombre = br.ReadString();
                carnet = br.ReadString();
            }

            if (br != null)
            {
                br.Close();
            }
            if (f != null)
            {
                f.Close();
            }
        }
    }
}
