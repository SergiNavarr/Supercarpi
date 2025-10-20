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
            label1 = new Label();
            txtRutaBackUp = new TextBox();
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
            LBD.Location = new Point(83, 116);
            LBD.Name = "LBD";
            LBD.Size = new Size(232, 21);
            LBD.TabIndex = 1;
            LBD.Text = "Seleccione la base de datos:";
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(322, 116);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(257, 23);
            CBCategoria.TabIndex = 14;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(83, 156);
            label1.Name = "label1";
            label1.Size = new Size(233, 21);
            label1.TabIndex = 28;
            label1.Text = "Ruta del destino del BackUp:";
            // 
            // txtRutaBackUp
            // 
            txtRutaBackUp.Location = new Point(322, 158);
            txtRutaBackUp.Name = "txtRutaBackUp";
            txtRutaBackUp.Size = new Size(257, 23);
            txtRutaBackUp.TabIndex = 29;
            // 
            // btnGenerarBU
            // 
            btnGenerarBU.BackColor = Color.ForestGreen;
            btnGenerarBU.Cursor = Cursors.Hand;
            btnGenerarBU.FlatAppearance.BorderSize = 0;
            btnGenerarBU.FlatStyle = FlatStyle.Flat;
            btnGenerarBU.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarBU.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarBU.Location = new Point(383, 206);
            btnGenerarBU.Name = "btnGenerarBU";
            btnGenerarBU.Size = new Size(135, 27);
            btnGenerarBU.TabIndex = 30;
            btnGenerarBU.Text = "Crear BackUp";
            btnGenerarBU.UseVisualStyleBackColor = false;
            btnGenerarBU.Click += btnGenerarBU_Click;
            // 
            // btnRuta
            // 
            btnRuta.BackColor = Color.FromArgb(0, 80, 200);
            btnRuta.Cursor = Cursors.Hand;
            btnRuta.FlatAppearance.BorderSize = 0;
            btnRuta.FlatStyle = FlatStyle.Flat;
            btnRuta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRuta.ForeColor = SystemColors.ButtonHighlight;
            btnRuta.Location = new Point(594, 155);
            btnRuta.Name = "btnRuta";
            btnRuta.Size = new Size(158, 27);
            btnRuta.TabIndex = 31;
            btnRuta.Text = "Seleccionar Carpeta";
            btnRuta.UseVisualStyleBackColor = false;
            btnRuta.Click += btnRuta_Click;
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1073, 537);
            Controls.Add(btnRuta);
            Controls.Add(btnGenerarBU);
            Controls.Add(txtRutaBackUp);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txtRutaBackUp;
        private Button btnGenerarBU;
        private Button btnRuta;
    }
}