using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class LineaBlanca : Producto
    {
        private bool aplicaDescuento;

        /// <summary>
        ///  El atributo Descunto calcula el valor de retorno mas un 10%
        /// </summary>
        public int Descuento
        {
            get
            {
                if (aplicaDescuento is true)
                {
                    return (int)(ValorDeVenta * 10 / 100);
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        ///  sobrecarga del atributo Porcentaje Ganancia
        /// </summary>
        public override int PorcentajeGanancia
        {
            get { return PorcentajeGanancia * 50 / 100; }
        }

        /// <summary>
        /// sobrecarga del metodo PorcentajeImpuestointerno
        /// </summary>
        public override int PorcentajeImpuestoInterno
        {
            get
            {
                return PorcentajeImpuestoInterno * 10 / 100;
            }

        }
        public override float ValorDeVenta
        {
            get
            {
                return ValorDeVenta - Descuento;
            }
        }
        public LineaBlanca(string nombre, int valorDeCompra, Origen origen) : base(nombre, valorDeCompra, Origen.Nacional)
        {

        }
        public LineaBlanca(string nombre, int valorDeCompra, Origen origen, bool aplicaDescuento)
            : this(nombre, valorDeCompra, origen)
        {
            this.aplicaDescuento = aplicaDescuento;
        }
        public override string Etiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Etiqueta());
            if(aplicaDescuento==true)
            {
                sb.AppendFormat("Aplica descuento: SI");
            }
            else
            {
                sb.AppendFormat("Aplica descuento:NO");
            }
            return sb.ToString();
        }
    }
}
