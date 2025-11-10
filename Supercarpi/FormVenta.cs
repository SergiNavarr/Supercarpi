using Entidades.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Negocio.Implementacion;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private readonly ICajaService _cajaService;

        private decimal Total { get; set; }
        private List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();

        public int CajaActual { get; set; }
        public Empleado empleado { get; set; }

        public FormVenta(IPagoService pagoService,
                         IVentaService ventaService,
                         IProductoService productoService,
                         ICajaService cajaService)
        {
            _pagoService = pagoService;
            _ventaService = ventaService;
            InitializeComponent();
            _productoService = productoService;
            _cajaService = cajaService;
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

            //Verificar stock antes de registrar
            foreach (var d in DetallesVenta)
            {
                var productoBD = await _productoService.ObtenerPorId(d.ProductoId);

                if (productoBD == null)
                {
                    MessageBox.Show($"El producto con ID {d.ProductoId} ya no existe.");
                    return;
                }

                if (d.Cantidad > productoBD.StockActual)
                {
                    MessageBox.Show(
                        $"No hay suficiente stock para el producto:\n" +
                        $"{productoBD.Nombre}\n" +
                        $"Stock disponible: {productoBD.StockActual}\n" +
                        $"Cantidad solicitada: {d.Cantidad}",
                        "Stock insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
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
                VentaId = venta.VentaId,
                MetodoPagoId = (int)CBMetodoPago.SelectedValue,
                Monto = venta.Total
            };

            PagoTarjeta pagoTarjeta = null;
            if (pago.MetodoPagoId == 2 || pago.MetodoPagoId == 3)
            {
                using (var formTarjeta = new FormPagoTarjeta())
                {
                    var resultado = formTarjeta.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        pagoTarjeta = formTarjeta.PagoTarjeta;
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada. Venta no registrada.");
                        return;
                    }
                }
            }

            bool exito = await _ventaService.RegistrarVenta(venta, DetallesVenta, pago, pagoTarjeta);

            if (exito)
            {
                GenerarFacturaPDF(venta, DetallesVenta, empleado);
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
            using (var form = new FormSeleccionCaja(_cajaService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CajaActual = form.CajaSeleccionada.CajaId;
                    MessageBox.Show($"Caja {form.CajaSeleccionada.Numero} abierta correctamente.");

                    BtnAbrirCaja.Visible = false;
                    BtnCerrarCaja.Visible = true;
                    HabilitarCampos();
                }
            }
        }

        private void HabilitarCampos()
        {
            BtnGenerarVenta.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnBuscar.Enabled = true;
            BtnLimpiar.Enabled = true;
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
            TBCodigo.Enabled = false;
            CBMetodoPago.Enabled = false;
            dgvVenta.Enabled = false;
        }



        private void Limpiarcampos()
        {
            DetallesVenta = new List<DetalleVenta>();
            dgvVenta.Rows.Clear();
            TBCodigo.Clear();
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
        private async void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (CajaActual == 0)
            {
                MessageBox.Show("No hay una caja activa para cerrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Seguro que desea cerrar la caja actual?",
                "Confirmar cierre de caja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    bool exito = await _cajaService.CerrarCaja(CajaActual);

                    if (exito)
                    {
                        MessageBox.Show("Caja cerrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Resetear valores
                        CajaActual = 0;
                        DetallesVenta.Clear();
                        dgvVenta.Rows.Clear();
                        Total = 0;
                        LTotal.Text = "TOTAL: $0.00";
                        LItems.Text = "ITEMS: 0";

                        DeshabilitarCampos();
                        Limpiarcampos();

                        BtnAbrirCaja.Visible = true;
                        BtnCerrarCaja.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cerrar la caja. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cerrar la caja: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CajaActual != 0)
            {
                // Detener el cierre temporalmente
                e.Cancel = true;

                try
                {
                    await _cajaService.CerrarCaja(CajaActual);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cerrar la caja automáticamente: {ex.Message}");
                }

                CajaActual = 0;

                //cerrar la app manualmente
                Application.Exit();
            }
        }


        private void GenerarFacturaPDF(Venta venta, List<DetalleVenta> detalles, Empleado empleado)
        {
            string folderPath = @"C:\Supercarpi\Facturas";
            Directory.CreateDirectory(folderPath);

            // Generar número de factura
            string numeroFactura = $"FACT-{venta.VentaId.ToString().PadLeft(6, '0')}";
            string fileName = $"{folderPath}\\{numeroFactura}.pdf";

            Document doc = new Document(PageSize.A4, 40, 40, 20, 20);
            PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
            doc.Open();

            // ===== FUENTES =====
            var tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);

            // ===== ENCABEZADO =====
            Paragraph titulo = new Paragraph("SUPERCARPI", tituloFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Factura N°: {numeroFactura}", boldFont));
            doc.Add(new Paragraph($"Fecha: {venta.Fecha:dd/MM/yyyy HH:mm}", normalFont));
            doc.Add(new Paragraph($"Cajero: {empleado.Nombre} {empleado.Apellido}", normalFont));
            doc.Add(new Paragraph($"Caja: {venta.CajaId}", normalFont));
            doc.Add(new Paragraph("--------------------------------------------------"));

            // ===== TABLA DE PRODUCTOS =====
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 45, 15, 15, 25 });

            // Encabezados
            PdfPCell c1 = new PdfPCell(new Phrase("Producto", boldFont));
            PdfPCell c2 = new PdfPCell(new Phrase("Precio", boldFont));
            PdfPCell c3 = new PdfPCell(new Phrase("Cant.", boldFont));
            PdfPCell c4 = new PdfPCell(new Phrase("Subtotal", boldFont));

            c1.HorizontalAlignment = c2.HorizontalAlignment = c3.HorizontalAlignment =
                c4.HorizontalAlignment = Element.ALIGN_CENTER;

            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);

            // Filas
            foreach (var d in detalles)
            {
                table.AddCell(d.Producto.Nombre);
                table.AddCell(d.PrecioUnitario.ToString("C2", new CultureInfo("es-AR")));
                table.AddCell(d.Cantidad.ToString());
                table.AddCell(d.Subtotal.ToString("C2", new CultureInfo("es-AR")));
            }

            doc.Add(table);

            doc.Add(new Paragraph("--------------------------------------------------"));
            Paragraph total = new Paragraph($"TOTAL: {venta.Total.ToString("C2", new CultureInfo("es-AR"))}", boldFont);
            total.Alignment = Element.ALIGN_RIGHT;
            doc.Add(total);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("¡Gracias por su compra! Supercarpi te espera siempre", normalFont));

            doc.Close();

            MessageBox.Show($"Factura generada en: {fileName}");
        }


        // Esto es para manejar los clicks en la columna de acciones (+/-)
        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Verificar si es la columna de acciones
            if (dgvVenta.Columns[e.ColumnIndex].Name == "Acciones")
            {
                var detalle = DetallesVenta[e.RowIndex];

                var clickPos = dgvVenta.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var mouseX = dgvVenta.PointToClient(Cursor.Position).X - clickPos.Left;

                // SUMAR
                if (mouseX < (clickPos.Width / 2))
                {
                    detalle.Cantidad++;
                }
                else
                {
                    // RESTAR
                    if (detalle.Cantidad > 1)
                    {
                        detalle.Cantidad--;
                    }
                    else
                    {
                        // Si llega a 0, eliminar de la lista y grilla
                        DetallesVenta.RemoveAt(e.RowIndex);
                        dgvVenta.Rows.RemoveAt(e.RowIndex);
                    }
                }

                // Si el producto sigue en la lista, actualizar subtotal y grilla
                if (e.RowIndex < DetallesVenta.Count)
                {
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

                    dgvVenta.Rows[e.RowIndex].Cells["Cantidad"].Value = detalle.Cantidad;
                    dgvVenta.Rows[e.RowIndex].Cells["Subtotal"].Value = detalle.Subtotal.ToString("N2");
                }

                // Actualizar totales en pantalla
                Total = DetallesVenta.Sum(d => d.Subtotal);
                LTotal.Text = $"TOTAL: ${Total:N2}";
                LItems.Text = $"ITEMS: {DetallesVenta.Sum(d => d.Cantidad)}";

            }
        }

    }
}