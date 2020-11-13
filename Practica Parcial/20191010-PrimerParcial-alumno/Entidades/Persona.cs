using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dorsal;
        private short edad;

        public Persona(string nombre, string apellido, short edad, int dorsal)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dorsal = dorsal;
            this.edad = edad;
        }

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Dni { get { return this.dorsal; } }
        public short Edad { get { return this.edad; } }


        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {nombre}");
            sb.AppendFormat($"Apellido: {apellido}");
            sb.AppendFormat($"Edad: {edad}");
            sb.AppendFormat($"Dorsal: {dorsal}");

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}

