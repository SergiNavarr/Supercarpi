namespace Interfaz
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LGestionProductos = new Label();
            dvgProductos = new DataGridView();
            ProductoId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            MarcaId = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            CategoriaId = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            ImagenUrl = new DataGridViewTextBoxColumn();
            LNombreProducto = new Label();
            LProductoDescripcion = new Label();
            LPrecio = new Label();
            LProductoMarca = new Label();
            LProductoCategoria = new Label();
            LStock = new Label();
            txtNombreProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            CBCategoria = new ComboBox();
            txtPrecioProducto = new TextBox();
            txtStockProducto = new TextBox();
            pbProducto = new PictureBox();
            btnImagen = new Button();
            txtImagenUrl = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnCrear = new Button();
            CBMarca = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            SuspendLayout();
            // 
            // LGestionProductos
            // 
            LGestionProductos.AutoSize = true;
            LGestionProductos.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LGestionProductos.ForeColor = SystemColors.ButtonHighlight;
            LGestionProductos.Location = new Point(32, 31);
            LGestionProductos.Name = "LGestionProductos";
            LGestionProductos.Size = new Size(336, 32);
            LGestionProductos.TabIndex = 0;
            LGestionProductos.Text = "GESTION DE PRODUCTOS";
            // 
            // dvgProductos
            // 
            dvgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Columns.AddRange(new DataGridViewColumn[] { ProductoId, Nombre, Descripcion, PrecioUnitario, Stock, MarcaId, Marca, CategoriaId, Categoria, ImagenUrl });
            dvgProductos.Location = new Point(74, 277);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.Size = new Size(949, 213);
            dvgProductos.TabIndex = 1;
            dvgProductos.CellClick += dvgProductos_CellClick;
            // 
            // ProductoId
            // 
            ProductoId.HeaderText = "Id";
            ProductoId.MinimumWidth = 6;
            ProductoId.Name = "ProductoId";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // MarcaId
            // 
            MarcaId.HeaderText = "MarcaId";
            MarcaId.MinimumWidth = 6;
            MarcaId.Name = "MarcaId";
            MarcaId.Visible = false;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            // 
            // CategoriaId
            // 
            CategoriaId.HeaderText = "CategoriaId";
            CategoriaId.MinimumWidth = 6;
            CategoriaId.Name = "CategoriaId";
            CategoriaId.Visible = false;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // ImagenUrl
            // 
            ImagenUrl.HeaderText = "ImagenUrl";
            ImagenUrl.Name = "ImagenUrl";
            // 
            // LNombreProducto
            // 
            LNombreProducto.AutoSize = true;
            LNombreProducto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreProducto.ForeColor = SystemColors.ButtonHighlight;
            LNombreProducto.Location = new Point(74, 86);
            LNombreProducto.Name = "LNombreProducto";
            LNombreProducto.Size = new Size(77, 21);
            LNombreProducto.TabIndex = 2;
            LNombreProducto.Text = "Nombre:";
            // 
            // LProductoDescripcion
            // 
            LProductoDescripcion.AutoSize = true;
            LProductoDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LProductoDescripcion.ForeColor = SystemColors.ButtonHighlight;
            LProductoDescripcion.Location = new Point(74, 117);
            LProductoDescripcion.Name = "LProductoDescripcion";
            LProductoDescripcion.Size = new Size(104, 21);
            LProductoDescripcion.TabIndex = 3;
            LProductoDescripcion.Text = "Descripción:";
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LPrecio.ForeColor = SystemColors.ButtonHighlight;
            LPrecio.Location = new Point(492, 84);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(125, 21);
            LPrecio.TabIndex = 4;
            LPrecio.Text = "Precio Unitario:";
            // 
            // LProductoMarca
            // 
            LProductoMarca.AutoSize = true;
            LProductoMarca.Font = new Font("Century Gothic", 12F);
            LProductoMarca.ForeColor = SystemColors.ButtonHighlight;
            LProductoMarca.Location = new Point(74, 154);
            LProductoMarca.Name = "LProductoMarca";
            LProductoMarca.Size = new Size(66, 21);
            LProductoMarca.TabIndex = 5;
            LProductoMarca.Text = "Marca:";
            // 
            // LProductoCategoria
            // 
            LProductoCategoria.AutoSize = true;
            LProductoCategoria.Font = new Font("Century Gothic", 12F);
            LProductoCategoria.ForeColor = SystemColors.ButtonHighlight;
            LProductoCategoria.Location = new Point(74, 191);
            LProductoCategoria.Name = "LProductoCategoria";
            LProductoCategoria.Size = new Size(95, 21);
            LProductoCategoria.TabIndex = 6;
            LProductoCategoria.Text = "Categoría:";
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Font = new Font("Century Gothic", 12F);
            LStock.ForeColor = SystemColors.ButtonHighlight;
            LStock.Location = new Point(492, 121);
            LStock.Name = "LStock";
            LStock.Size = new Size(115, 21);
            LStock.TabIndex = 7;
            LStock.Text = "Stock Actual:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(192, 86);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(252, 23);
            txtNombreProducto.TabIndex = 8;
            txtNombreProducto.KeyPress += txtNombreProducto_KeyPress;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(192, 119);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(252, 23);
            txtDescripcionProducto.TabIndex = 9;
            txtDescripcionProducto.KeyPress += txtDescripcionProducto_KeyPress;
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(192, 191);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(252, 23);
            CBCategoria.TabIndex = 12;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(627, 84);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(252, 23);
            txtPrecioProducto.TabIndex = 13;
            txtPrecioProducto.KeyPress += txtPrecioProducto_KeyPress;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(627, 119);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(252, 23);
            txtStockProducto.TabIndex = 14;
            txtStockProducto.KeyPress += txtStockProducto_KeyPress;
            // 
            // pbProducto
            // 
            pbProducto.Image = Properties.Resources.shopping;
            pbProducto.Location = new Point(885, 31);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(176, 206);
            pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbProducto.TabIndex = 18;
            pbProducto.TabStop = false;
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(492, 156);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(115, 23);
            btnImagen.TabIndex = 19;
            btnImagen.Text = "Imagen";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // txtImagenUrl
            // 
            txtImagenUrl.Enabled = false;
            txtImagenUrl.Location = new Point(627, 156);
            txtImagenUrl.Name = "txtImagenUrl";
            txtImagenUrl.Size = new Size(252, 23);
            txtImagenUrl.TabIndex = 20;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(568, 192);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 23);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkOrange;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(780, 192);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 23);
            btnEditar.TabIndex = 31;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(780, 192);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 23);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 80, 200);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = SystemColors.Control;
            btnConfirmar.Location = new Point(675, 192);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(99, 23);
            btnConfirmar.TabIndex = 29;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(0, 80, 200);
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = SystemColors.Control;
            btnCrear.Location = new Point(675, 192);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(99, 23);
            btnCrear.TabIndex = 28;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // CBMarca
            // 
            CBMarca.FormattingEnabled = true;
            CBMarca.Location = new Point(192, 157);
            CBMarca.Name = "CBMarca";
            CBMarca.Size = new Size(252, 23);
            CBMarca.TabIndex = 33;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1073, 537);
            Controls.Add(CBMarca);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCrear);
            Controls.Add(txtImagenUrl);
            Controls.Add(btnImagen);
            Controls.Add(pbProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(CBCategoria);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(LStock);
            Controls.Add(LProductoCategoria);
            Controls.Add(LProductoMarca);
            Controls.Add(LPrecio);
            Controls.Add(LProductoDescripcion);
            Controls.Add(LNombreProducto);
            Controls.Add(dvgProductos);
            Controls.Add(LGestionProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProducto";
            Text = "Productos";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LGestionProductos;
        private DataGridView dvgProductos;
        private Label LNombreProducto;
        private Label LProductoDescripcion;
        private Label LPrecio;
        private Label LProductoMarca;
        private Label LProductoCategoria;
        private Label LStock;
        private TextBox txtNombreProducto;
        private TextBox txtDescripcionProducto;
        private ComboBox CBCategoria;
        private TextBox txtPrecioProducto;
        private TextBox txtStockProducto;
        private PictureBox pbProducto;
        private Button btnImagen;
        private TextBox txtImagenUrl;
        private DataGridViewTextBoxColumn ProductoId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn MarcaId;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn CategoriaId;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn ImagenUrl;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnCrear;
        private ComboBox CBMarca;
    }
}