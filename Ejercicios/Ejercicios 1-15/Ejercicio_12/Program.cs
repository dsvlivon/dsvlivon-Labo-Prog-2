using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

/*/N°12 - Realizar un programa que sume números enteros hasta que el usuario lo determine, 
 * por medio de un mensaje "¿Continuar? (S/N)". En el método estático ValidaS_N(char c) 
 * de la clase ValidarRespuesta, se validará el ingreso de opciones. 
 * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' 
 * y FALSE si se ingresó cualquier otro valor./*/

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°12";
            string input;
            char answer;
            string inputChar;
            int valueA;

            do
            {
                do
                {
                    Console.Write("ingrese un numero: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out valueA));
                Console.Write("Desea ingresar otro numero(S/N): ");
                inputChar = Console.ReadLine();
                char.TryParse(inputChar, out answer);
            } while (ValidarRespuesta.ValidaS_N(answer));
            Console.Write("Gracias...");
        }
    }
}
