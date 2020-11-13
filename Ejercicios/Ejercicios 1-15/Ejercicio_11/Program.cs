using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

/*/11.Realizar una clase llamada Validacion que posea un método estático llamado Validar, 
que posea la siguiente firma: 
bool Validar(int valor, int min, int max):
a.valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. 
Validar con el método desarrollado anteriormente que esten dentro del rango -100 y 100. 
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. 
Nota: Utilizar variables escalares, NO utilizar vectores./*/

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°11";
            int valueA;
            int acumulator = 0;
            int counter = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            string input;
            float average;

            for (int i = 0; i < 10; i++)
            {

                do
                {
                    Console.Write("ingrese un numero: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out valueA));

                if(Validacion.Validar(valueA,-100,100))
                {
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
