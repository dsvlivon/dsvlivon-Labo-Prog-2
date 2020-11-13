using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 5;
            Stack<double> data = new Stack<double>();
            int i;
            for (i = max; i >0; i--)
            {
                data.Push(i);
            }
            for (i = 0; i < max; i++)
            {
                Console.WriteLine(String.Format("{0} ", data.Pop()));
            }
            Console.ReadKey();
        }
    }
}
