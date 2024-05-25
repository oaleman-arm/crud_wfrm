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
        //Crear Variable para almacenar el ID de la Categoría
        int ID_Categoria = 0;


        //validacion para que el formulario no se repita
        //se genera una funcion para verificar la intancia de ese formulario, si esta abierto
        //llamar la funcion si no esta abierto abrirlo
        private static frmCategoria _instancia=null;
        public static frmCategoria ventana_unica()
        {
            if (_instancia == null)
            {
                _instancia = new frmCategoria();
                return _instancia;
            }
            return _instancia;
        }

        public frmCategoria()
        {
            InitializeComponent();
            
        }

        //Se ejecuta el metodo para mostrar las categorias en el Load del formulario
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarCategorias();
            txtNombreCategoria.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        //Método para mostrar una categoría
        private void MostrarCategorias()
        {
            dgCategoria.DataSource = null;
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
           
            //Se bloquea la edición de las columnas
            dgCategoria.Columns["NOMBRE_CATEGORIA"].ReadOnly = true;
            dgCategoria.Columns["ESTADO"].ReadOnly = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            txtNombreCategoria.Enabled = true;
            txtNombreCategoria.Text = "";
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            ID_Categoria = 0;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if (ID_Categoria > 0)
            {
                //Se llama al método ModificarCategoria de la clase ClassCategoria
              if(categoria.ModificarCategoria(ID_Categoria, txtNombreCategoria.Text)){
                    MessageBox.Show("Categoría Modificada Correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Modificar la Categoría");
                }
            }
            else { 
                //Se llama al método InsertarCategoria de la clase ClassCategoria
                if (categoria.InsertarCategoria(txtNombreCategoria.Text))
                {
                    MessageBox.Show("Categoría Guardada Correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Guardar la Categoría");
                }
            }
            MostrarCategorias();
            txtNombreCategoria.Enabled = false;
            txtNombreCategoria.Text = "";
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Categoria = Convert.ToInt32(dgCategoria.CurrentRow.Cells["ID_CATEGORIA"].Value);
            txtNombreCategoria.Text = dgCategoria.CurrentRow.Cells["NOMBRE_CATEGORIA"].Value.ToString();
            txtNombreCategoria.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Categoria > 0)
            {
                //|Aparece un mensaje de confirmación para eliminar la categoría
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la categoría?", "Eliminar Categoría", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Se llama al método EliminarCategoria de la clase ClassCategoria
                    if (categoria.EliminarCategoria(ID_Categoria))
                    {
                        MessageBox.Show("Categoría Eliminada Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al Eliminar la Categoría");
                    }
                    MostrarCategorias();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            txtNombreCategoria.Enabled = false;
            txtNombreCategoria.Text = "";
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            MostrarCategorias();
        }

        private void pnlCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
