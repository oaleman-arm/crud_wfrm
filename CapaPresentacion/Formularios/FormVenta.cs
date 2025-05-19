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

namespace CapaPresentacion.Formularios
{
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        //llamar la funcion si no esta abierto abrirlo
        private static FormVenta _instancia = null;
        public static FormVenta ventana_unica()
        {
            if (_instancia == null)
            {
                _instancia = new FormVenta();
                return _instancia;
            }
            return _instancia;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Instanciar Cliente
            ClassCliente objCliente = new ClassCliente();
            //Validar que el campo no este vacio
            if (txtDocumentoIdentidad.Text != "")
            {
                //Buscar cliente por documento
                DataTable dt = objCliente.BuscarCliente(txtDocumentoIdentidad.Text);
                //Validar que el cliente exista
                if (dt.Rows.Count > 0)
                {
                    //Llenar los campos con los datos del cliente
                    txtNombreCliente.Text = dt.Rows[0]["NOMBRE"].ToString();
                    txtDireccion.Text = dt.Rows[0]["DIRECCION"].ToString();
                    txtTelefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                    txtCorreo.Text = dt.Rows[0]["CORREO"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un documento de identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            //limpiar cajas de texto
            txtDocumentoIdentidad.Clear();
            txtNombreCliente.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCantidad.Clear();
            txtDescuentoProducto.Clear();
            txtIVA.Text = "0.00";
            txtSubtotal.Text = "0.00";
            txtTotalVenta.Text = "0.00";

            //Inicializar el datagridview
            dgvDetalleVenta.Columns.Add("Codigo", "Codigo");
            dgvDetalleVenta.Columns.Add("Nombre", "Nombre");
            dgvDetalleVenta.Columns.Add("Precio", "Precio");
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("Descuento", "Descuento");
            dgvDetalleVenta.Columns.Add("Total", "Total");
            //Vaciar el datagridview
            dgvDetalleVenta.Rows.Clear();

            txtDocumentoIdentidad.Focus();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Instanciar Producto
            ClassProducto objProducto = new ClassProducto();

            //Si el nombre del cliente es vacio no se puede buscar el producto
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Ingrese un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoProducto.Clear();
                txtDocumentoIdentidad.Focus();
                
                return;
            }
            //Validar que el campo no este vacio
            if (txtCodigoProducto.Text != "" )
            {
                int codigoProducto = Convert.ToInt32(txtCodigoProducto.Text);
                //Buscar producto por codigo
                DataTable dt = objProducto.BuscarProducto(codigoProducto);
                //Validar que el producto exista
                if (dt.Rows.Count > 0)
                {
                    //Llenar los campos con los datos del producto
                    txtNombreProducto.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                    txtPrecio.Text = dt.Rows[0]["PRECIO"].ToString();
                    txtStock.Text = dt.Rows[0]["STOCK"].ToString();

                    //limpiar campo txtCodigoProducto
                    txtCodigoProducto.Clear();
                    //establecer el foco en txtCantidad y con valor 1
                    txtCantidad.Clear();
                    txtCantidad.Focus();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un codigo de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que solo se ingresen numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que solo se ingresen numeros y que no sea mayor al stock
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescuentoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que solo se ingresen numeros y en rango de 0 a 100
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            //Validar que la cantidad no sea mayor al stock
            if (txtCantidad.Text != "" && txtStock.Text != "")
            {
                if (Convert.ToInt32(txtCantidad.Text) > Convert.ToInt32(txtStock.Text))
                {
                    MessageBox.Show("La cantidad no puede ser mayor al disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Clear();
                    txtCantidad.Focus();
                }
            }
        }

        private void txtDescuentoProducto_TextChanged(object sender, EventArgs e)
        {
            //Validar que el descuento no sea mayor a 100
            if (txtDescuentoProducto.Text != "")
            {
                if (Convert.ToDecimal(txtDescuentoProducto.Text) > 100)
                {
                    MessageBox.Show("El descuento no puede ser mayor a 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescuentoProducto.Clear();
                    txtDescuentoProducto.Focus();
                }
            }
        }
    }
}
