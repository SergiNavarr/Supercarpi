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
            panelFechas = new Panel();
            cbCaja = new ComboBox();
            lCaja = new Label();
            cbTipoGrafico = new ComboBox();
            lTipoReporte = new Label();
            btnGenerar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            LHasta = new Label();
            LDesde = new Label();
            panelGrafico = new Panel();
            lstLeyenda = new ListBox();
            dgvResumenGeneral = new DataGridView();
            Total_Ventas = new DataGridViewTextBoxColumn();
            Total_Recaudacion = new DataGridViewTextBoxColumn();
            Metodo_pago_mas_usado = new DataGridViewTextBoxColumn();
            Producto_mas_vendido = new DataGridViewTextBoxColumn();
            dgvResumenCajas = new DataGridView();
            nro_caja = new DataGridViewTextBoxColumn();
            Monto_total = new DataGridViewTextBoxColumn();
            Metodo_mas_usado = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            panelFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenGeneral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumenCajas).BeginInit();
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
            // panelFechas
            // 
            panelFechas.BackColor = Color.Teal;
            panelFechas.Controls.Add(cbCaja);
            panelFechas.Controls.Add(lCaja);
            panelFechas.Controls.Add(cbTipoGrafico);
            panelFechas.Controls.Add(lTipoReporte);
            panelFechas.Controls.Add(btnGenerar);
            panelFechas.Controls.Add(dtpHasta);
            panelFechas.Controls.Add(dtpDesde);
            panelFechas.Controls.Add(LHasta);
            panelFechas.Controls.Add(LDesde);
            panelFechas.Location = new Point(43, 70);
            panelFechas.Name = "panelFechas";
            panelFechas.Size = new Size(783, 130);
            panelFechas.TabIndex = 2;
            // 
            // cbCaja
            // 
            cbCaja.FormattingEnabled = true;
            cbCaja.Location = new Point(572, 21);
            cbCaja.Name = "cbCaja";
            cbCaja.Size = new Size(121, 23);
            cbCaja.TabIndex = 11;
            // 
            // lCaja
            // 
            lCaja.AutoSize = true;
            lCaja.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lCaja.ForeColor = SystemColors.ButtonHighlight;
            lCaja.Location = new Point(405, 25);
            lCaja.Name = "lCaja";
            lCaja.Size = new Size(161, 21);
            lCaja.TabIndex = 10;
            lCaja.Text = "Caja seleccionada:";
            lCaja.Click += label4_Click;
            // 
            // cbTipoGrafico
            // 
            cbTipoGrafico.FormattingEnabled = true;
            cbTipoGrafico.Location = new Point(168, 86);
            cbTipoGrafico.Name = "cbTipoGrafico";
            cbTipoGrafico.Size = new Size(178, 23);
            cbTipoGrafico.TabIndex = 9;
            // 
            // lTipoReporte
            // 
            lTipoReporte.AutoSize = true;
            lTipoReporte.Font = new Font("Century Gothic", 12F);
            lTipoReporte.ForeColor = SystemColors.ButtonHighlight;
            lTipoReporte.Location = new Point(28, 88);
            lTipoReporte.Name = "lTipoReporte";
            lTipoReporte.Size = new Size(142, 21);
            lTipoReporte.TabIndex = 8;
            lTipoReporte.Text = "Tipo de Reporte: ";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(0, 80, 200);
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Century Gothic", 9.75F);
            btnGenerar.ForeColor = SystemColors.ButtonHighlight;
            btnGenerar.Location = new Point(370, 80);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(114, 32);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(264, 22);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(82, 23);
            dtpHasta.TabIndex = 5;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(97, 23);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(84, 23);
            dtpDesde.TabIndex = 4;
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LHasta.ForeColor = SystemColors.ButtonHighlight;
            LHasta.Location = new Point(198, 25);
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
            LDesde.Location = new Point(28, 23);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(63, 21);
            LDesde.TabIndex = 2;
            LDesde.Text = "Desde:";
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(448, 218);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(433, 279);
            panelGrafico.TabIndex = 40;
            // 
            // lstLeyenda
            // 
            lstLeyenda.FormattingEnabled = true;
            lstLeyenda.ItemHeight = 15;
            lstLeyenda.Location = new Point(887, 218);
            lstLeyenda.Name = "lstLeyenda";
            lstLeyenda.Size = new Size(151, 139);
            lstLeyenda.TabIndex = 41;
            // 
            // dgvResumenGeneral
            // 
            dgvResumenGeneral.AllowUserToOrderColumns = true;
            dgvResumenGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenGeneral.Columns.AddRange(new DataGridViewColumn[] { Total_Ventas, Total_Recaudacion, Metodo_pago_mas_usado, Producto_mas_vendido });
            dgvResumenGeneral.Location = new Point(40, 243);
            dgvResumenGeneral.Name = "dgvResumenGeneral";
            dgvResumenGeneral.Size = new Size(402, 109);
            dgvResumenGeneral.TabIndex = 42;
            // 
            // Total_Ventas
            // 
            Total_Ventas.HeaderText = "Total de Ventas";
            Total_Ventas.Name = "Total_Ventas";
            // 
            // Total_Recaudacion
            // 
            Total_Recaudacion.HeaderText = "Recaudacion Total";
            Total_Recaudacion.Name = "Total_Recaudacion";
            // 
            // Metodo_pago_mas_usado
            // 
            Metodo_pago_mas_usado.HeaderText = "Metodo de pago mas usado";
            Metodo_pago_mas_usado.Name = "Metodo_pago_mas_usado";
            // 
            // Producto_mas_vendido
            // 
            Producto_mas_vendido.HeaderText = "Producto más Vendido";
            Producto_mas_vendido.Name = "Producto_mas_vendido";
            // 
            // dgvResumenCajas
            // 
            dgvResumenCajas.AllowUserToOrderColumns = true;
            dgvResumenCajas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResumenCajas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenCajas.Columns.AddRange(new DataGridViewColumn[] { nro_caja, Monto_total, Metodo_mas_usado });
            dgvResumenCajas.Location = new Point(40, 394);
            dgvResumenCajas.Name = "dgvResumenCajas";
            dgvResumenCajas.Size = new Size(402, 103);
            dgvResumenCajas.TabIndex = 43;
            // 
            // nro_caja
            // 
            nro_caja.HeaderText = "Caja Número";
            nro_caja.Name = "nro_caja";
            // 
            // Monto_total
            // 
            Monto_total.HeaderText = "Arqueo de caja";
            Monto_total.Name = "Monto_total";
            // 
            // Metodo_mas_usado
            // 
            Metodo_mas_usado.HeaderText = "Metodo de pago más usado";
            Metodo_mas_usado.Name = "Metodo_mas_usado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(43, 223);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 44;
            label2.Text = "Resumen General:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(42, 371);
            label3.Name = "label3";
            label3.Size = new Size(132, 17);
            label3.TabIndex = 45;
            label3.Text = "Resumen de Cajas:";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1050, 509);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvResumenCajas);
            Controls.Add(dgvResumenGeneral);
            Controls.Add(lstLeyenda);
            Controls.Add(panelGrafico);
            Controls.Add(label1);
            Controls.Add(panelFechas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportes";
            Load += FormReportes_Load;
            panelFechas.ResumeLayout(false);
            panelFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenGeneral).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumenCajas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panelFechas;
        private Label LHasta;
        private Label LDesde;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnGenerar;
        private ComboBox cbTipoGrafico;
        private Label lTipoReporte;
        private Panel panelGrafico;
        private Label lCaja;
        private ComboBox cbCaja;
        private ListBox lstLeyenda;
        private DataGridView dgvResumenGeneral;
        private DataGridView dgvResumenCajas;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Total_Ventas;
        private DataGridViewTextBoxColumn Total_Recaudacion;
        private DataGridViewTextBoxColumn Metodo_pago_mas_usado;
        private DataGridViewTextBoxColumn Producto_mas_vendido;
        private DataGridViewTextBoxColumn nro_caja;
        private DataGridViewTextBoxColumn Monto_total;
        private DataGridViewTextBoxColumn Metodo_mas_usado;
    }
}