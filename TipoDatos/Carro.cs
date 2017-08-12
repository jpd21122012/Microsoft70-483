using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDatos
{
    class Carro
    {
        string marca = "BMW";
        double largo = 4.9;
        double ancho = 1.8;
        int garantia = 5;
        char estado = 'a';
        bool encendido = true;
        string[] var = { "hola", "soy", "jorge", "perales" };
        //creacion del delegado
        delegate void miDelegado(string _nom);

        enum Colores : short
        {
            rojo = 1,
            azul = 0,
            verde = 0
        }

        struct propiedades
        {
            public string modelo;


            public propiedades(string _mod)
            {
                modelo = _mod;
            }
        }
        static void Main(string[] args)
        {
            Carro car = new Carro();
            propiedades pro = new propiedades("asdfas");
            miDelegado del = new miDelegado(Run);


            Console.WriteLine(car.marca + " " + car.garantia);
            Console.WriteLine(Colores.rojo + " " + car.encendido + " " + pro.modelo);
            Console.WriteLine(car.var[1]);
            del("delegado");

            Console.ReadKey();
        }

        static public void Run(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
    }
}