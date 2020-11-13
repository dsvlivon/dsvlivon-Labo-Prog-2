using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        public Gente(short edad):base("",edad)
        {

        }
        public Gente(string nombre, short edad) : base(nombre, edad)
        {

        }
        /// <summary>
        /// Valida edad >18
        /// </summary>
        /// <returns></returns>
        public override bool Validar()
        {
            if(Edad>18)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Muestra los datos de gente
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("GENTE:");
            sb.AppendFormat($"Alt: {Nombre}");
            sb.AppendFormat($"Peso: {Edad}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
