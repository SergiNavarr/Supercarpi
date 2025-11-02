namespace Interfaz
{
    partial class FormPagoTarjeta
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
            labelNumero = new Label();
            labelTitular = new Label();
            txtNumero = new TextBox();
            txtTitular = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();

            SuspendLayout();

            // 
            // FormPagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(420, 280);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pago con tarjeta";
            MaximizeBox = false;
            MinimizeBox = false;
            ForeColor = Color.White;

            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            labelTitulo.Location = new Point(90, 20);
            labelTitulo.Text = "Datos de la tarjeta";

            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Century Gothic", 10F);
            labelNumero.Location = new Point(30, 80);
            labelNumero.Text = "Número de tarjeta:";

            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(200, 76);
            txtNumero.MaxLength = 16;
            txtNumero.Size = new Size(180, 27);

            // 
            // labelTitular
            // 
            labelTitular.AutoSize = true;
            labelTitular.Font = new Font("Century Gothic", 10F);
            labelTitular.Location = new Point(30, 130);
            labelTitular.Text = "Titular:";

            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(200, 126);
            txtTitular.Size = new Size(180, 27);

            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 80, 200);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnConfirmar.Location = new Point(70, 200);
            btnConfirmar.Size = new Size(120, 40);
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += BtnConfirmar_Click;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(230, 200);
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += (s, e) => this.Close();

            // 
            // Add controls
            // 
            Controls.Add(labelTitulo);
            Controls.Add(labelNumero);
            Controls.Add(txtNumero);
            Controls.Add(labelTitular);
            Controls.Add(txtTitular);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelNumero;
        private Label labelTitular;
        private TextBox txtNumero;
        private TextBox txtTitular;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}