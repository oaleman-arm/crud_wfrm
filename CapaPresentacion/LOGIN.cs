using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDatos;
using CapaNegocio.Entidades;
using CapaPresentacion.Formularios;

namespace CapaPresentacion
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

         private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btnacceder_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "Usuario")
            {
                if (txtpass.Text != "Contraseña")

                {

                    ClassUsuario usuario = new ClassUsuario();
                    var validLogin = usuario.Login(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos");
                        txtuser.Clear();
                        txtpass.Clear();

                        txtuser.Focus();
                    }
                }
                else msgError("Ingrese su contraseña");
            }
            else
            {
                msgError("Ingrese su nombre de usuario");
            }

        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "      " + msg;
            lblErrorMessage.Visible = true;
        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
