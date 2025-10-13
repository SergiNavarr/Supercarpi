using Datos.DBContext;
using Entidades.Models;
using Interfaz;
using Negocio.Interfaces;

namespace Supercarpi
{
    public partial class Login : Form
    {
        private readonly SupercarpiDbContext _context;
        private readonly Inicio _formInicio;
        private readonly IEmpleadoService _empleadoService;

        public Login(SupercarpiDbContext context, Inicio inicio, IEmpleadoService empleadoService)
        {
            InitializeComponent();
            _context = context;
            _formInicio = inicio;
            _empleadoService = empleadoService;
        }

        private async void BLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener credenciales del formulario
                string dni = TBDni.Text.Trim();
                string pass = TBPassword.Text.Trim();

                // Llamar al servicio de empleados
                Empleado empleado = await _empleadoService.ObtenerPorCredenciales(dni, pass);

                if (empleado != null)
                {

                    this.Hide();
                    //SesionActual.EmpleadoLogueado = empleado;
                    _formInicio.empleado = empleado;
                    _formInicio.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales inválidas");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("DNI debe ser un número válido");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
