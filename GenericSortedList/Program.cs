using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sorted = new SortedList<int, string>();

            sorted.Add(4, "cuatro");
            sorted.Add(1, "uno");
            sorted.Add(2, "dos");
            sorted.Add(3, "tres");

            foreach (KeyValuePair<int, string> item in sorted)
            {
                Console.WriteLine("Key: {0} , value: {1}", item.Key, item.Value);
            }

            string valor;
            if (sorted.TryGetValue(3, out valor))
            {
                Console.WriteLine(valor);
            }
            else
            {
                Console.WriteLine("La clave no se encuentra");
            }
            bool llave = sorted.ContainsKey(2);
            bool val = sorted.ContainsValue("cuatro");
            Console.WriteLine("Key 2 : " + llave + " Valor cuatro: " + val);
            Console.ReadKey();
        }
    }
}