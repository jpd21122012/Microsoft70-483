using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Gato michito = new Gato();
             michito.CambiarNombre("Gato con botas");
             michito.Maullar();*/
            Cafetera Cafe = new Cafetera();
            if (Cafe.LlenarCafetera(20))
                Console.WriteLine("Se lleno el cafe, y su valor es de : " + Cafe.CantidadActual());
            else
                Console.WriteLine("No se pudo llenar el cafe");

            Cafe.ServirCafe();
            Console.WriteLine("La cantidad actual de cafe es " + Cafe.CantidadActual());
            Console.ReadKey();
        }
    }
    class Gato
    {
        public int edad;
        public string nombre;
        public void CambiarNombre(string _nombre)
        {
            this.nombre = _nombre;
        }
        public void Maullar()
        {
            Console.WriteLine(nombre + " dice Miau");
        }
    }
}