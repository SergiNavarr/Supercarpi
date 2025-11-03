namespace Interfaz
{
    partial class FormSeleccionCaja
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitulo = new Label();
            dgvCajas = new DataGridView();
            CajaId = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Abierto = new DataGridViewCheckBoxColumn();
            EsActivo = new DataGridViewCheckBoxColumn();
            BtnSeleccionar = new Button();
            BtnCancelar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvCajas).BeginInit();
            SuspendLayout();

            // 
            // FormSeleccionCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(500, 420);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Seleccionar Caja";
            MaximizeBox = false;
            MinimizeBox = false;
            ForeColor = Color.White;

            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            labelTitulo.Location = new Point(130, 20);
            labelTitulo.Text = "Seleccionar Caja";

            // 
            // dgvCajas
            // 
            dgvCajas.AllowUserToAddRows = false;
            dgvCajas.AllowUserToDeleteRows = false;
            dgvCajas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCajas.BackgroundColor = Color.FromArgb(60, 75, 90);
            dgvCajas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCajas.Columns.AddRange(new DataGridViewColumn[] { CajaId, Numero, Abierto, EsActivo });
            dgvCajas.Location = new Point(40, 80);
            dgvCajas.Name = "dgvCajas";
            dgvCajas.RowHeadersVisible = false;
            dgvCajas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCajas.Size = new Size(420, 250);
            dgvCajas.TabIndex = 0;
            dgvCajas.ReadOnly = true;

            // 
            // CajaId
            // 
            CajaId.HeaderText = "ID";
            CajaId.Name = "CajaId";
            CajaId.DataPropertyName = "CajaId";
            CajaId.MinimumWidth = 6;

            // 
            // Numero
            // 
            Numero.HeaderText = "Número";
            Numero.Name = "Numero";
            Numero.DataPropertyName = "Numero";
            Numero.MinimumWidth = 6;

            // 
            // Abierto (oculto)
            // 
            Abierto.HeaderText = "Abierto";
            Abierto.Name = "Abierto";
            Abierto.DataPropertyName = "Abierto";
            Abierto.Visible = false;

            // 
            // EsActivo (oculto)
            // 
            EsActivo.HeaderText = "Activo";
            EsActivo.Name = "EsActivo";
            EsActivo.DataPropertyName = "EsActivo";
            EsActivo.Visible = false;

            // 
            // BtnSeleccionar
            // 
            BtnSeleccionar.BackColor = Color.FromArgb(0, 80, 200);
            BtnSeleccionar.FlatStyle = FlatStyle.Flat;
            BtnSeleccionar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            BtnSeleccionar.Location = new Point(80, 350);
            BtnSeleccionar.Size = new Size(150, 40);
            BtnSeleccionar.Text = "Seleccionar";
            BtnSeleccionar.UseVisualStyleBackColor = false;

            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            BtnCancelar.Location = new Point(270, 350);
            BtnCancelar.Size = new Size(150, 40);
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += (s, e) => this.Close();

            // 
            // FormSeleccionCaja Controls
            // 
            Controls.Add(labelTitulo);
            Controls.Add(dgvCajas);
            Controls.Add(BtnSeleccionar);
            Controls.Add(BtnCancelar);

            ((System.ComponentModel.ISupportInitialize)dgvCajas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private DataGridView dgvCajas;
        private DataGridViewTextBoxColumn CajaId;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewCheckBoxColumn Abierto;
        private DataGridViewCheckBoxColumn EsActivo;
        private Button BtnSeleccionar;
        private Button BtnCancelar;
    }
}
