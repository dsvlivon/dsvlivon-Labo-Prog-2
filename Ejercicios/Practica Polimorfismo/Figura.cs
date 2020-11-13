using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Figura
    {
        public double num1;
        public double num2;

        public abstract double CalcuarSuperficie();
        public abstract double CalcuarPerimetro();

        public virtual String Dibujar()
        {
            return "Dibujando forma...";
        }
    }
}
