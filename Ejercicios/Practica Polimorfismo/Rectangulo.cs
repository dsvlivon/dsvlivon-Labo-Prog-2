using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo:Figura
    {
        public Rectangulo(double lado1, double lado2)
        {
            this.num1 = lado1;
            this.num2 = lado2;
        }

        public override double CalcuarPerimetro()
        {
            return (this.num1 * 2) + (this.num2 * 2);
        }

        public override double CalcuarSuperficie()
        {
            return this.num1 * this.num2;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }
    }
}
