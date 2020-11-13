using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    /*La clase Punto ha de tener dos atributos privados con acceso de sólo lectura (sólo con getters), 
     que serán las coordenadas del punto. También un constructor que reciba los parámetros x e y.*/
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int a, int b)
        {
            this.x = a;
            this.y = b;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
