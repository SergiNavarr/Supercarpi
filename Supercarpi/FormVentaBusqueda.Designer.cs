namespace Interfaz
{
    partial class FormVentaBusqueda
    {
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dgvResultados;

        private void InitializeComponent()
        {
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();

            // TBNombre
            this.TBNombre.Location = new System.Drawing.Point(12, 12);
            this.TBNombre.Size = new System.Drawing.Size(250, 23);

            // BtnBuscar
            this.BtnBuscar.Location = new System.Drawing.Point(270, 12);
            this.BtnBuscar.Size = new System.Drawing.Size(100, 23);
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);

            // dgvResultados
            this.dgvResultados.Location = new System.Drawing.Point(12, 50);
            this.dgvResultados.Size = new System.Drawing.Size(600, 300);
            this.dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);

            // FormVentaBusqueda
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dgvResultados);
            this.Text = "Buscar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}