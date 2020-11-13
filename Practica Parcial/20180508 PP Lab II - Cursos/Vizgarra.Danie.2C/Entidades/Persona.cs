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
        private string documento;
        private string nombre;
        //public enum Divisiones { A, B, C, D, E }
        public Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.Documento = documento;
            this.nombre = nombre;
        }


        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public string Documento
        {
            get { return this.documento; }
            set
            {
                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                    /* esto es triky ... OJO!
                    usa el ValidarDocumentacion, q es ABSTRACT, no esta implementado 
                    entonces segun el poliformismo va a implementar el mas especifico
                    d cada clase
                    */
                }
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {nombre}");
            sb.AppendFormat($"Nombre: {apellido}");
            sb.AppendFormat($"Nombre: {documento}");

            return sb.ToString();
        }
        protected abstract bool ValidarDocumentacion(string doc);
    }
}
