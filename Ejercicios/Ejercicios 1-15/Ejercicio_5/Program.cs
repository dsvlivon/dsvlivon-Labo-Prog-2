using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*/
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) 
 * en dos grupos de números, cuyas sumas son iguales. El primer centro numérico es el 6, el cual separa 
 * la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
 * El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: 
 * (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. 
 * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario 
 * ingrese por consola. Nota: Utilizar estructuras repetitivas y selectivas.
/*/
namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°5";
            int value;
            string input;
            
            Console.Write("Ingrese un numero para determinar su centro: ");
            input = Console.ReadLine();
            if(int.TryParse(input, out value))
            {
                Console.WriteLine("buscando centro para {0}...", value);
                for (int i = 1; i <= value; i++)
                {
                    int buffer = 0;
                    for (int j = 1; j < i; j++)
                    {
                        buffer += j;
                    }
                    int cont = i + 1;
                    do
                    {
                        buffer -= cont;
                        cont++;
                    } while (buffer > 0);

                    if (buffer == 0)
                    {
                        Console.WriteLine("{0} es centro numérico de {0}", i,value);
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("Ingreso un dato invalido.");
            }
            Console.ReadKey();
        }
    }
}

