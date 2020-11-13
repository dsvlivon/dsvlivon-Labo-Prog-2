using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;


        public DateTime Fecha{ get;}

        private Venta()
        {
            porcentajeIva=21;
        }

        protected Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }
        private void Vender(int cantidad)
        {
            this.fecha = DateTime.Today;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
            this.producto.Stock -= cantidad;
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            return (precioUnidad * cantidad)*1.21;
        }

        public string ObtenerDescripcionBreve()
        {
            return $"{fecha}-{des}"+
        }

    }
}
