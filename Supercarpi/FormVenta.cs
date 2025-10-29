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

        public int CajaActual { get; set; } = 1;
        public Empleado empleado { get; set; }

        public FormVenta(IPagoService pagoService,
                         IVentaService ventaService,
                         IProductoService productoService)
        {
            _pagoService = pagoService;
            _ventaService = ventaService;
            InitializeComponent();
            _productoService = productoService;
        }

        private async void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
            if (DetallesVenta.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
                return;
            }

            if (CBMetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            var venta = new Venta
            {
                EmpleadoId = empleado.EmpleadoId,
                CajaId = CajaActual,
                Fecha = DateTime.Now,
                Total = DetallesVenta.Sum(d => d.Subtotal)
            };

            var pago = new Pago
            {
                VentaId = venta.VentaId, // se setea al guardar
                MetodoPagoId = (int)CBMetodoPago.SelectedValue,
                Monto = venta.Total
            };

            PagoTarjeta pagoTarjeta = null;
            if (pago.MetodoPagoId == 2 || pago.MetodoPagoId == 3)
            {
                pagoTarjeta = new PagoTarjeta
                {
                    NumeroTarjeta = "****1234", // ejemplo
                    Titular = "Cliente"
                };
            }

            bool exito = await _ventaService.RegistrarVenta(venta, DetallesVenta, pago, pagoTarjeta);

            if (exito)
            {
                MessageBox.Show("Venta registrada correctamente.");
                dgvVenta.Rows.Clear();
                DetallesVenta.Clear();
                Total = 0;
                LTotal.Text = "TOTAL: $0.00";
                LItems.Text = "ITEMS: 0";
            }
            else
            {
                MessageBox.Show("Error al registrar la venta.");
            }
        }


        private void BtnAbrirCaja_Click(object sender, EventArgs e)
        {
            BtnAbrirCaja.Visible = false;
            BtnCerrarCaja.Visible = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            BtnGenerarVenta.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnBuscar.Enabled = true;
            BtnLimpiar.Enabled = true;
            TBNombre.Enabled = true;
            TBCodigo.Enabled = true;
            CBMetodoPago.Enabled = true;
            dgvVenta.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            BtnGenerarVenta.Enabled = false;
            BtnAgregar.Enabled = false;
            BtnBuscar.Enabled = false;
            BtnLimpiar.Enabled = false;
            TBNombre.Enabled = false;
            TBCodigo.Enabled = false;
            CBMetodoPago.Enabled = false;
            dgvVenta.Enabled = false;
        }



        private void Limpiarcampos()
        {
            DetallesVenta = new List<DetalleVenta>();
            dgvVenta.Rows.Clear();
            TBCodigo.Clear();
            TBNombre.Clear();
            CBMetodoPago.SelectedIndex = -1;
            LTotal.Text = "TOTAL: $0.00";
            LItems.Text = "ITEMS: 0";
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TBCodigo.Text, out var id))
            {
                MessageBox.Show("Ingrese un código válido.");
                return;
            }

            var producto = await _productoService.ObtenerPorId(id);

            if (producto != null)
                AgregarProductoAVenta(producto);
            else
                MessageBox.Show("Producto no encontrado.");
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiarcampos();
        }

        private async Task CargarMetodosPago()
        {
            try
            {
                var metodos = await _pagoService.ObtenerMetodosPago();

                CBMetodoPago.DataSource = metodos;
                CBMetodoPago.DisplayMember = "Nombre";
                CBMetodoPago.ValueMember = "MetodoPagoId";
                CBMetodoPago.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Metodos de pago: " + ex.Message);
            }
        }

        private async void FormVenta_Load(object sender, EventArgs e)
        {
            await CargarMetodosPago();
            dgvVenta.ForeColor = Color.Black;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (var formBusqueda = new FormVentaBusqueda(_productoService))
            {
                if (formBusqueda.ShowDialog() == DialogResult.OK)
                {
                    var producto = formBusqueda.ProductoSeleccionado;
                    if (producto != null)
                    {
                        AgregarProductoAVenta(producto);
                    }
                }
            }
        }

        private void AgregarProductoAVenta(Producto producto)
        {
            // Si ya existe en la lista, aumentar cantidad
            var existente = DetallesVenta.FirstOrDefault(d => d.ProductoId == producto.ProductoId);
            if (existente != null)
            {
                existente.Cantidad++;
                existente.Subtotal = existente.Cantidad * existente.PrecioUnitario;
                // refrescar dgvVenta
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    if ((int)row.Cells["ProductoId"].Value == producto.ProductoId)
                    {
                        row.Cells["Cantidad"].Value = existente.Cantidad;
                        row.Cells["Subtotal"].Value = existente.Subtotal;
                        break;
                    }
                }
            }
            else
            {
                var detalle = new DetalleVenta
                {
                    ProductoId = producto.ProductoId,
                    Cantidad = 1,
                    PrecioUnitario = producto.PrecioUnitario,
                    Subtotal = producto.PrecioUnitario
                };
                DetallesVenta.Add(detalle);
                dgvVenta.Rows.Add(producto.ProductoId, producto.Nombre, detalle.PrecioUnitario, detalle.Cantidad, detalle.Subtotal);
            }

            Total = DetallesVenta.Sum(d => d.Subtotal);
            LTotal.Text = $"TOTAL: ${Total}";
            LItems.Text = $"ITEMS: {DetallesVenta.Count}";
        }


    }
}
