using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public abstract class Producto
    {
        public enum Origen { Nacional, Importado }

        private string nombre;
        private Origen origen;
        private int valorDeCompra;

        public abstract int PorcentajeGanancia { get; }
        public abstract int PorcentajeImpuestoInterno { get; }
        public abstract float ValorDeVenta { get; }
        public int PorcentajeImpuestoImportacion
        {
            get
            {
              return valorDeCompra += (int)origen;
            }
        }


        protected Producto(string nombre, int valorDeCompra, Origen origen)
        {
            this.nombre = nombre;
            this.valorDeCompra = valorDeCompra;
            this.origen = origen;
        }
        public virtual string Etiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Producto {this.nombre} comprado a {this.valorDeCompra} como {origen}"));
            return sb.ToString();

        }

        public static explicit operator Origen(Producto p)
        {
            if (p.origen == Origen.Importado)
            {
                p.valorDeCompra = (p.valorDeCompra * 35) / 100;

                return Origen.Importado;
            }

            return Origen.Nacional;
        }
    }
}

