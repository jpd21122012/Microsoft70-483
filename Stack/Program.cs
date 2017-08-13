using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack pila = new Stack();
            //pila.Push(34);
            //pila.Push("string");
            //pila.Push(true);
            //pila.Push(34.6);

            //Console.WriteLine("La cantidad de elementos en la pila es de: " + pila.Count);
            //double el = double.Parse(pila.Pop().ToString());
            //Console.WriteLine("El elemento que se saca con Pop(): {0}", el);
            //Console.WriteLine("El ultimo elemento es: {0}", pila.Peek());
            //Console.WriteLine("La cantidad de elementos en la pila es de: " + pila.Count);
            Libro lib = new Libro();
            lib.IngresarLibro(3);
            Console.WriteLine("Ingrese elementos");
            string valor = lib.DevolverUltimo().ToString();
            Console.WriteLine("el ultimo elemento es: {0}", valor);
            Console.WriteLine("El numero de elementos es: " + lib.ContarLibros());
            //Console.WriteLine("Ingrese el libro que quiere consultar");
            //if (lib.Consulta(Console.ReadLine()))
            //{
            //    Console.WriteLine("Libro encontrado");
            //}
            //else
            //{
            //    Console.WriteLine("No se encuentra el libro");
            //}
            Console.WriteLine("Desea retirar un libro? s/n");
            if (Console.ReadLine() == "s")
            {
                lib.RetirarLibro();
            }
            Console.WriteLine("El numero de elementos es: " + lib.ContarLibros());
            lib.Limpiar();
            Console.WriteLine("El numero de elementos es: " + lib.ContarLibros());

            Console.ReadKey();
        }
    }
}