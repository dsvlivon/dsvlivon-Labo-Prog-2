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
            Grupo grupoMixto = new Grupo("Mascotitas love", Grupo.TipoManada.Mixta);
            Grupo grupoPerros = new Grupo("Mascotitas Perros", Grupo.TipoManada.Unica);//al no poner el tipo de grupo, se setea en Unica.
            Grupo grupoGatos = new Grupo("Mascotitas Gatos");

            Perro perro1 = new Perro("Yago", "Ñoño", 10, true);//esAlfa = true;
            Perro perro2 = new Perro("Camu", "Salchicha", 9, false);//no tiene que mostrar que es alfa
            Perro perro3 = new Perro("Maggie", "Shorshire");//edad = 0, no tiene que mostrar que es alfa

            Gato gato1 = new Gato("Neo", "Abisinio");
            Gato gato2 = new Gato("Queen", "Asiático");
            Gato gato3 = new Gato("Princesa", "Bombay");

            Perro perroClon1 = new Perro("Yago", "Ñoño", 10, true);//esAlfa = true;
            Gato gatoClon1 = new Gato("Neo", "Abisinio");

            Console.WriteLine("--PERROS--");
            Console.WriteLine(perro1.ToString());
            Console.WriteLine(perro2.ToString());
            Console.WriteLine(perro3.ToString());
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--GATOS--");
            Console.WriteLine(gato1.ToString());
            Console.WriteLine(gato2.ToString());
            Console.WriteLine(gato3.ToString());
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            //---------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------

            Console.WriteLine("--GRUPO MIXTO--");
            grupoMixto += perro1;
            grupoMixto += perro2;
            grupoMixto += perro3;
            Console.WriteLine(grupoMixto);
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--GRUPO MIXTO (Borro a Yago)--");
            grupoMixto += perro1;
            grupoMixto += perro2;
            grupoMixto -= perro1;
            Console.WriteLine(grupoMixto);
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--GRUPO MIXTO (Agrego de nuevo a Yago)--");
            grupoMixto += new Perro("Yago", "Ñoño", 10, true);
            Console.WriteLine(grupoMixto);
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
