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
            LDesde = new Label();
            label3 = new Label();
            LHasta = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnRuta = new Button();
            button1 = new Button();
            button2 = new Button();
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
            panelFechas.Controls.Add(dateTimePicker2);
            panelFechas.Controls.Add(dateTimePicker1);
            panelFechas.Controls.Add(LHasta);
            panelFechas.Controls.Add(LDesde);
            panelFechas.Controls.Add(LSeleccion);
            panelFechas.Location = new Point(73, 99);
            panelFechas.Name = "panelFechas";
            panelFechas.Size = new Size(528, 100);
            panelFechas.TabIndex = 2;
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LDesde.ForeColor = SystemColors.ButtonHighlight;
            LDesde.Location = new Point(88, 56);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(63, 21);
            LDesde.TabIndex = 2;
            LDesde.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(89, 224);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 3;
            label3.Text = "Generar Reporte por:";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LHasta.ForeColor = SystemColors.ButtonHighlight;
            LHasta.Location = new Point(323, 55);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(60, 21);
            LHasta.TabIndex = 3;
            LHasta.Text = "Hasta:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(157, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(84, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(389, 55);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(82, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // btnRuta
            // 
            btnRuta.BackColor = Color.FromArgb(0, 80, 200);
            btnRuta.Cursor = Cursors.Hand;
            btnRuta.FlatAppearance.BorderSize = 0;
            btnRuta.FlatStyle = FlatStyle.Flat;
            btnRuta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRuta.ForeColor = SystemColors.ButtonHighlight;
            btnRuta.Location = new Point(502, 283);
            btnRuta.Name = "btnRuta";
            btnRuta.Size = new Size(168, 27);
            btnRuta.TabIndex = 32;
            btnRuta.Text = "Recaudacion por Caja";
            btnRuta.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 80, 200);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(274, 283);
            button1.Name = "button1";
            button1.Size = new Size(182, 27);
            button1.TabIndex = 33;
            button1.Text = "Productos más vendidos";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 80, 200);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(89, 283);
            button2.Name = "button2";
            button2.Size = new Size(135, 27);
            button2.TabIndex = 34;
            button2.Text = "Total de Ventas";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRuta);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panelFechas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportes";
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
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnRuta;
        private Button button1;
        private Button button2;
    }
}