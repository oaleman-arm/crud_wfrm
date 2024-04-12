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

    }
}
