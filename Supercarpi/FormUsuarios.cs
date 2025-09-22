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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        ErrorProvider errorP1 = new ErrorProvider();
        private void txtNombreUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtNombreUser, "Solo se permiten letras");
            }
        }

        private void txtApellidoUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtApellidoUser, "Solo se permiten letras");
            }
        }

        private void txtEmailUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtEmailUser, "Solo se permiten letras");
            }
        }

        private void txtTelefonoUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtTelefonoUser, "Solo se permiten números");
            }
        }

        private void txtDniUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtDniUser, "Solo se permiten números");
            }
        }
    }
}
