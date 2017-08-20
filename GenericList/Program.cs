using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> lista = new List<string>();
            //lista.Add("23");
            //lista.Add("hello");
            //lista.Insert(0, "uno");
            ////lista.Capacity = 5;
            //lista.Add("string");
            //lista.Add("elemento");
            //lista.Add("nuevo");
            //lista[1] = "veititres";
            //lista.Sort();

            //Console.WriteLine("La lista tiene una capacidad de : {0}", lista.Capacity);

            //foreach (string item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            List<Producto> listPro = new List<Producto>();
            listPro.Add(new Producto("1", "Avena", 6.23));
            listPro.Add(new Producto("2", "Leche", 1.87));
            listPro.Add(new Producto("3", "Mermelada", 2.45));
            listPro.Add(new Producto("4", "Avena", 5.23));

            listPro.Sort();

            foreach (Producto item in listPro)
            {
                Console.WriteLine(item + " , " + item.Precio);
            }

            Console.ReadKey();
        }
    }
}