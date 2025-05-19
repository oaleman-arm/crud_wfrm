using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos.Metodos
{
    public class CDCliente
    {
        //Se instancia la clase de conexión
        ClassConnection connection = new ClassConnection();

        //Se crea el método para listar los clientes
        public DataTable ListarClientes()
        {
            try
            {
                //Se crea el comando SQL para listar los clientes
                SqlCommand command = new SqlCommand();
                //Se crea el lector de datos
                SqlDataReader reader;
                //Se crea la tabla para almacenar los datos
                DataTable dt = new DataTable();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_MOSTRAR_CLIENTES";
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

        //Metodo para buscar cliente por numero de documento
        public DataTable BuscarCliente(string documento)
        {
            try
            {
                //Se crea el comando SQL para buscar un cliente por su documento
                SqlCommand command = new SqlCommand();
                //Se crea la tabla para almacenar los datos
                DataTable dt = new DataTable();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_BUSCAR_CLIENTE";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agrega el parámetro al comando
                command.Parameters.AddWithValue("@IDENTIDAD", documento);
                //Se ejecuta el comando y almacena los datos en la tabla
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
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
    }
}
