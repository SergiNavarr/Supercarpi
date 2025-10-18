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
            LNombreProducto = new Label();
            LProductoDescripcion = new Label();
            LPrecio = new Label();
            LProductoMarca = new Label();
            LProductoCategoria = new Label();
            LStock = new Label();
            txtNombreProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            txtMarcaProducto = new TextBox();
            CBCategoria = new ComboBox();
            txtPrecioProducto = new TextBox();
            txtStockProducto = new TextBox();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            btnGuardarProducto = new Button();
            pbProducto = new PictureBox();
            btnImagen = new Button();
            txtUrlImagen = new TextBox();
            ProductoId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            StockActual = new DataGridViewTextBoxColumn();
            MarcaId = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            CategoriaId = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            ImagenUrl = new DataGridViewTextBoxColumn();
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
            dvgProductos.Columns.AddRange(new DataGridViewColumn[] { ProductoId, Nombre, Descripcion, PrecioUnitario, StockActual, MarcaId, Marca, CategoriaId, Categoria, ImagenUrl });
            dvgProductos.Location = new Point(74, 277);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.Size = new Size(949, 213);
            dvgProductos.TabIndex = 1;
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
            // txtMarcaProducto
            // 
            txtMarcaProducto.Location = new Point(192, 156);
            txtMarcaProducto.Name = "txtMarcaProducto";
            txtMarcaProducto.Size = new Size(252, 23);
            txtMarcaProducto.TabIndex = 10;
            txtMarcaProducto.KeyPress += txtMarcaProducto_KeyPress;
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
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.FromArgb(0, 80, 200);
            btnEditarProducto.FlatAppearance.BorderColor = Color.FromArgb(0, 80, 200);
            btnEditarProducto.FlatStyle = FlatStyle.Flat;
            btnEditarProducto.Font = new Font("Century Gothic", 11.25F);
            btnEditarProducto.ForeColor = SystemColors.Control;
            btnEditarProducto.Location = new Point(646, 202);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(88, 31);
            btnEditarProducto.TabIndex = 15;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Red;
            btnEliminarProducto.FlatAppearance.BorderColor = Color.Red;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Century Gothic", 11.25F);
            btnEliminarProducto.ForeColor = SystemColors.Control;
            btnEliminarProducto.Location = new Point(492, 202);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(88, 31);
            btnEliminarProducto.TabIndex = 16;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.ForestGreen;
            btnGuardarProducto.FlatAppearance.BorderColor = Color.FromArgb(0, 80, 200);
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Century Gothic", 11.25F);
            btnGuardarProducto.ForeColor = SystemColors.Control;
            btnGuardarProducto.Location = new Point(791, 202);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(88, 31);
            btnGuardarProducto.TabIndex = 17;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // pbProducto
            // 
            pbProducto.Image = Properties.Resources.shopping;
            pbProducto.Location = new Point(910, 72);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(151, 142);
            pbProducto.SizeMode = PictureBoxSizeMode.CenterImage;
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
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(627, 156);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new Size(252, 23);
            txtUrlImagen.TabIndex = 20;
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
            // StockActual
            // 
            StockActual.HeaderText = "Stock";
            StockActual.MinimumWidth = 6;
            StockActual.Name = "StockActual";
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
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1073, 537);
            Controls.Add(txtUrlImagen);
            Controls.Add(btnImagen);
            Controls.Add(pbProducto);
            Controls.Add(btnGuardarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(CBCategoria);
            Controls.Add(txtMarcaProducto);
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
        private TextBox txtMarcaProducto;
        private ComboBox CBCategoria;
        private TextBox txtPrecioProducto;
        private TextBox txtStockProducto;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
        private Button btnGuardarProducto;
        private PictureBox pbProducto;
        private Button btnImagen;
        private TextBox txtUrlImagen;
        private DataGridViewTextBoxColumn ProductoId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn StockActual;
        private DataGridViewTextBoxColumn MarcaId;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn CategoriaId;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn ImagenUrl;
    }
}