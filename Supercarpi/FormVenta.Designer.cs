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
            dataGridView1 = new DataGridView();
            LNombre = new Label();
            TBNombre = new TextBox();
            LTitulo = new Label();
            LCodigo = new Label();
            textBox1 = new TextBox();
            BtnBuscar = new Button();
            BtnGenerarVenta = new Button();
            BtnLimpiar = new Button();
            LTotal = new Label();
            LItems = new Label();
            CBMetodoPago = new ComboBox();
            LMetodoPago = new Label();
            BtnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1025, 365);
            dataGridView1.TabIndex = 0;
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
            LCodigo.Click += LCodigo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 487);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.FromArgb(0, 80, 200);
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(302, 443);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(99, 23);
            BtnBuscar.TabIndex = 6;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnGenerarVenta
            // 
            BtnGenerarVenta.BackColor = Color.FromArgb(0, 80, 200);
            BtnGenerarVenta.Cursor = Cursors.Hand;
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
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregar.Location = new Point(302, 486);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(99, 23);
            BtnAgregar.TabIndex = 13;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1089, 576);
            Controls.Add(BtnAgregar);
            Controls.Add(LMetodoPago);
            Controls.Add(CBMetodoPago);
            Controls.Add(LItems);
            Controls.Add(LTotal);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnGenerarVenta);
            Controls.Add(BtnBuscar);
            Controls.Add(textBox1);
            Controls.Add(LCodigo);
            Controls.Add(LTitulo);
            Controls.Add(TBNombre);
            Controls.Add(LNombre);
            Controls.Add(dataGridView1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVenta";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label LNombre;
        private TextBox TBNombre;
        private Label LTitulo;
        private Label LCodigo;
        private TextBox textBox1;
        private Button BtnBuscar;
        private Button BtnGenerarVenta;
        private Button BtnLimpiar;
        private Label LTotal;
        private Label LItems;
        private ComboBox CBMetodoPago;
        private Label LMetodoPago;
        private Button BtnAgregar;
    }
}