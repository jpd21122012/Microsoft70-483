using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Persona
    {
        public static void Method(ref string nombre, ref int edad)
        {
            Console.WriteLine("Hola soy : " + nombre + " y tengo " + edad);
        }
        public void OtroMethod(string nombre, int edad)
        {
            Console.WriteLine("Hola soy : " + nombre + " y tengo " + edad);
        }
    }
}
