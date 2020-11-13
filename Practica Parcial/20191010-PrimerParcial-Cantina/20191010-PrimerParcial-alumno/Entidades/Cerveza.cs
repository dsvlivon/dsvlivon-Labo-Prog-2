using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(string marca, int capacidadML, int contenidoML, Tipo tipo) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        public Cerveza(string marca, int capacidadML, int contenidoML) : this(marca, capacidadML, contenidoML, Tipo.Vidrio)
        {
         
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(Cerveza.MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            float medidaCerveza = (float)MEDIDA*0.8f;
            if (medidaCerveza <= this.contenidoML)
            {
                this.ContenidoML = contenidoML - medida;
            }
            else if (medidaCerveza > contenidoML)
            {
                this.ContenidoML -= this.ContenidoML;
            }
            return this.ContenidoML;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat($"Tipo: {this.tipo}");

            return sb.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
