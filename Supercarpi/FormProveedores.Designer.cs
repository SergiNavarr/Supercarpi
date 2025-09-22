namespace Interfaz
{
    partial class FormProveedores
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
            LProveedor = new Label();
            label3 = new Label();
            CBCategoria = new ComboBox();
            LEmpleado = new Label();
            LFechaPedido = new Label();
            CBEmpleado = new ComboBox();
            txtImporteSub = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            LNombreProducto = new Label();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            contador1 = new NumericUpDown();
            BtnBuscar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contador1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 34);
            label1.TabIndex = 0;
            label1.Text = "PEDIDOS A PROVEEDORES";
            // 
            // LProveedor
            // 
            LProveedor.AutoSize = true;
            LProveedor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LProveedor.Location = new Point(74, 120);
            LProveedor.Margin = new Padding(2, 0, 2, 0);
            LProveedor.Name = "LProveedor";
            LProveedor.Size = new Size(94, 21);
            LProveedor.TabIndex = 1;
            LProveedor.Text = "Proveedor:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 2;
            label3.Text = "Nuevo Pedido:";
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(173, 118);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(174, 27);
            CBCategoria.TabIndex = 13;
            // 
            // LEmpleado
            // 
            LEmpleado.AutoSize = true;
            LEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LEmpleado.Location = new Point(382, 120);
            LEmpleado.Name = "LEmpleado";
            LEmpleado.Size = new Size(94, 21);
            LEmpleado.TabIndex = 14;
            LEmpleado.Text = "Empleado:";
            // 
            // LFechaPedido
            // 
            LFechaPedido.AutoSize = true;
            LFechaPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFechaPedido.Location = new Point(694, 120);
            LFechaPedido.Name = "LFechaPedido";
            LFechaPedido.Size = new Size(149, 21);
            LFechaPedido.TabIndex = 15;
            LFechaPedido.Text = "Fecha del Pedido:";
            // 
            // CBEmpleado
            // 
            CBEmpleado.FormattingEnabled = true;
            CBEmpleado.Location = new Point(482, 118);
            CBEmpleado.Name = "CBEmpleado";
            CBEmpleado.Size = new Size(174, 27);
            CBEmpleado.TabIndex = 16;
            // 
            // txtImporteSub
            // 
            txtImporteSub.Location = new Point(922, 333);
            txtImporteSub.Name = "txtImporteSub";
            txtImporteSub.Size = new Size(113, 27);
            txtImporteSub.TabIndex = 17;
            txtImporteSub.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(849, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(113, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(779, 336);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 19;
            label2.Text = "Importe subtotal:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(961, 150);
            dataGridView1.TabIndex = 20;
            // 
            // LNombreProducto
            // 
            LNombreProducto.AutoSize = true;
            LNombreProducto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreProducto.Location = new Point(74, 337);
            LNombreProducto.Name = "LNombreProducto";
            LNombreProducto.Size = new Size(86, 21);
            LNombreProducto.TabIndex = 21;
            LNombreProducto.Text = "Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 337);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 22;
            label5.Text = "Cantidad:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(166, 334);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(174, 27);
            txtNombreProducto.TabIndex = 24;
            txtNombreProducto.KeyPress += txtNombreProducto_KeyPress;
            // 
            // contador1
            // 
            contador1.Location = new Point(454, 334);
            contador1.Name = "contador1";
            contador1.Size = new Size(30, 27);
            contador1.TabIndex = 25;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.FromArgb(0, 80, 200);
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(74, 391);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(99, 27);
            BtnBuscar.TabIndex = 26;
            BtnBuscar.Text = "Modificar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(513, 335);
            button1.Name = "button1";
            button1.Size = new Size(99, 27);
            button1.TabIndex = 27;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(241, 391);
            button2.Name = "button2";
            button2.Size = new Size(99, 27);
            button2.TabIndex = 28;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1073, 537);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnBuscar);
            Controls.Add(contador1);
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(LNombreProducto);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtImporteSub);
            Controls.Add(CBEmpleado);
            Controls.Add(LFechaPedido);
            Controls.Add(LEmpleado);
            Controls.Add(CBCategoria);
            Controls.Add(label3);
            Controls.Add(LProveedor);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormProveedores";
            Text = "Nuevo pedido a Proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contador1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LProveedor;
        private Label label3;
        private ComboBox CBCategoria;
        private Label LEmpleado;
        private Label LFechaPedido;
        private ComboBox CBEmpleado;
        private TextBox txtImporteSub;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label LNombreProducto;
        private Label label5;
        private TextBox txtNombreProducto;
        private NumericUpDown contador1;
        private Button BtnBuscar;
        private Button button1;
        private Button button2;
    }
}