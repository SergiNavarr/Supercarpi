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
    public partial class FormProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        private readonly IMarcaService _marcaService;

        private bool _esEdicion = false;
        private int _productoIdEdicion = 0;


        private string rutaTemporal = string.Empty; // variable para guardar la ruta temporal de la imagen

        public FormProducto(IProductoService productoService, ICategoriaService categoriaService, IMarcaService marcaService)
        {
            _productoService = productoService;
            _categoriaService = categoriaService;
            InitializeComponent();
            _marcaService = marcaService;
        }

        private async void FormProducto_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            await CargarCategorias();
            await CargarMarcas();
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

        private async Task CargarMarcas()
        {
            try
            {
                var marcas = await _marcaService.Lista();

                CBMarca.DataSource = marcas;
                CBMarca.DisplayMember = "Nombre";
                CBMarca.ValueMember = "MarcaId";
                CBMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }


        private void DeshabilitarCampos()
        {
            txtNombreProducto.Enabled = false;
            txtDescripcionProducto.Enabled = false;
            CBMarca.Enabled = false;
            txtPrecioProducto.Enabled = false;
            txtStockProducto.Enabled = false;
            CBCategoria.Enabled = false;
            btnImagen.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            CBMarca.SelectedIndex = -1;
            txtPrecioProducto.Clear();
            txtStockProducto.Clear();
            txtImagenUrl.Clear();
            CBCategoria.SelectedIndex = -1;
        }

        private void HabilitarCampos()
        {
            txtNombreProducto.Enabled = true;
            txtDescripcionProducto.Enabled = true;
            CBMarca.Enabled = true;
            txtPrecioProducto.Enabled = true;
            txtStockProducto.Enabled = true;
            CBCategoria.Enabled = true;
            btnImagen.Enabled = true;
        }

        private void BloquearDataGridView()
        {
            dvgProductos.Enabled = false;
        }

        private void DesbloquearDataGridView()
        {
            dvgProductos.Enabled = true;
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

                    txtImagenUrl.Text = rutaRelativa;
                }
            }
        }

        private void dvgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // para evitar la fila de encabezado
            {
                DataGridViewRow fila = dvgProductos.Rows[e.RowIndex];

                txtNombreProducto.Text = fila.Cells["Nombre"].Value?.ToString();
                txtDescripcionProducto.Text = fila.Cells["Descripcion"].Value?.ToString();
                txtPrecioProducto.Text = fila.Cells["PrecioUnitario"].Value?.ToString();
                txtStockProducto.Text = fila.Cells["Stock"].Value?.ToString();
                txtImagenUrl.Text = fila.Cells["ImagenUrl"].Value?.ToString();


                try
                {
                    CBMarca.SelectedValue = fila.Cells["MarcaId"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el rol: " + ex.Message);

                }

                try
                {
                    CBCategoria.SelectedValue = fila.Cells["CategoriaId"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el rol: " + ex.Message);

                }

                // --- Imagen del producto ---
                string rutaRelativa = fila.Cells["ImagenUrl"].Value?.ToString();
                if (!string.IsNullOrEmpty(rutaRelativa))
                {
                    string rutaCompleta = Path.Combine(Application.StartupPath, rutaRelativa);
                    if (File.Exists(rutaCompleta))
                    {
                        pbProducto.Image = Image.FromFile(rutaCompleta);
                        pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        MostrarImagenPorDefecto();
                    }
                }
                else
                {
                    MostrarImagenPorDefecto();
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            _esEdicion = false;
            _productoIdEdicion = 0;

            HabilitarCampos();
            LimpiarCampos();
            BloquearDataGridView();

            dvgProductos.ClearSelection();

            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCrear.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
            DesbloquearDataGridView();
            MostrarImagenPorDefecto();

            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnCrear.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;

            _esEdicion = false;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool guardado = await GuardarCambios();

            if (guardado)
            {
                LimpiarCampos();
                DeshabilitarCampos();
                DesbloquearDataGridView();

                btnConfirmar.Visible = false;
                btnCancelar.Visible = false;
                btnCrear.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
            }
            _esEdicion = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dvgProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para editar.");
                return;
            }

            _esEdicion = true;
            _productoIdEdicion = Convert.ToInt32(dvgProductos.CurrentRow.Cells["ProductoId"].Value);

            HabilitarCampos();
            BloquearDataGridView();

            btnConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnCrear.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgProductos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.");
                    return;
                }

                int idProducto = Convert.ToInt32(dvgProductos.CurrentRow.Cells["ProductoId"].Value);

                DialogResult result = MessageBox.Show("¿Desea eliminar este producto?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                bool eliminado = await _productoService.EliminarProducto(idProducto);

                if (eliminado)
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                    await CargarProductos(); // refrescar la grilla
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }



        private async Task<bool> GuardarCambios()
        {
            try
            {
                // --- Validaciones ---
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcionProducto.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía");
                    return false;
                }

                if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número válido mayor que 0");
                    return false;
                }

                if (!int.TryParse(txtStockProducto.Text, out int stock) || stock < 0)
                {
                    MessageBox.Show("El stock debe ser un número válido");
                    return false;
                }

                if (CBMarca.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una marca");
                    return false;
                }

                if (CBCategoria.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una categoría");
                    return false;
                }

                // --- Copiar imagen solo al confirmar ---
                string rutaRelativa = "";
                if (!string.IsNullOrEmpty(rutaTemporal))
                {
                    string carpetaDestino = Path.Combine(Application.StartupPath, "Imagenes", "Productos");
                    if (!Directory.Exists(carpetaDestino))
                        Directory.CreateDirectory(carpetaDestino);

                    string nombreArchivo = Path.GetFileName(rutaTemporal);
                    string destino = Path.Combine(carpetaDestino, nombreArchivo);

                    File.Copy(rutaTemporal, destino, true);

                    rutaRelativa = Path.Combine("Imagenes", "Productos", nombreArchivo);
                }

                // --- Construir objeto producto ---
                Producto producto = new Producto
                {
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcionProducto.Text,
                    PrecioUnitario = precio,
                    StockActual = stock,
                    MarcaId = (int)CBMarca.SelectedValue,
                    CategoriaId = (int)CBCategoria.SelectedValue,
                    ImagenUrl = txtImagenUrl.Text
                };

                // --- Crear o Editar ---
                if (!_esEdicion)
                {
                    await _productoService.CrearProducto(producto);
                    MessageBox.Show("Producto creado correctamente");
                }
                else
                {
                    producto.ProductoId = _productoIdEdicion;
                    await _productoService.ActualizarProducto(producto);
                    MessageBox.Show("Producto editado correctamente");
                }

                _esEdicion = false;
                await CargarProductos(); // refrescar listado
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto: " + ex.Message);
                return false;
            }
        }

        private void MostrarImagenPorDefecto()
        {
            string rutaDefault = Path.Combine(Application.StartupPath, "Imagenes", "Productos", "default.png");

            if (File.Exists(rutaDefault))
            {
                pbProducto.Image = Image.FromFile(rutaDefault);
                pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbProducto.Image = null; // si no existe, queda vacío
            }
        }


    }
}
