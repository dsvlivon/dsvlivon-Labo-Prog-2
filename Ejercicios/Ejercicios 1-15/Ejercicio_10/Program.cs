using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*/
Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima 
por pantalla una pirámide como la siguiente:
    *
   ***
  *****
 ********
**********
Nota: Utilizar estructuras repetitivas y selectivas.
/*/
namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°10";

            string input;
            int altura;
            //int alturaAcumulada=1;

            Console.Write("Ingrese la altura de la piramide: ");
            input = Console.ReadLine();
            int.TryParse(input, out altura);

            //Console.WriteLine("*");

            for (int i = 1; i <= altura; i++)
            {
                //Console.Write(" ");
                for (int j = i; j <= altura; j++)
                {
                    Console.Write("  ");
                }
                for (int e = 1; e <= (2*i)-1; e++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
