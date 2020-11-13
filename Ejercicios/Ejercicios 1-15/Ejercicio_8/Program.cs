using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

/*/
Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas 
trabajadas en el mes de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar 
el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados 
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos. 
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en 
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados. 
Nota: Utilizar estructuras repetitivas y selectivas.
namespace Ejercicio8
/*/
namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO N°8";

            string inputChar;
            char answer;
            string nombre;
            string input;
            int hora;
            int antiguedad;
            float cobro;
            float dto = 0.87f;
            float totalNeto;
            float totalDescuento;

            do
            {
                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese las horas: ");
                input = Console.ReadLine();
                int.TryParse(input, out hora);
                Console.Write("Ingrese las horas: ");
                input = Console.ReadLine();
                int.TryParse(input, out antiguedad);

                cobro = hora * antiguedad * 150;
                totalDescuento = cobro - (cobro * dto);
                totalNeto = cobro - dto;  

                Console.WriteLine("Recibo de sueldo:" + "\n" +
                            "---------------------------------" + "\n" +
                            "Nombre: " + nombre + "\n" +
                            "Antiguedad: " + antiguedad + "\n" +
                            "Valor por hora: " + hora + "\n" +
                            "Total sueldo bruto: " + cobro + "\n" +
                            "Descuentos: " + totalDescuento + "\n" +
                            "Valor neto a cobrar: " + totalNeto + "\n");

                Console.Write("Desea ingresar otro numero(S/N): ");
                inputChar = Console.ReadLine();
                char.TryParse(inputChar, out answer);

            } while (ValidarRespuesta.ValidaS_N(answer));
              Console.ReadKey();
        }
    }
}
