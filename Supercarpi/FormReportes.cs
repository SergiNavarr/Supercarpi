using Entidades.DTOs;
using Negocio.Interfaces;
using ScottPlot;
using ScottPlot.WinForms;
using ScottPlot.TickGenerators;
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

            var formsPlot = new FormsPlot { Dock = DockStyle.Fill };
            var plt = formsPlot.Plot;

            if (cbTipoGrafico.SelectedItem?.ToString() == "Ventas por producto" &&
                reporte.VentasPorProducto?.Any() == true)
            {
                var etiquetas = reporte.VentasPorProducto.Keys.ToArray();
                var valores = reporte.VentasPorProducto.Values.Select(v => (double)v).ToArray();

                var barPlot = plt.Add.Bars(valores);

                // color uniforme (loop sobre cada barra)
                foreach (var b in barPlot.Bars)
                    b.FillColor = Colors.SteelBlue;

                // etiquetas del eje X
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

    }
}
