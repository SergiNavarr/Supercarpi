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
    public partial class FormProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;

        private string rutaTemporal = string.Empty; // variable para guardar la ruta temporal de la imagen

        public FormProducto(IProductoService productoService, ICategoriaService categoriaService)
        {
            _productoService = productoService;
            _categoriaService = categoriaService;
            InitializeComponent();
        }

        private async void FormProducto_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            await CargarCategorias();
            await CargarProductos();
        }

        private async Task CargarProductos()
        {
            try
            {
                dvgProductos.Rows.Clear();

                var productos = await _productoService.ObtenerTodos();

                foreach (var p in productos)
                {

                    dvgProductos.Rows.Add(
                        p.ProductoId,
                        p.Nombre,
                        p.Descripcion,
                        p.PrecioUnitario,
                        p.StockActual,
                        p.Marca.MarcaId,
                        p.Marca.Nombre,
                        p.Categoria.CategoriaId,
                        p.Categoria.Nombre,
                        p.ImagenUrl
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private async Task CargarCategorias()
        {
            try
            {
                var categorias = await _categoriaService.Lista();

                CBCategoria.DataSource = categorias;
                CBCategoria.DisplayMember = "Nombre";
                CBCategoria.ValueMember = "CategoriaId";
                CBCategoria.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void DeshabilitarCampos()
        {
            txtNombreProducto.Enabled = false;
            txtDescripcionProducto.Enabled = false;
            txtMarcaProducto.Enabled = false;
            txtPrecioProducto.Enabled = false;
            txtStockProducto.Enabled = false;
            CBCategoria.Enabled = false;
            btnImagen.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNombreProducto.Enabled = true;
            txtDescripcionProducto.Enabled = true;
            txtMarcaProducto.Enabled = true;
            txtPrecioProducto.Enabled = true;
            txtStockProducto.Enabled = true;
            CBCategoria.Enabled = true;
            btnImagen.Enabled = true;
        }

        ErrorProvider errorP1 = new ErrorProvider();
        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtNombreProducto, "Solo se permiten letras");
            }
        }

        private void txtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtDescripcionProducto, "Solo se permiten letras");
            }
        }

        private void txtMarcaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtMarcaProducto, "Solo se permiten letras");
            }
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtPrecioProducto, "Solo se permiten números");
            }
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace) y números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                errorP1.SetError(txtStockProducto, "Solo se permiten números");
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
                ofd.Title = "Seleccionar imagen del producto";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaTemporal = ofd.FileName; // guardamos la ruta temporal
                    pbProducto.Image = Image.FromFile(rutaTemporal); // solo vista previa

                    string nombreArchivo = Path.GetFileName(rutaTemporal);
                    string rutaRelativa = $"Imagenes/Productos/{nombreArchivo}";

                    txtUrlImagen.Text = rutaRelativa;
                }
            }
        }

    }
}
