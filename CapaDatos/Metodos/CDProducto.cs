using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Metodos
{
    public class CDProducto
    {
        //Se instancia la clase de conexión a la base de datos
        ClassConnection connection = new ClassConnection();

        //Se crea el método para listar los productos
        public DataTable ListarProductos()
        {
            try
            {
                //Se crea el comando SQL para listar los productos
                SqlCommand command = new SqlCommand();
                //Se crea el lector de datos
                SqlDataReader reader;
                //Se crea la tabla para almacenar los datos
                DataTable dt = new DataTable();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_MOSTRAR_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se ejecuta el comando y almacena los datos en el lector de datos
                reader = command.ExecuteReader();
                // Se carga los datos en la tabla con el lector de datos
                dt.Load(reader);
                //Se cierra la conexión a la base de datos
                connection.CloseConnection();

                return dt;
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }

        }

        //Crear Metodo para Insertar Productos con Procedimientos Almacenados
        public bool InsertarProducto(int id_categoria, int id_marca, string descripcion, decimal precio, int stock)
        {
            try
            {
                //Se crea el comando SQL para insertar un producto
                SqlCommand command = new SqlCommand();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_INSERTAR_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agregan los parámetros necesarios
                command.Parameters.AddWithValue("@ID_CATEGORIA", id_categoria);
                command.Parameters.AddWithValue("@ID_MARCA", id_marca);
                command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                command.Parameters.AddWithValue("@PRECIO", precio);
                command.Parameters.AddWithValue("@STOCK", stock);
                //Se ejecuta el comando
                command.ExecuteNonQuery();
                //Se cierra la conexión a la base de datos
                connection.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Crear Metodo para Modificar Productos con Procedimientos Almacenados
        public bool ModificarProducto(int id_producto, int id_categoria, int id_marca, string descripcion, decimal precio, int stock)
        {
            try
            {
                //Se crea el comando SQL para modificar un producto
                SqlCommand command = new SqlCommand();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_EDITAR_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agregan los parámetros necesarios
                command.Parameters.AddWithValue("@ID_PRODUCTO", id_producto);
                command.Parameters.AddWithValue("@ID_CATEGORIA", id_categoria);
                command.Parameters.AddWithValue("@ID_MARCA", id_marca);
                command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                command.Parameters.AddWithValue("@PRECIO", precio);
                command.Parameters.AddWithValue("@STOCK", stock);
                //Se ejecuta el comando
                command.ExecuteNonQuery();
                //Se cierra la conexión a la base de datos
                connection.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Crear Metodo para Dar de Baja Productos con Procedimientos Almacenados
        public bool EliminarProducto(int id_producto)
        {
            try
            {
                //Se crea el comando SQL para eliminar un producto
                SqlCommand command = new SqlCommand();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_ELIMINAR_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agregan los parámetros necesarios
                command.Parameters.AddWithValue("@ID_PRODUCTO", id_producto);
                //Se ejecuta el comando
                command.ExecuteNonQuery();
                //Se cierra la conexión a la base de datos
                connection.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Metodo para buscar producto por id
        public DataTable BuscarProducto(int codigo)
        {
            try
            {
                //Se crea el comando SQL para buscar un producto por su descripción
                SqlCommand command = new SqlCommand();
                //Se crea la tabla para almacenar los datos
                DataTable dt = new DataTable();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_BUSCAR_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agrega el parámetro al comando
                command.Parameters.AddWithValue("@CODIGO", codigo);
                //Se ejecuta el comando y almacena los datos en la tabla
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                //Se cierra la conexión a la base de datos
                connection.CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        //Metodo para actualizar stock de productos
        public bool ActualizarStock(int id_producto, int cantidad)
        {
            try
            {
                //Se crea el comando SQL para actualizar el stock de un producto
                SqlCommand command = new SqlCommand();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_ACTUALIZAR_STOCK_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agregan los parámetros necesarios
                command.Parameters.AddWithValue("@ID_PRODUCTO", id_producto);
                command.Parameters.AddWithValue("@CANTIDAD", cantidad);
                //Se ejecuta el comando
                command.ExecuteNonQuery();
                //Se cierra la conexión a la base de datos
                connection.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Metodo para restaurar stock producto
        public bool RestaurarStock(int id_producto, int cantidad)
        {
            try
            {
                //Se crea el comando SQL para restaurar el stock de un producto
                SqlCommand command = new SqlCommand();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_RESTAURAR_STOCK_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agregan los parámetros necesarios
                command.Parameters.AddWithValue("@ID_PRODUCTO", id_producto);
                command.Parameters.AddWithValue("@CANTIDAD", cantidad);
                //Se ejecuta el comando
                command.ExecuteNonQuery();
                //Se cierra la conexión a la base de datos
                connection.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

    }
}
