using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //double dec = 6.5;
            //int num2 = (int)dec;

            //string cad = "34";
            //int num = int.Parse(cad);

            //string cadena = "True";
            //bool bo = bool.Parse(cadena);


            //int numero = 45;
            //Console.WriteLine(numero.ToString());
            Persona per = new Persona();
            Console.WriteLine("Ingrese un id :");
            per.Id = Console.ReadLine();
            Console.WriteLine(per.Id + " " + per);
            Console.ReadKey();
        }
    }
}