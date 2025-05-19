using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private static FormCategoria _instancia = null;
        public static FormCategoria ventana_unica()
        {
            if (_instancia == null)
            {
                _instancia = new FormCategoria();
                return _instancia;
            }
            return _instancia;
        }
    }
}
