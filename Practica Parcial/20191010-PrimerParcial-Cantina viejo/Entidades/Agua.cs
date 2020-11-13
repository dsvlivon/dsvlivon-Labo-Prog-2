using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        const int MEDIDA = 400;

        public Agua(string marca, int capacidadML, int contenidoML): base(capacidadML, contenidoML, marca)
        {
            // this.cantina.Botellas.Add(new Agua("", 2000, Botella.Tipo.Vidrio, 2000));
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }

        public int ServirMedida(int medida)
        {
            if(medida<=this.Contenido && medida >0)
            {
                this.Contenido = this.Contenido - medida;
            }
            else
            {
                this.Contenido -= this.Contenido;
            }
            return this.Contenido;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
          
                        return sb.ToString();
        }

   }   
}
