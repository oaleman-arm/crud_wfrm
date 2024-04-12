using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ClassConnection
    {
        //Se crea la conexión a la base de datos Data Source = Nombre del servidor; Initial Catalog = Nombre de la base de datos; User ID = sa; Password = Contraseña
        private SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=BD_VENTA;User ID=sa; Password=@qu3R0nte*");

        //Se abre la conexión a la base de datos
        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        //Se cierra la conexión a la base de datos
        public SqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
