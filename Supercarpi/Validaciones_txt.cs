using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Validaciones_txt
    {
        public static bool validarNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return false;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        public static bool validarLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }

            else
            {
                e.Handled = true;
                return false;
            }
        }











    }

}
