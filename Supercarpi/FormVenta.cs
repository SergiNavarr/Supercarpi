using Entidades.Models;
using Negocio.Implementacion;
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

namespace Interfaz
{
    public partial class FormVenta : Form
    {
        private readonly IPagoService _pagoService;
        private readonly IVentaService _ventaService;
        private readonly IProductoService _productoService;

        private decimal Total { get; set; }
        private List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();

        public FormVenta(IPagoService pagoService,
                         IVentaService ventaService,
                         IProductoService productoService)
        {
            _pagoService = pagoService;
            _ventaService = ventaService;
            InitializeComponent();
            _productoService = productoService;
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
        }

        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {
            BtnAbrirCaja.Visible = false;
            BtnCerrarCaja.Visible = true;
            BtnGenerarVenta.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnBuscar.Enabled = true;
            BtnLimpiar.Enabled = true;
            TBNombre.Enabled = true;
            TBCodigo.Enabled = true;
            CBMetodoPago.Enabled = true;
            dgvVenta.Enabled = true;
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TBCodigo.Text, out var id))
            {
                MessageBox.Show("Ingrese un código válido.");
                return;
            }

            Producto producto = await _productoService.ObtenerPorId(id);

            if (producto != null)
            {
                // Buscar si ya existe el detalle
                var detalleExistente = DetallesVenta.FirstOrDefault(d => d.ProductoId == producto.ProductoId);

                if (detalleExistente != null)
                {
                    detalleExistente.Cantidad++;
                    detalleExistente.Subtotal = detalleExistente.Cantidad * detalleExistente.PrecioUnitario;
                }
                else
                {
                    DetallesVenta.Add(new DetalleVenta
                    {
                        ProductoId = producto.ProductoId,
                        Cantidad = 1,
                        PrecioUnitario = producto.PrecioUnitario,
                        Subtotal = producto.PrecioUnitario
                    });
                }

                Total = DetallesVenta.Sum(d => d.Subtotal);
                LTotal.Text = $"Total: {Total:C2}";
                LItems.Text = $"Items: {DetallesVenta.Sum(d => d.Cantidad)}";

                // Refrescar grilla
                CargarDetalles();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void CargarDetalles()
        {
            dgvVenta.Rows.Clear();

            foreach (var dv in DetallesVenta)
            {

                dgvVenta.Rows.Add(
                    dv.ProductoId,
                    null,
                    dv.Cantidad,
                    dv.PrecioUnitario.ToString("C2"),
                    dv.Subtotal.ToString("C2")
                );

            }
        }

    }
}
