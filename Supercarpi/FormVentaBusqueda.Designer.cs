namespace Interfaz
{
    partial class FormVentaBusqueda
    {
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label LBusqueda;

        private void InitializeComponent()
        {
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.LBusqueda = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();

            // ====== FORM ======
            this.BackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.ForeColor = System.Drawing.Color.White;
            this.Text = "Buscar Producto";

            // ====== LABEL BUSQUEDA ======
            this.LBusqueda.AutoSize = true;
            this.LBusqueda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBusqueda.Location = new System.Drawing.Point(12, 20);
            this.LBusqueda.Text = "Nombre del producto:";

            // ====== TEXTBOX NOMBRE ======
            this.TBNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TBNombre.Location = new System.Drawing.Point(200, 18);
            this.TBNombre.Size = new System.Drawing.Size(260, 24);

            // ====== BOTÓN BUSCAR ======
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(0, 80, 200);
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnBuscar.Location = new System.Drawing.Point(470, 17);
            this.BtnBuscar.Size = new System.Drawing.Size(120, 27);
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);

            // ====== DATAGRID ======
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.FromArgb(49, 66, 82);
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 80, 200);
            this.dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.GridColor = System.Drawing.Color.White;
            this.dgvResultados.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            this.dgvResultados.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResultados.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 80, 200);
            this.dgvResultados.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.Location = new System.Drawing.Point(12, 70);
            this.dgvResultados.Size = new System.Drawing.Size(680, 360);
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);

            // ====== AGREGAR AL FORM ======
            this.Controls.Add(this.LBusqueda);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dgvResultados);

            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
