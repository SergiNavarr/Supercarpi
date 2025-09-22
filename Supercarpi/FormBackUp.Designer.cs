namespace Interfaz
{
    partial class FormBackUp
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
            LGestionBackUp = new Label();
            LBD = new Label();
            CBCategoria = new ComboBox();
            BtnConectar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnGenerarBU = new Button();
            btnRuta = new Button();
            SuspendLayout();
            // 
            // LGestionBackUp
            // 
            LGestionBackUp.AutoSize = true;
            LGestionBackUp.Font = new Font("Century Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LGestionBackUp.ForeColor = SystemColors.ButtonHighlight;
            LGestionBackUp.Location = new Point(69, 55);
            LGestionBackUp.Name = "LGestionBackUp";
            LGestionBackUp.Size = new Size(519, 34);
            LGestionBackUp.TabIndex = 0;
            LGestionBackUp.Text = "Gestion de BackUp de Base de Datos";
            // 
            // LBD
            // 
            LBD.AutoSize = true;
            LBD.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBD.ForeColor = SystemColors.ButtonHighlight;
            LBD.Location = new Point(100, 118);
            LBD.Name = "LBD";
            LBD.Size = new Size(315, 21);
            LBD.TabIndex = 1;
            LBD.Text = "Seleccione la base de datos a guardar:";
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(430, 116);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(202, 23);
            CBCategoria.TabIndex = 14;
            // 
            // BtnConectar
            // 
            BtnConectar.BackColor = Color.FromArgb(0, 80, 200);
            BtnConectar.Cursor = Cursors.Hand;
            BtnConectar.FlatAppearance.BorderSize = 0;
            BtnConectar.FlatStyle = FlatStyle.Flat;
            BtnConectar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConectar.ForeColor = SystemColors.ButtonHighlight;
            BtnConectar.Location = new Point(653, 116);
            BtnConectar.Name = "BtnConectar";
            BtnConectar.Size = new Size(99, 27);
            BtnConectar.TabIndex = 27;
            BtnConectar.Text = "Conectar";
            BtnConectar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(100, 153);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 28;
            label1.Text = "Ruta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 29;
            // 
            // btnGenerarBU
            // 
            btnGenerarBU.BackColor = Color.ForestGreen;
            btnGenerarBU.Cursor = Cursors.Hand;
            btnGenerarBU.FlatAppearance.BorderSize = 0;
            btnGenerarBU.FlatStyle = FlatStyle.Flat;
            btnGenerarBU.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarBU.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarBU.Location = new Point(653, 155);
            btnGenerarBU.Name = "btnGenerarBU";
            btnGenerarBU.Size = new Size(135, 27);
            btnGenerarBU.TabIndex = 30;
            btnGenerarBU.Text = "Generar BackUp";
            btnGenerarBU.UseVisualStyleBackColor = false;
            // 
            // btnRuta
            // 
            btnRuta.BackColor = Color.FromArgb(0, 80, 200);
            btnRuta.Cursor = Cursors.Hand;
            btnRuta.FlatAppearance.BorderSize = 0;
            btnRuta.FlatStyle = FlatStyle.Flat;
            btnRuta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRuta.ForeColor = SystemColors.ButtonHighlight;
            btnRuta.Location = new Point(430, 153);
            btnRuta.Name = "btnRuta";
            btnRuta.Size = new Size(99, 27);
            btnRuta.TabIndex = 31;
            btnRuta.Text = "Ruta";
            btnRuta.UseVisualStyleBackColor = false;
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1073, 537);
            Controls.Add(btnRuta);
            Controls.Add(btnGenerarBU);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnConectar);
            Controls.Add(CBCategoria);
            Controls.Add(LBD);
            Controls.Add(LGestionBackUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBackUp";
            Text = "BackUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LGestionBackUp;
        private Label LBD;
        private ComboBox CBCategoria;
        private Button BtnConectar;
        private Label label1;
        private TextBox textBox1;
        private Button btnGenerarBU;
        private Button btnRuta;
    }
}