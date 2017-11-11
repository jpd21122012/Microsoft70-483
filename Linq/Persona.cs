using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Persona
    {
        string _nombre;
        string _apellido;
        int _edad;

        public Persona(string nombre,string apellido, int edad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
        }
        public string Nombre { get { return _nombre; } }
        public string Apellidos { get { return _apellido; } }
        public int Edad { get { return _edad; } }
    }
}