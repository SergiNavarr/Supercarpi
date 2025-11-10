using Entidades.DTOs;
using Entidades.Models;
using Negocio.Interfaces;
using ScottPlot;
using ScottPlot.TickGenerators;
using ScottPlot.WinForms;

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
    public partial class FormReportes : Form
    {
        private readonly IReporteService _reporteService;
        private readonly ICajaService _cajaService;
        private FormsPlot formsPlot1;
        public FormReportes(IReporteService reporteService, ICajaService cajaService)
        {
            InitializeComponent();
            _reporteService = reporteService;
            _cajaService = cajaService;
            
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

                cbCaja.DataSource = cajas;
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
        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;

                int? empleadoId = string.IsNullOrWhiteSpace(txtEmpleadoId.Text)
                    ? null
                    : int.Parse(txtEmpleadoId.Text);

                int? cajaId = cbCaja.SelectedValue as int?;

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
                // 🔹 Tomar solo los 5 productos más vendidos
                var topProductos = reporte.VentasPorProducto
                    .OrderByDescending(v => v.Value)
                    .Take(5)
                    .ToDictionary(kv => kv.Key, kv => kv.Value);

                // 🔹 Generar etiquetas cortas y valores
                var etiquetas = topProductos.Keys.Select((p, i) => $"P{i + 1}").ToArray();
                var valores = topProductos.Values.Select(v => (double)v).ToArray();

                // 🔹 Agregar gráfico de barras
                var barPlot = plt.Add.Bars(valores);
                foreach (var b in barPlot.Bars)
                    b.FillColor = Colors.SteelBlue;

                // 🔹 Etiquetas alineadas con las barras
                plt.Axes.Bottom.TickGenerator = new NumericManual(
                    Enumerable.Range(0, etiquetas.Length).Select(i => (double)i).ToArray(),
                    etiquetas
                );

                // 🔹 Títulos
                plt.Title("Ventas por producto (Top 5)");
                plt.YLabel("Cantidad vendida");

                // 🔹 Leyenda en ListBox (P1 → Nombre completo)
                int index = 1;
                foreach (var kv in topProductos)
                {
                    lstLeyenda.Items.Add($"P{index} → {kv.Key}");
                    index++;
                }

                // 🔹 Ajustar límites automáticos
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
    }

}

