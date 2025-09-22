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
            dataGridView1 = new DataGridView();
            LNombreProducto = new Label();
            LProductoDescripcion = new Label();
            label2 = new Label();
            LProductoMarca = new Label();
            LProductoCategoria = new Label();
            label1 = new Label();
            txtNombreProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            txtMarcaProducto = new TextBox();
            CBCategoria = new ComboBox();
            txtPrecioProducto = new TextBox();
            txtStockProducto = new TextBox();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            btnGuardarProducto = new Button();
            pictureBoxProducto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(805, 213);
            dataGridView1.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(492, 84);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 4;
            label2.Text = "Precio Unitario:";
            label2.Click += label2_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(492, 121);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 7;
            label1.Text = "Stock Actual:";
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
            btnEditarProducto.Location = new Point(648, 185);
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
            btnEliminarProducto.Location = new Point(492, 185);
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
            btnGuardarProducto.Location = new Point(791, 183);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(88, 31);
            btnGuardarProducto.TabIndex = 17;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Image = Properties.Resources.shopping;
            pictureBoxProducto.Location = new Point(910, 72);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(151, 142);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxProducto.TabIndex = 18;
            pictureBoxProducto.TabStop = false;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1073, 537);
            Controls.Add(pictureBoxProducto);
            Controls.Add(btnGuardarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(CBCategoria);
            Controls.Add(txtMarcaProducto);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Controls.Add(LProductoCategoria);
            Controls.Add(LProductoMarca);
            Controls.Add(label2);
            Controls.Add(LProductoDescripcion);
            Controls.Add(LNombreProducto);
            Controls.Add(dataGridView1);
            Controls.Add(LGestionProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProducto";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LGestionProductos;
        private DataGridView dataGridView1;
        private Label LNombreProducto;
        private Label LProductoDescripcion;
        private Label label2;
        private Label LProductoMarca;
        private Label LProductoCategoria;
        private Label label1;
        private TextBox txtNombreProducto;
        private TextBox txtDescripcionProducto;
        private TextBox txtMarcaProducto;
        private ComboBox CBCategoria;
        private TextBox txtPrecioProducto;
        private TextBox txtStockProducto;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
        private Button btnGuardarProducto;
        private PictureBox pictureBoxProducto;
    }
}