using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.capacidadML = capacidadML;
            this.marca = marca;

            if(capacidadML<contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else 
            { 
                this.capacidadML = capacidadML; 
            }
        }

        
        public int CapacidadML
        {
            get
            {
                return this.capacidadML/1000;
            }
        }
        public int ContenidoML
        {
            get
            {
                return this.contenidoML/1000;
            }
            set
            {
                this.capacidadML = value;
            }
        }
        public float PorcentajeContenido 
        {
            get
            {
                return (contenidoML*100)/capacidadML; 
            } 
        }

        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Marca: {this.marca}");
            sb.AppendFormat($"Capacidad: {CapacidadML}");
            sb.AppendFormat($"Contenido: {ContenidoML}");
            sb.AppendFormat($"Porcentaje: {PorcentajeContenido}");

            return sb.ToString();
        }


        public override string ToString()
        {
            return this.GenergarInforme();
        }
    }
}
