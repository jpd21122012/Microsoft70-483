using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = "string";
            string nombre = "Maria";
            int edad = 21;

            string[] array = { "uno", "dos", "tres" };

            Persona.Method(ref nombre, ref edad);
            Persona per = new Persona();
            per.OtroMethod("Jorge", 22);
            Console.WriteLine(nombre);

            Console.WriteLine(array.Length);
            Console.ReadKey();
        }
    }
}