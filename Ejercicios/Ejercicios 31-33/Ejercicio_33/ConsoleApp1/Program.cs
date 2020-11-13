using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            string pag;

            for (int i = 0; i < 5; i++)
            {
                libro[i] = String.Format("Página {0:0#}", i);
            }

            pag = libro[0];
            Console.WriteLine("\nIndice: {0}. Resultado: {1}", 0, pag);

            pag = libro[1];
            Console.WriteLine("\nIndice: {0}. Resultado: {1}", 1, pag);

            pag = libro[2];
            Console.WriteLine("\nIndice: {0}. Resultado: {1}", 2, pag);

            Console.ReadKey();
        }
    }
}
