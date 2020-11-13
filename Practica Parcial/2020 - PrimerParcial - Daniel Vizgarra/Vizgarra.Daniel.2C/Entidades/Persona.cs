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

        public short Edad 
        { 
            get
            {
                return edad;
            }
            set
            {
                this.edad = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        public static explicit operator string(Persona persona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", persona.Nombre);
            sb.AppendFormat("Edad: {0}\n", persona.Edad);

            return sb.ToString();
        }

        public virtual string Mostrar()
        {
            return (string)this;
        }

        protected Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public abstract bool Validar();

    }
}
