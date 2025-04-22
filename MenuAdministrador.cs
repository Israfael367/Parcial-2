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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
            CollapseMenu();
        }

        // Permite mover la ventana, NO BORRAR O MODIFICAR  
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void label1_Click(object sender, EventArgs e)
        {
            // Método vacío, no requiere cambios.  
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Método vacío, no requiere cambios.  
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Método vacío, no requiere cambios.  
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestaurarAdmin.Visible = true;
            MaximizarAdmin.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.PanelMenuAdmin.Width > 200)
            {
                PanelMenuAdmin.Width = 100;
                LogoAdmin.Visible = false;
                LogoAdminChikito.Visible = true;
                OpcionesDelMenu.Dock = DockStyle.Left;
                foreach (Button menuButton in PanelMenuAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                PanelMenuAdmin.Width = 230;
                LogoAdmin.Visible = true;
                LogoAdminChikito.Visible = false;
                OpcionesDelMenu.Dock = DockStyle.Left;
                foreach (Button menuButton in PanelMenuAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag?.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VentanaNormalAdmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestaurarAdmin.Visible = false;
            MaximizarAdmin.Visible = true;
        }

        private void PanelDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
