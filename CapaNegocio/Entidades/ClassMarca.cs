using CapaDatos.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio.Entidades
{
    public class ClassMarca
    {
        
        //Se crean las propiedades de la entidad Marca
        public int ID_Marca { get; set; }
        public string Nombre_Marca { get; set; }
        public bool Estado { get; set; }

        //Se instancia la clase de metodos de la entidad Marca
        CDMarca cdMarca = new CDMarca();

        //Se crea el método para listar las marcas
        public DataTable ListarMarcas()
        {
            try
            {
                //Se llama al método ListarMarcas de la clase CDMarca
                return cdMarca.ListarMarcas();
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
