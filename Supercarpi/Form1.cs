using Datos.DBContext;
using Interfaz;

namespace Supercarpi
{
    public partial class Login : Form
    {
        private readonly SupercarpiDbContext _context;
        public Login(SupercarpiDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string dni = TBDni.Text.Trim();
            string pass = TBPassword.Text.Trim();

            var usuario = _context.Empleados
                                    .FirstOrDefault(u => u.Dni == dni && u.PasswordHash == pass);

            if (usuario != null)
            {
                MessageBox.Show("Login Exitoso");

                var inicio = new Inicio();
                inicio.Show();

            }
            else
            {
                MessageBox.Show("usuario No encontrado");
            }

        }
    }
}
