using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona per = new Persona();
            Empleado emp = new Empleado();
            //Deriva d = new Deriva();
            //d.ImprimirEdad();
            //d.ImprimirNombre();
            //d.ImprimirEdadPadre();
            // Console.WriteLine(ObjInterno.edad);
            emp.miMetodo();
            //ObjInterno obj = new ObjInterno();
            //obj.nombre = "Hola";
            Console.ReadKey();
        }
    }
}