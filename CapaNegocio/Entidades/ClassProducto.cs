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
        public int Stock { get; set; }
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
        public bool InsertarProducto(ClassProducto obj)
        {
            try
            {
                                //Se llama al método InsertarProducto de la clase CDProducto
                return cdProducto.InsertarProducto(obj.ID_Categoria, obj.ID_Marca, obj.Descripcion, obj.Precio, obj.Stock);
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
        public bool ModificarProducto(ClassProducto obj)
        {
            try
            {
                //Se llama al método ModificarProducto de la clase CDProducto
                return cdProducto.ModificarProducto(obj.ID_Producto, obj.ID_Categoria, obj.ID_Marca,obj.Descripcion,obj.Precio,obj.Stock);
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
        public bool EliminarProducto(ClassProducto obj)
        {
            try
            {
                //Se llama al método EliminarProducto de la clase CDProducto
                return cdProducto.EliminarProducto(obj.ID_Producto);
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Crear Metodo para Buscar Productos por ID con Procedimientos Almacenados
        public DataTable BuscarProducto(int id_producto)
        {
            try
            {
                //Se llama al método BuscarProducto de la clase CDProducto
                return cdProducto.BuscarProducto(id_producto);
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        //Metodo para actualizar el stock de un producto
        public bool ActualizarStock(int id_producto, int cantidad)
        {
            try
            {
                //Se llama al método ActualizarStock de la clase CDProducto
                return cdProducto.ActualizarStock(id_producto, cantidad);
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Metodo para restaurar el stock de un producto
        public bool RestaurarStock(int id_producto, int cantidad)
        {
            try
            {
                //Se llama al método RestaurarStock de la clase CDProducto
                return cdProducto.RestaurarStock(id_producto, cantidad);
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
