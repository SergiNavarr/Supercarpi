namespace Interfaz
{
    partial class FormReportes
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
            label1 = new Label();
            LSeleccion = new Label();
            panelFechas = new Panel();
            cbTipoGrafico = new ComboBox();
            lTipoReporte = new Label();
            label2 = new Label();
            btnGenerar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            LHasta = new Label();
            LDesde = new Label();
            txtEmpleadoId = new TextBox();
            lblTotalVentas = new Label();
            lblRecaudacion = new Label();
            lblProducto = new Label();
            lblMetodoPago = new Label();
            panelGrafico = new Panel();
            lCaja = new Label();
            cbCaja = new ComboBox();
            panelFechas.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(296, 34);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Reportes ";
            // 
            // LSeleccion
            // 
            LSeleccion.AutoSize = true;
            LSeleccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LSeleccion.ForeColor = SystemColors.ButtonHighlight;
            LSeleccion.Location = new Point(16, 13);
            LSeleccion.Name = "LSeleccion";
            LSeleccion.Size = new Size(166, 21);
            LSeleccion.TabIndex = 1;
            LSeleccion.Text = "Seleccione la fecha:";
            // 
            // panelFechas
            // 
            panelFechas.BackColor = Color.Teal;
            panelFechas.Controls.Add(cbCaja);
            panelFechas.Controls.Add(lCaja);
            panelFechas.Controls.Add(cbTipoGrafico);
            panelFechas.Controls.Add(lTipoReporte);
            panelFechas.Controls.Add(label2);
            panelFechas.Controls.Add(btnGenerar);
            panelFechas.Controls.Add(dtpHasta);
            panelFechas.Controls.Add(dtpDesde);
            panelFechas.Controls.Add(LHasta);
            panelFechas.Controls.Add(LDesde);
            panelFechas.Controls.Add(LSeleccion);
            panelFechas.Location = new Point(43, 73);
            panelFechas.Name = "panelFechas";
            panelFechas.Size = new Size(783, 127);
            panelFechas.TabIndex = 2;
            // 
            // cbTipoGrafico
            // 
            cbTipoGrafico.FormattingEnabled = true;
            cbTipoGrafico.Location = new Point(166, 94);
            cbTipoGrafico.Name = "cbTipoGrafico";
            cbTipoGrafico.Size = new Size(121, 23);
            cbTipoGrafico.TabIndex = 9;
            // 
            // lTipoReporte
            // 
            lTipoReporte.AutoSize = true;
            lTipoReporte.Font = new Font("Century Gothic", 12F);
            lTipoReporte.ForeColor = SystemColors.ButtonHighlight;
            lTipoReporte.Location = new Point(28, 94);
            lTipoReporte.Name = "lTipoReporte";
            lTipoReporte.Size = new Size(142, 21);
            lTipoReporte.TabIndex = 8;
            lTipoReporte.Text = "Tipo de Reporte: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(233, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 7;
            label2.Text = "Desde:";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(0, 80, 200);
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Century Gothic", 9.75F);
            btnGenerar.ForeColor = SystemColors.ButtonHighlight;
            btnGenerar.Location = new Point(300, 93);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(293, 54);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(82, 23);
            dtpHasta.TabIndex = 5;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(97, 54);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(84, 23);
            dtpDesde.TabIndex = 4;
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LHasta.ForeColor = SystemColors.ButtonHighlight;
            LHasta.Location = new Point(227, 54);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(60, 21);
            LHasta.TabIndex = 3;
            LHasta.Text = "Hasta:";
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LDesde.ForeColor = SystemColors.ButtonHighlight;
            LDesde.Location = new Point(28, 55);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(63, 21);
            LDesde.TabIndex = 2;
            LDesde.Text = "Desde:";
            // 
            // txtEmpleadoId
            // 
            txtEmpleadoId.Location = new Point(345, 44);
            txtEmpleadoId.Name = "txtEmpleadoId";
            txtEmpleadoId.Size = new Size(100, 23);
            txtEmpleadoId.TabIndex = 35;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Century Gothic", 9.75F);
            lblTotalVentas.ForeColor = SystemColors.ButtonHighlight;
            lblTotalVentas.Location = new Point(43, 245);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(95, 17);
            lblTotalVentas.TabIndex = 36;
            lblTotalVentas.Text = "Total Ventas: ";
            // 
            // lblRecaudacion
            // 
            lblRecaudacion.AutoSize = true;
            lblRecaudacion.Font = new Font("Century Gothic", 9.75F);
            lblRecaudacion.ForeColor = SystemColors.ButtonHighlight;
            lblRecaudacion.Location = new Point(43, 277);
            lblRecaudacion.Name = "lblRecaudacion";
            lblRecaudacion.Size = new Size(138, 17);
            lblRecaudacion.TabIndex = 37;
            lblRecaudacion.Text = "Total Recaudacion: ";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Century Gothic", 9.75F);
            lblProducto.ForeColor = SystemColors.ButtonHighlight;
            lblProducto.Location = new Point(43, 347);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(165, 17);
            lblProducto.TabIndex = 38;
            lblProducto.Text = "Producto mas vendido: ";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Century Gothic", 9.75F);
            lblMetodoPago.ForeColor = SystemColors.ButtonHighlight;
            lblMetodoPago.Location = new Point(43, 309);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(217, 17);
            lblMetodoPago.TabIndex = 39;
            lblMetodoPago.Text = "Metodo de Pago mas utilizado: ";
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(358, 218);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(468, 279);
            panelGrafico.TabIndex = 40;
            // 
            // lCaja
            // 
            lCaja.AutoSize = true;
            lCaja.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lCaja.ForeColor = SystemColors.ButtonHighlight;
            lCaja.Location = new Point(417, 94);
            lCaja.Name = "lCaja";
            lCaja.Size = new Size(161, 21);
            lCaja.TabIndex = 10;
            lCaja.Text = "Caja seleccionada:";
            lCaja.Click += label4_Click;
            // 
            // cbCaja
            // 
            cbCaja.FormattingEnabled = true;
            cbCaja.Location = new Point(584, 94);
            cbCaja.Name = "cbCaja";
            cbCaja.Size = new Size(121, 23);
            cbCaja.TabIndex = 11;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(838, 509);
            Controls.Add(panelGrafico);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblProducto);
            Controls.Add(lblRecaudacion);
            Controls.Add(lblTotalVentas);
            Controls.Add(txtEmpleadoId);
            Controls.Add(label1);
            Controls.Add(panelFechas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportes";
            Load += FormReportes_Load;
            panelFechas.ResumeLayout(false);
            panelFechas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LSeleccion;
        private Panel panelFechas;
        private Label LHasta;
        private Label LDesde;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnGenerar;
        private TextBox txtEmpleadoId;
        private Label label2;
        private Label lblTotalVentas;
        private Label lblRecaudacion;
        private Label lblProducto;
        private Label lblMetodoPago;
        private ComboBox cbTipoGrafico;
        private Label lTipoReporte;
        private Panel panelGrafico;
        private Label lCaja;
        private ComboBox cbCaja;
    }
}