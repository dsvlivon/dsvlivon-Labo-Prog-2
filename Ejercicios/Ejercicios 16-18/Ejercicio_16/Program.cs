using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.apellido = "Ariel Perez";
            alumno2.apellido = "Bernando Gomez";
            alumno3.apellido = "Carlos Lopez";

            alumno1.legajo = 100;
            alumno2.legajo = 101;
            alumno3.legajo = 102;
            //hasta ahi asigno derecho datos a los atributos

            alumno1.Estudiar(3, 4);
            alumno2.Estudiar(5, 6);
            alumno3.Estudiar(7, 8);
            //aca se llama al Metodo Estudiar y cargo las notas

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            //escibies en consola c el cw, llamando metodo Mostrar d cada objeto instanciado
            Console.ReadKey();
        }
    }
}
