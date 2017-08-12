using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Cafetera
    {
        public int minCafe = 2;
        public int maxCafe = 35;
        int cafe = 7;

        public bool LlenarCafetera(int cantidad)
        {
            if ((cafe + cantidad) < maxCafe)
            {
                cafe += cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ServirCafe()
        {
            if (cafe > minCafe)
            {
                cafe -= 2;
                Console.WriteLine("Se sirvio el cafe");
            }
            else
            {
                Console.WriteLine("No hay cafe");
            }
        }
        public int CantidadActual()
        {
            return cafe;
        }
    }
}