using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tecnico : Persona
    {
        private int añosExperiencia;


        public int AñosExperiencia
        {
            get { return this.añosExperiencia; }
            set { this.añosExperiencia = value; }
        }

        public Tecnico(string nombre, string apellido, short edad, int dni, int años) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = años;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Datos del dt: {base.Mostrar()}");
            sb.AppendFormat($"Experiencia: {this.añosExperiencia}");

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            if (this.Edad < 65 && this.AñosExperiencia >= 2)
            {
                return true;
            }
            return false;
        }
    }
}


