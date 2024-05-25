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
    public partial class FormProductos : Form
    {
        //llamar la funcion si no esta abierto abrirlo
        private static FormProductos _instancia = null;
        public static FormProductos ventana_unica()
        {
            if (_instancia == null)
            {
                _instancia = new FormProductos();
                return _instancia;
            }
            return _instancia;
        }
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Start();
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
        }
    }
}
