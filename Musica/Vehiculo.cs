using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class Vehiculo : IFuncion
    {
        string _nom;
        public Vehiculo()
        {

        }
        public string Nombre { get { return "hola"; } set { _nom = value; } }

        public string Encender()
        {
            return "Encendido";
        }
    }
}