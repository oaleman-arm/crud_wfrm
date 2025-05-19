using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos.Metodos;


namespace CapaNegocio.Entidades
{
    public class ClassVenta
    {
        //Se crean las propiedades de la entidad Venta
        public int ID_Venta { get; set; }
        public string Fecha_Venta { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Usuario { get; set; }
        public DataTable dt { get; set; }

        //Se instancia la clase de metodos de la entidad Venta
        CDVenta cdVenta = new CDVenta();
        //Se crea el método para insertar una venta y su detalle,se reciben los parámetros como Objeto de ClassVenta
        public bool InsertarVenta(ClassVenta obj)
        {
            try
            {
                //Se llama al método InsertarVenta de la clase CDVenta
                return cdVenta.InsertarVenta(obj.Fecha_Venta, obj.Descuento, obj.IVA, obj.Subtotal, obj.Total, obj.ID_Cliente, obj.ID_Usuario, obj.dt);
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
