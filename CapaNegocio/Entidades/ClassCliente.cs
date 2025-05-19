using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Metodos;
using System.Data;

namespace CapaNegocio.Entidades
{
    public class ClassCliente
    {
        //Se crean las propiedades de la entidad Cliente
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Documento_Identidad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }

        //Se instancia la clase de metodos de la entidad Cliente
        CDCliente cdCliente = new CDCliente();
        //Se crea el método para listar los clientes
        public DataTable ListarClientes()
            {
                try
                {
                    //Se llama al método ListarClientes de la clase CDCliente
                    return cdCliente.ListarClientes();
                }
                catch (Exception ex)
                {
                    //Se imprime el mensaje de la excepción
                    string error = ex.Message;
                    Console.WriteLine(error);
                    return null;
                }
            }
      

    //Metodo para buscar cliente por numero de documento
    public DataTable BuscarCliente(string documento)
        {
            try
            {
                //Se llama al método BuscarCliente de la clase CDCliente
                return cdCliente.BuscarCliente(documento);
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
