using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador():this (0)
        {          

        }
        
        public long Sumar(long a, long b)          
        {
            long aux = a + b;
            this.cantidadSumas++;
            return aux;
        }

        public string Sumar(string a, string b)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(a);
            retorno.AppendFormat(b);
            this.cantidadSumas++;
            return retorno.ToString();
        }

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas; 
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas + s2.cantidadSumas);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
