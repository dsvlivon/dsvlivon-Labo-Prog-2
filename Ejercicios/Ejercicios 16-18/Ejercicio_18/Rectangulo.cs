using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    /*La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4 
    (que corresponden a los cuatro vértices del rectángulo).*/
    public class Rectangulo
    {
        private float area;
        private float perimetro;

        Punto vertice1;//puedo usar la clase Punto sin usar el using xq estan en el mismo NameSpace
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }
        public float Area()
        {
            float laBase = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.area = laBase* altura;

            return this.area;
        }
        public float Perimetro()
        {
            float laBase= Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.perimetro = (laBase + altura) * 2;

            return this.perimetro;
        }
    }
}
