using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Entidades;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        //Se instancia la clase de la entidad Categoría
        ClassCategoria categoria = new ClassCategoria();


        public frmCategoria()
        {
            InitializeComponent();
        }

        //Se ejecuta el metodo para mostrar las categorias en el Load del formulario
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarCategorias();
        }

        //Método para mostrar una categoría
        private void MostrarCategorias()
        {
            //Se instancia la clase de la entidad Categoría
            ClassCategoria obj = new ClassCategoria();
            //Se asigna al DataGridView el resultado del método ListarCategorias
            dgCategoria.DataSource = obj.ListarCategorias();
            //Se oculta la columna ID_CATEGORIA
            dgCategoria.Columns["ID_CATEGORIA"].Visible = false;
            //Se asigna el nombre de las columnas
            dgCategoria.Columns["NOMBRE_CATEGORIA"].HeaderText = "Nombre Categoria";
            //Se ajusta el ancho de la columna NOMBRE_CATEGORIA
            dgCategoria.Columns["NOMBRE_CATEGORIA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Se asigna el nombre de las columnas
            dgCategoria.Columns["ESTADO"].HeaderText = "Estado";
            //Se ajusta el ancho de la columna ESTADO
            dgCategoria.Columns["ESTADO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            

            
        }
    }
}
