using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public abstract class Instrumento
    {
        public Instrumento()
        {

        }
        public abstract void MiMetodo();
    }
    public class Guitarra : Instrumento
    {
        public Guitarra()
        {

        }

        public override void MiMetodo()
        {
            
        }
    }
}