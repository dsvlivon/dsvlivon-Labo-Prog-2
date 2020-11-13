using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
//Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
//Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°2";

            int value;
            string input;
            double doubleValue;


            Console.Write("Ingrese un numero mayor a cero: ");
            input = Console.ReadLine();
            int.TryParse(input, out value);

            while (value <= 0)
            {
                Console.Write("Error! El numero ingresado debe ser mayor a cero: ");
                input = Console.ReadLine();
                Int32.TryParse(input, out value);
            }
            doubleValue = value;
            Console.WriteLine("El cuadrado del numero ingresado es : {0}", Math.Pow(doubleValue,2));
            Console.WriteLine("El cuadrado del numero ingresado es : {0}", Math.Pow(doubleValue,3));
            Console.ReadKey();
        }
    }
}
