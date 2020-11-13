﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*/
Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. 
Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. 
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
/*/

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°6";

            string input;
            int value;

            Console.WriteLine("Ingrese el año a calcular: ****");
            input = Console.ReadLine();
            int.TryParse(input, out value);

            
            if (value % 4 == 0 && value % 100 != 0 || value % 400 == 0)
            {
                Console.WriteLine("{0} es bisiesto ", value);
            }
            else
            {
                Console.WriteLine("{0} no es bisiesto ", value);
            }

         Console.ReadKey();
        }
    }
}
