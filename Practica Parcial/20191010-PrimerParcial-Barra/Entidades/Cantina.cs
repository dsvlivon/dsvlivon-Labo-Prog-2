using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        private Cantina(int espacios)
        {
            botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        public static Cantina GetCantina(int espacios)
        {
            if (singleton == null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if(c.espaciosTotales > c.Botellas.Count)
            {
                c.Botellas.Add(b);
                return true;
            }
            return false;
        }

}
}
