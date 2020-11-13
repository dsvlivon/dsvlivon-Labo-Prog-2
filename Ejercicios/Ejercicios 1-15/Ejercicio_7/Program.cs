using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*/
Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) 
y calcule el número de días vividos por esa persona hasta la fecha actual 
(tomar la fecha del sistema con DateTime.Now). 
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
/*/

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°7";
            
            DateTime date1 = new DateTime();
            //DateTime date2 = new DateTime();
            TimeSpan dias;

            //string now;

            Console.Write("Ingrese su decha de nacimiento (--/--/----):");
            date1 = DateTime.Parse(Console.ReadLine());
            dias = DateTime.Now - date1;

            Console.WriteLine("Ha vivido {0} dias.", dias.Days);

            /*/Console.WriteLine("AÑO: ");
            inputYear = Console.ReadLine();
            Console.WriteLine("MES: ");
            inputYear = Console.ReadLine();
            Console.WriteLine("DIA: ");
            inputYear = Console.ReadLine();
            if (!int.TryParse(inputYear, out year) || !int.TryParse(inputMonth, out month) || !int.TryParse(inputDay, out day))
            {
                Console.WriteLine("Error en ingreso de datos.");
            }/*/
            //Console.WriteLine("{0}", date1);


            Console.ReadKey();

        }
    }
}
