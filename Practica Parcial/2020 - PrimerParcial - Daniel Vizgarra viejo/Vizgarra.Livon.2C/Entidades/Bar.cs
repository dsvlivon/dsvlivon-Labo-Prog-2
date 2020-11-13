using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Gente> gente;
        private List<Empleado> empleados;
        private static Bar singleton;
        
       private Bar()
        {
            this.gente = new List<Gente>();
            this.empleados = new List<Empleado>();
        }

        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }
        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }

        public static Bar GetBar()
        {
            if (singleton == null)
            {
                singleton = new Bar();
            }
            
            return singleton;
        }
        /// <summary>
        /// Si estan dadas las condiciones, agrega un empleado
        /// </summary>
        /// <param name="bar"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static bool operator +(Bar bar, Empleado empleado)
        {
            if (!(bar is null) && !(empleado is null))
            {
                if (bar.gente.Count<=10)
                {
                    foreach(Empleado item in bar.empleados)
                    {
                        if(item==empleado)
                        {
                            return true;
                        }
                    }
                    bar.empleados.Add(empleado);
                }
            }
            return false;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            if (!(bar is null) && !(gente is null))
            {
                bar.gente.Add(gente);
            }
            return false;
        }//estos son bool... puedo saber si agrega o no

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Gente gente in gente)
            {
                sb.AppendLine(gente.ToString());
            }
            foreach (Empleado empleado in empleados)
            {
                sb.AppendLine(empleado.ToString());
            }
            return sb.ToString();
        }
    }
}
