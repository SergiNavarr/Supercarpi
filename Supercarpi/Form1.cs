using Datos.DBContext;
using Interfaz;

namespace Supercarpi
{
    public partial class Login : Form
    {
        private readonly SupercarpiDbContext _context;
        private readonly Inicio _formInicio;
        public Login(SupercarpiDbContext context, Inicio inicio)
        {
            InitializeComponent();
            _context = context;
            _formInicio = inicio;
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string dni = TBDni.Text.Trim();
            string pass = TBPassword.Text.Trim();

            var empleado = _context.Empleados
                                    .FirstOrDefault(u => u.Dni == dni && u.PasswordHash == pass);

            if (empleado != null)
            {
                this.Hide();

                _formInicio.empleado = empleado;
                _formInicio.Show();

            }
            else
            {
                MessageBox.Show("Credenciales invalidas");
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
