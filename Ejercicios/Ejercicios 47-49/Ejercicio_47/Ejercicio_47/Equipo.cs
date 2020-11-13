using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
            this.fechaCreacion = DateTime.Today;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.nombre == e2.nombre && e2.fechaCreacion == e1.fechaCreacion)
                return true;
            return false;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            
            return !(e1==e2);
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"[{this.nombre}] Fundado el [{this.fechaCreacion:dd/MM/yy}]"));
            return sb.ToString();
        }


    }
}
