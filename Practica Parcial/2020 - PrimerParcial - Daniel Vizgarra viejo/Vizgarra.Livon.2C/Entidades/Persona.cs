using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public short Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public Persona(string nombre, short edad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
        }

        public static explicit operator string(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Persona:");
            
            return sb.ToString();
        }

        public abstract bool Validar();
        protected abstract string Mostrar();
    }
}
