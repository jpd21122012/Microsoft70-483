using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> lista = new List<string>();
            //lista.Add("Jose Luis");
            //lista.Add("Martin");
            //lista.Add("Luisa");

            //Console.WriteLine(lista.First());
            //Console.WriteLine(lista.Last());
            //Console.WriteLine(lista.Count);

            ColegioDataContext db = new ColegioDataContext();
            string primerApellido = (from a in db.tb_alumnos select a.Apellido).First();
            IQueryable<tb_alumno> lista = (from a in db.tb_alumnos select a).OrderByDescending(l =>l.Nombre);
            IEnumerable<string> apellidos = lista.Select(m=>m.Apellido);
            //foreach (tb_alumno item in lista)
            //{
            //    Console.WriteLine(item.Nombre+" "+item.Apellido);
            //}

            var union = from al in db.tb_alumnos join g in db.tb_grados on al.IdGrado equals g.Id
                        select new {
                        Nombres= al.Nombre,
                        Apellido = al.Apellido,
                        Grado = g.Nombre,
                        Capacidad = g.Capacidad,
                        Seccion = g.Seccion
                        };
            Console.WriteLine("Union de tablas con JOIN\n");
            foreach (var item in union)
            {
                Console.WriteLine(item.Nombres+" "+item.Apellido + " " +item.Grado + " " +item.Capacidad + " " +item.Seccion);
            }


            double promedio = (double)(from al in db.tb_alumnos select al.Calificacion).Average();
            Console.WriteLine("El promedio es: "+promedio);
            //foreach (string item in apellidos)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n"+primerApellido);

            Console.ReadKey();
        }
    }
}