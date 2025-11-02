using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Models;
using Negocio.Interfaces;

namespace Interfaz
{
    public partial class FormSeleccionCaja : Form
    {
        private readonly ICajaService _cajaService;
        public Caja CajaSeleccionada { get; private set; }

        public FormSeleccionCaja(ICajaService cajaService)
        {
            InitializeComponent();
            _cajaService = cajaService;
            Load += FormSeleccionCaja_Load;
            dgvCajas.CellDoubleClick += dgvCajas_CellDoubleClick; // Asegura que el evento esté enlazado
        }

        private async void FormSeleccionCaja_Load(object sender, EventArgs e)
        {
            dgvCajas.ForeColor = Color.Black;
            try
            {
                // 🔹 Cargar solo las cajas cerradas y activas
                var cajas = await _cajaService.ObtenerCajasCerradas();

                if (cajas == null || cajas.Count == 0)
                {
                    MessageBox.Show("No hay cajas cerradas disponibles para abrir.");
                    return;
                }

                dgvCajas.DataSource = cajas;

                // Ocultar columnas que no queremos mostrar
                dgvCajas.Columns["Abierto"].Visible = false;
                dgvCajas.Columns["EsActivo"].Visible = false;
                dgvCajas.Columns["Venta"].Visible = false;

                dgvCajas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cajas: {ex.Message}");
            }
        }

        private async void dgvCajas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Tomar la caja seleccionada del grid
                    Caja caja = (Caja)dgvCajas.Rows[e.RowIndex].DataBoundItem;

                    // 🔹 Intentar abrir la caja directamente desde el servicio
                    var cajaAbierta = await _cajaService.AbrirCaja(caja.Numero);

                    CajaSeleccionada = cajaAbierta;

                    MessageBox.Show($"Caja N° {cajaAbierta.Numero} abierta correctamente.");

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir la caja: {ex.Message}");
                }
            }
        }
    }
}