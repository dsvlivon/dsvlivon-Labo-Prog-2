using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar 5 números por consola, guardándolos en una variable escalar. 
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°1";

            int valueA;
            int acumulator=0;
            int counter=0;
            int max = int.MinValue;
            int min = int.MaxValue;
            string input;
            float average;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("ingrese un numero: ", i);
                input = Console.ReadLine();

                while (!int.TryParse(input, out valueA))
                {
                    Console.Write("ingrese un numero: ", i);
                    input = Console.ReadLine();
                }
                if ((valueA > max) || i == 0)
                {
                    max = valueA;
                }
                if ((valueA < min || i == 0))
                {
                    min = valueA;
                }
                counter++;
                acumulator += valueA;
            }
            Console.Clear();
            Console.WriteLine("El numero maximo es: {0} ", max);
            Console.WriteLine("El numero minimo es: {0} ", min);
            average = acumulator / counter;
            Console.WriteLine("El numero promedio es: {0:#.##}", average);
            Console.ReadKey();

        }
    }
}
