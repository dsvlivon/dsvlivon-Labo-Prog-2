using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario 
//por consola. Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°3";
            int value;
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out value))
            {
                if(value == 1)
                {
                    Console.Write("No hay numeros primos que mostrar.");
                }
                else
                {
                    int i = 0;                
                    for (int j = 2; j <= value; j++)
                    {
                        for (i = 2; i < j; i++)
                        {
                            if ((j % i) == 0)
                            {
                                break;
                            }
                        }
                        if (i == j)
                        {
                            Console.WriteLine("{0} es primo", j);
                        }
                        else
                        {
                            Console.WriteLine("{0} NO es primo", j);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
