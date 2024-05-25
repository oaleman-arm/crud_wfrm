using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio.Entidades
{
    public class ClassUsuario
    {
        CDUsuario datosUsuario = new CDUsuario();
        public bool Login(string Usuar, string pass)
        {
            return datosUsuario.Login(Usuar, pass);

        }

    }
}
