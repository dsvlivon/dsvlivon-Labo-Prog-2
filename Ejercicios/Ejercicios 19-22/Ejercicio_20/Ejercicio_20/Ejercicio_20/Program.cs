using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar unDolar = new Dolar(1);
            Euro unEuro = new Euro(3.10);
            Peso unPeso = new Peso(19.88);


            Euro auxEuro = unEuro - unPeso;
            Peso auxPeso = unPeso + unDolar;
            Dolar auxDolar = unDolar + unPeso + unEuro;

            Console.WriteLine(auxEuro.getCantidad());
            Console.WriteLine(auxPeso.getCantidad());
            Console.WriteLine(auxDolar.getCantidad());
            Console.ReadKey();
        }
    }
}
