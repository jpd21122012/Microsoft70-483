using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Producto : IComparable
    {
        string codigo;
        string nombres;
        double precio;

        public Producto(string cod, string nom, double pre)
        {
            this.codigo = cod;
            this.nombres = nom;
            this.precio = pre;
        }
        public override string ToString()
        {
            return codigo + " -> " + Nombre.ToUpper(); ;
        }

        public int CompareTo(object obj)
        {
            Producto otroProd = (Producto)obj;
            if (this.nombres != otroProd.nombres)
            {
                return this.nombres.CompareTo(otroProd.nombres);
            }
            else
            {
                return precio.CompareTo(otroProd.precio);
            }
        }

        public string Codigo
        {
            get { return codigo; }
        }
        public string Nombre
        {
            get { return nombres; }
        }
        public double Precio
        {
            get { return precio; }
        }
    }
}