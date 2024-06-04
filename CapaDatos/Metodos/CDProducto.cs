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
                command.CommandText = "SELECT P.ID_PRODUCTO, P.DESCRIPCION,M.ID_MARCA, M.NOMBRE_MARCA,C.ID_CATEGORIA, C.NOMBRE_CATEGORIA, P.PRECIO, P.ESTADO " +
                    "FROM PRODUCTO P " +
                    "INNER JOIN MARCA M " +
                    "ON P.ID_MARCA = M.ID_MARCA " +
                    "INNER JOIN CATEGORIA C " +
                    "ON P.ID_CATEGORIA = C.ID_CATEGORIA " +
                    "WHERE P.ESTADO = 1";
                //Se establece el tipo de comando
                command.CommandType = CommandType.Text;
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
        public bool InsertarProducto(int id_categoria, int id_marca, string descripcion, decimal precio)
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
        public bool ModificarProducto(int id_producto, int id_categoria, int id_marca, string descripcion, decimal precio)
        {
            try
            {
                //Se crea el comando SQL para modificar un producto
                SqlCommand command = new SqlCommand();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_MODIFICAR_PRODUCTO";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agregan los parámetros necesarios
                command.Parameters.AddWithValue("@ID_PRODUCTO", id_producto);
                command.Parameters.AddWithValue("@ID_CATEGORIA", id_categoria);
                command.Parameters.AddWithValue("@ID_MARCA", id_marca);
                command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                command.Parameters.AddWithValue("@PRECIO", precio);
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
    }
}
