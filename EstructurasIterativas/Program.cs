using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasIterativas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 1;
            int y = 1;
            while (x == 10)
            {
                Console.WriteLine(x);
                x++;
            }

            do
            {
                Console.WriteLine(y);
                y++;
            } while (y == 5);*/

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            string saludo = "hola";
            int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int item in arrayInt)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
