using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable tabla = new Hashtable();
            bool encontrado;
            tabla.Add("1", 34.45);
            tabla.Add("2", 56.23);
            tabla.Add("3", 34.67);
            tabla.Add("4", 12.6);
            //  encontrado = tabla.Contains("5");
            //Console.WriteLine("El valor de encontrado es: " + encontrado);


            foreach (DictionaryEntry item in tabla)
            {
                Console.WriteLine("Elementos en hashtable: {0} , {1}", item.Key, item.Value);
            }

            SortedList sort = new SortedList();
            sort.Add("1", "nombre");
            sort.Add("5", "apellidos");
            sort.Add("3", "direccion");

            sort.SetByIndex(1,"Apodo");

            foreach (DictionaryEntry item in sort)
            {
                Console.WriteLine("Elementos en sortedlist: {0} , {1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}