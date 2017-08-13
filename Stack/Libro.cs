using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCollection
{
    public class Libro
    {
        Stack piladb = new Stack();

        public void IngresarLibro(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                object elemento;
                elemento = Console.ReadLine();
                piladb.Push(elemento);
            }
        }
        public object RetirarLibro()
        {
            object elemento;
            elemento = piladb.Pop();
            return elemento;
        }
        public bool Consulta(object busqueda)
        {
            bool encontrado = false;
            encontrado = piladb.Contains(busqueda);
            return encontrado;
        }
        public object DevolverUltimo()
        {
            object elemento;
            elemento = piladb.Peek();
            return elemento;
        }
        public void Limpiar()
        {
            piladb.Clear();
        }
        public int ContarLibros()
        {
            return piladb.Count;
        }
    }
}