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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(_formVenta);
        }
    }
}
