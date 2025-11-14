using Entidades.DTOs;
using Entidades.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Negocio.Implementacion;
using Negocio.Interfaces;
using ScottPlot;
using ScottPlot.TickGenerators;
using ScottPlot.WinForms;

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
    public partial class FormReportes : Form
    {
        private readonly IReporteService _reporteService;
        private readonly ICajaService _cajaService;
        private readonly IEmpleadoService _empleadoService;
        private FormsPlot formsPlot1;
        public FormReportes(IReporteService reporteService, ICajaService cajaService, IEmpleadoService empleadoService)
        {
            InitializeComponent();
            _reporteService = reporteService;
            _cajaService = cajaService;
            _empleadoService = empleadoService;
        }


        private async void FormReportes_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            dtpHasta.Value = DateTime.Now;

            cbTipoGrafico.Items.AddRange(new string[]
            {
                "Ventas por producto",
                "Ventas por método de pago"
            });
            cbTipoGrafico.SelectedIndex = 0;

            await CargarCajasAsync();
            await CargarCajerosAsync();
        }

        // Carga las cajas activas desde el servicio de negocio
        private async Task CargarCajasAsync()
        {
            try
            {
                var cajas = await _cajaService.ObtenerCajas();

                if (cajas == null || !cajas.Any())
                {
                    MessageBox.Show("No se encontraron cajas activas.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cajas.Insert(0, new Caja { CajaId = 0, Numero = -1 });

                cbCaja.DataSource = cajas
                    .Select(c => new { c.CajaId, Texto = c.CajaId == 0 ? "(Todas)" : $"Caja {c.Numero}" })
                    .ToList();
                cbCaja.DisplayMember = "Numero"; // mostramos el número de caja
                cbCaja.ValueMember = "CajaId";
                cbCaja.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las cajas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarCajerosAsync()
        {
            try
            {
                var cajeros = await _empleadoService.ObtenerCajeros();

                // Agregar opción "Todos"
                cajeros.Insert(0, new Empleado { EmpleadoId = 0, Nombre = "(Todos)", Apellido = "" });

                // Crear lista para el ComboBox
                var listaCombo = cajeros
                    .Select(c => new
                    {
                        c.EmpleadoId,
                        NombreCompleto = $"{c.Nombre} {c.Apellido}".Trim()
                    })
                    .ToList();

                // Asignar al combo
                cbCajero.DataSource = listaCombo;
                cbCajero.DisplayMember = "NombreCompleto";
                cbCajero.ValueMember = "EmpleadoId";
                cbCajero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cajeros: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;

                int? empleadoId = cbCajero.SelectedValue is int idCajero && idCajero != 0
                    ? idCajero
    : null;


                int? cajaId = cbCaja.SelectedValue is int idCaja && idCaja != 0
                    ? idCaja
                    : null;

                var reporte = await _reporteService.GenerarReporteVentasAsync(desde, hasta, empleadoId, cajaId);

                if (reporte == null)
                {
                    MessageBox.Show("No se encontraron datos en el periodo seleccionado.");
                    return;
                }

                MostrarResumen(reporte);
                MostrarGrafico(reporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResumen(ReporteResumenDTO reporte)
        {
            // Limpiar grillas antes de volver a cargar
            dgvResumenGeneral.Rows.Clear();
            dgvResumenCajas.Rows.Clear();
            dgvResumenGeneral.Rows.Clear();

            // Agregar una sola fila vacía
            int fila = dgvResumenGeneral.Rows.Add();

            // Cargar datos en las columnas ya definidas en el diseñador
            dgvResumenGeneral.Rows[fila].Cells["Total_Ventas"].Value = reporte.TotalVentas;
            dgvResumenGeneral.Rows[fila].Cells["Total_Recaudacion"].Value = $"${reporte.RecaudacionTotal:F2}";
            dgvResumenGeneral.Rows[fila].Cells["Metodo_pago_mas_usado"].Value = reporte.MetodoPagoMasUsado;
            dgvResumenGeneral.Rows[fila].Cells["Producto_mas_vendido"].Value = reporte.ProductoMasVendido;


            // --- RESUMEN POR CAJA ---
            if (reporte.ResumenPorCaja != null && reporte.ResumenPorCaja.Any())
            {
                foreach (var caja in reporte.ResumenPorCaja)
                {
                    int filaCaja = dgvResumenCajas.Rows.Add();
                    dgvResumenCajas.Rows[filaCaja].Cells["nro_caja"].Value = caja.CajaId;
                    dgvResumenCajas.Rows[filaCaja].Cells["Monto_total"].Value = $"${caja.MontoTotal:F2}";
                    dgvResumenCajas.Rows[filaCaja].Cells["Metodo_mas_usado"].Value = caja.MetodoPagoMasUsado;
                }
            }
            else
            {
                // Si no hay datos, mostramos una fila vacía con "Sin datos"

                dgvResumenCajas.Rows[fila].Cells["nro_caja"].Value = "-";
                dgvResumenCajas.Rows[fila].Cells["Monto_total"].Value = "-";
                dgvResumenCajas.Rows[fila].Cells["Metodo_mas_usado"].Value = "Sin datos";
            }
        }


        private void MostrarGrafico(ReporteResumenDTO reporte)
        {
            panelGrafico.Controls.Clear();
            lstLeyenda.Items.Clear();

            var formsPlot = new FormsPlot { Dock = DockStyle.Fill };
            var plt = formsPlot.Plot;

            if (cbTipoGrafico.SelectedItem?.ToString() == "Ventas por producto" &&
                reporte.VentasPorProducto?.Any() == true)
            {
                // Tomar solo los 5 productos más vendidos
                var topProductos = reporte.VentasPorProducto
                    .OrderByDescending(v => v.Value)
                    .Take(5)
                    .ToDictionary(kv => kv.Key, kv => kv.Value);

                // Generar etiquetas cortas y valores
                var etiquetas = topProductos.Keys.Select((p, i) => $"P{i + 1}").ToArray();
                var valores = topProductos.Values.Select(v => (double)v).ToArray();

                // Agregar gráfico de barras
                var barPlot = plt.Add.Bars(valores);
                foreach (var b in barPlot.Bars)
                    b.FillColor = Colors.SteelBlue;

                // Etiquetas alineadas con las barras
                plt.Axes.Bottom.TickGenerator = new NumericManual(
                    Enumerable.Range(0, etiquetas.Length).Select(i => (double)i).ToArray(),
                    etiquetas
                );

                // Títulos
                plt.Title("Ventas por producto (Top 5)");
                plt.YLabel("Cantidad vendida");

                // Leyenda en ListBox (P1 → Nombre completo)
                int index = 1;
                foreach (var kv in topProductos)
                {
                    lstLeyenda.Items.Add($"P{index} → {kv.Key}");
                    index++;
                }

                // Ajustar límites automáticos
                plt.Axes.SetLimits(0, etiquetas.Length, 0, double.NaN);
            }
            else if (cbTipoGrafico.SelectedItem?.ToString() == "Ventas por método de pago" &&
                     reporte.VentasPorMetodoPago?.Any() == true)
            {
                var etiquetas = reporte.VentasPorMetodoPago.Keys.ToArray();
                var valores = reporte.VentasPorMetodoPago.Values.Select(v => (double)v).ToArray();

                var barPlot = plt.Add.Bars(valores);
                foreach (var b in barPlot.Bars)
                    b.FillColor = Colors.OrangeRed;

                plt.Axes.Bottom.TickGenerator = new NumericManual(
                    Enumerable.Range(0, etiquetas.Length).Select(i => (double)i).ToArray(),
                    etiquetas
                );

                plt.Title("Ventas por método de pago");
                plt.YLabel("Cantidad de ventas");
                plt.Axes.SetLimits(0, etiquetas.Length, 0, double.NaN);
            }
            else
            {
                plt.Title("Sin datos para graficar");
            }

            formsPlot.Refresh();
            panelGrafico.Controls.Add(formsPlot);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GenerarReporteFacturasPDF(
                List<Venta> ventas,
                DateTime desde,
                DateTime hasta,
                string cajeroNombre,
                string cajaNombre)
        {
            string folderPath = @"C:\Supercarpi\Reportes";
            Directory.CreateDirectory(folderPath);

            string nombreArchivo = $"ReporteFacturas_{desde:ddMMyyyy}_{hasta:ddMMyyyy}_{Guid.NewGuid()}.pdf";

            string filePath = Path.Combine(folderPath, nombreArchivo);

            Document doc = new Document(PageSize.A4, 40, 40, 20, 20);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            var tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);

            // ENCABEZADO
            Paragraph titulo = new Paragraph("REPORTE DE FACTURAS - SUPERCARPI", tituloFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Desde: {desde:dd/MM/yyyy}  -  Hasta: {hasta:dd/MM/yyyy}", normalFont));
            doc.Add(new Paragraph($"Cajero: {cajeroNombre}", normalFont));
            doc.Add(new Paragraph($"Caja: {cajaNombre}", normalFont));
            doc.Add(new Paragraph("--------------------------------------------------"));

            // TABLA
            PdfPTable tabla = new PdfPTable(5);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 15, 15, 25, 20, 25 });

            tabla.AddCell(new Phrase("Factura", boldFont));
            tabla.AddCell(new Phrase("Fecha", boldFont));
            tabla.AddCell(new Phrase("Cajero", boldFont));
            tabla.AddCell(new Phrase("Caja", boldFont));
            tabla.AddCell(new Phrase("Monto Total", boldFont));

            foreach (var v in ventas)
            {
                string nroFactura = $"FACT-{v.VentaId.ToString().PadLeft(6, '0')}";

                tabla.AddCell(nroFactura);
                tabla.AddCell(v.Fecha.ToString("dd/MM/yyyy HH:mm"));
                tabla.AddCell($"{v.Empleado.Nombre} {v.Empleado.Apellido}");
                tabla.AddCell(v.CajaId.ToString());
                tabla.AddCell(v.Total.ToString("C2", new CultureInfo("es-AR")));
            }

            doc.Add(tabla);

            doc.Add(new Paragraph(" "));

            doc.Close();

            MessageBox.Show($"Reporte generado:\n{filePath}");
        }


        private async void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Obtener filtros
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1); // incluye todo el día

                int? empleadoId = cbCajero.SelectedIndex > 0
                    ? cbCajero.SelectedValue as int?
                    : null;

                int? cajaId = cbCaja.SelectedIndex > 0
                    ? cbCaja.SelectedValue as int?
                    : null;

                // 2) Consultar ventas del repositorio
                var ventas = await _reporteService.ObtenerVentasAsync(desde, hasta, empleadoId, cajaId);

                if (ventas == null || !ventas.Any())
                {
                    MessageBox.Show("No se encontraron ventas en el período o filtros seleccionados.");
                    return;
                }
                // 3) Identificar nombres de cajero/caja para el PDF
                string nombreCajero =
                    cbCajero.SelectedIndex <= 0
                    ? "Todos"
                    : cbCajero.Text;

                string nombreCaja =
                    cbCaja.SelectedIndex <= 0
                    ? "Todas"
                    : cbCaja.Text;
                // 4) Generar el PDF completo
                GenerarReporteFacturasPDF(
                    ventas,
                    desde,
                    hasta,
                    nombreCajero,
                    nombreCaja
                );

                MessageBox.Show("Reporte PDF generado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

