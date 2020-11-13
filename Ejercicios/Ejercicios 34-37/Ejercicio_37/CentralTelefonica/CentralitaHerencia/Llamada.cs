using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion 
        { 
            get 
            { 
                return duracion; 
            } 
        }
        public string NroDestino 
        { 
            get 
            { 
                return nroDestino; 
            } 
        }
        public string NroOrigen 
        { 
            get 
            { 
                return nroOrigen; 
            } 
        }

        
        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(string.Format($"Duracion de la llamada: {this.Duracion}"));
            mensaje.AppendLine(string.Format($"Numero de Origen: {this.NroOrigen}"));
            mensaje.AppendLine(string.Format($"Numero de Destino: {this.NroDestino}"));
            return mensaje.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = -1;

            if (llamada1.duracion > llamada2.duracion)
            {
                retorno= 1;
            }
            else if (llamada1.duracion == llamada2.duracion)
            { 
                retorno = 0;
            }
            return retorno;            
        }
        
    }
}
