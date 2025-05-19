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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            FormCategoria frm = FormCategoria.ventana_unica();
            if (frm.IsDisposed)
            {
                frm = new FormCategoria();
            }
            frm.MdiParent = this;
            frm.Show();
            //esta propiedad muestra el formulario  en primer plano
            frm.BringToFront();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos form =  FormProductos.ventana_unica();  
            if (form.IsDisposed)
            {
                form = new FormProductos();
            }
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tssUsuario.Text = "MSc.Yulieth N.Casanova";
           // tssUsuario.Text = "Usuario: " + Program.nombreUsuario;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenta form = FormVenta.ventana_unica();
            if (form.IsDisposed)
            {
                form = new FormVenta();
            }
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }
    }
}
