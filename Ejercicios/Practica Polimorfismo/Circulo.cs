using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Circulo : Figura
    {
        public Circulo(double radio)
        {
            this.num1 = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo...";
        }

        public override double CalcuarPerimetro()
        {
            return Math.PI * this.num2;
        }

        public override double CalcuarSuperficie()
        {
            return (Math.PI * this.num1) * 2;
        }
    }
}
