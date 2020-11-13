using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {

        public Gente(short edad) : base("", edad)
        {

        }

        public Gente(string nombre, short edad) : base (nombre, edad)
        {

        }

        public override bool Validar()
        {
            if (Edad > 18)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// sobrecarga del string para dato d gente
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de: GENTE");
            sb.AppendLine(base.Mostrar());//ESTE ERA EL TRUCO

            return sb.ToString();
        }
    }
}
