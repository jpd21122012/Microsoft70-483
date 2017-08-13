using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Queue cola = new Queue();
            Stack pila = new Stack();

            Hashtable table = new Hashtable();
            SortedList list = new SortedList();

            Figura<double> fig = new Figura<double>();
            al.Add(23);
            al.Add("Hola");
            al.Add(true);

            fig.tamanio = 45.6;
            Console.WriteLine("ArrayList:");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine("\n"+fig.tamanio);
            Console.ReadKey();

            //NG
            Dictionary<int, string> dic = new Dictionary<int, string>();

        }
    }
}