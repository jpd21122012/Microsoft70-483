using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Persona
    {
        string _nombre;
        string _apellido;
        int _edad;
        string _documento;
        public void SetNombre(string nombre)
        {
            this._nombre = nombre;
        }
        public string GetNombre()
        {
            return this._nombre;
        }

        public void SetApellido(string apellido)
        {
            this._apellido = apellido;
        }
        public string GetApellido()
        {
            return this._apellido;
        }

        public void SetDocumento(string documento)
        {
            this._documento = documento;
        }
        public string GetDocumento()
        {
            return this._documento;
        }
        public void SetEdad(int edad)
        {
            this._edad = edad;
        }
        public int GetEdad()
        {
            return this._edad;
        }
    }
}