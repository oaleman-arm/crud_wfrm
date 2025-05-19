using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos.Metodos
{
    public class CDVenta
    {
        //Se instancia la clase de conexión 
        ClassConnection connection = new ClassConnection();

        //Metodo para inserta venta y detalle de venta
        public bool InsertarVenta( string fecha, decimal descuento, decimal iva, decimal subtotal, decimal total, int id_cliente, int id_usuario,  DataTable dt)
        {
            try
            {

                //convertir string a Fecha
                DateTime fecha_venta = Convert.ToDateTime(fecha);
                //Se crea el comando SQL para insertar una venta
                SqlCommand command = new SqlCommand();
                //Se abre la conexión a la base de datos
                command.Connection = connection.OpenConnection();
                //Se crea la consulta SQL
                command.CommandText = "SP_INSERTAR_VENTA";
                //Se establece el tipo de comando
                command.CommandType = CommandType.StoredProcedure;
                //Se agregan los parámetros al comando
                command.Parameters.AddWithValue("@FECHA_VENTA", fecha_venta);
                command.Parameters.AddWithValue("@DESCUENTO", descuento);
                command.Parameters.AddWithValue("@IVA", iva);
                command.Parameters.AddWithValue("@SUBTOTAL", subtotal);
                command.Parameters.AddWithValue("@TOTAL", total);
                command.Parameters.AddWithValue("@ID_CLIENTE", id_cliente);
                command.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                //Se ejecuta el comando y obtiene el ID de la venta insertada
                int id_venta = Convert.ToInt32(command.ExecuteScalar());
                //Se inserta los detalles de la venta
                foreach (DataRow row in dt.Rows)
                {
                    //Calcular total de cada detalle de venta con descuento
                    decimal total_detalle = Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"]) - Convert.ToDecimal(row["descuento"]);
                    //Se crea el comando SQL para insertar un detalle de venta
                    SqlCommand detailCommand = new SqlCommand();
                    detailCommand.Connection = connection.OpenConnection();
                    detailCommand.CommandText = "SP_INSERTAR_DETALLE_VENTA";
                    detailCommand.CommandType = CommandType.StoredProcedure;
                    detailCommand.Parameters.AddWithValue("@ID_VENTA", id_venta);
                    detailCommand.Parameters.AddWithValue("@ID_PRODUCTO", row["id_producto"]);
                    detailCommand.Parameters.AddWithValue("@CANTIDAD", row["cantidad"]);
                    detailCommand.Parameters.AddWithValue("@PRECIO", row["precio"]);
                    detailCommand.Parameters.AddWithValue("@DESCUENTO", row["descuento"]);
                    detailCommand.Parameters.AddWithValue("@TOTAL", total_detalle);
                    detailCommand.ExecuteNonQuery();
                    connection.CloseConnection();
                }
                connection.CloseConnection();
                return true;
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
