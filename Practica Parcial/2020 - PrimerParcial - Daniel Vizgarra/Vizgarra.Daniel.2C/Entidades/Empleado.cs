using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private int dni;

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public Empleado(string nombre, short edad) : this(nombre, edad, -1)
        {

        }

        public Empleado(string nombre, short edad, int dni) : base(nombre, edad)
        {
            this.dni = dni;
        }

        public override bool Validar()
        {
            if (Edad > 21 && Nombre.Length > 2)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (e1.Nombre == e2.Nombre && e1.Edad == e2.Edad)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de: EMPLEADO");
            sb.AppendLine(base.Mostrar());//ESTE ERA EL TRUCO
            sb.AppendFormat("DNI: {0} \n", this.dni);

            return sb.ToString();
        }
    }
}
