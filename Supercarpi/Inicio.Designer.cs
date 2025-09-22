namespace Interfaz
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            BarraTitulo = new Panel();
            PBContraer = new PictureBox();
            PBCerrar = new PictureBox();
            PBMaximizar = new PictureBox();
            PBMinimizar = new PictureBox();
            panelContenido = new Panel();
            menuVertical = new Panel();
            panelMenu = new Panel();
            panel6 = new Panel();
            btnBackUp = new Button();
            panel5 = new Panel();
            btnReportes = new Button();
            panel4 = new Panel();
            btnUsuario = new Button();
            panel3 = new Panel();
            btnProveedores = new Button();
            panel2 = new Panel();
            btnVentas = new Button();
            panel1 = new Panel();
            btnProductos = new Button();
            PBLogo = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBContraer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBLogo).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(PBContraer);
            BarraTitulo.Controls.Add(PBCerrar);
            BarraTitulo.Controls.Add(PBMaximizar);
            BarraTitulo.Controls.Add(PBMinimizar);
            BarraTitulo.Controls.Add(panelContenido);
            BarraTitulo.Controls.Add(menuVertical);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1284, 35);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // PBContraer
            // 
            PBContraer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBContraer.Cursor = Cursors.Hand;
            PBContraer.Image = Properties.Resources.contraer;
            PBContraer.Location = new Point(1215, 0);
            PBContraer.Name = "PBContraer";
            PBContraer.Size = new Size(30, 30);
            PBContraer.SizeMode = PictureBoxSizeMode.Zoom;
            PBContraer.TabIndex = 6;
            PBContraer.TabStop = false;
            PBContraer.Visible = false;
            PBContraer.Click += PBContraer_Click;
            // 
            // PBCerrar
            // 
            PBCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBCerrar.Cursor = Cursors.Hand;
            PBCerrar.Image = Properties.Resources.cerrar;
            PBCerrar.Location = new Point(1251, 2);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(30, 30);
            PBCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            PBCerrar.TabIndex = 3;
            PBCerrar.TabStop = false;
            PBCerrar.Click += PBCerrar_Click;
            // 
            // PBMaximizar
            // 
            PBMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBMaximizar.Cursor = Cursors.Hand;
            PBMaximizar.Image = Properties.Resources.maximizar;
            PBMaximizar.Location = new Point(1215, 2);
            PBMaximizar.Name = "PBMaximizar";
            PBMaximizar.Size = new Size(30, 30);
            PBMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            PBMaximizar.TabIndex = 5;
            PBMaximizar.TabStop = false;
            PBMaximizar.Click += PBMaximizar_Click;
            // 
            // PBMinimizar
            // 
            PBMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBMinimizar.Cursor = Cursors.Hand;
            PBMinimizar.Image = Properties.Resources.minimizar;
            PBMinimizar.Location = new Point(1179, 2);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(30, 30);
            PBMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            PBMinimizar.TabIndex = 4;
            PBMinimizar.TabStop = false;
            PBMinimizar.Click += PBMinimizar_Click;
            // 
            // panelContenido
            // 
            panelContenido.Location = new Point(191, 34);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1093, 577);
            panelContenido.TabIndex = 2;
            // 
            // menuVertical
            // 
            menuVertical.Location = new Point(149, 34);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(200, 622);
            menuVertical.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(26, 32, 40);
            panelMenu.Controls.Add(panel6);
            panelMenu.Controls.Add(btnBackUp);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(btnProveedores);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(PBLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 35);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(195, 576);
            panelMenu.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 426);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 30);
            panel6.TabIndex = 4;
            // 
            // btnBackUp
            // 
            btnBackUp.FlatAppearance.BorderSize = 0;
            btnBackUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnBackUp.FlatStyle = FlatStyle.Flat;
            btnBackUp.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackUp.ForeColor = SystemColors.ControlLightLight;
            btnBackUp.Image = (Image)resources.GetObject("btnBackUp.Image");
            btnBackUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackUp.Location = new Point(0, 426);
            btnBackUp.Name = "btnBackUp";
            btnBackUp.Size = new Size(204, 32);
            btnBackUp.TabIndex = 6;
            btnBackUp.Text = "Back Up";
            btnBackUp.UseVisualStyleBackColor = true;
            btnBackUp.Click += btnBackUp_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(0, 375);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 32);
            panel5.TabIndex = 3;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = SystemColors.ControlLightLight;
            btnReportes.Image = Properties.Resources.reportes;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(4, 375);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(202, 32);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 30);
            panel4.TabIndex = 2;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnUsuario.Image = Properties.Resources.empleados;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(3, 183);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(202, 32);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 326);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 2;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = SystemColors.ControlLightLight;
            btnProveedores.Image = Properties.Resources.compras;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(3, 326);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(202, 32);
            btnProveedores.TabIndex = 3;
            btnProveedores.Text = "Provedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 32);
            panel2.TabIndex = 1;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ControlLightLight;
            btnVentas.Image = Properties.Resources.venta;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 281);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(205, 32);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 32);
            panel1.TabIndex = 0;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ButtonHighlight;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(-9, 235);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(214, 32);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // PBLogo
            // 
            PBLogo.Image = Properties.Resources.logo_supercarpi;
            PBLogo.Location = new Point(12, 19);
            PBLogo.Name = "PBLogo";
            PBLogo.Size = new Size(173, 137);
            PBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PBLogo.TabIndex = 0;
            PBLogo.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(195, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1089, 576);
            panelContenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 611);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBContraer).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel menuVertical;
        private Panel panelMenu;
        private PictureBox PBLogo;
        private Button btnProductos;
        private Panel panel1;
        private Button btnProveedores;
        private Panel panel2;
        private Button btnVentas;
        private Panel panel3;
        private Panel panel6;
        private Button btnBackUp;
        private Panel panel5;
        private Button btnReportes;
        private Panel panel4;
        private Button btnUsuario;
        private Panel panelContenido;
        private Panel panelContenedor;
        private Button BtnPrueba;
        private PictureBox PBContraer;
        private PictureBox PBCerrar;
        private PictureBox PBMaximizar;
        private PictureBox PBMinimizar;
    }
}