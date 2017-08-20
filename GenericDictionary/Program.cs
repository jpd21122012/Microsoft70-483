using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "uno");
            dict.Add(2, "dos");
            dict.Add(3, "tres");
            dict.Add(4, "cuatro");
            dict.Add(new KeyValuePair<int, string>(5,"cinco"));

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            string val;
            if (dict.TryGetValue(1, out val))
            {
                Console.WriteLine("Se encontro el valor y es: " + val);
            }
            else
            {
                Console.WriteLine("No se encontro el valor");
            }

            Console.ReadKey();
        }
    }
}