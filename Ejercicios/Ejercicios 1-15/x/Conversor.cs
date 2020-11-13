using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        static public int BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            //invierte los valores van incrementadose de derecha a izquierda
            Array.Reverse(array);
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    //Usamos la potencia de 2, segun la posicion
                    suma += (int)Math.Pow(2, i);
                }
            }
            return suma;
        }

        static public string DecimalBinario(int numero)
        {
            string resto = "";

            while ((numero >= 2))
            {
                resto = numero % 2 + resto;
                numero /= 2;
            }
            return resto;
        }

    }
}
