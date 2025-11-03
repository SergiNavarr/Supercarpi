using Entidades.DTOs;
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
using ScottPlot;


namespace Interfaz
{
    public partial class FormReportes : Form
    {
        private readonly IReporteService _reporteService;

        public FormReportes(IReporteService reporteService)
        {
            InitializeComponent();
            _reporteService = reporteService;
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            dtpHasta.Value = DateTime.Now;

            cbTipoGrafico.Items.AddRange(new string[]
            {
                "Ventas por producto",
                "Ventas por método de pago"
            });
            cbTipoGrafico.SelectedIndex = 0;
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            int? empleadoId = string.IsNullOrWhiteSpace(txtEmpleadoId.Text)
                ? null
                : int.Parse(txtEmpleadoId.Text);

            var reporte = await _reporteService.GenerarReporteVentasAsync(desde, hasta, empleadoId);

            if (reporte == null)
            {
                MessageBox.Show("No se encontraron datos en el periodo seleccionado.");
                return;
            }

            MostrarResumen(reporte);
            MostrarGrafico(reporte);
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
            var plt = new ScottPlot.WinForms.FormsPlot();
            plt.Dock = DockStyle.Fill;

            if (cbTipoGrafico.SelectedItem.ToString() == "Ventas por producto" &&
                reporte.VentasPorProducto != null && reporte.VentasPorProducto.Any())
            {
                var etiquetas = reporte.VentasPorProducto.Keys.ToArray();
                var valores = reporte.VentasPorProducto.Values.Select(v => (double)v).ToArray();

                plt.Plot.AddBar(valores);
                plt.Plot.XTicks(etiquetas);
                plt.Plot.Title("Ventas por producto");
                plt.Plot.YLabel("Cantidad vendida");
            }
            else if (cbTipoGrafico.SelectedItem.ToString() == "Ventas por método de pago" &&
                     reporte.VentasPorMetodoPago != null && reporte.VentasPorMetodoPago.Any())
            {
                var etiquetas = reporte.VentasPorMetodoPago.Keys.ToArray();
                var valores = reporte.VentasPorMetodoPago.Values.Select(v => (double)v).ToArray();

                plt.Plot.AddBar(valores);
                plt.Plot.XTicks(etiquetas);
                plt.Plot.Title("Ventas por método de pago");
                plt.Plot.YLabel("Cantidad de ventas");
            }
            else
            {
                plt.Plot.Title("Sin datos para graficar");
            }

            plt.Plot.SetAxisLimits(yMin: 0);
            plt.Refresh();

            panelGrafico.Controls.Add(plt);
        }

    }
}
