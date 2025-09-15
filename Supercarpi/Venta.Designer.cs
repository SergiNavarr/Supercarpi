namespace Interfaz
{
    partial class Venta
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
            dataGridView1.Location = new Point(14, 121);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1440, 487);
            dataGridView1.TabIndex = 0;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(19, 659);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(64, 20);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(85, 655);
            TBNombre.Margin = new Padding(3, 4, 3, 4);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(229, 27);
            TBNombre.TabIndex = 2;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.Location = new Point(610, 43);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(280, 40);
            LTitulo.TabIndex = 3;
            LTitulo.Text = "Panel de ventas";
            // 
            // LCodigo
            // 
            LCodigo.AutoSize = true;
            LCodigo.Location = new Point(26, 716);
            LCodigo.Name = "LCodigo";
            LCodigo.Size = new Size(58, 20);
            LCodigo.TabIndex = 4;
            LCodigo.Text = "Codigo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 712);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.FromArgb(26, 32, 40);
            BtnBuscar.Location = new Point(345, 653);
            BtnBuscar.Margin = new Padding(3, 4, 3, 4);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(113, 31);
            BtnBuscar.TabIndex = 6;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnGenerarVenta
            // 
            BtnGenerarVenta.BackColor = Color.FromArgb(26, 32, 40);
            BtnGenerarVenta.Location = new Point(1210, 617);
            BtnGenerarVenta.Margin = new Padding(3, 4, 3, 4);
            BtnGenerarVenta.Name = "BtnGenerarVenta";
            BtnGenerarVenta.Size = new Size(243, 105);
            BtnGenerarVenta.TabIndex = 7;
            BtnGenerarVenta.Text = "Generar Venta";
            BtnGenerarVenta.UseVisualStyleBackColor = false;
            BtnGenerarVenta.Click += BtnGenerarVenta_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Red;
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(961, 616);
            BtnLimpiar.Margin = new Padding(3, 4, 3, 4);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(242, 105);
            BtnLimpiar.TabIndex = 8;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // LTotal
            // 
            LTotal.AutoSize = true;
            LTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTotal.Location = new Point(1283, 747);
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(188, 41);
            LTotal.TabIndex = 9;
            LTotal.Text = "TOTAL: $0.00";
            // 
            // LItems
            // 
            LItems.AutoSize = true;
            LItems.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LItems.Location = new Point(1134, 747);
            LItems.Name = "LItems";
            LItems.Size = new Size(131, 41);
            LItems.TabIndex = 10;
            LItems.Text = "ITEMS: 0";
            // 
            // CBMetodoPago
            // 
            CBMetodoPago.FormattingEnabled = true;
            CBMetodoPago.Location = new Point(714, 655);
            CBMetodoPago.Margin = new Padding(3, 4, 3, 4);
            CBMetodoPago.Name = "CBMetodoPago";
            CBMetodoPago.Size = new Size(186, 28);
            CBMetodoPago.TabIndex = 11;
            // 
            // LMetodoPago
            // 
            LMetodoPago.AutoSize = true;
            LMetodoPago.Location = new Point(757, 631);
            LMetodoPago.Name = "LMetodoPago";
            LMetodoPago.Size = new Size(120, 20);
            LMetodoPago.TabIndex = 12;
            LMetodoPago.Text = "Metodo de Pago";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(26, 32, 40);
            BtnAgregar.Location = new Point(345, 711);
            BtnAgregar.Margin = new Padding(3, 4, 3, 4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(113, 31);
            BtnAgregar.TabIndex = 13;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1467, 815);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Venta";
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