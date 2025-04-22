using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria nesesaria para mover la ventana, NO BORRAR
using System.Runtime.InteropServices;

namespace DistribuidoraExpress
{
    public partial class Login : Form
    {
        private ServicioLogin _serviciologin = new ServicioLogin();

        public Login()
        {
            InitializeComponent();
        }

        //Permite mover la ventana, NO BORRAR O MODIFICAR
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);


        private void EntrarButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string contraseña = ContraseñaTextBox.Text;

            // por si se dejan las casillas 
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("¡Debe ingresar usuario y contraseña!", "Error");
                return;
            }

            Usuario usuario = _serviciologin.Autenticar(email, contraseña);

            if (usuario != null)
            {
                MessageBox.Show($"¡Bienvenido, {usuario.Nombre}!", "Login Exitoso");
                this.Hide();

                // Redirigir según el tipo de usuario
                switch (usuario.TipoUsuario)
                {
                    case "SuperUsuario":
                        MenuSuperUsuario MenuSuperUsuario = new MenuSuperUsuario();
                        MenuSuperUsuario.Show();
                        break;

                    case "Administrador":
                        
                        MenuAdministrador MenuAdministrador = new MenuAdministrador();
                        MenuAdministrador.Show();
                        
                        break;

                    case "Registrador":
                        new MenuRegistrador().Show();

                        break;

                    case "Aprobador":
                        new MenuAprobador().Show();

                        break;
                }
            }
            else
            {
                // Verificar si el error es por usuario o contraseña
                bool usuarioExiste = _serviciologin.ExisteUsuario(email);

                if (usuarioExiste)
                {
                    MessageBox.Show("Contraseña incorrecta", "Error");
                }
                    
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error");
                }

                ContraseñaTextBox.Clear();
                ContraseñaTextBox.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if(EmailTextBox.Text=="EMAIL")
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = Color.LightGray;
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "") 
            {
                EmailTextBox.Text = "EMAIL";
                EmailTextBox.ForeColor = Color.DimGray;
            }
        }

        private void ContraseñaTextBox_Enter(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.Text == "CONTRACEÑA")
            {
                ContraseñaTextBox.Text = "";
                ContraseñaTextBox.ForeColor = Color.LightGray;
                //oculta el texto ingresado en la caja de texto con caracteres protegidos
                ContraseñaTextBox.UseSystemPasswordChar = true;
            }
        }

        private void ContraseñaTextBox_Leave(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.Text == "")
            {
                ContraseñaTextBox.Text = "CONTRACEÑA";
                ContraseñaTextBox.ForeColor = Color.DimGray;
                //muestra el texto existente (CONTRACEÑA) en la caja de texto sin protección
                ContraseñaTextBox.UseSystemPasswordChar = false;
            }
        }

        //Permite mover la ventana parte2, NO BORRAR O MODIFICAR
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMinimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
