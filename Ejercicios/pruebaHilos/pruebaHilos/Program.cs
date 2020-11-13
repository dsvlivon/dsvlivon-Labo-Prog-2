using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace pruebaHilos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = new Thread(ThreadStart(metodoX)); eso seria designando un delegado del tipo Thread
            //Thread t = new Thread(metodoX);
            Thread t = new Thread(()=>metodoY("A","B"));

            t.Start();
            t.Join();//para q se encolen.. digamos. 
            Console.WriteLine("Hilo finalizado.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main.");
            }
            Console.ReadKey();
            //lo q va a pasar es q va a arrancar a escribir 'Main'... y dps va a ir mechando con 'Hilos'
        }

        static void metodoY(string s, string k)
        {
            Console.WriteLine(s);
            Console.WriteLine(k);
        }

        //static void metodoX()
        static void metodoX(object o)
        {
            Console.WriteLine(o.ToString());
            for(int i=0; i<10;i++)
            {
                Console.WriteLine("Hilos.");
            }
        }

    }
}
