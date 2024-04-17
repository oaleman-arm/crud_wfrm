using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaDatos.Metodos;

namespace CapaNegocio.Entidades
{
    //Se crea la clase de la entidad Categoría
    public class ClassCategoria
    {
        //Se crean las propiedades de la entidad
        public int ID_Categoria { get; set; }
        public string Nombre_Categoria { get; set; }
        public bool Estado { get; set; }

        //Se instancia la clase de métodos de la entidad Categoría
        CDCategoria cdCategoria = new CDCategoria();

        //Se crea el método para listar las categorías
        public DataTable ListarCategorias()
        {
            try
            {
                //Se llama al método ListarCategorias de la clase CDCategoria
                return cdCategoria.ListarCategorias();
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        //Crear Metodo para Insertar Categorias con Procedimientos Almacenados
        public bool InsertarCategoria(string nombre)
        {
            try
            {
                //Se llama al método InsertarCategoria de la clase CDCategoria
                return cdCategoria.InsertarCategoria(nombre);
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Crear Metodo para Modificar Categorias con Procedimientos Almacenados
        public bool ModificarCategoria(int id, string nombre)
        {
            try
            {
                //Se llama al método ModificarCategoria de la clase CDCategoria
                return cdCategoria.ModificarCategoria(id, nombre);
            }
            catch (Exception ex)
            {
                //Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        //Crear Metodo para Eliminar Categorias con Procedimientos Almacenados
        public bool EliminarCategoria(int id)
        {
            try
            {
                //Se llama al método EliminarCategoria de la clase CDCategoria
                return cdCategoria.EliminarCategoria(id);
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
