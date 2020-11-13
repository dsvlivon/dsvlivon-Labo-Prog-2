using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion{ get; }
        public double Precio{ get; }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = new Guid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Descpricion: {this.Descripcion}");
            sb.AppendFormat($"Codigo: {codigo}");
            sb.AppendFormat($"Precio: {this.Precio}");
            sb.AppendFormat($"Stock: {this.Stock}");

            return sb.ToString();
        }


    }
}
