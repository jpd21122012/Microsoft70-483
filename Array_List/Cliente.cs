using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    public class Cliente
    {
        ArrayList db = new ArrayList();
        public void Agregar(string nombre)
        {
            db.Add(nombre);
        }
        public void Editar(string edit, string new_element)
        {
            db[db.IndexOf(edit)] = new_element;
        }
        public void Eliminar(string elemento)
        {
            db.Remove(elemento);
        }
        public void SelectClientes()
        {
            foreach (object item in db)
            {
                Console.WriteLine(item);
            }
        }
        public void AgregarLista(string[] clientes)
        {
            db.AddRange(clientes);
        }
        public void Ordenar()
        {
            db.Sort(new OrdenarDesc());
        }
    }
    class OrdenarDesc : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer().Compare(y,x));
        }
    }
}