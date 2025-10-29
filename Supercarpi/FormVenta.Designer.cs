namespace Interfaz
{
    partial class FormVenta
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
            dgvVenta = new DataGridView();
            ProductoId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            LNombre = new Label();
            TBNombre = new TextBox();
            LTitulo = new Label();
            LCodigo = new Label();
            TBCodigo = new TextBox();
            BtnBuscar = new Button();
            BtnGenerarVenta = new Button();
            BtnLimpiar = new Button();
            LTotal = new Label();
            LItems = new Label();
            CBMetodoPago = new ComboBox();
            LMetodoPago = new Label();
            BtnAgregar = new Button();
            BtnAbrirCaja = new Button();
            BtnCerrarCaja = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // dgvVenta
            // 
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Columns.AddRange(new DataGridViewColumn[] { ProductoId, Nombre, PrecioUnitario, Cantidad, Subtotal });
            dgvVenta.Enabled = false;
            dgvVenta.Location = new Point(12, 44);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(1025, 365);
            dgvVenta.TabIndex = 0;
            // 
            // ProductoId
            // 
            ProductoId.DataPropertyName = "ProductoId";
            ProductoId.HeaderText = "Codigo";
            ProductoId.MinimumWidth = 6;
            ProductoId.Name = "ProductoId";
            ProductoId.Resizable = DataGridViewTriState.True;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Producto.Nombre";
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombre.Location = new Point(12, 450);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(59, 16);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // TBNombre
            // 
            TBNombre.Enabled = false;
            TBNombre.Location = new Point(74, 444);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(201, 23);
            TBNombre.TabIndex = 2;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.Location = new Point(460, 9);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(223, 32);
            LTitulo.TabIndex = 3;
            LTitulo.Text = "Panel de ventas";
            // 
            // LCodigo
            // 
            LCodigo.AutoSize = true;
            LCodigo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LCodigo.Location = new Point(12, 489);
            LCodigo.Name = "LCodigo";
            LCodigo.Size = new Size(55, 16);
            LCodigo.TabIndex = 4;
            LCodigo.Text = "Codigo";
            // 
            // TBCodigo
            // 
            TBCodigo.Enabled = false;
            TBCodigo.Location = new Point(74, 487);
            TBCodigo.Name = "TBCodigo";
            TBCodigo.Size = new Size(201, 23);
            TBCodigo.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.FromArgb(0, 80, 200);
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.Enabled = false;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(302, 443);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(99, 23);
            BtnBuscar.TabIndex = 6;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnGenerarVenta
            // 
            BtnGenerarVenta.BackColor = Color.FromArgb(0, 80, 200);
            BtnGenerarVenta.Cursor = Cursors.Hand;
            BtnGenerarVenta.Enabled = false;
            BtnGenerarVenta.FlatAppearance.BorderSize = 0;
            BtnGenerarVenta.FlatStyle = FlatStyle.Flat;
            BtnGenerarVenta.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGenerarVenta.Location = new Point(824, 425);
            BtnGenerarVenta.Name = "BtnGenerarVenta";
            BtnGenerarVenta.Size = new Size(213, 79);
            BtnGenerarVenta.TabIndex = 7;
            BtnGenerarVenta.Text = "Generar Venta";
            BtnGenerarVenta.UseVisualStyleBackColor = false;
            BtnGenerarVenta.Click += BtnGenerarVenta_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Red;
            BtnLimpiar.Cursor = Cursors.Hand;
            BtnLimpiar.Enabled = false;
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(606, 424);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(212, 79);
            BtnLimpiar.TabIndex = 8;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // LTotal
            // 
            LTotal.AutoSize = true;
            LTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTotal.Location = new Point(888, 523);
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(149, 32);
            LTotal.TabIndex = 9;
            LTotal.Text = "TOTAL: $0.00";
            // 
            // LItems
            // 
            LItems.AutoSize = true;
            LItems.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LItems.Location = new Point(757, 523);
            LItems.Name = "LItems";
            LItems.Size = new Size(105, 32);
            LItems.TabIndex = 10;
            LItems.Text = "ITEMS: 0";
            // 
            // CBMetodoPago
            // 
            CBMetodoPago.Enabled = false;
            CBMetodoPago.FormattingEnabled = true;
            CBMetodoPago.Location = new Point(423, 452);
            CBMetodoPago.Name = "CBMetodoPago";
            CBMetodoPago.Size = new Size(163, 23);
            CBMetodoPago.TabIndex = 11;
            // 
            // LMetodoPago
            // 
            LMetodoPago.AutoSize = true;
            LMetodoPago.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LMetodoPago.Location = new Point(437, 429);
            LMetodoPago.Name = "LMetodoPago";
            LMetodoPago.Size = new Size(136, 20);
            LMetodoPago.TabIndex = 12;
            LMetodoPago.Text = "Metodo de Pago";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(0, 80, 200);
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.Enabled = false;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregar.Location = new Point(302, 486);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(99, 23);
            BtnAgregar.TabIndex = 13;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnAbrirCaja
            // 
            BtnAbrirCaja.BackColor = Color.FromArgb(0, 80, 200);
            BtnAbrirCaja.Cursor = Cursors.Hand;
            BtnAbrirCaja.FlatAppearance.BorderSize = 0;
            BtnAbrirCaja.FlatStyle = FlatStyle.Flat;
            BtnAbrirCaja.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAbrirCaja.Location = new Point(23, 524);
            BtnAbrirCaja.Name = "BtnAbrirCaja";
            BtnAbrirCaja.Size = new Size(202, 43);
            BtnAbrirCaja.TabIndex = 14;
            BtnAbrirCaja.Text = "Abrir Caja";
            BtnAbrirCaja.UseVisualStyleBackColor = false;
            BtnAbrirCaja.Click += BtnAbrirCaja_Click;
            // 
            // BtnCerrarCaja
            // 
            BtnCerrarCaja.BackColor = Color.Red;
            BtnCerrarCaja.Cursor = Cursors.Hand;
            BtnCerrarCaja.FlatAppearance.BorderSize = 0;
            BtnCerrarCaja.FlatStyle = FlatStyle.Flat;
            BtnCerrarCaja.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarCaja.Location = new Point(23, 524);
            BtnCerrarCaja.Name = "BtnCerrarCaja";
            BtnCerrarCaja.Size = new Size(202, 43);
            BtnCerrarCaja.TabIndex = 15;
            BtnCerrarCaja.Text = "Cerrar caja";
            BtnCerrarCaja.UseVisualStyleBackColor = false;
            BtnCerrarCaja.Visible = false;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1089, 576);
            Controls.Add(BtnCerrarCaja);
            Controls.Add(BtnAbrirCaja);
            Controls.Add(BtnAgregar);
            Controls.Add(LMetodoPago);
            Controls.Add(CBMetodoPago);
            Controls.Add(LItems);
            Controls.Add(LTotal);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnGenerarVenta);
            Controls.Add(BtnBuscar);
            Controls.Add(TBCodigo);
            Controls.Add(LCodigo);
            Controls.Add(LTitulo);
            Controls.Add(TBNombre);
            Controls.Add(LNombre);
            Controls.Add(dgvVenta);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVenta";
            Text = "Form2";
            Load += FormVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVenta;
        private Label LNombre;
        private TextBox TBNombre;
        private Label LTitulo;
        private Label LCodigo;
        private TextBox TBCodigo;
        private Button BtnBuscar;
        private Button BtnGenerarVenta;
        private Button BtnLimpiar;
        private Label LTotal;
        private Label LItems;
        private ComboBox CBMetodoPago;
        private Label LMetodoPago;
        private Button BtnAgregar;
        private Button BtnAbrirCaja;
        private Button BtnCerrarCaja;
        private DataGridViewTextBoxColumn ProductoId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}