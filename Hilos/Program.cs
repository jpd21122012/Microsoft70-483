using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inicio del proceso 1");
            //ThreadStart delegado = new ThreadStart(Metodo);
            //Thread hilo = new Thread(delegado);
            //Thread.Sleep(1000);
            //hilo.Start();
            //Console.WriteLine("Termino del proceso 1");
            Thread hilo1 = new Thread(new ThreadStart (Tarea1));
            Thread hilo2 = new Thread(new ThreadStart(Tarea2));
            hilo1.Start();
            hilo2.Start();
            hilo1.Priority = ThreadPriority.Highest;
            hilo2.Priority = ThreadPriority.Lowest;


            Console.ReadKey();
        }
        static void Metodo()
        {
            
            Console.WriteLine("Ejecucion de Metodo()");
        }
        static void Tarea1()
        {
            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
        static void Tarea2()
        {
            for (int i = 11; i <21; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
    }
}