namespace CapaPresentacion
{
    partial class frmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlCategoria = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.dgc = new System.Windows.Forms.DataGridView();
            this.btnGuardarCat = new System.Windows.Forms.Button();
            this.btnNuevoCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.pnlCategoria.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCategoria.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgCategoria.Location = new System.Drawing.Point(21, 106);
            this.dgCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgCategoria.RowHeadersWidth = 51;
            this.dgCategoria.Size = new System.Drawing.Size(448, 185);
            this.dgCategoria.TabIndex = 0;
            this.dgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellContentClick);
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(27, 26);
            this.lblNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(56, 16);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(24, 67);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(445, 22);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Firebrick;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(501, 97);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 37);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(501, 142);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 37);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(501, 200);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 37);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(501, 245);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlCategoria
            // 
            this.pnlCategoria.Controls.Add(this.panel1);
            this.pnlCategoria.Controls.Add(this.btnCancelar);
            this.pnlCategoria.Controls.Add(this.dgCategoria);
            this.pnlCategoria.Controls.Add(this.btnEliminar);
            this.pnlCategoria.Controls.Add(this.lblNombreCategoria);
            this.pnlCategoria.Controls.Add(this.btnGuardar);
            this.pnlCategoria.Controls.Add(this.txtNombreCategoria);
            this.pnlCategoria.Controls.Add(this.btnNuevo);
            this.pnlCategoria.Location = new System.Drawing.Point(13, 25);
            this.pnlCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCategoria.Name = "pnlCategoria";
            this.pnlCategoria.Size = new System.Drawing.Size(1057, 460);
            this.pnlCategoria.TabIndex = 4;
            this.pnlCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCategoria_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelarCat);
            this.panel1.Controls.Add(this.btnEliminarCat);
            this.panel1.Controls.Add(this.btnNuevoCat);
            this.panel1.Controls.Add(this.btnGuardarCat);
            this.panel1.Controls.Add(this.dgc);
            this.panel1.Controls.Add(this.txtcategoria);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Location = new System.Drawing.Point(692, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 274);
            this.panel1.TabIndex = 4;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.IndianRed;
            this.lblnombre.Location = new System.Drawing.Point(21, 29);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(56, 16);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(104, 26);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(201, 22);
            this.txtcategoria.TabIndex = 6;
            // 
            // dgc
            // 
            this.dgc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc.Location = new System.Drawing.Point(24, 65);
            this.dgc.Name = "dgc";
            this.dgc.RowHeadersWidth = 51;
            this.dgc.RowTemplate.Height = 24;
            this.dgc.Size = new System.Drawing.Size(169, 150);
            this.dgc.TabIndex = 7;
            // 
            // btnGuardarCat
            // 
            this.btnGuardarCat.Location = new System.Drawing.Point(208, 121);
            this.btnGuardarCat.Name = "btnGuardarCat";
            this.btnGuardarCat.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCat.TabIndex = 8;
            this.btnGuardarCat.Text = "Guardar";
            this.btnGuardarCat.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCat
            // 
            this.btnNuevoCat.Location = new System.Drawing.Point(208, 79);
            this.btnNuevoCat.Name = "btnNuevoCat";
            this.btnNuevoCat.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCat.TabIndex = 9;
            this.btnNuevoCat.Text = "Nuevo";
            this.btnNuevoCat.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(208, 161);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCat.TabIndex = 10;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.Location = new System.Drawing.Point(208, 201);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCat.TabIndex = 11;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 519);
            this.Controls.Add(this.pnlCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.pnlCategoria.ResumeLayout(false);
            this.pnlCategoria.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlCategoria;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgc;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btnCancelarCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnNuevoCat;
        private System.Windows.Forms.Button btnGuardarCat;
    }
}