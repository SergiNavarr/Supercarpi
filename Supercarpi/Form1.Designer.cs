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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Location = new Point(241, 113);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(47, 15);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "Usuario";
            // 
            // LContrasenia
            // 
            LContrasenia.AutoSize = true;
            LContrasenia.Location = new Point(241, 202);
            LContrasenia.Name = "LContrasenia";
            LContrasenia.Size = new Size(67, 15);
            LContrasenia.TabIndex = 1;
            LContrasenia.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 438);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LContrasenia);
            Controls.Add(LUsuario);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LUsuario;
        private Label LContrasenia;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
