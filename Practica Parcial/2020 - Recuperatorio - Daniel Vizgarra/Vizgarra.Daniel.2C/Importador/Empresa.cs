using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Empresa
    {
        private int limiteProductos;
        private string nombre;
        private List<Producto> productos;

        private Empresa()
        {
            productos = new List<Producto>();
        }
        public Empresa(string nombre)
            : this(nombre, 3)
        {

        }
        public Empresa(string nombre, int limiteProductos)
            : this()
        {
            this.nombre = nombre;
            this.limiteProductos = limiteProductos;
        }
        /// <summary>
        ///  sobrecarga del metodo ToString() para que devuelva la informacion de cada producto de las lista
        ///  <summary>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format($"Productos de la empresa {nombre}"));

            foreach (Producto item in productos)
            {
                sb.AppendLine(string.Format($"{item.Etiqueta()}"));

            }
            return sb.ToString();
        }

        public static Empresa operator +(Empresa empresa, Producto producto)
        {
            if(producto !=null)
            {
                 empresa.productos.Add(producto);
            }
        }

    }
}
