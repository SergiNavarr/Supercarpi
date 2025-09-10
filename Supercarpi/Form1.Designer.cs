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
            LUsuario = new Label();
            LContrasenia = new Label();
            TBDni = new TextBox();
            TBPassword = new TextBox();
            BLogin = new Button();
            SuspendLayout();
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Location = new Point(162, 131);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(35, 20);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "DNI";
            // 
            // LContrasenia
            // 
            LContrasenia.AutoSize = true;
            LContrasenia.Location = new Point(162, 235);
            LContrasenia.Name = "LContrasenia";
            LContrasenia.Size = new Size(83, 20);
            LContrasenia.TabIndex = 1;
            LContrasenia.Text = "Contraseña";
            // 
            // TBDni
            // 
            TBDni.Location = new Point(162, 155);
            TBDni.Margin = new Padding(3, 4, 3, 4);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(242, 27);
            TBDni.TabIndex = 2;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(162, 259);
            TBPassword.Margin = new Padding(3, 4, 3, 4);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(242, 27);
            TBPassword.TabIndex = 3;
            // 
            // BLogin
            // 
            BLogin.Location = new Point(162, 327);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(242, 29);
            BLogin.TabIndex = 4;
            BLogin.Text = "Entrar";
            BLogin.UseVisualStyleBackColor = true;
            BLogin.Click += BLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 427);
            Controls.Add(BLogin);
            Controls.Add(TBPassword);
            Controls.Add(TBDni);
            Controls.Add(LContrasenia);
            Controls.Add(LUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LUsuario;
        private Label LContrasenia;
        private TextBox TBDni;
        private TextBox TBPassword;
        private Button BLogin;
    }
}
