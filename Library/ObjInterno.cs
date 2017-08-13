using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public sealed class ObjInterno
    {
        //internal solo es accesible en el mismo proyecto
        //sealed no se puede derivar
        public static string nombre = "hola";
        public static int edad = 100;
        public readonly string apellidos = "Perales";

        public ObjInterno()
        {
            apellidos = "asd";
        }
    }
    //public class Deriva : ObjInterno
    //{
    //    public new int edad = 15;
    //    public void ImprimirNombre()
    //    {
    //        Console.WriteLine(nombre);
    //    }
    //    public void ImprimirEdad()
    //    {
    //        Console.WriteLine(edad);
    //    }
    //    public void ImprimirEdadPadre()
    //    {
    //        Console.WriteLine(ObjInterno.edad);
    //    }
    //}
}