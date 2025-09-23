using Entidades.Models;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz
{
    public partial class FormUsuarios : Form
    {
        public readonly IEmpleadoService _empleadoService;

        public FormUsuarios(IEmpleadoService empleadoService)
        {
            InitializeComponent();
            _empleadoService = empleadoService;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // cargar roles en el comboBox de forma hardcodeada hasta implementar el servicio de roles
            var roles = new List<Rol>
            {
                new Rol { RolId = 1, Nombre = "Administrador" },
                new Rol { RolId = 2, Nombre = "Cajero" },
                new Rol { RolId = 3, Nombre = "Repositor" }
               };

            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
            cmbRoles.ValueMember = "RolId";

            DeshabilitarCampos();
            CargarEmpleados();
        }
        private async Task CargarEmpleados()
        {
            try
            {
                dvgEmpleados.Rows.Clear();

                var empleados = await _empleadoService.Lista();

                foreach (var emp in empleados)
                {

                    dvgEmpleados.Rows.Add(
                        emp.Nombre,
                        emp.Apellido,
                        emp.Email,
                        emp.Telefono,
                        emp.Dni,
                        emp.Rol.Nombre,
                        emp.Rol.RolId,
                        emp.EmpleadoId
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void dvgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // para evitar la fila de encabezado
            {
                DataGridViewRow fila = dvgEmpleados.Rows[e.RowIndex];

                txtNombreUser.Text = fila.Cells["Nombre"].Value?.ToString();
                txtApellidoUser.Text = fila.Cells["Apellido"].Value?.ToString();
                txtEmailUser.Text = fila.Cells["Email"].Value?.ToString();
                txtTelefonoUser.Text = fila.Cells["Telefono"].Value?.ToString();
                txtDniUser.Text = fila.Cells["DNI"].Value?.ToString();

                // Rol en el comboBox
                try
                {
                    cmbRoles.SelectedValue = fila.Cells["RolId"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el rol: " + ex.Message);

                }
            }
        }

        private void DeshabilitarCampos()
        {
            txtNombreUser.Enabled = false;
            txtApellidoUser.Enabled = false;
            txtEmailUser.Enabled = false;
            txtTelefonoUser.Enabled = false;
            txtDniUser.Enabled = false;
            txtPasswordUser.Enabled = false;
            cmbRoles.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNombreUser.Enabled = true;
            txtApellidoUser.Enabled = true;
            txtEmailUser.Enabled = true;
            txtTelefonoUser.Enabled = true;
            txtDniUser.Enabled = true;
            txtPasswordUser.Enabled = true;
            cmbRoles.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtNombreUser.Clear();
            txtApellidoUser.Clear();
            txtEmailUser.Clear();
            txtTelefonoUser.Clear();
            txtDniUser.Clear();
            txtPasswordUser.Clear();
            cmbRoles.SelectedIndex = -1; // Deseleccionar cualquier selección en el comboBox
        }

        private void BloquearDataGridView()
        {
            dvgEmpleados.Enabled = false;
        }
        private void DesbloquearDataGridView()
        {
            dvgEmpleados.Enabled = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();
            BloquearDataGridView();

            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCrear.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            BloquearDataGridView();

            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCrear.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;

            txtDniUser.Enabled = false;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool guardado = await GuardarCambios();

            if (guardado)
            {
                LimpiarCampos();
                DeshabilitarCampos();
                DesbloquearDataGridView();

                btnConfirmar.Visible = false;
                btnCancelar.Visible = false;
                btnCrear.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
            DesbloquearDataGridView();

            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnCrear.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
        }

        private async Task<bool> GuardarCambios()
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtNombreUser.Text))
                {
                    MessageBox.Show("El Nombre no puede estar vacío");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtApellidoUser.Text))
                {
                    MessageBox.Show("El Apellido no puede estar vacío");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtDniUser.Text))
                {
                    MessageBox.Show("El DNI no puede estar vacío");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtEmailUser.Text))
                {
                    MessageBox.Show("El Email no puede estar vacío");
                    return false;
                }

                if (cmbRoles.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un rol");
                    return false;
                }


                string dni = txtDniUser.Text;

                // Buscar empleado por DNI
                Empleado existente = await _empleadoService.ObtenerPorDni(dni);

                // Crear objeto empleado con los datos
                Empleado empleado = new Empleado
                {
                    Nombre = txtNombreUser.Text,
                    Apellido = txtApellidoUser.Text,
                    Email = txtEmailUser.Text,
                    Telefono = txtTelefonoUser.Text,
                    Dni = dni,
                    PasswordHash = txtPasswordUser.Text,
                    RolId = (int)cmbRoles.SelectedValue
                };

                if (existente == null)
                {
                    // Crear
                    await _empleadoService.Crear(empleado);
                    MessageBox.Show("Empleado creado correctamente");
                    CargarEmpleados();
                    return true;
                }
                else
                {
                    // Editar
                    empleado.EmpleadoId = existente.EmpleadoId; // importante para que EF sepa que es edición
                    await _empleadoService.Editar(empleado);
                    MessageBox.Show("Empleado editado correctamente");
                    CargarEmpleados();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgEmpleados.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.");
                    return;
                }

                // Obtener el ID del empleado desde la columna oculta
                int idEmpleado = Convert.ToInt32(dvgEmpleados.CurrentRow.Cells["EmpleadoId"].Value);

                // Confirmar eliminación
                DialogResult result = MessageBox.Show("¿Desea eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                // Llamar al servicio para eliminar
                bool eliminado = await _empleadoService.Eliminar(idEmpleado);

                if (eliminado)
                {
                    MessageBox.Show("Empleado eliminado correctamente.");
                    await CargarEmpleados(); // recargar la lista
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            else
            {
                errorP1.Clear();
            }
        }

        private void txtApellidoUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtApellidoUser, "Solo se permiten letras");
            }
            else
            {
                errorP1.Clear();
            }
        }

        private void txtEmailUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
           !char.IsLetterOrDigit(e.KeyChar) &&
           e.KeyChar != '@' && e.KeyChar != '.' &&
           e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
                errorP1.SetError(txtEmailUser, "Caracter no permitido en email");
            }
            else
            {
                errorP1.SetError(txtEmailUser, string.Empty);
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
            else
            {
                errorP1.Clear();
            }
        }

        private void txtDniUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtDniUser, "Solo se permiten números");
            }
            else
            {
                errorP1.Clear();
            }
        }
    }
}
