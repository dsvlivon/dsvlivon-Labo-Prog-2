﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace pruebaSql
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int id = 5;

                Producto prod1 = new Producto(6, "12sasd", 56.9f, "Sprite", null);
                Producto prod2 = new Producto(5, "123abc", 55.4f, "Manaos", null);
                ProductosDAO productosDAO = new ProductosDAO();

                //productosDAO.InsertarProducto(prod1);
                //productosDAO.BorrarProducto(prod1);
                //productosDAO.ModificarProducto(prod2);

                List<Producto> productos = productosDAO.ListarProductos();
                Producto productoPorID = productosDAO.ListarProductosPorId(id);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("PRODUCTOS TOTALES");

                foreach (Producto producto in productos)
                {
                    sb.AppendLine($"Producto id {producto.Id} de nombre {producto.Nombre}");
                }

                sb.AppendLine("<-------------------------------------------------------->");
                sb.AppendLine($"PRODUCTOS CON ID {id}");

                if (productoPorID != null)
                {
                    sb.AppendLine($"Producto id {productoPorID.Id} de nombre {productoPorID.Nombre}");
                }

                Console.WriteLine(sb.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
