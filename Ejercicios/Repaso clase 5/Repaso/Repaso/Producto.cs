using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string codigo, string marca, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string auxCodigo = p.codigoDeBarra;
            string auxMarca = p.GetMarca();
            float auxPrecio = p.GetPrecio();

            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(auxCodigo);
            retorno.AppendFormat(auxMarca);
            retorno.AppendFormat($"{auxPrecio}");

            return retorno.ToString();          
        }

        //Explícito.Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
        public static explicit operator string(Producto p)
        {           
            return p.codigoDeBarra;
        }

        //Igualdad (Producto, Producto). 
        //Retornará true, si las marcas y códigos de barras son iguales, false, caso contrario.
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.marca== p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra)
            {
                return true;
            }
            return false;
        }
        //Igualdad(Producto, string). Retornará true, si la marca del producto coincide 
        //con la cadena pasada por parámetro, false, caso contrario.
        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            if (p.marca != marca)
            {
                return true;
            }
            return false;
        }
    }
}
