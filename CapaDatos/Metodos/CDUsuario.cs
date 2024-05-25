using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;

namespace CapaDatos
{

// Esta clase hereda de la clase conexion
    public class CDUsuario:ClassConnection
    {
        ClassConnection connection = new ClassConnection();
        public bool Login(string Usuar, string pass)
        {
            try
            {
                var flag = false;
                SqlCommand command = new SqlCommand();
                command.Connection = connection.OpenConnection();
                command.CommandText = "select * from USUARIO where NombreUsuario=@Usuar and Password=@pass";
                command.Parameters.AddWithValue("@Usuar", Usuar);
                command.Parameters.AddWithValue("@pass", pass);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                flag = reader.HasRows;
                connection.CloseConnection();

                return flag;
               
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
    
        }
    }
}
