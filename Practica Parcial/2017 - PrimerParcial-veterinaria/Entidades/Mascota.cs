using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre { get { return this.nombre; } }
        public string Raza { get { return this.raza; } }


        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        protected abstract string Ficha();
        
        /*
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: {nombre}");
            sb.AppendFormat($"Raza: {raza}");

            return sb.ToString();
        }*/
        protected virtual string DatosCompletos()
        {
            string nombre = string.Format("\nNombre : {0}", this.nombre);
            string raza = string.Format("\nRaza : {0}", this.raza);
            return nombre +" / "+ raza;
        }

    }
}
