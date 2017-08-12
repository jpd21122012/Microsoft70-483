using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Program
    {
        /// <summary>
        /// Encapsulacion, modificadores de acceso, herencia, polimorfismo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /* Persona per = new Persona();
             per.SetNombre("Jorge");
             per.SetApellido("Perales Diaz");
             per.SetEdad(20);
             Console.WriteLine(per.GetNombre() + " " + per.GetApellido() + " tiene " + per.GetEdad().ToString() + " annios");
     */

            //Personal personal = new Personal("Jorge", "12345");

            /* Profesor profe = new Profesor("Profe", "12345", "direccion del profe");
             Console.WriteLine("El nombre es: " + profe.GetNombre());
             Console.WriteLine("DNI: " + profe.GetDNI());
             Console.WriteLine("Direccion: " + profe.Getdireccion());*/

            Personal per = new Personal("Personal Juan", "125678");
            per.Saludar();

            per = new Alumno("Alumno jpd","12457");
            per.Saludar();

            Console.ReadKey();
        }
    }
}