using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
        {

        }

        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public bool EsAlfa { get { return this.esAlfa; } set { this.esAlfa = value; } }
        
        protected override string Ficha()
        {
            /*Si es alfa: Ramón Salchicha, alfa de la manada, edad 2 
             * Si no lo es: Julio Cruza edad 13*/
            string buffer = "";
            if (esAlfa == true)
            {
                buffer = "alfa de la manada";
            }

            return DatosCompletos() + "\n" + buffer + "\n" + edad;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }
        public override string ToString()
        {
            //ojo q dice SOBREESCRIBIR
            return this.Ficha();
        }

        public override bool Equals(Object obj)
        {
            if (obj is Perro)
            {
                if (this == (Perro)obj)
                {
                    return true;
                }                    
            }
            return false;
        }
    }
}
