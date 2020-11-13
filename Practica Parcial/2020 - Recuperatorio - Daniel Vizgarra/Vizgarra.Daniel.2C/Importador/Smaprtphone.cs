using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Smarthpone: Producto
    {

        public Smarthpone(string nombre, int valorDeCompra,Origen origen):base(nombre,valorDeCompra,origen)
        {

        }

        /// <summary>
        /// sobrecarga del atributo PorcentajeGanancia
        /// </summary>
        public override int PorcentajeGanancia
        {
            get { return PorcentajeGanancia * 60 / 100; }
        }

        /// <summary>
        /// sobrecarga del atributo PorcentajeImpuestoInterno
        /// </summary>
        public override int PorcentajeImpuestoInterno
        {
            get
            {
                return PorcentajeImpuestoInterno * 21 / 100;
            }

        }

        /// <summary>
        ///  sobrecarga del atributo PorcentajeImpuestoInterno
        /// </summary>
        public override float ValorDeVenta
        {
            get
            {
                return ValorDeVenta;
            }
        }
    }
}
