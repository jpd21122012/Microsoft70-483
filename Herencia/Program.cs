using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro("Marca1", "Modelo1", 15, 80, 1, "Rojo");
            car.AumentarK(10);
            car.CambiarColor("negro");
            Console.WriteLine("Kilometraje: " + car.Kilometraje);

            Vehiculo ve = new Vehiculo("Vehiculo1", "mod1", 12.3, 120);
            ve.CambiarColor("Verde");
            Console.WriteLine(ve);
            Console.ReadKey();
        }
    }
}