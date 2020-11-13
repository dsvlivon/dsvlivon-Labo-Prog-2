using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo
        {
            Plastico, Vidrio
        }

        public int CapacidadLitros
        { 
            get
            {
               return this.capacidadML/1000;
            }
        }
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
                
        public float PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * 100)/this.capacidadML;
            }
        }

        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            if(capacidadML<=contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }
            this.capacidadML = capacidadML;
            this.marca = marca;
        }

        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Botella de {marca}");
            sb.AppendFormat($"Contenido: {contenidoML}");
            sb.AppendFormat($"Capacidad: {capacidadML}");
            sb.AppendFormat($"Porcentaje: {PorcentajeContenido}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme(); 
        }
    }
}
