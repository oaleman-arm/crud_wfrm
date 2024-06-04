using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CapaNegocio.Entidades;

namespace CapaPresentacion.Formularios
{
    public partial class FormProductos : Form
    {

        //Se instancia la clase de la entidad Producto
        ClassProducto producto = new ClassProducto();
        //Crear Variable para almacenar los IDs
        int ID_Producto = 0;

        //validacion para que el formulario no se repita
        //se genera una funcion para verificar la intancia de ese formulario, si esta abierto
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

        private void FormProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            LlenarComboMarcas();
            LlenarComboCategorias();
            cancelar();
        }
        public FormProductos()
        {
            InitializeComponent();
        }

        //Método para mostrar un producto
        private void MostrarProductos()
        {
            dgvProducto.DataSource = null;
            //Se instancia la clase de la entidad Producto
            ClassProducto obj = new ClassProducto();
            //Se asigna al DataGridView el resultado del método ListarProductos
            dgvProducto.DataSource = obj.ListarProductos();
            //Se ocultan las columnas con ID
            dgvProducto.Columns["ID_PRODUCTO"].Visible = false;
            dgvProducto.Columns["ID_MARCA"].Visible = false;
            dgvProducto.Columns["ID_CATEGORIA"].Visible = false;

            //Reemplazar el HeaderText de las columnas
            dgvProducto.Columns["DESCRIPCION"].HeaderText = "Descripción";
            dgvProducto.Columns["NOMBRE_MARCA"].HeaderText = "Marca";
            dgvProducto.Columns["NOMBRE_CATEGORIA"].HeaderText = "Categoría";
            dgvProducto.Columns["PRECIO"].HeaderText = "Precio";
            dgvProducto.Columns["ESTADO"].HeaderText = "Estado";

            //Ajustar el tamaño de las columnas
            dgvProducto.Columns["DESCRIPCION"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducto.Columns["NOMBRE_MARCA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducto.Columns["NOMBRE_CATEGORIA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducto.Columns["PRECIO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducto.Columns["ESTADO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Bloquear la edición de las celdas
            dgvProducto.ReadOnly = true;
        }

        //Crear Metodo para Llenar el ComboBox de Categorias
        private void LlenarComboCategorias()
        {
            //Se instancia la clase de la entidad Categoria
            ClassCategoria obj = new ClassCategoria();
            //Crear ComboBox de Tipo DropDownList
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            //Se asigna al ComboBox el resultado del método ListarCategorias
            cmbCategoria.DataSource = obj.ListarCategorias();
            //Se asigna el valor de la columna ID_CATEGORIA al ValueMember
            cmbCategoria.ValueMember = "ID_CATEGORIA";
            //Se asigna el valor de la columna NOMBRE_CATEGORIA al DisplayMember
            cmbCategoria.DisplayMember = "NOMBRE_CATEGORIA";
            //Se selecciona un elemento por defecto
            cmbCategoria.SelectedIndex = -1;

        }

        //Crear Metodo para Llenar el ComboBox de Marcas
        private void LlenarComboMarcas()
        {
            //Se instancia la clase de la entidad Marca
            ClassMarca obj = new ClassMarca();
            //Crear ComboBox de Tipo DropDownList
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            //Se asigna al ComboBox el resultado del método ListarMarcas
            cmbMarca.DataSource = obj.ListarMarcas();
            //Se asigna el valor de la columna ID_MARCA al ValueMember
            cmbMarca.ValueMember = "ID_MARCA";
            //Se asigna el valor de la columna NOMBRE_MARCA al DisplayMember
            cmbMarca.DisplayMember = "NOMBRE_MARCA";
            //Se selecciona un elemento por defecto
            cmbMarca.SelectedIndex = -1;
        }

        private void cancelar()
        {
            //Limpiar e inhabilitar los Textos
            txtDescripcion.Text = "";
            txtDescripcion.Enabled = false;
            txtPrecio.Text = "";
            txtPrecio.Enabled = false;
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Enabled = false;
            cmbMarca.SelectedIndex = -1;
            cmbMarca.Enabled = false;
            //Reiniciar IDs
            ID_Producto = 0;
            //Habilitar Botones
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            txtDescripcion.Enabled = true;
            txtDescripcion.Text = "";
            txtPrecio.Enabled = true;
            txtPrecio.Text = "";
            cmbCategoria.Enabled = true;
            cmbMarca.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            ID_Producto = 0;
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Producto = Convert.ToInt32(dgvProducto.CurrentRow.Cells["ID_PRODUCTO"].Value);
            cmbCategoria.SelectedValue = Convert.ToInt32(dgvProducto.CurrentRow.Cells["ID_CATEGORIA"].Value);
            cmbMarca.SelectedValue = Convert.ToInt32(dgvProducto.CurrentRow.Cells["ID_MARCA"].Value);
            txtDescripcion.Text = dgvProducto.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            txtPrecio.Text = dgvProducto.CurrentRow.Cells["PRECIO"].Value.ToString();
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbMarca.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
            MostrarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ID_Producto > 0)
            {
                   //Se llama al método ModificarProducto de la clase ClassProducto
                if (producto.ModificarProducto(ID_Producto, Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue), txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text)))
                {
                    MessageBox.Show("Producto Modificado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Modificar el Producto");
                }
            }
            else
            {
                //Se llama al método InsertarProducto de la clase ClassProducto
                if (producto.InsertarProducto(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue), txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text)))
                {
                    MessageBox.Show("Producto Guardado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Guardar el Producto");
                }
            }
            MostrarProductos();
            cancelar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Producto?", "Eliminar Producto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Se llama al método EliminarProducto de la clase ClassProducto
                if (producto.EliminarProducto(ID_Producto))
                {
                    MessageBox.Show("Producto Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Producto");
                }
                MostrarProductos();
                cancelar();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que solo se ingresen números y el punto
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
