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
            lSexoUser = new Label();
            lUserRol = new Label();
            comboBox1 = new ComboBox();
            txtNombreUser = new TextBox();
            txtApellidoUser = new TextBox();
            txtEmailUser = new TextBox();
            txtTelefonoUser = new TextBox();
            txtDniUser = new TextBox();
            txtContraseñaUser = new TextBox();
            rBtnNujer = new RadioButton();
            rBtnHombre = new RadioButton();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            lLista = new Label();
            btnGuardarUser = new Button();
            btnEliminarUser = new Button();
            btnEditarUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lUsuarios
            // 
            lUsuarios.AutoSize = true;
            lUsuarios.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lUsuarios.ForeColor = SystemColors.ButtonHighlight;
            lUsuarios.Location = new Point(79, 9);
            lUsuarios.Name = "lUsuarios";
            lUsuarios.Size = new Size(293, 36);
            lUsuarios.TabIndex = 0;
            lUsuarios.Text = "Gestión de Usuarios";
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
            // lSexoUser
            // 
            lSexoUser.AutoSize = true;
            lSexoUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSexoUser.ForeColor = SystemColors.ButtonHighlight;
            lSexoUser.Location = new Point(79, 230);
            lSexoUser.Name = "lSexoUser";
            lSexoUser.Size = new Size(50, 21);
            lSexoUser.TabIndex = 9;
            lSexoUser.Text = "Sexo:";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(556, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(166, 72);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(206, 23);
            txtNombreUser.TabIndex = 12;
            // 
            // txtApellidoUser
            // 
            txtApellidoUser.Location = new Point(166, 113);
            txtApellidoUser.Name = "txtApellidoUser";
            txtApellidoUser.Size = new Size(206, 23);
            txtApellidoUser.TabIndex = 13;
            // 
            // txtEmailUser
            // 
            txtEmailUser.Location = new Point(166, 154);
            txtEmailUser.Name = "txtEmailUser";
            txtEmailUser.Size = new Size(206, 23);
            txtEmailUser.TabIndex = 14;
            // 
            // txtTelefonoUser
            // 
            txtTelefonoUser.Location = new Point(166, 194);
            txtTelefonoUser.Name = "txtTelefonoUser";
            txtTelefonoUser.Size = new Size(206, 23);
            txtTelefonoUser.TabIndex = 15;
            // 
            // txtDniUser
            // 
            txtDniUser.Location = new Point(556, 72);
            txtDniUser.Name = "txtDniUser";
            txtDniUser.Size = new Size(206, 23);
            txtDniUser.TabIndex = 17;
            // 
            // txtContraseñaUser
            // 
            txtContraseñaUser.Location = new Point(556, 117);
            txtContraseñaUser.Name = "txtContraseñaUser";
            txtContraseñaUser.Size = new Size(206, 23);
            txtContraseñaUser.TabIndex = 18;
            // 
            // rBtnNujer
            // 
            rBtnNujer.AutoSize = true;
            rBtnNujer.Location = new Point(166, 233);
            rBtnNujer.Name = "rBtnNujer";
            rBtnNujer.Size = new Size(56, 19);
            rBtnNujer.TabIndex = 19;
            rBtnNujer.TabStop = true;
            rBtnNujer.Text = "Mujer";
            rBtnNujer.UseVisualStyleBackColor = true;
            // 
            // rBtnHombre
            // 
            rBtnHombre.AutoSize = true;
            rBtnHombre.Location = new Point(278, 233);
            rBtnHombre.Name = "rBtnHombre";
            rBtnHombre.Size = new Size(69, 19);
            rBtnHombre.TabIndex = 20;
            rBtnHombre.TabStop = true;
            rBtnHombre.Text = "Hombre";
            rBtnHombre.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Telefono, DNI, Rol });
            dataGridView1.Location = new Point(79, 323);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 150);
            dataGridView1.TabIndex = 21;
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
            // lLista
            // 
            lLista.AutoSize = true;
            lLista.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lLista.ForeColor = SystemColors.ButtonHighlight;
            lLista.Location = new Point(79, 279);
            lLista.Name = "lLista";
            lLista.Size = new Size(143, 21);
            lLista.TabIndex = 22;
            lLista.Text = "Lista de Usuarios: ";
            // 
            // btnGuardarUser
            // 
            btnGuardarUser.Location = new Point(863, 71);
            btnGuardarUser.Name = "btnGuardarUser";
            btnGuardarUser.Size = new Size(75, 23);
            btnGuardarUser.TabIndex = 23;
            btnGuardarUser.Text = "Guardar";
            btnGuardarUser.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUser
            // 
            btnEliminarUser.Location = new Point(863, 153);
            btnEliminarUser.Name = "btnEliminarUser";
            btnEliminarUser.Size = new Size(75, 23);
            btnEliminarUser.TabIndex = 24;
            btnEliminarUser.Text = "Eliminar";
            btnEliminarUser.UseVisualStyleBackColor = true;
            // 
            // btnEditarUser
            // 
            btnEditarUser.Location = new Point(863, 112);
            btnEditarUser.Name = "btnEditarUser";
            btnEditarUser.Size = new Size(75, 23);
            btnEditarUser.TabIndex = 25;
            btnEditarUser.Text = "Editar";
            btnEditarUser.UseVisualStyleBackColor = true;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1284, 611);
            Controls.Add(btnEditarUser);
            Controls.Add(btnEliminarUser);
            Controls.Add(btnGuardarUser);
            Controls.Add(lLista);
            Controls.Add(dataGridView1);
            Controls.Add(rBtnHombre);
            Controls.Add(rBtnNujer);
            Controls.Add(txtContraseñaUser);
            Controls.Add(txtDniUser);
            Controls.Add(txtTelefonoUser);
            Controls.Add(txtEmailUser);
            Controls.Add(txtApellidoUser);
            Controls.Add(txtNombreUser);
            Controls.Add(comboBox1);
            Controls.Add(lUserRol);
            Controls.Add(lSexoUser);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label lSexoUser;
        private Label lUserRol;
        private ComboBox comboBox1;
        private TextBox txtNombreUser;
        private TextBox txtApellidoUser;
        private TextBox txtEmailUser;
        private TextBox txtTelefonoUser;
        private TextBox txtDniUser;
        private TextBox txtContraseñaUser;
        private RadioButton rBtnNujer;
        private RadioButton rBtnHombre;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Rol;
        private Label lLista;
        private Button btnGuardarUser;
        private Button btnEliminarUser;
        private Button btnEditarUser;
    }
}