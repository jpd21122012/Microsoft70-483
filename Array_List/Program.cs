using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList arli = new ArrayList();

            arli.Add(2);
            arli.Add("dos");
            arli.Add(12.5);

            arli.Insert(2, true);

            //arli.RemoveAt(2);

            // arli.Remove("dos");

            Console.WriteLine("Numero de elementos en el ArrayList: " + arli.Count + "\n");
            foreach (object item in arli)
            {
                Console.WriteLine(item);
            }
            */
            Cliente cli = new Cliente();
            cli.Agregar("Jorge Perales");
            cli.AgregarLista(new string[] { "Cliente 2", "Cliente 3", "Cliente 4" });
            cli.Editar("Cliente 2", "Maria");
            cli.Eliminar("Cliente 4");
            cli.Ordenar();
            cli.SelectClientes();

            Console.ReadKey();
        }
    }
}