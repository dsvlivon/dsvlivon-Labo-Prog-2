using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafos;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //En el Main, crear un bolígrafo de tinta azul(ConsoleColor.Blue) y una cantidad inicial de tinta de 100 
            //y otro de tinta roja(ConsoleColor.Red) y 50 de tinta.
            Boligrafo lapiceraAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo lapiceraRoja = new Boligrafo(50, ConsoleColor.Red);

            //int opcion;
            string dibujo;

            lapiceraRoja.Pintar(20, out dibujo);
            Console.ForegroundColor = lapiceraRoja.GetColor();
            
            Console.WriteLine(dibujo);
            lapiceraAzul.Pintar(20, out dibujo);
            Console.ForegroundColor = lapiceraAzul.GetColor();
            
            Console.WriteLine(dibujo);
            lapiceraRoja.Pintar(20, out dibujo);
            Console.ForegroundColor = lapiceraRoja.GetColor();


            Console.ReadKey();

        }
    }
}
