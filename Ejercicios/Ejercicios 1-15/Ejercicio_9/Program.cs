using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*/
Escribir un programa que imprima por pantalla una pirámide como la siguiente: 
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. 
Para el ejemplo anterior la altura ingresada fue de 5. 
Nota: Utilizar estructuras repetitivas y selectivas.
/*/
namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°9";

            string input;
            int altura;
            //int alturaAcumulada=1;

            Console.Write("Ingrese la altura de la piramide: ");
            input = Console.ReadLine();
            int.TryParse(input, out altura);

            //Console.WriteLine("*");
            
            for(int i=1;i<=(altura*2);i+=2)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
            Console.ReadKey();
        }
    }
}
