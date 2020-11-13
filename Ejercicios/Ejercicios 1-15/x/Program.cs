using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*/N°13.Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
 * string DecimalBinario(int). Convierte un número de entero a binario. int BinarioDecimal(string). Convierte un número binario a entero.
NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control./*/

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            int numero;
            string binario = "";

            Console.Write("Ingrese el numero decimal a convertir: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.Write("Ingrese el numero binario a convertir: ");
            binario = Console.ReadLine();

            Console.WriteLine("Numero en binario: " + Conversor.DecimalBinario(numero));
            Console.WriteLine("Numero en decimal: " + Conversor.BinarioDecimal(binario));
            Console.ReadKey();
        }
    }
}