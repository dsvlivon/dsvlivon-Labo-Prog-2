using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        Tipo tipo;

        public Cerveza(string marca, int capacidadML, int contenidoML) : this(marca, capacidadML, Tipo.Vidrio, contenidoML)
        {

        }

        public Cerveza(string marca, int capacidadML, Tipo tipo, int contenidoML) : base(capacidadML, contenidoML, marca)
        {
            this.tipo = tipo;
        }
        // this.cantina.Botellas.Add(new Cerveza("", 2000, Botella.Tipo.Vidrio, 2000));

        public override int ServirMedida()
        {
            if (MEDIDA <= this.Contenido)
            {
                this.Contenido = this.Contenido - (MEDIDA * 80 / 100);
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
            sb.AppendFormat($"Tipo:{this.tipo}");


            return sb.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
