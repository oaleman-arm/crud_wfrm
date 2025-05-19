using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmPrincipal es el formulario principal de la aplicación
           //Application.Run(new frmCategoria());
           Application.Run(new Formularios.FrmPrincipal());
           //Application.Run(new LOGIN());
        }
    }
}
