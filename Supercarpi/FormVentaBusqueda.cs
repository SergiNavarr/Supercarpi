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
    public partial class FormVentaBusqueda : Form
    {
        private readonly IProductoService _productoService;
        public Producto ProductoSeleccionado { get; private set; }

        public FormVentaBusqueda(IProductoService productoService)
        {
            InitializeComponent();
            _productoService = productoService;
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = TBNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(filtro))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            var resultados = await _productoService.BuscarPorNombre(filtro);

            dgvResultados.DataSource = resultados;
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductoSeleccionado = (Producto)dgvResultados.Rows[e.RowIndex].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

