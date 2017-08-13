using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            char continuar = 'n';
            int opcion = 0;
            //cola.Enqueue("cadena");
            //cola.Enqueue(18);
            //cola.Enqueue(87.3);

            //object ultimo = cola.Dequeue();
            //Console.WriteLine("El numero de elementos en la cola es: {0}", cola.Count);
            //Console.WriteLine("Primer elemento en salir: " + ultimo);
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1-Ingresar elemento");
                Console.WriteLine("2-Contar elementos");
                Console.WriteLine("3-Buscar elemento");
                Console.WriteLine("4-Limpiar Cola");

                Console.WriteLine("Ingrese opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cola.Enqueue(Console.ReadLine());
                        Console.WriteLine("Ingresado");
                        break;
                    case 2:
                        Console.WriteLine("Elementos: " + cola.Count);
                        break;
                    case 3:
                        if (cola.Contains(Console.ReadLine()))
                        {
                            Console.WriteLine("Elemento encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Elemento no encontrado");
                        }
                        break;
                    case 4:
                        cola.Clear();
                        Console.WriteLine("Elementos: " + cola.Count);
                        break;
                }
                Console.ReadKey();
            } while (continuar == 'n');

            Console.ReadKey();
        }
    }
}