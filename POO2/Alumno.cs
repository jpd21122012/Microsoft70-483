using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Alumno : Personal
    {
        public Alumno(string _nom, string _dni) : base(_nom, _dni)
        {

        }
        public override void Saludar()
        {
            //base.Saludar();
            Console.WriteLine("Hola mi nombre es: " + GetNombre() + " y soy Alumno");
        }
    }
}
