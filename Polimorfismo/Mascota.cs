using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract class Mascota
    {
        protected string _nombre;
        protected int _edad;
        public abstract string Saludar();
    }
    class Gato : Mascota
    {
        public Gato(string nombre):base ()
        {
            this._nombre = nombre;
        }
        public override string Saludar()
        {
            return "Soy Gato y mi nombre es: "+_nombre;
        }
    }
    class Perico : Mascota
    {
        public Perico(string nombre):base ()
        {
            this._nombre = nombre;
        }
        public override string Saludar()
        {
            return "Soy Perico y mi nombre es: " + _nombre;
        }
    }
}