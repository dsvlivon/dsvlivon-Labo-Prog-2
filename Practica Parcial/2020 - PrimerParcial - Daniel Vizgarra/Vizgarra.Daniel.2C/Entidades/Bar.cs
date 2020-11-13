using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gentes;
        private static Bar singleton;
        public static int max = 10;


        public List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }
        }
        public List<Gente> Gentes
        {
            get
            {
                return gentes;
            }
        }


        private Bar()
        {
            gentes = new List<Gente>();
            empleados = new List<Empleado>();
        }

        public static Bar GetBar()
        {
            if (singleton == null)
            {
                singleton = new Bar();
            }
            return singleton;
        }

        public static bool operator +(Bar bar, Empleado empleado)
        {
            if (empleado.Validar())
            {
                foreach (Empleado aux in bar.empleados)
                {
                    if (empleado == aux)
                    {
                        return false;
                    }
                }
                bar.empleados.Add(empleado);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            int capacidad = bar.empleados.Count * max;
            if (gente.Validar() && bar.gentes.Count < capacidad)
            {
                bar.gentes.Add(gente);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Gente gente in gentes)
            {
                sb.AppendFormat((string)gente);
                //este era el truco p/usar la sobrecarga del string
            }
            foreach (Empleado empleado in empleados)
            {
                sb.AppendFormat((string)empleado);
            }
            return sb.ToString();
        }
    }
}
