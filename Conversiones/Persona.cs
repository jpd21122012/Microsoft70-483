using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Persona
    {
        int id;
        string nombre;
        public string Id
        {
            get { return id.ToString(); }
            set { id = int.Parse(value); }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public override string ToString()
        {
            return "Clase manipulada por ToString";
        }
    }
}