namespace Supercarpi
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            BLogin = new Button();
            TBPassword = new TextBox();
            TBDni = new TextBox();
            LContrasenia = new Label();
            LUsuario = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 66, 82);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(BLogin);
            panel2.Controls.Add(TBPassword);
            panel2.Controls.Add(TBDni);
            panel2.Controls.Add(LContrasenia);
            panel2.Controls.Add(LUsuario);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 324);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Interfaz.Properties.Resources.logo_supercarpi;
            pictureBox1.Location = new Point(172, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BLogin
            // 
            BLogin.Location = new Point(147, 257);
            BLogin.Margin = new Padding(3, 2, 3, 2);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(212, 22);
            BLogin.TabIndex = 9;
            BLogin.Text = "Entrar";
            BLogin.UseVisualStyleBackColor = true;
            BLogin.Click += BLogin_Click;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(147, 212);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(212, 23);
            TBPassword.TabIndex = 8;
            // 
            // TBDni
            // 
            TBDni.Location = new Point(147, 159);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(212, 23);
            TBDni.TabIndex = 7;
            TBDni.KeyPress += TBDni_KeyPress;
            // 
            // LContrasenia
            // 
            LContrasenia.AutoSize = true;
            LContrasenia.ForeColor = Color.White;
            LContrasenia.Location = new Point(147, 194);
            LContrasenia.Name = "LContrasenia";
            LContrasenia.Size = new Size(67, 15);
            LContrasenia.TabIndex = 6;
            LContrasenia.Text = "Contraseña";
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.ForeColor = Color.White;
            LUsuario.Location = new Point(147, 141);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(27, 15);
            LUsuario.TabIndex = 5;
            LUsuario.Text = "DNI";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 320);
            Controls.Add(panel2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button BLogin;
        private TextBox TBPassword;
        private TextBox TBDni;
        private Label LContrasenia;
        private Label LUsuario;
        private PictureBox pictureBox1;
    }
}
