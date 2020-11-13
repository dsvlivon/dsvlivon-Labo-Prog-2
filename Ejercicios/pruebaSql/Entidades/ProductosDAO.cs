using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductosDAO
    {
        private SqlConnection sqlConnection;
        public string connectionString = "Server=.\\SQLEXPRESS;Database=ProductosDB;Trusted_Connection=True;";

        public ProductosDAO()
        {
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void InsertProducto(Producto producto)
        {
            try
            {
                string command =  "INSERT INTO Productos(nombre, precio, codigo)" + /*podria no estar lo del parentesis*/
                    $"VALUES(@nombre, @precio, @codigo)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }

            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void UpdateProducto(Producto producto)
        {
            try
            {
                              
                string command = "UPDATE Productos SET "+ 
                    "codigo = @codigo, nombre = @nombre, precio = @precio"+ "WHERE id = @id";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);
                sqlCommand.Parameters.AddWithValue("id", producto.Id);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }

            finally
            {
                if (sqlConnection != null &&
                    sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }
   
        public void DeleteProducto(Producto produtco)
        {
            try
            {
                string command = "DELETE FROM Productos " + "WHERE id = @id";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", produtco.Id);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(this.sqlConnection !=null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public List<Producto> ListarProductos()
        {
            //recordar q en connectionString estoy poniendo esa suerte de Ruta...
			//te evita el finally, es decir q se ocupa de cerrar el archivo, invoca el finally  d manera implictia
		//tambien se usa en archivos
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                List<Producto> productos = new List<Producto>();

                string command = "SELECT * FROM Productos";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while(reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    string descripcion = null;
                    if(reader["descripcion"]!= DBNull.Value)
                    {
                        descripcion = (string)reader["descripcion"];
                    }
                    float precio = (float)Convert.ToDouble(reader["precio"]);
                    Producto producto = new Producto(id, nombre, precio, codigo, descripcion);

                    productos.Add(producto);

                }
                return productos;
            }                    
        }

        public Producto ListarProductosPorId(int idBuscar)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                List<Producto> productos = new List<Producto>();
                string command = "SELECT * FROM Productos WHERE id = @id";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", idBuscar);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                Producto producto = null;
                if (reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    string descripcion = null;

                    if (reader["descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["descripcion"];
                    }

                    float precio = (float)Convert.ToDouble(reader["precio"]);

                    producto = new Producto(id,nombre, precio, codigo, descripcion);
                }


                return producto;
            }
        }
    }
}
