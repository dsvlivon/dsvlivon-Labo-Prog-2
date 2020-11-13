using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado1, double lado2): base
            (lado1, lado2)
        { }
        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }
    }
}
