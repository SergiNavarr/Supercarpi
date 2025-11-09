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
            //InicializarGrafico();
        }
        // private void InicializarGrafico()
        //{
        //formsPlot1 = new FormsPlot
        //{
        // Dock = DockStyle.Fill
        //};
        //panelGrafico.Controls.Add(formsPlot1);
        // }

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
            lblTotalVentas.Text = $"Total de ventas: {reporte.TotalVentas}";
            lblRecaudacion.Text = $"Recaudación total: ${reporte.RecaudacionTotal:F2}";
            lblMetodoPago.Text = $"Método de pago más utilizado: {reporte.MetodoPagoMasUsado}";
            lblProducto.Text = $"Producto más vendido: {reporte.ProductoMasVendido}";
        }

        private void MostrarGrafico(ReporteResumenDTO reporte)
        {
            panelGrafico.Controls.Clear();


            var formsPlot = new FormsPlot { Dock = DockStyle.Fill };
            var plt = formsPlot.Plot;

            if (cbTipoGrafico.SelectedItem?.ToString() == "Ventas por producto" &&
                reporte.VentasPorProducto?.Any() == true)
            {
                var etiquetas = reporte.VentasPorProducto.Keys.ToArray();
                var valores = reporte.VentasPorProducto.Values.Select(v => (double)v).ToArray();

                var barPlot = plt.Add.Bars(valores);
                foreach (var b in barPlot.Bars)
                    b.FillColor = Colors.SteelBlue;

                plt.Axes.Bottom.TickGenerator = new NumericManual(
                    Enumerable.Range(0, etiquetas.Length).Select(i => (double)i).ToArray(),
                    etiquetas
                );

                plt.Title("Ventas por producto");
                plt.YLabel("Cantidad vendida");
                plt.Axes.SetLimits(0, double.NaN, 0, double.NaN);
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
                plt.Axes.SetLimits(0, double.NaN, 0, double.NaN);
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

