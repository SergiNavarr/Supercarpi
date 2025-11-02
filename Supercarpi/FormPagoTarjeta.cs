using Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormPagoTarjeta : Form
    {
        public PagoTarjeta PagoTarjeta { get; private set; }

        public FormPagoTarjeta()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text.Trim();
            string titular = txtTitular.Text.Trim();

            if (string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(titular))
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardamos solo los últimos 4 dígitos por seguridad
            string ultimos4 = numero.Length > 4 ? numero[^4..] : numero;

            PagoTarjeta = new PagoTarjeta
            {
                NumeroTarjeta = $"**** **** **** {ultimos4}",
                Titular = titular
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}