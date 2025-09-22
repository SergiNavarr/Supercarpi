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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        ErrorProvider errorP1 = new ErrorProvider();
        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtNombreProducto, "Solo se permiten letras");
            }
        }

        private void txtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtDescripcionProducto, "Solo se permiten letras");
            }
        }

        private void txtMarcaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtMarcaProducto, "Solo se permiten letras");
            }
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtPrecioProducto, "Solo se permiten números");
            }
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtStockProducto, "Solo se permiten números");
            }
        }
    }
}
