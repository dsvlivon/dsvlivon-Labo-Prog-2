using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        private int dni;

        public Empleado(string nombre, short edad):base(nombre, edad)
        {
            this.dni = -1;
        }
        public Empleado(string nombre, short edad, int dni):base(nombre, edad)
        {
            this.dni = dni;
        }

        public int Dni 
        { 
            get
            {
                return this.dni;
            }            
        }

        public override bool Validar()
        {
            if (Edad > 21 && Nombre.Length >2)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("EMPLEADO:");
            sb.AppendFormat($"Nombre: {Nombre}");
            sb.AppendFormat($"Edad: {Edad}");
            if(Dni != 0 && Dni!=-1)
            { 
                sb.AppendFormat($"Peso: {Dni}");
            }
            return sb.ToString();
        }
        /// <summary>
        /// dos empleados son iguales si comparte nombre y edad
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if(e1.Nombre== e2.Nombre && e1.Edad == e2.Edad)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }


    }
}
