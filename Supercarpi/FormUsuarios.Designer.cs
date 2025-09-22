namespace Interfaz
{
    partial class FormUsuarios
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
            lUsuarios = new Label();
            lNombreUser = new Label();
            lApellidoUser = new Label();
            lEmailUser = new Label();
            lUserName = new Label();
            lContraseñaUser = new Label();
            lDni = new Label();
            lTelefonoUser = new Label();
            lUserRol = new Label();
            cmbRoles = new ComboBox();
            txtNombreUser = new TextBox();
            txtApellidoUser = new TextBox();
            txtEmailUser = new TextBox();
            txtTelefonoUser = new TextBox();
            txtDniUser = new TextBox();
            txtPasswordUser = new TextBox();
            dvgEmpleados = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            RolId = new DataGridViewTextBoxColumn();
            EmpleadoId = new DataGridViewTextBoxColumn();
            lLista = new Label();
            btnCrear = new Button();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // lUsuarios
            // 
            lUsuarios.AutoSize = true;
            lUsuarios.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lUsuarios.Location = new Point(79, 9);
            lUsuarios.Name = "lUsuarios";
            lUsuarios.Size = new Size(323, 36);
            lUsuarios.TabIndex = 0;
            lUsuarios.Text = "GESTION DE USUARIOS";
            // 
            // lNombreUser
            // 
            lNombreUser.AutoSize = true;
            lNombreUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombreUser.ForeColor = SystemColors.ButtonHighlight;
            lNombreUser.Location = new Point(79, 74);
            lNombreUser.Name = "lNombreUser";
            lNombreUser.Size = new Size(81, 21);
            lNombreUser.TabIndex = 1;
            lNombreUser.Text = "Nombre: ";
            // 
            // lApellidoUser
            // 
            lApellidoUser.AutoSize = true;
            lApellidoUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lApellidoUser.ForeColor = SystemColors.ButtonHighlight;
            lApellidoUser.Location = new Point(79, 115);
            lApellidoUser.Name = "lApellidoUser";
            lApellidoUser.Size = new Size(82, 21);
            lApellidoUser.TabIndex = 2;
            lApellidoUser.Text = "Apellido: ";
            // 
            // lEmailUser
            // 
            lEmailUser.AutoSize = true;
            lEmailUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEmailUser.ForeColor = SystemColors.ButtonHighlight;
            lEmailUser.Location = new Point(79, 156);
            lEmailUser.Name = "lEmailUser";
            lEmailUser.Size = new Size(55, 21);
            lEmailUser.TabIndex = 3;
            lEmailUser.Text = "Email:";
            // 
            // lUserName
            // 
            lUserName.AutoSize = true;
            lUserName.Location = new Point(79, 202);
            lUserName.Name = "lUserName";
            lUserName.Size = new Size(0, 15);
            lUserName.TabIndex = 4;
            // 
            // lContraseñaUser
            // 
            lContraseñaUser.AutoSize = true;
            lContraseñaUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lContraseñaUser.ForeColor = SystemColors.ButtonHighlight;
            lContraseñaUser.Location = new Point(443, 115);
            lContraseñaUser.Name = "lContraseñaUser";
            lContraseñaUser.Size = new Size(107, 21);
            lContraseñaUser.TabIndex = 5;
            lContraseñaUser.Text = "Contraseña:";
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDni.ForeColor = SystemColors.ButtonHighlight;
            lDni.Location = new Point(443, 74);
            lDni.Name = "lDni";
            lDni.Size = new Size(43, 21);
            lDni.TabIndex = 6;
            lDni.Text = "DNI:";
            // 
            // lTelefonoUser
            // 
            lTelefonoUser.AutoSize = true;
            lTelefonoUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTelefonoUser.ForeColor = SystemColors.ButtonHighlight;
            lTelefonoUser.Location = new Point(79, 196);
            lTelefonoUser.Name = "lTelefonoUser";
            lTelefonoUser.Size = new Size(80, 21);
            lTelefonoUser.TabIndex = 7;
            lTelefonoUser.Text = "Telefono:";
            // 
            // lUserRol
            // 
            lUserRol.AutoSize = true;
            lUserRol.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lUserRol.ForeColor = SystemColors.ButtonHighlight;
            lUserRol.Location = new Point(443, 156);
            lUserRol.Name = "lUserRol";
            lUserRol.Size = new Size(37, 21);
            lUserRol.TabIndex = 10;
            lUserRol.Text = "Rol:";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(556, 158);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(121, 23);
            cmbRoles.TabIndex = 11;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(166, 72);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(206, 23);
            txtNombreUser.TabIndex = 12;
            txtNombreUser.KeyPress += txtNombreUser_KeyPress;
            // 
            // txtApellidoUser
            // 
            txtApellidoUser.Location = new Point(166, 113);
            txtApellidoUser.Name = "txtApellidoUser";
            txtApellidoUser.Size = new Size(206, 23);
            txtApellidoUser.TabIndex = 13;
            txtApellidoUser.KeyPress += txtApellidoUser_KeyPress;
            // 
            // txtEmailUser
            // 
            txtEmailUser.Location = new Point(166, 154);
            txtEmailUser.Name = "txtEmailUser";
            txtEmailUser.Size = new Size(206, 23);
            txtEmailUser.TabIndex = 14;
            txtEmailUser.KeyPress += txtEmailUser_KeyPress;
            // 
            // txtTelefonoUser
            // 
            txtTelefonoUser.Location = new Point(166, 194);
            txtTelefonoUser.Name = "txtTelefonoUser";
            txtTelefonoUser.Size = new Size(206, 23);
            txtTelefonoUser.TabIndex = 15;
            txtTelefonoUser.KeyPress += txtTelefonoUser_KeyPress;
            // 
            // txtDniUser
            // 
            txtDniUser.Location = new Point(556, 72);
            txtDniUser.Name = "txtDniUser";
            txtDniUser.Size = new Size(206, 23);
            txtDniUser.TabIndex = 17;
            txtDniUser.KeyPress += txtDniUser_KeyPress;
            // 
            // txtPasswordUser
            // 
            txtPasswordUser.Location = new Point(556, 117);
            txtPasswordUser.Name = "txtPasswordUser";
            txtPasswordUser.Size = new Size(206, 23);
            txtPasswordUser.TabIndex = 18;
            // 
            // dvgEmpleados
            // 
            dvgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dvgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgEmpleados.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Telefono, DNI, Rol, RolId, EmpleadoId });
            dvgEmpleados.Location = new Point(79, 310);
            dvgEmpleados.Name = "dvgEmpleados";
            dvgEmpleados.Size = new Size(797, 227);
            dvgEmpleados.TabIndex = 21;
            dvgEmpleados.CellClick += dvgEmpleados_CellClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // RolId
            // 
            RolId.HeaderText = "RolId";
            RolId.Name = "RolId";
            RolId.Visible = false;
            // 
            // EmpleadoId
            // 
            EmpleadoId.HeaderText = "EmpleadoId";
            EmpleadoId.Name = "EmpleadoId";
            EmpleadoId.Visible = false;
            // 
            // lLista
            // 
            lLista.AutoSize = true;
            lLista.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lLista.ForeColor = SystemColors.ButtonHighlight;
            lLista.Location = new Point(79, 270);
            lLista.Name = "lLista";
            lLista.Size = new Size(143, 21);
            lLista.TabIndex = 22;
            lLista.Text = "Lista de Usuarios: ";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(0, 80, 200);
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = SystemColors.Control;
            btnCrear.Location = new Point(558, 213);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(99, 23);
            btnCrear.TabIndex = 23;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 80, 200);
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = SystemColors.Control;
            btnConfirmar.Location = new Point(558, 213);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(99, 23);
            btnConfirmar.TabIndex = 24;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(663, 213);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkOrange;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(663, 213);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 23);
            btnEditar.TabIndex = 26;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(451, 213);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 23);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1089, 576);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCrear);
            Controls.Add(lLista);
            Controls.Add(dvgEmpleados);
            Controls.Add(txtPasswordUser);
            Controls.Add(txtDniUser);
            Controls.Add(txtTelefonoUser);
            Controls.Add(txtEmailUser);
            Controls.Add(txtApellidoUser);
            Controls.Add(txtNombreUser);
            Controls.Add(cmbRoles);
            Controls.Add(lUserRol);
            Controls.Add(lTelefonoUser);
            Controls.Add(lDni);
            Controls.Add(lContraseñaUser);
            Controls.Add(lUserName);
            Controls.Add(lEmailUser);
            Controls.Add(lApellidoUser);
            Controls.Add(lNombreUser);
            Controls.Add(lUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dvgEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lUsuarios;
        private Label lNombreUser;
        private Label lApellidoUser;
        private Label lEmailUser;
        private Label lUserName;
        private Label lContraseñaUser;
        private Label lDni;
        private Label lTelefonoUser;
        private Label lUserRol;
        private ComboBox cmbRoles;
        private TextBox txtNombreUser;
        private TextBox txtApellidoUser;
        private TextBox txtEmailUser;
        private TextBox txtTelefonoUser;
        private TextBox txtDniUser;
        private TextBox txtPasswordUser;
        private DataGridView dvgEmpleados;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn RolId;
        private DataGridViewTextBoxColumn EmpleadoId;
        private Label lLista;
        private Button btnCrear;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}