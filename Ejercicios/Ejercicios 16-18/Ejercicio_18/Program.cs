using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejericicio 18";

            Geometria.Punto punto1 = new Geometria.Punto(1, 4);
            Geometria.Punto punto2 = new Geometria.Punto(3, 5);
            Geometria.Punto punto3 = new Geometria.Punto(4, 3);
            Geometria.Punto punto4 = new Geometria.Punto(6, 2);

            Geometria.Rectangulo figura1 = new Geometria.Rectangulo(punto1, punto2);
            Geometria.Rectangulo figura2 = new Geometria.Rectangulo(punto3, punto4);

            Console.WriteLine("FIGURA 1");
            Console.WriteLine("Area: {0}", figura1.Area());
            Console.WriteLine("Perimetro: {0}", figura1.Perimetro());

            Console.WriteLine("");
            Console.WriteLine("FIGURA 2");
            Console.WriteLine("Area: {0}", figura2.Area());
            Console.WriteLine("Perimetro: {0}", figura2.Perimetro());





            Console.ReadKey();
        }
    }
}
