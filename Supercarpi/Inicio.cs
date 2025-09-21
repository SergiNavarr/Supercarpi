using Entidades.Models;
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

namespace Interfaz
{
    public partial class Inicio : Form
    {
        private readonly FormVenta _formVenta;
        private readonly FormUsuarios _formUsuarios;

        public Empleado empleado { get; set; }

        public Inicio(FormVenta formVenta, FormUsuarios formUsuarios)
        {

            InitializeComponent();
            _formVenta = formVenta;
            _formUsuarios = formUsuarios;

        }

        private void AbrirFormHija(Form formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            formhija.TopLevel = false;
            formhija.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formhija);
            this.panelContenedor.Tag = formhija;
            formhija.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormHija(_formUsuarios);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormProducto());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(_formVenta);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormProveedores());
        }

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PBMaximizar.Visible = false;
            PBContraer.Visible = true;
        }

        private void PBContraer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PBContraer.Visible = false;
            PBMaximizar.Visible = true;
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Mover formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // Fin mover formulario

        // Evita que el formulario se maximice sobre la barra de tareas
        private void Inicio_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        
    }
}
