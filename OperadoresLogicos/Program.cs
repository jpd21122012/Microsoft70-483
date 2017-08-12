using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 8;
            double num2 = 9;
            double suma;
            double resta = ((num1 + num2) - num2) * 3;
            double mult = num1 * num2;
            int modulo = 27 % 4;
            suma = num1 + num2;
            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(mult);
            Console.WriteLine(modulo);
            num1++;
            Console.WriteLine(num1);
            double res = -(num1);
            Console.WriteLine(res);
            Console.WriteLine(num1>num2);

            Console.ReadKey();
        }
    }
}