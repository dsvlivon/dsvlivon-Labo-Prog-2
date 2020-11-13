using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua:Botella
    {
        private const int MEDIDA=400;


        public Agua(string marca, int capacidadML,  int contenidoML):base(marca, capacidadML, contenidoML)
        {

        }
        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            if (MEDIDA <= this.contenidoML)
            {
                this.ContenidoML = contenidoML - medida;
            }
            else if (MEDIDA > contenidoML)
            {
                this.ContenidoML -= this.ContenidoML;
            }
            return this.ContenidoML;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());

            return sb.ToString();
        }
    }
}
