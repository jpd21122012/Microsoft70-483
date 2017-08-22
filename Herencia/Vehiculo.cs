using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Vehiculo
    {
        protected string _marca;
        protected string _modelo;
        protected double _kilometraje;
        protected int _velocidad;

        public Vehiculo()
        {

        }
        public Vehiculo(string marca, string modelo, double kilometraje, int velocidad)
        {
            this._marca = marca;
            this._modelo = modelo;
            this._kilometraje = kilometraje;
            this._velocidad = velocidad;
        }
        public override string ToString()
        {
            return "Vehiculo => Marca: " + _marca + ", Modelo:" + _modelo;
        }
        public void AumentarK(int k)
        {
            this._kilometraje += k;
        }
        public virtual void CambiarColor(string color)
        {
            Console.WriteLine("No se ha asignado ningun color");
        }
    }
    class Carro : Vehiculo
    {
        int cod;
        string color;
        public double Kilometraje
        {
            get { return this._kilometraje; }
        }

        public Carro()
        {

        }
        public Carro(string marca, string modelo, double kilometraje, int velocidad, int codi, string col) : base(marca, modelo, kilometraje, velocidad)
        {
            this.cod = codi;
            this.color = col;
        }
        public void metodo()
        {
            _marca = "";
        }
        public override void CambiarColor(string color)
        {
            this.color = color;
            Console.WriteLine("El color es: {0}", color);
        }
    }
}