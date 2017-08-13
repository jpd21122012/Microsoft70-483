using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    public abstract class Persona
    {
        protected string nombre;
        const int documento = 12345;
        //protected se utiliza dentro de la clase o clases derivadas
        public abstract string Nombre
        {
            get;
            set;
        }
        public virtual void miMetodo()
        {

        }
    }
    public class Empleado : Persona
    {
        int edad;
        public override string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override void miMetodo()
        {
            //base.miMetodo();
            Console.WriteLine("Metodo sobreescrito");
        }
    }
}