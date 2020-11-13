using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace LosResultadosDeLafecha
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("AFA");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("FABB");

            EquipoFutbol Futbol1 = new EquipoFutbol("River");
            EquipoFutbol Futbol2 = new EquipoFutbol("Boca");
            EquipoFutbol Futbol3 = new EquipoFutbol("Banfield");
            EquipoBasquet Basquet1 = new EquipoBasquet("Obras");
            EquipoBasquet Basquet2 = new EquipoBasquet("Ferro");
            EquipoBasquet Basquet3 = new EquipoBasquet("GyELZ");


            bool rta;
            rta = torneoFutbol + Futbol1;
            rta = torneoFutbol + Futbol2;
            rta = torneoFutbol + Futbol3;
            //rta = torneoBasquet + Futbol3; no se pude xq el + sobrecarga c el == q se fija q sean Tipos iguales
            rta = torneoBasquet + Basquet1;
            rta = torneoBasquet + Basquet2;
            rta = torneoBasquet + Basquet3;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine(torneoFutbol.JugarPartido());
            Console.WriteLine(torneoFutbol.JugarPartido());

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.WriteLine(torneoBasquet.JugarPartido());
            Console.WriteLine(torneoBasquet.JugarPartido());


            Console.ReadKey();
        }
    }
}
