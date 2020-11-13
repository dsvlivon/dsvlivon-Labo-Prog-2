using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;

namespace Estantes
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;
        //int[,] array
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
            //El constructor de instancia privado será el único que inicializará el array
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
            //La sobrecarga pública del constructor inicializará la ubicación del estante, 
            //recibiendo como parámetro capacidad y ubicación. Reutilizar código.
        }

        //asi se declara un metodo de tipo "Clase-array"
        public Producto[] GetProductos()
        {
            return this.productos;
            //El método público GetProductos, retornará el array de productos.
        }
        
        
        public static string MostrarEstante()
        {
            //El método público de clase MostrarEstante, retornará una cadena con toda la información 
            //del estante, incluyendo el detalle de cada uno de sus productos.Reutilizar código.
            string auxCodigo;
            string auxMarca;
            StringBuilder retorno = new StringBuilder();

            foreach Producto in productos
            { 
                retorno.AppendFormat(aux1);
                retorno.AppendFormat(aux2);
            }
            return retorno.ToString();
        }
    }



    


}
