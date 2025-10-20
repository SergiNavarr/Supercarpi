using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Interfaces;
using System.Threading.Tasks;

namespace Interfaz
{
    public partial class FormBackUp : Form
    {
        public FormBackUp()
        {
            InitializeComponent();
        }

        //Campo privado para almacenar la referencia del servicio
        private readonly IBackupService _backupService;
        private string _rutaSeleccionada;


        // Se inyecta el servicio por constructor
        public FormBackUp(IBackupService backupService)
        {
            InitializeComponent();
            _backupService = backupService;
        }

        

        private void btnRuta_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Seleccione la carpeta donde guardar el backup";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _rutaSeleccionada = dialog.SelectedPath;
                    txtRutaBackUp.Text = _rutaSeleccionada;
                }
            }
        }

        private async void btnGenerarBU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutaBackUp.Text))
            {
                MessageBox.Show("Debe seleccionar una carpeta de destino.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Generar nombre del archivo
                string nombreArchivo = $"Backup_Supercarpi_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string rutaCompleta = Path.Combine(_rutaSeleccionada, nombreArchivo);

                // Ejecutar backup
                await _backupService.CrearBackupAsync(rutaCompleta);

                MessageBox.Show($"✅ Backup realizado con éxito.\nRuta: {rutaCompleta}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("❌ Acceso denegado.\nEjecute la aplicación como administrador o elija otra carpeta.",
                    "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al realizar el backup:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 }



    

 
    

