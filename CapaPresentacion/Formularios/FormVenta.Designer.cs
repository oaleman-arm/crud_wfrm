namespace CapaPresentacion.Formularios
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupCliente = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.groupProducto = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.groupDetalleVenta = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescuentoVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescuentoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupCliente.SuspendLayout();
            this.groupProducto.SuspendLayout();
            this.groupDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCliente
            // 
            this.groupCliente.Controls.Add(this.lblCorreo);
            this.groupCliente.Controls.Add(this.txtCorreo);
            this.groupCliente.Controls.Add(this.lblTelefono);
            this.groupCliente.Controls.Add(this.txtTelefono);
            this.groupCliente.Controls.Add(this.txtDireccion);
            this.groupCliente.Controls.Add(this.label1);
            this.groupCliente.Controls.Add(this.btnBuscarCliente);
            this.groupCliente.Controls.Add(this.lblCedula);
            this.groupCliente.Controls.Add(this.txtDocumentoIdentidad);
            this.groupCliente.Controls.Add(this.lblNombreCliente);
            this.groupCliente.Controls.Add(this.txtNombreCliente);
            this.groupCliente.Location = new System.Drawing.Point(12, 12);
            this.groupCliente.Name = "groupCliente";
            this.groupCliente.Size = new System.Drawing.Size(740, 175);
            this.groupCliente.TabIndex = 0;
            this.groupCliente.TabStop = false;
            this.groupCliente.Text = "Cliente";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(316, 119);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 16);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(319, 138);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(231, 22);
            this.txtCorreo.TabIndex = 18;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(53, 119);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(56, 138);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(231, 22);
            this.txtTelefono.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(56, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(610, 22);
            this.txtDireccion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Direccion";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(222, 46);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(65, 30);
            this.btnBuscarCliente.TabIndex = 12;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(53, 31);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(135, 16);
            this.lblCedula.TabIndex = 11;
            this.lblCedula.Text = "Documento Identidad";
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(56, 50);
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(160, 22);
            this.txtDocumentoIdentidad.TabIndex = 10;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(316, 31);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(56, 16);
            this.lblNombreCliente.TabIndex = 9;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCliente.Location = new System.Drawing.Point(316, 50);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(350, 22);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // groupProducto
            // 
            this.groupProducto.Controls.Add(this.label6);
            this.groupProducto.Controls.Add(this.txtDescuentoProducto);
            this.groupProducto.Controls.Add(this.btnAgregar);
            this.groupProducto.Controls.Add(this.lblNombreProducto);
            this.groupProducto.Controls.Add(this.label2);
            this.groupProducto.Controls.Add(this.txtNombreProducto);
            this.groupProducto.Controls.Add(this.txtCantidad);
            this.groupProducto.Controls.Add(this.lblStock);
            this.groupProducto.Controls.Add(this.txtStock);
            this.groupProducto.Controls.Add(this.lblPrecio);
            this.groupProducto.Controls.Add(this.txtPrecio);
            this.groupProducto.Controls.Add(this.btnBuscarProducto);
            this.groupProducto.Controls.Add(this.lblProducto);
            this.groupProducto.Controls.Add(this.txtCodigoProducto);
            this.groupProducto.Location = new System.Drawing.Point(12, 193);
            this.groupProducto.Name = "groupProducto";
            this.groupProducto.Size = new System.Drawing.Size(740, 131);
            this.groupProducto.TabIndex = 1;
            this.groupProducto.TabStop = false;
            this.groupProducto.Text = "Producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(524, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 30);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(310, 18);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(56, 16);
            this.lblNombreProducto.TabIndex = 21;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cantidad";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreProducto.Location = new System.Drawing.Point(310, 37);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(350, 22);
            this.txtNombreProducto.TabIndex = 20;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(289, 89);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(169, 70);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(72, 16);
            this.lblStock.TabIndex = 21;
            this.lblStock.Text = "Disponible";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(172, 89);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 20;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(53, 70);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(56, 89);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 18;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(222, 33);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(65, 30);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(53, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(51, 16);
            this.lblProducto.TabIndex = 14;
            this.lblProducto.Text = "Codigo";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(56, 37);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(160, 22);
            this.txtCodigoProducto.TabIndex = 13;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // groupDetalleVenta
            // 
            this.groupDetalleVenta.Controls.Add(this.label7);
            this.groupDetalleVenta.Controls.Add(this.txtTotalVenta);
            this.groupDetalleVenta.Controls.Add(this.label3);
            this.groupDetalleVenta.Controls.Add(this.txtDescuentoVenta);
            this.groupDetalleVenta.Controls.Add(this.label4);
            this.groupDetalleVenta.Controls.Add(this.txtIVA);
            this.groupDetalleVenta.Controls.Add(this.label5);
            this.groupDetalleVenta.Controls.Add(this.txtSubtotal);
            this.groupDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.groupDetalleVenta.Location = new System.Drawing.Point(12, 333);
            this.groupDetalleVenta.Name = "groupDetalleVenta";
            this.groupDetalleVenta.Size = new System.Drawing.Size(739, 279);
            this.groupDetalleVenta.TabIndex = 2;
            this.groupDetalleVenta.TabStop = false;
            this.groupDetalleVenta.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descuento %";
            // 
            // txtDescuentoVenta
            // 
            this.txtDescuentoVenta.Location = new System.Drawing.Point(166, 242);
            this.txtDescuentoVenta.Name = "txtDescuentoVenta";
            this.txtDescuentoVenta.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoVenta.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "IVA  15%";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(275, 242);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(100, 22);
            this.txtIVA.TabIndex = 26;
            this.txtIVA.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(10, 242);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(150, 22);
            this.txtSubtotal.TabIndex = 24;
            this.txtSubtotal.Text = "0.00";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(10, 21);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(717, 199);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Descuento %";
            // 
            // txtDescuentoProducto
            // 
            this.txtDescuentoProducto.Location = new System.Drawing.Point(404, 89);
            this.txtDescuentoProducto.Name = "txtDescuentoProducto";
            this.txtDescuentoProducto.Size = new System.Drawing.Size(100, 22);
            this.txtDescuentoProducto.TabIndex = 25;
            this.txtDescuentoProducto.TextChanged += new System.EventHandler(this.txtDescuentoProducto_TextChanged);
            this.txtDescuentoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuentoProducto_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total";
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(381, 242);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.ReadOnly = true;
            this.txtTotalVenta.Size = new System.Drawing.Size(150, 22);
            this.txtTotalVenta.TabIndex = 30;
            this.txtTotalVenta.Text = "0.00";
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(533, 619);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(100, 30);
            this.btnFacturar.TabIndex = 12;
            this.btnFacturar.Text = "Guardar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(639, 618);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.groupDetalleVenta);
            this.Controls.Add(this.groupProducto);
            this.Controls.Add(this.groupCliente);
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.groupCliente.ResumeLayout(false);
            this.groupCliente.PerformLayout();
            this.groupProducto.ResumeLayout(false);
            this.groupProducto.PerformLayout();
            this.groupDetalleVenta.ResumeLayout(false);
            this.groupDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtDocumentoIdentidad;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox groupProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupDetalleVenta;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescuentoVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescuentoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCancelar;
    }
}