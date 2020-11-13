using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(3));
            figuras.Add(new Rectangulo(4, 6));
            figuras.Add(new Cuadrado(3, 3));

            foreach (Figura fig in figuras)
            {
                Console.WriteLine(fig.GetType());
                Console.WriteLine(fig.Dibujar());
                Console.WriteLine("Area:{0}",fig.CalcuarSuperficie());
                Console.WriteLine("Perimetro:{0}", fig.CalcuarPerimetro());
                Console.WriteLine("**************");
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        
        }
    }
}
