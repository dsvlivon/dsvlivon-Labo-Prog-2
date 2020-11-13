using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool aux = false;
            if(valor>=min && valor<=max)
            {
                aux = true;
            }
            return aux;
        }
    }

    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool aux = false;
            if (c=='s' || c=='S')
            {
                aux = true;
            }
            return aux;
        }
    }

}
