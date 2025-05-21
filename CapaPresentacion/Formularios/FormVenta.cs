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

        //Crear variable para ID_Cliente e ID_Producto
        public int ID_Cliente { get; set; }
        public int ID_Producto { get; set; }

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
                    //Guardar el ID_Cliente
                    ID_Cliente = Convert.ToInt32(dt.Rows[0]["ID_CLIENTE"].ToString());
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
                    //Guardar el ID_Producto
                    ID_Producto = Convert.ToInt32(dt.Rows[0]["ID_PRODUCTO"].ToString());
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validar que los campos no esten vacios
            if (txtNombreCliente.Text == "" || txtNombreProducto.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validar que la cantidad no sea mayor al stock
            if (Convert.ToInt32(txtCantidad.Text) > Convert.ToInt32(txtStock.Text))
            {
                MessageBox.Show("La cantidad no puede ser mayor al disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Clear();
                txtCantidad.Focus();
                return;
            }
           
            //Actualizar el stock en la base de datos
            ClassProducto objProducto = new ClassProducto();
            objProducto.ID_Producto = ID_Producto;
            int cantidad = 0;
            decimal precio = 0;
            decimal descuento = 0;
            decimal total = 0;
            objProducto.ActualizarStock(objProducto.ID_Producto,Convert.ToInt32(txtCantidad.Text));
    
           
                //Validar que el ID_Producto exista en el datagridview
                bool productoExiste = false;
                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    if (row.Cells["Codigo"].Value != null && Convert.ToInt32(row.Cells["Codigo"].Value) == ID_Producto)
                    {
                        //Actualizar la cantidad
                        cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value) + Convert.ToInt32(txtCantidad.Text);
                        row.Cells["Cantidad"].Value = cantidad;
                        //Actualizar el total
                        precio = Convert.ToDecimal(txtPrecio.Text);
                        descuento = txtDescuentoProducto.Text != "" ? ((precio * cantidad) * (Convert.ToDecimal(txtDescuentoProducto.Text) / 100)) : 0;
                        total = (precio * cantidad) - (descuento);
                    //Actualizar el monto total de descuento    
                    row.Cells["Descuento"].Value = descuento.ToString("N2");
                    //Actualizar el total
                    row.Cells["Total"].Value = total.ToString("N2");
                        productoExiste = true;
                        break;
                    }
                }
                if (!productoExiste)
                {
                    //calcular el total
                    precio = Convert.ToDecimal(txtPrecio.Text);
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                //calcular el monto total de descuento
                descuento = txtDescuentoProducto.Text != "" ? ((precio * cantidad) * (Convert.ToDecimal(txtDescuentoProducto.Text)/100)) : 0;

                //descuento = txtDescuentoProducto.Text != "" ? Convert.ToDecimal(txtDescuentoProducto.Text) : 0;
                total = (precio * cantidad) - (descuento);

                    //Agregar el producto al datagridview
                    dgvDetalleVenta.Rows.Add(ID_Producto, txtNombreProducto.Text, txtPrecio.Text, txtCantidad.Text, descuento.ToString("N2"), total.ToString("N2"));
                }
            //Limpiar los campos
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCantidad.Clear();
            txtDescuentoProducto.Clear();
            ID_Producto = 0;
            //Establecer el foco en txtCodigoProducto
            txtCodigoProducto.Focus();
            //Calcular el total de la venta
            calcularTotal();
        }

        private void calcularTotal() {
            //Calcular el Subtotal de la venta en txtSubtotal
            decimal subtotal = 0;
            decimal iva = 0;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            //Calcular el IVA
            iva = subtotal * 0.15m;
            //Calcular el total
            total = subtotal + iva;
            //Mostrar el subtotal, iva y total en los textbox
            txtSubtotal.Text = subtotal.ToString("N2");
            txtIVA.Text = iva.ToString("N2");
            txtTotalVenta.Text = total.ToString("N2");
        }

        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            if(dgvDetalleVenta.CurrentRow != null)
            {
                //Mensaje de confirmacion
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                //Actualizar el stock en la base de datos
                ClassProducto objProducto = new ClassProducto();
                objProducto.ID_Producto = Convert.ToInt32(dgvDetalleVenta.CurrentRow.Cells["Codigo"].Value);
                //Actualizar el stock
                objProducto.RestaurarStock(objProducto.ID_Producto, Convert.ToInt32(dgvDetalleVenta.CurrentRow.Cells["Cantidad"].Value));
                //Eliminar la fila seleccionada
                dgvDetalleVenta.Rows.RemoveAt(dgvDetalleVenta.CurrentRow.Index);
                //Calcular el total de la venta
                calcularTotal();
                //Inicializar ID_Producto
                ID_Producto = 0;
                //Limpiar los campos
                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
                txtCantidad.Clear();
                txtDescuentoProducto.Clear();
                //Establecer el foco en txtCodigoProducto
                txtCodigoProducto.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleVenta_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvDetalleVenta.ClearSelection();
                dgvDetalleVenta.Rows[e.RowIndex].Selected = true;
                dgvDetalleVenta.CurrentCell = dgvDetalleVenta.Rows[e.RowIndex].Cells[0];
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            //Limpiar los campos de cliente
            txtDocumentoIdentidad.Clear();
            txtNombreCliente.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            //Limpiar los campos de producto
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCantidad.Clear();
            txtDescuentoProducto.Clear();
            ID_Producto = 0;
            //Establecer el foco en txtCodigoProducto
            txtCodigoProducto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Mostrar mensaje de confirmacion
             DialogResult result = MessageBox.Show("¿Está seguro de cancelar la venta?", "Cancelar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                   {
                        //Limpiar los campos de cliente
                        txtDocumentoIdentidad.Clear();
                        txtNombreCliente.Clear();
                        txtDireccion.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
                        //Limpiar los campos de producto
                        txtCodigoProducto.Clear();
                        txtNombreProducto.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                        txtCantidad.Clear();
                        txtDescuentoProducto.Clear();
                        //Si el datagridview tiene filas, restaurar el stock de los productos
                        if (dgvDetalleVenta.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                            {
                                //Actualizar el stock en la base de datos
                                ClassProducto objProducto = new ClassProducto();
                                objProducto.ID_Producto = Convert.ToInt32(row.Cells["Codigo"].Value);
                                //Actualizar el stock
                                objProducto.RestaurarStock(objProducto.ID_Producto, Convert.ToInt32(row.Cells["Cantidad"].Value));
                            }
                        }
                        //Actualizar el datagridview
                        dgvDetalleVenta.Rows.Clear();
                        //Limpiar el ID_Producto
                        ID_Producto = 0;
                        //Limpiar el ID_Cliente
                        ID_Cliente = 0;
                        //Limpiar los campos de descuento
                        txtDescuentoVenta.Clear();
                        //Limpiar el total de la venta
                        txtSubtotal.Text = "0.00";
                        txtIVA.Text = "0.00";
                        txtTotalVenta.Text = "0.00";
                   }
            }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //Validar que los campos no esten vacios
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validar que la grilla no este vacia
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Mostrar mensaje de confirmacion
            DialogResult result = MessageBox.Show("¿Está seguro de realizar la venta?", "Realizar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Instanciar la clase de venta
                ClassVenta objVenta = new ClassVenta();
                //Llenar los campos de la venta
                objVenta.Fecha_Venta = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                objVenta.Descuento = txtDescuentoVenta.Text != "" ? Convert.ToDecimal(txtDescuentoVenta.Text) : 0;
                objVenta.IVA = Convert.ToDecimal(txtIVA.Text);
                objVenta.Subtotal = Convert.ToDecimal(txtSubtotal.Text);
                objVenta.Total = Convert.ToDecimal(txtTotalVenta.Text);
                objVenta.ID_Cliente = ID_Cliente;
                objVenta.ID_Usuario = 1; //ID de usuario logueado, se debe implementar la logica para obtener el ID del usuario logueado
                
                //Crear datatable para los detalles de la venta
                DataTable dtDetalles = new DataTable();
                dtDetalles.Columns.Add("ID_Producto", typeof(int));
                dtDetalles.Columns.Add("Precio", typeof(decimal));
                dtDetalles.Columns.Add("Cantidad", typeof(int));
                dtDetalles.Columns.Add("Descuento", typeof(decimal));
                dtDetalles.Columns.Add("Total", typeof(decimal));
              
                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    if (row.Cells["Codigo"].Value != null)
                    {
                        dtDetalles.Rows.Add(
                            Convert.ToInt32(row.Cells["Codigo"].Value),
                            Convert.ToDecimal(row.Cells["Precio"].Value),
                            Convert.ToInt32(row.Cells["Cantidad"].Value),
                            Convert.ToDecimal(row.Cells["Descuento"].Value),
                            Convert.ToDecimal(row.Cells["Total"].Value));
                    }
                }
                //Asignar el datatable a la propiedad dt de la clase venta
                objVenta.dt = dtDetalles;
                //Llamar al metodo para insertar la venta
                if (objVenta.InsertarVenta(objVenta))
                {
                    //Mostrar mensaje de exito
                    MessageBox.Show("Venta realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar los campos de cliente
                    txtDocumentoIdentidad.Clear();
                    txtNombreCliente.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    //Limpiar los campos de producto
                    txtCodigoProducto.Clear();
                    txtNombreProducto.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();
                    txtCantidad.Clear();
                    txtDescuentoProducto.Clear();
                    //Limpiar el datagridview
                    dgvDetalleVenta.Rows.Clear();
                    //Limpiar el total de la venta
                    txtSubtotal.Text = "0.00";
                    txtIVA.Text = "0.00";
                    txtTotalVenta.Text = "0.00";
                }
                else
                {
                    MessageBox.Show("Error al realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana
            this.Close();
        }
    }
}
