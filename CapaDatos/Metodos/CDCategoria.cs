using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos.Metodos
{
    public class CDCategoria
    {
        //Se instancia la clase de conexión
        ClassConnection connection = new ClassConnection();

        //Se crea el método para listar las categorías
          public DataTable ListarCategorias()
        {
            try
            {
                //Se crea el comando SQL para listar las categorías
                SqlCommand command = new SqlCommand();
                //Se crea el lector de datos
                SqlDataReader reader;
                //Se crea la tabla para almacenar los datos
                DataTable dt = new DataTable();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SELECT * FROM CATEGORIA";
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
                //print the exception message
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
               
        }
        

    }
}
