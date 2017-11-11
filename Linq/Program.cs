using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[] { 2,4,7,8,15,20,12};
            int[] customerIds = new int[] { 2, 4, 7, 8, 15,15, 20, 12 };
            var consultaG = from d in datos select d;
            var consultaind = from d in datos where d<8 select d;
            int customerIdremove = 2;

            int[] filteredcost = customerIds.Distinct().Where(value => value != customerIdremove).OrderByDescending(x => x).ToArray();
            foreach (int item in filteredcost)
            {
                Console.WriteLine(item);
            }

            /*Console.WriteLine("Consulta general");
            //foreach (var item in consultaG)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine("\nConsulta individual");
            //foreach (var item in consultaind)
            //{
            //    Console.WriteLine(item.ToString());
            }*/

            /*Persona[] personas= {new Persona("Jorge","Perales",20),new Persona("Jose","Fuentes",17),new Persona("Pablo","Escobar",36) };
            //IEnumerable<Persona> consulta = from p in personas where p.Edad<30 select p;
            //foreach (Persona item in consulta)
            //{
            //    Console.WriteLine("Nombre:{0}, Apellido:{1}, Edad:{2}",item.Nombre,item.Apellidos,item.Edad);
            }*/


            /*ColegioContextDataContext colegio = new ColegioContextDataContext();
            var alumnos = from a in colegio.tb_alumnos where a.Calificacion < 15 orderby a.Apellido select a;
            foreach (tb_alumno item in alumnos)
            {
                Console.WriteLine(item.Nombre+" "+item.Apellido);
            }
            */



            Console.ReadKey();
        }
    }
}