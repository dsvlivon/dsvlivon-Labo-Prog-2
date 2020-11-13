using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*/N°4-Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
 * (excluido el mismo) que son divisores del número. El primer número perfecto es 6, ya que los divisores
 * de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación que encuentre los 4 primeros números 
 * perfectos. Nota: Utilizar estructuras repetitivas y selectivas./*/

//NO FUNCA

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°4";
            int buffer = 0;
            int cont = 0;
            int value = 1;
            //Console.Write("Ingrese un número: ");
            /*/if (int.TryParse(Console.ReadLine(), out value))
            {/*/
            //Console.WriteLine("suma ejemplo: {0}", value +1);
            do
            {
                Console.WriteLine("INICIANDO...");
                for (int i = 1; i < value; i++)
                {
                    /*/if ((i % 2) > 0)
                    {
                        Console.WriteLine("{0} no es par",i);
                    }
                    else
                    {
                        Console.WriteLine("{0} es par",i);
                    }/*/
                    Console.WriteLine("probando {0}", i);
                    for (int j = value-1; j > 0; j--)
                    {
                        if ((value % j) == 0)
                        {
                            buffer += j;
                            //cont++;
                        }
                        else
                            Console.WriteLine("no... ");
                    }
                    if (buffer == value)
                    {
                        cont++;
                        Console.WriteLine("Los primeros cuatro numeros perfectos son: {0}",i);
                    }
                }
                value++;
             } while (cont == 3);
            Console.ReadLine();
        }
    }
}
