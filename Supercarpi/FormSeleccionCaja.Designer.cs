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
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            labelTitulo.Location = new Point(114, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(197, 26);
            labelTitulo.TabIndex = 0;
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
            dgvCajas.Location = new Point(35, 60);
            dgvCajas.Margin = new Padding(3, 2, 3, 2);
            dgvCajas.Name = "dgvCajas";
            dgvCajas.ReadOnly = true;
            dgvCajas.RowHeadersVisible = false;
            dgvCajas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCajas.Size = new Size(368, 188);
            dgvCajas.TabIndex = 0;
            // 
            // CajaId
            // 
            CajaId.DataPropertyName = "CajaId";
            CajaId.HeaderText = "ID";
            CajaId.MinimumWidth = 6;
            CajaId.Name = "CajaId";
            CajaId.ReadOnly = true;
            CajaId.Visible = false;
            // 
            // Numero
            // 
            Numero.DataPropertyName = "Numero";
            Numero.HeaderText = "Número";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // Abierto
            // 
            Abierto.DataPropertyName = "Abierto";
            Abierto.HeaderText = "Abierto";
            Abierto.Name = "Abierto";
            Abierto.ReadOnly = true;
            Abierto.Visible = true;
            // 
            // EsActivo
            // 
            EsActivo.DataPropertyName = "EsActivo";
            EsActivo.HeaderText = "Activo";
            EsActivo.Name = "EsActivo";
            EsActivo.ReadOnly = true;
            EsActivo.Visible = false;
            // 
            // BtnSeleccionar
            // 
            BtnSeleccionar.BackColor = Color.FromArgb(0, 80, 200);
            BtnSeleccionar.FlatStyle = FlatStyle.Flat;
            BtnSeleccionar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            BtnSeleccionar.Location = new Point(70, 262);
            BtnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            BtnSeleccionar.Name = "BtnSeleccionar";
            BtnSeleccionar.Size = new Size(131, 30);
            BtnSeleccionar.TabIndex = 1;
            BtnSeleccionar.Text = "Seleccionar";
            BtnSeleccionar.UseVisualStyleBackColor = false;
            BtnSeleccionar.Click += BtnSeleccionar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            BtnCancelar.Location = new Point(236, 262);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(131, 30);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FormSeleccionCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(438, 315);
            Controls.Add(labelTitulo);
            Controls.Add(dgvCajas);
            Controls.Add(BtnSeleccionar);
            Controls.Add(BtnCancelar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSeleccionCaja";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Seleccionar Caja";
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
