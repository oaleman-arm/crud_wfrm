using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaDatos.Metodos;

namespace CapaNegocio.Entidades
{
    public class ClassProducto
    {
        //Se crean las propiedades de la entidad Producto
        public int ID_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Marca { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }
        
        //Se instancia la clase de métodos de la entidad Producto
        CDProducto cdProducto = new CDProducto();

        //Se crea el método para listar los productos
        public DataTable ListarProductos()
        {
            try
            {
                //Se llama al método ListarProductos de la clase CDProducto
                return cdProducto.ListarProductos();
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
                //Se llama al método InsertarProducto de la clase CDProducto
                return cdProducto.InsertarProducto(id_categoria, id_marca, descripcion, precio);
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
        public bool ModificarProducto(int id, int id_categoria, int id_marca, string descripcion, decimal precio)
        {
            try
            {
                //Se llama al método ModificarProducto de la clase CDProducto
                return cdProducto.ModificarProducto(id, id_categoria, id_marca, descripcion, precio);
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Crear Metodo para Eliminar Productos con Procedimientos Almacenados
        public bool EliminarProducto(int id)
        {
            try
            {
                //Se llama al método EliminarProducto de la clase CDProducto
                return cdProducto.EliminarProducto(id);
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
