using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local: Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        //dudas
        public Local(string origen,float duracion, string destino, float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
               
        }

        private float CalcularCosto()
        {
            float retorno=-1;

            if(this.Duracion >0 && this.costo>0)
            {
                retorno = this.Duracion * this.costo;
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(string.Format($"base: {base.Mostrar()}"));
            mensaje.AppendLine(string.Format($"Costo de la llamada: {this.CostoLlamada:C}"));
            return mensaje.ToString();
        }
    }
}
