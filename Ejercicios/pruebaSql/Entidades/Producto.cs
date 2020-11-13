using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string codigo;
        private string descripcion;
        private float precio;

        //(nombre, precio, codigo, descripcion) 
        public Producto(int id, string nombre, float precio, string codigo, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.Precio = precio;
        }

        public int Id { get => id; set => id = value; }
       
        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
