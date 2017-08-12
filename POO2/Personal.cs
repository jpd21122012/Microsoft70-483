using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Personal
    {
        string nombre;
        string dni;

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string _nombre)
        {
            this.nombre = _nombre;
        }

        public string GetDNI()
        {
            return dni;
        }
        public void SetDNI(string _dni)
        {
            this.dni = _dni;
        }
        public Personal(string _nom, string _dni)
        {
            this.nombre = _nom;
            this.dni = _dni;
        }
        // virtual hace que las clases hijas puedan sobreescribir el metodo
        public virtual void Saludar()
        {
            Console.WriteLine("Hola mi nombre es: " + nombre + " y soy un Personal");
        }
    }
    public class Profesor : Personal
    {
        string direccion;
        public Profesor(string _nom_, string _dni_, string _direc_) : base(_nom_, _dni_)
        {
            this.direccion = _direc_;
        }
        public string Getdireccion()
        {
            return direccion;
        }
    }
}